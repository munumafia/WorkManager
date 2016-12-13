using Akka.Actor;
using WorkManager.Messages.Frontend;

namespace WorkManager.Workers
{
    /// <summary>
    /// Akka worker used to enqueue new work requests and request status updates on
    /// running workjobs. Uses DispatchWorker to do most of the work of determining
    /// whether or not a new workjob can be created based on the resource limits
    /// that have been configured as well as settings like the max number of workers
    /// that can be running at once
    /// </summary>
    public class FrontendWorker : TypedActor, IHandle<AddWorkJob>, IHandle<GetWorkJobStatus>
    {
        /// <summary>
        /// Handles the AddWorkJob message
        /// </summary>
        /// <param name="message">The message to process</param>
        public void Handle(AddWorkJob message)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Handles the GetWorkJobStatus message
        /// </summary>
        /// <param name="message">The message to process</param>
        public void Handle(GetWorkJobStatus message)
        {
            throw new System.NotImplementedException();
        }
    }
}
