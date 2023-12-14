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
    public class EfMoneyCaseDal : GenericRepository<MoneyCase>, IMoneyCaseDal
    {
        public EfMoneyCaseDal(RealTimeDataContext context) : base(context) 
        {
        }

        public decimal TotalMoneyCaseAmount()
        {
            using var context = new RealTimeDataContext();
            return context.MoneyCases.Select(x=>x.TotalAmount).FirstOrDefault();
        }
    }
}
