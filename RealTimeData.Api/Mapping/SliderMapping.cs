using AutoMapper;
using RealTimeData.DtoLayer.SliderDto;
using RealTimeData.EntityLayer.Entities;

namespace RealTimeData.Api.Mapping
{
    public class SliderMapping : Profile
    {
        public SliderMapping()
        {
            CreateMap<Slider, ResultSliderDto>().ReverseMap();
        }
    }
}
