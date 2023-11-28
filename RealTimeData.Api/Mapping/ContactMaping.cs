using AutoMapper;
using RealTimeData.DtoLayer.ContactDto;
using RealTimeData.EntityLayer.Entities;

namespace RealTimeData.Api.Mapping
{
    public class ContactMaping :Profile
    {
        public ContactMaping()
        {
            CreateMap<Contact,CreateContactDto>().ReverseMap();
            CreateMap<Contact,ResultContactDto>().ReverseMap();
            CreateMap<Contact,UpdateContactDto>().ReverseMap();
            CreateMap<Contact,GetContactDto>().ReverseMap();
        }
    }
}
