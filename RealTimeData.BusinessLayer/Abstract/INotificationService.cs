using RealTimeData.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeData.BusinessLayer.Abstract
{
	public interface INotificationService : IGenericService <Notification>
	{
		int TNotificationCountByStatusFalse();
		List<Notification> TGetAllNotificationByFalse();
	}
}
