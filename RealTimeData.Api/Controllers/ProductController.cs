using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealTimeData.BusinessLayer.Abstract;
using RealTimeData.DataAccessLayer.Concrete;
using RealTimeData.DtoLayer.ProductDto;
using RealTimeData.EntityLayer.Entities;
using System.Security.Cryptography.X509Certificates;

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
        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(value);
        }

        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var context = new RealTimeDataContext();
            var values = context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategoryDto
            {
                Description = y.Description,
                ImageURL = y.ImageURL,
                Price = y.Price,
                ProductID = y.ProductID,
                ProductName = y.ProductName,
                ProductStatus = y.ProductStatus,
                CategoryName = y.Category.CategoryName
            });
            return Ok(values.ToList());
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd(new Product()
            {
                Description = createProductDto.Description,
                Price = createProductDto.Price,
                ImageURL = createProductDto.ImageURL,
                ProductName = createProductDto.ProductName,
                ProductStatus = true,
                CategoryID=createProductDto.CategoryID
            });
            return Ok("Urun bilgisi eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok("Urun bilgisi silindi");
        }


		[HttpGet("{id}")]
        public IActionResult GetProduct(int id)
		{
			var value = _productService.TGetByID(id);
			{
				return Ok(value);
			}

		}

		[HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product()
            {
                Description = updateProductDto.Description,
                Price = updateProductDto.Price,
                ImageURL = updateProductDto.ImageURL,
                ProductID = updateProductDto.ProductID,
                ProductName = updateProductDto.ProductName,
                ProductStatus = updateProductDto.ProductStatus,
                CategoryID=updateProductDto.CategoryID
                
            });
            return Ok("Urun bilgisi guncellendi");
        }

      

       
    }
}
