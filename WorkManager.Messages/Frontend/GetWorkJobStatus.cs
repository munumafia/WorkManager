using System;

namespace WorkManager.Messages.Frontend
{
    /// <summary>
    /// Message for getting the status of an existing job, you'll want
    /// to use the message id of the AddWorkJob that was originally sent
    /// </summary>
    public class GetWorkJobStatus : Message
    {
        /// <summary>
        /// The Id of the AddWorkJobId message that spawned the work job
        /// that the status is being requested for
        /// </summary>
        public Guid AddWorkJobId { get; }

        /// <summary>
        /// Constructs a new instance of GetWorkJobStatus
        /// </summary>
        /// <param name="addWorkJobId">The Guid of the AddWorkJob message that you want the status of</param>
        public GetWorkJobStatus(Guid addWorkJobId)
        {
            AddWorkJobId = addWorkJobId;
        }
    }
}
