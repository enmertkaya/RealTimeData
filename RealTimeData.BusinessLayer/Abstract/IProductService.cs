using RealTimeData.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeData.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService <Product>
    {
        List<Product> TGetProductsWithCategories();

        int TProductCount();
        int TProductCountByCategoryNameHamburger ();
        int TProductCountByCategoryNameDrink ();
        decimal TProductPriceAvg();
        string TProductNameByMaxPrice();
        string TProductNameByMinPrice();
        decimal TProductAvgPriceByHamburger();
        decimal TProductPriceBySteakBurger();
        decimal TTotalPriceByDrinkCategory();
        decimal TTotalPriceBySaladCategory();


    }
}
