using AutoMapper;
using RealTimeData.DtoLayer.DiscountDto;
using RealTimeData.DtoLayer.ProductDto;
using RealTimeData.EntityLayer.Entities;

namespace RealTimeData.Api.Mapping
{
    public class ProductMaping :Profile
    {
        public ProductMaping()
        {
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductWithCategoryDto>().ReverseMap();
        }
    }   
}
