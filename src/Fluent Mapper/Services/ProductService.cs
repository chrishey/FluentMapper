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
            return new Product().MapLite(entity).MapFull(entity);
        }
    }
}
