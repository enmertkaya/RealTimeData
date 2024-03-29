﻿using RealTimeData.DataAccessLayer.Abstract;
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
	public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
	{
		public EfNotificationDal(RealTimeDataContext context) : base(context)
		{

		}

		public List<Notification> GetAllNotificationByFalse()
		{
			using var context = new RealTimeDataContext();
			return context.Notifications.Where(x => x.Status == false).ToList();
		}

		public int NotificationCountByStatusFalse()
		{
			using var context = new RealTimeDataContext();
			return context.Notifications.Where(x=>x.Status==false).Count();
		}

		public void NotificationStatusChangeToFalse(int id)
		{
			using var context = new RealTimeDataContext();
			var value = context.Notifications.Find(id);
			value.Status = false;
			context.SaveChanges();
		}

		public void NotificationStatusChangeToTrue(int id)
		{
			using var context = new RealTimeDataContext();
			var value = context.Notifications.Find(id);
			value.Status=true;
			context.SaveChanges();
		}
	}
}
