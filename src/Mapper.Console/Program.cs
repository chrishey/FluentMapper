using System;
using Fluent_Mapper.Base;

namespace Mapper.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // generate a random entity
            var entity = new Entity();

            // pass it to the lite mapper
            var product = new Product().MapLite(entity);

            // show output
            Console.WriteLine("Mapped to Lite");
            Console.WriteLine(product.Id);

            // pass it through both mappers
            var fullProduct = new Product().MapLite(entity).MapFull(entity);

            //show output
            Console.WriteLine("Mapped to Full");
            Console.WriteLine(fullProduct.Id);
            Console.WriteLine(fullProduct.Name);
            Console.WriteLine(fullProduct.Colour);

            // pause and wait for input before closing the window
            Console.ReadKey();
        }
    }
}
