using Akka.Actor;

namespace WorkManager.Workers
{
    /// <summary>
    /// Handles keeping a queue of all jobs that can't currently be handled
    /// by the dispatcher for execution. The QueueWorker will periodically
    /// receive a message to attempt to deliver any messages that may be in the 
    /// queue. The dispatcher will report to the QueueHandler whether it can handle
    /// the work or not
    /// </summary>
    public class QueueWorker : TypedActor
    {
    }
}
