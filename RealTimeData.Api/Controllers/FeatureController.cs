using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealTimeData.BusinessLayer.Abstract;
using RealTimeData.DtoLayer.FeatureDto;
using RealTimeData.EntityLayer.Entities;

namespace RealTimeData.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult FeatureList ()
        {
            var value = _mapper.Map<List<ResultFeatureDto>>(_featureService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateFeature (CreateFeatureDto createFeatureDto)
        {
            _featureService.TAdd(new Feature()
            {
                Descripton1=createFeatureDto.Description1,
                Descripton2=createFeatureDto.Description2,
                Descripton3 = createFeatureDto.Description3,
                Title1 = createFeatureDto.Title1,
                Title2 = createFeatureDto.Title2,
                Title3 = createFeatureDto.Title3
            });
            return Ok("Yorum bilgisi eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteFeature (int id)
        {
            var value=_featureService.TGetByID(id);
            _featureService.TDelete(value);
            return Ok("Yorum bilgisi silindi");
        }
        [HttpPut]
        public IActionResult UpdateFeature (UpdateFeatureDto updateFeatureDto)
        {
            _featureService.TUpdate(new Feature()
            {
                Descripton1 = updateFeatureDto.Description1,
                Descripton2 = updateFeatureDto.Description2,
                Descripton3 = updateFeatureDto.Description3,
                Title1 = updateFeatureDto.Title1,
                Title2 = updateFeatureDto.Title2,
                Title3 = updateFeatureDto.Title3,
                FeatureID= updateFeatureDto.FeatureID
            });
            return Ok("Feature guncellendi");
        }
        [HttpGet("GetFeature")]
        public IActionResult GetFeature(int id)
        {
            var values=_featureService.TGetByID(id);
            return Ok(values);
        }
    }
}
