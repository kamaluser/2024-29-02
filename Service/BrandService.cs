using Core.Entities;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BrandService
    {
        private AppDbContext _context;
        public BrandService()
        {
            _context = new AppDbContext();
        }

        public void InsertBrand(Brand brand)
        {
            _context.Brands.Add(brand);
            _context.SaveChanges();
        }

        public Brand GetBrandById(int id)
        {
            return _context.Brands.Find(id);
        }

        public List<Brand> GetAllBrands()
        {
            var list = _context.Brands.ToList();
            return _context.Brands.ToList();
        }

        public void DeleteBrand(int id)
        {
            var a = _context.Brands.FirstOrDefault(x => x.Id == id);
            if (a != null)
            {
                _context.Brands.Remove(a);
                _context.SaveChanges();
                Console.WriteLine("Deleted Succesfully");
            }
            else
            {
                Console.WriteLine("Id Not Found!");
            }
        }

        public void UpdateBrand(int id)
        {
            string name;
            do
            {
                Console.WriteLine("Name:");
                name = Console.ReadLine();
            } while (String.IsNullOrWhiteSpace(name));

            var a = _context.Brands.FirstOrDefault(x => x.Id == id);
            if (a != null)
            {
                a.Name = name;
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Id Not Found!");
            }
        }
    }
}
