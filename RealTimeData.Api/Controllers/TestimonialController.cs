using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealTimeData.BusinessLayer.Abstract;
using RealTimeData.DtoLayer.TestimonialDto;
using RealTimeData.EntityLayer.Entities;

namespace RealTimeData.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList ()
        {
            var value= _mapper.Map<List<CreateTestimonialDto>>(_testimonialService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]

        public IActionResult CreateTestimonial (CreateTestimonialDto createTestimonialDto)
        {
            _testimonialService.TAdd(new Testimonial()
            {
                Name = createTestimonialDto.Name,
                Comment = createTestimonialDto.Comment,
                Status = true,
                Title = createTestimonialDto.Title,
                ImageURL = createTestimonialDto.ImageURL
                
            });
            return Ok("Testimonial olusturuldu");
        }

        [HttpPut]
        public IActionResult UpdateTestimonial (UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialService.TUpdate(new Testimonial()
            {
                ImageURL = updateTestimonialDto.ImageURL,
                Status = true,
                Comment = updateTestimonialDto.Comment,
                Name = updateTestimonialDto.Name,
                Title = updateTestimonialDto.Title,
                TestimonialID=updateTestimonialDto.TestimonialID
            });
            return Ok("Testimonial guncellendi");
        }

        [HttpGet("GetTestimonial")]
        public IActionResult GetTestimonial (int id)
        {
            var value=_testimonialService.TGetByID(id);
            return Ok(value);
        }

        [HttpDelete]
        public IActionResult DeleteTestimonial(int  id)
        {
            var value=_testimonialService.TGetByID(id);
            _testimonialService.TDelete(value);
            return Ok("Testimonial silindi");
        }
    }
}
