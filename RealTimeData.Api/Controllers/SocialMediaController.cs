using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealTimeData.BusinessLayer.Abstract;
using RealTimeData.DtoLayer.SocialMediaDto;
using RealTimeData.EntityLayer.Entities;

namespace RealTimeData.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult SocialMediaList() 
        {
            var value = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateSocialMedia (CreateSocialMediaDto createSocialMediaDto)
        {
            _socialMediaService.TAdd(new SocialMedia()
            {
                Icon=createSocialMediaDto.Icon,
                Title=createSocialMediaDto.Title,
                Url=createSocialMediaDto.Url
            });
            return Ok("Sosyal medya bilgisi eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSocialMedia (int id)
        {
            var value=_socialMediaService.TGetByID(id);
            _socialMediaService.TDelete(value);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateSocialMedia (UpdateSocialMediaDto updateSocialMediaDto)
        {
            _socialMediaService.TUpdate(new SocialMedia()
            {
                Icon = updateSocialMediaDto.Icon,
                SocialMediaID = updateSocialMediaDto.SocialMediaID,
                Title = updateSocialMediaDto.Title,
                Url = updateSocialMediaDto.Url
            });
            return Ok("Sosyal medya bilgisi guncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetSocialMedia(int id)
        {
            var value= _socialMediaService.TGetByID(id) ;
            return Ok(value);
        }
    }
}
