using RealTimeData.DataAccessLayer.Abstract;
using RealTimeData.DataAccessLayer.Concrete;
using RealTimeData.DataAccessLayer.Repositories;
using RealTimeData.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeData.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(RealTimeDataContext context) : base(context)
        {
        }

        public int ActiveCategoryCount()
        {
            using var context = new RealTimeDataContext();
            return context.Categories.Where(x=>x.Status==true).Count();
        }

        public int CategoryCount()
        {
            using var context = new RealTimeDataContext();
            return context.Categories.Count();
        }

        public int PassiveCategoryCount()
        {
            using var context = new RealTimeDataContext();
            return context.Categories.Where(x=>x.Status==false).Count();
        }
    }
}
