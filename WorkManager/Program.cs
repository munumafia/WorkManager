using Topshelf;

namespace WorkManager
{
    /// <summary>
    /// Entry point for the WorkManager console application, uses Topshelf
    /// to run either as a Windows service or as a console app
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            HostFactory.Run(x =>
            {
                x.Service<BackendService>(s =>
                {
                    s.ConstructUsing(name => new BackendService());
                    s.WhenStarted(bs => bs.Start());
                    s.WhenStopped(bs => bs.Stop());
                });

                // TODO: Need to make this configurable
                x.RunAsNetworkService();

                x.SetDescription("WorkManager Service");
                x.SetDisplayName("WorkManager Service");
                x.SetServiceName("WorkManagerService");
            });
        }
    }
}
