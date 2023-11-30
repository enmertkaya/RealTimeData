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
    }
}
