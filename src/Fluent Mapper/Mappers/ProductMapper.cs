using System;
using Fluent_Mapper.Base;

namespace Fluent_Mapper.Mappers
{
    public class ProductMapper : IMapper<Product, Entity>
    {
        private readonly Product _product;
        public ProductMapper()
        {
            _product = new Product();
        }

        public Product MapLite(Entity entity)
        {
            _product.Id = int.Parse(entity.Attribute1);

            return _product;
        }

        public Product MapFull(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
