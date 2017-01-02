using Topshelf;

namespace AkkaHost
{
    public static class Program
    {
        public static void Main()
        {
            HostFactory.Run(x =>
            {
                x.Service<AkkaHost>(s =>
                {
                    s.ConstructUsing(n => new AkkaHost());
                    s.WhenStarted(service => service.Start());
                    s.WhenStopped(service => service.Stop());
                });

                x.RunAsLocalSystem();
                x.UseAssemblyInfoForServiceInfo();
            });

        }
    }
}
