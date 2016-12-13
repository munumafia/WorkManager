using Akka.Actor;

namespace WorkManager.Workers
{
    /// <summary>
    /// Executes the work for a work request. The WorkJobWorker will
    /// execute a WorkRequest, spawn off the executable that is requested
    /// to be ran by the WorkRequest, then keep track of things like CPU
    /// time spent, percent of CPU that the executable is taking up, and
    /// the amount of memory that the executable is currently consuming.
    /// 
    /// Each WorkJobWorker instance will periodically receive a message to
    /// report its resource usage back to the DispatcherWorker, which will
    /// then determine if the work request needs to be terminated. If the
    /// work request does need to be terminated, the worker will receive
    /// a message to terminate it's work and then will be restarted.
    /// </summary>
    public class WorkJobWorker : TypedActor
    {
    }
}
