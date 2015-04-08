using Fluent_Mapper.Base;

namespace Fluent_Mapper.Services
{
    public class ProductService
    {
        public Product GetLiteProduct(Entity entity)
        {
            return new Product().MapLite(entity);
        }

        public Product GetFullProduct(Entity entity)
        {
            return GetLiteProduct(entity).MapFull(entity);
        }

        public ConvertedProduct ConvertToThing(Entity entity)
        {
            return GetFullProduct(entity).Convert();
        }
    }
}
