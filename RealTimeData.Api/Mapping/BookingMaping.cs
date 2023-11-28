using AutoMapper;
using RealTimeData.DtoLayer.BookingDto;
using RealTimeData.EntityLayer.Entities;

namespace RealTimeData.Api.Mapping
{
    public class BookingMaping :Profile
    {
        public BookingMaping()
        {
            CreateMap<Booking,ResultBookingDto>().ReverseMap();
            CreateMap<Booking,CreateBookingDto>().ReverseMap();
            CreateMap<Booking,UpdateBookingDto>().ReverseMap();
            CreateMap<Booking,GetBookingDto>().ReverseMap();
        }
    }
}
