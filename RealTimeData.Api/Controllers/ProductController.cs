using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealTimeData.BusinessLayer.Abstract;
using RealTimeData.DtoLayer.ProductDto;
using RealTimeData.EntityLayer.Entities;

namespace RealTimeData.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList ()
        {
            var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd(new Product()
            {
                Description = createProductDto.Description,
                Price = createProductDto.Price,
                ImageURL=createProductDto.ImageURL,
                ProductName = createProductDto.ProductName,
                ProductStatus = true
            });
            return Ok("Urun bilgisi eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteProduct (int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok("Urun bilgisi silindi");
        }
        [HttpPut]
        public IActionResult UpdateProduct (UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product()
            {
                Description= updateProductDto.Description,
                Price = updateProductDto.Price,
                ImageURL=updateProductDto.ImageURL,
                ProductID = updateProductDto.ProductID,
                ProductName= updateProductDto.ProductName,
                ProductStatus = updateProductDto.ProductStatus
            });
            return Ok("Urun bilgisi guncellendi");
        }
        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            var value= _productService.TGetByID(id);
            return Ok(value);
        }
    }
}
