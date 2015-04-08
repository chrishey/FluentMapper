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
            Console.WriteLine(product.Id);

            // pass it through both mappers
            var fullProduct = new Product().MapFull(entity);

            //show output
            Console.WriteLine(fullProduct.Id);
            Console.WriteLine(fullProduct.Name);
            Console.WriteLine(fullProduct.Colour);
        }
    }
}
