using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealTimeData.BusinessLayer.Abstract;
using RealTimeData.DtoLayer.NotificationDto;
using RealTimeData.EntityLayer.Entities;

namespace RealTimeData.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NotificationController : ControllerBase
	{
		private readonly INotificationService _notificationService;
		public NotificationController(INotificationService notificationService)
		{
			_notificationService = notificationService;
		}

		[HttpGet]
		public IActionResult NotificationList()
		{
			return Ok(_notificationService.TGetListAll());
		}


		[HttpGet("NotificationCountByStatusFalse")]
		public IActionResult NotificationCountByStatusFalse()
		{
			return Ok(_notificationService.TNotificationCountByStatusFalse());
		}

		[HttpGet("GetAllNotificationByFalse")]
		public IActionResult GetAllNotificationByFalse() 
		{
		return Ok(_notificationService.TGetAllNotificationByFalse());
		}

		[HttpPost]
		public IActionResult CreateNotification(CreateNotificationDto createNotificationDto) 
		{
			Notification notification = new Notification()
			{
				Description=createNotificationDto.Description,
				Icon=createNotificationDto.Icon,
				Date=Convert.ToDateTime(DateTime.Now.ToShortDateString()),
				Status=false,
				Type = createNotificationDto.Type
			};
			_notificationService.TAdd(notification);
			return Ok("Ekleme işlemi başarıyla yapıldı");

		}

		[HttpDelete]
		public IActionResult DeleteNotification(int id) 
		{
			var value= _notificationService.TGetByID(id);
			_notificationService.TDelete(value);
			return Ok("Bildirim Silindi");
		}

		[HttpGet("{id}")]
		public IActionResult GetNotification (int id)
		{
			var value = _notificationService.TGetByID(id);
			return Ok(value);
		}

		[HttpPut]
		public IActionResult UpdateNotification(UpdateNotificationDto updateNotificationDto)
		{
			Notification notification = new Notification()
			{
				NotificationID=updateNotificationDto.NotificationID,
				Description = updateNotificationDto.Description,
				Icon = updateNotificationDto.Icon,
				Date = updateNotificationDto.Date,
				Status =updateNotificationDto.Status,
				Type = updateNotificationDto.Type
			};
			_notificationService.TUpdate(notification);
			return Ok("Güncelleme işlemi başarıyla yapıldı");

		}

	}
}
