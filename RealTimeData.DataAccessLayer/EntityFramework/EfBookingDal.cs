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
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(RealTimeDataContext context) : base(context)
        {
        }
    }
}
