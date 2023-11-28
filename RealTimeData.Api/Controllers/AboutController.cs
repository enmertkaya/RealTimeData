using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealTimeData.BusinessLayer.Abstract;
using RealTimeData.DtoLayer.AboutDto;
using RealTimeData.EntityLayer.Entities;

namespace RealTimeData.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        [HttpGet]
        public IActionResult AboutList()
        {
            var value = _aboutService.TGetListAll();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            About about = new About()
            {
               Description = createAboutDto.Description,
               ImageURL=createAboutDto.ImageUrl,
               Title = createAboutDto.Title
            };

            _aboutService.TAdd(about);
            return Ok("Hakkimda kismi basarili bir sekilde eklendi");

        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var valıe=_aboutService.TGetByID(id);
            _aboutService.TDelete(valıe);
            return Ok("Hakkimda alani silindi");
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            About about = new About()
            {
                AboutID = updateAboutDto.AboutID,
                Title = updateAboutDto.Title,
                ImageURL = updateAboutDto.ImageUrl,
                Description=updateAboutDto.Description
            };
            _aboutService.TUpdate(about);
            return Ok("Hakkimda alani guncellendi");
        }
        [HttpGet("GetAbout")]
        public IActionResult GetAbout(int id)
        {
            var value=_aboutService.TGetByID(id);
            return Ok(value);
        }

    }
}
