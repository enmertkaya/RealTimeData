using AutoMapper;
using RealTimeData.DtoLayer.SocialMediaDto;
using RealTimeData.EntityLayer.Entities;

namespace RealTimeData.Api.Mapping
{
    public class SocialMediaDto :Profile
    {
        public SocialMediaDto()
        {
            CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
        }
    }
}
