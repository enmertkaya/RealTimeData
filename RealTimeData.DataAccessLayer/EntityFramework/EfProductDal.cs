using Microsoft.EntityFrameworkCore;
using RealTimeData.DataAccessLayer.Abstract;
using RealTimeData.DataAccessLayer.Concrete;
using RealTimeData.DataAccessLayer.Repositories;
using RealTimeData.DtoLayer.ProductDto;
using RealTimeData.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeData.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(RealTimeDataContext context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            var context = new RealTimeDataContext();
            var values= context.Products.Include(x=>x.Category).ToList();
            return values;
        }

        public int ProductCount()
        {
            using var context = new RealTimeDataContext();
            return context.Products.Count();
        }

        public int ProductCountByCategoryNameDrink()
        {
            using var context = new RealTimeDataContext();
            
            return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Icecek").Select(z => z.CategoryID).FirstOrDefault())).Count();

        }

        public int ProductCountByCategoryNameHamburger()
        {
            using var context = new RealTimeDataContext();

            return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Count();
        }
    }
}
