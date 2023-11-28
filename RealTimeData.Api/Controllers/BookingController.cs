﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealTimeData.BusinessLayer.Abstract;
using RealTimeData.DtoLayer.BookingDto;
using RealTimeData.EntityLayer.Entities;

namespace RealTimeData.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult BookingList ()
        {
            var values = _bookingService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking=new Booking()
            {
                Date = createBookingDto.Date,
                Name = createBookingDto.Name,
                PersonCount = createBookingDto.PersonCount,
                Phone = createBookingDto.Phone,
                Mail = createBookingDto.Mail
            };
            _bookingService.TAdd(booking);
            return Ok("Rezervasyon yapildi");
        }
        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var value=_bookingService.TGetByID(id);
            _bookingService.TDelete(value);
            return Ok("Rezervasyon silindi");

        }
        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking()
            {
                BookingID = updateBookingDto.BookingID,
                Date = updateBookingDto.Date,
                Mail = updateBookingDto.Mail,
                Name = updateBookingDto.Name,
                PersonCount= updateBookingDto.PersonCount,
                Phone = updateBookingDto.Phone
             
            };
            _bookingService.TUpdate(booking);
            return Ok("Rezervasyon guncellendi");
        }
        [HttpGet("GetBooking")]
        public IActionResult GetBooking (int id)
        {
            var value = _bookingService.TGetByID(id);
            return Ok(value);
        }
    }
}
