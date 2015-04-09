namespace Mapper.Demo
{
    public class Bootstrapper
    {
        public static void Initialize()
        {
            var container = TinyIoC.TinyIoCContainer.Current;

            container.AutoRegister();
        }
    }
}
