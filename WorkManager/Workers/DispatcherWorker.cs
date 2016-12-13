using Akka.Actor;

namespace WorkManager.Workers
{
    /// <summary>
    /// Handles all the business logic for dispatching work requests to workers for processing.
    /// The dispatcher takes things into account like CPU and RAM usage on the server and
    /// to intelligently determine whether more work can be started based on the resource
    /// usage settings for the actor system. Any requests that can't be handled immediately
    /// are instead routed to the QueueWorker in order to attempt dispatching at a later
    /// date
    /// </summary>
    public class DispatcherWorker : TypedActor
    {
    }
}
