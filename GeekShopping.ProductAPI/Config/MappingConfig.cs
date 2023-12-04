using AutoMapper;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model;
using System.Linq.Expressions;

namespace GeekShopping.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        {
            var mapingConfig = new MapperConfiguration(
                config =>
                {
                    config.CreateMap<ProductVO, Product>();
                    config.CreateMap<Product, ProductVO>();

                });
            return mapingConfig;
        }
    }
}
