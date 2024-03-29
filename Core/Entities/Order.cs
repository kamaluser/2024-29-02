﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public Product Product { get; set; }


        public override string ToString()
        {
            return $"Id - {Id}, ProductId - {ProductId}, Count - {Count}";
        }
    }
}
