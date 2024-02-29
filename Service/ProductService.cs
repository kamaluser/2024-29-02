using Core.Entities;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService
    {
        private AppDbContext _context;
        public ProductService()
        {
            _context = new AppDbContext();
        }
        public void InsertProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Find(id);
        }

        public List<Product> GetAllProducts()
        {
            var list = _context.Products.ToList();
            return list;
        }

        public void DeleteProduct(int id)
        {
            var a = _context.Products.FirstOrDefault(x => x.Id == id);
            if (a != null)
            {
                _context.Products.Remove(a);
                _context.SaveChanges();
                Console.WriteLine("Deleted Succesfully");
            }
            else
            {
                Console.WriteLine("Id Not Found!");
            }
        }

        public void UpdateProduct(int id, Product product)
        {
            var a = _context.Products.FirstOrDefault(x => x.Id == id);
            if (a != null)
            {
                a.Name = product.Name;
                a.Price = product.Price;
                a.BrandId = product.BrandId;
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Id Not Found!");
            }
        }
    }
}
