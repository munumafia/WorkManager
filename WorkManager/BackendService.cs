using Akka.Actor;
using Akka.Configuration;
using WorkManager.Workers;

namespace WorkManager
{
    /// <summary>
    /// Used to create a Windows Service that will be managed by Topshelf.
    /// Topshelf will handle determining whether or not to run this class
    /// as a console app or as a Windows service. In the case of the 
    /// Windows service, it will adapt this class to the interface that
    /// Windows expects for a service written in C# and handle registering
    /// and unregistering the service.
    /// </summary>
    public class BackendService
    {
        private ActorSystem _ActorSystem;

        public void Start()
        {
            // TODO: Make this configurable?
            _ActorSystem = ActorSystem.Create("WorkManager", ConfigurationFactory.Load());

            _ActorSystem.ActorOf(Props.Create<FrontendWorker>(), "Frontend");
            _ActorSystem.ActorOf(Props.Create<DispatcherWorker>(), "Dispatcher");
            _ActorSystem.ActorOf(Props.Create<QueueWorker>(), "Queue");
        }

        public void Stop()
        {
            _ActorSystem.Terminate().Wait();
            _ActorSystem.WhenTerminated.Wait();
        }
    }
}
