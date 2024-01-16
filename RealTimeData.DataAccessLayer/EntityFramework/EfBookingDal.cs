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

		public void BookingStatusApproved(int id)
		{
			using var context = new RealTimeDataContext();
			var values = context.Bookings.Find(id);
			values.Description = "Rezervasyon Onaylandi";
			context.SaveChanges();
		}

		public void BookingStatusCanceled(int id)
		{
			using var context = new RealTimeDataContext();
			var values = context.Bookings.Find(id);
			values.Description = "Rezervasyon İptal Edildi";
			context.SaveChanges();
		}
	}
}
