using Fluent_Mapper.Base;

namespace Fluent_Mapper.Services
{
    public interface IProductService
    {
        Product GetLiteProduct(Entity entity);
        Product GetFullProduct(Entity entity);
        ConvertedProduct ConvertToThing(Entity entity);
    }
}