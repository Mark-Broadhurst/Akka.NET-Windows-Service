using Topshelf;

namespace Akka.NET_Windows_Service
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
