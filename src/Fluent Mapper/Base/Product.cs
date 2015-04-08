using Fluent_Mapper.Mappers;

namespace Fluent_Mapper.Base
{
    public class Product : IMapper<Product, Entity>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }

        public Product Create
        {
            get { return new Product(); }
        }

        public Product MapLite(Entity entity)
        {
            Id = int.Parse(entity.Attribute1);

            return this;
        }

        public Product MapFull(Entity entity)
        {
            Name = entity.Attribute2;
            Colour = entity.Attribute3;

            return this;
        }
    }
}
