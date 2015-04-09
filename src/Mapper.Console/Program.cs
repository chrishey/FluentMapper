using Fluent_Mapper.Services;
using TinyIoC;

namespace Mapper.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bootstrapper.Initialize();

            using (var container = TinyIoCContainer.Current)
            {
                new MapThings(container.Resolve<IProductService>()).DoStuff();
            }
            
        }
    }
}
