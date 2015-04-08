using System;

namespace Fluent_Mapper.Base
{
    public class Entity
    {
        private readonly Random _random = new Random();

        private readonly string[] _names = {"Product 1", "Product 2", "Product 3"};
        private readonly string[] _colours = {"Red", "Blue", "Green", "Yellow"};

        public Entity()
        {
            Attribute1 = _random.Next(0, 100000).ToString();
            Attribute2 = _names[_random.Next(0, _names.Length)];
            Attribute3 = _names[_random.Next(0, _colours.Length)];
        }

        public string Attribute1 { get; set; }
        public string Attribute2 { get; set; }
        public string Attribute3 { get; set; }
    }
}
