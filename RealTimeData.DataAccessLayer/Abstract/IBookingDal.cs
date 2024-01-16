using RealTimeData.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeData.DataAccessLayer.Abstract
{
    public interface IBookingDal : IGenericDal <Booking>
    {
        void BookingStatusApproved(int id);
        void BookingStatusCanceled(int id);
    }
}
