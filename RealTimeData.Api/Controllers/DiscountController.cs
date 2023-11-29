using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealTimeData.BusinessLayer.Abstract;
using RealTimeData.DtoLayer.DiscountDto;
using RealTimeData.EntityLayer.Entities;

namespace RealTimeData.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult DiscountList ()
        {
            var value = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            _discountService.TAdd(new Discount()
            {
                Amount = createDiscountDto.Amount,
                Description = createDiscountDto.Description,
                Title = createDiscountDto.Title,
                ImageURL = createDiscountDto.ImageURL
            });
            return Ok("Indirim bilgisi eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteDiscount (int id)
        {
            var value = _discountService.TGetByID(id);
            _discountService.TDelete(value);
            return Ok("Iletisim bilgisi silindi");
        }
        [HttpPut]
        public IActionResult UpdateDiscount (UpdateDiscountDto updateDiscountDto)
        {
            _discountService.TUpdate(new Discount()
            {
                DiscountID = updateDiscountDto.DiscountID,
                Amount = updateDiscountDto.Amount,
                Description = updateDiscountDto.Description,
                Title = updateDiscountDto.Title,
                ImageURL = updateDiscountDto.ImageURL
            });
            return Ok("Iletisim bilgisi guncellendi");
        }
        [HttpGet("GetDiscount")]
        public IActionResult GetDiscount(int id)
        {
            var value= _discountService.TGetByID(id);
            return Ok(value);
        }
    }
}
