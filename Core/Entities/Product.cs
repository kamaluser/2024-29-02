using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public override string ToString()
        {
            return $"Id - {Id}, Name - {Name}, Price - {Price}, BrandId - {BrandId}";
        }
    }
}
