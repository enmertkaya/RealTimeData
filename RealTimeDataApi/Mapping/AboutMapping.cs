using AutoMapper;
using RealTimeData.EntityLayer.Entities;
using SignalR.DtoLayer.AboutDto;

namespace RealTimeDataApi.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<About,ResultAboutDto>().ReverseMap();
            C
        }
    }
}
