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
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
        public EfOrderDal(RealTimeDataContext context) : base(context)
        {
        }

        public int ActiveOrderCount()
        {
            using var context = new RealTimeDataContext();
            return context.Orders.Where(x=>x.Description=="Müşteri Masada").Count();
        }

        public decimal LastOrderPrice()
        {
            using var context = new RealTimeDataContext();
            return context.Orders.OrderByDescending(x => x.OrderID).Take(1).Select(y => y.TotalPrice).FirstOrDefault();
        }

        public decimal TodayTotalPrice()
        {
            return 0;
        }

        public int TotalOrderCount()
        {
            using var context = new RealTimeDataContext();
            return context.Orders.Count();
        }
    }
}
