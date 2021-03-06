﻿using System;
using Fluent_Mapper.Base;
using Fluent_Mapper.Services;

namespace Mapper.Demo
{
    public class MapThings
    {
        private static IProductService _productService;

        public MapThings(IProductService productService)
        {
            _productService = productService;
        }

        public void DoStuff()
        {
            // generate a random entity
            var entity = new Entity();

            Console.WriteLine("Directly mapping via Fluent method chaining");

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

            // via the service
            Console.WriteLine("Via the service");
            Console.WriteLine("Mapped to Lite");
            var servicedProduct = _productService.GetLiteProduct(entity);

            Console.WriteLine(servicedProduct.Id);

            Console.WriteLine("Mapped to full");
            var fullServicedProduct = _productService.GetFullProduct(entity);
            Console.WriteLine(fullServicedProduct.Id);
            Console.WriteLine(fullServicedProduct.Name);
            Console.WriteLine(fullServicedProduct.Colour);

            // pause and wait for input before closing the window
            Console.ReadKey();
        }
    }
}
