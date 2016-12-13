using System.Collections.Generic;

namespace WorkManager.Messages.Frontend
{
    /// <summary>
    /// Message for adding a new work request to be executed
    /// </summary>
    public class AddWorkJob : Message
    {
        /// <summary>
        /// Dictionary of parameters to pass when running the command line
        /// program associated with this job
        /// </summary>
        public IDictionary<string,string> Parameters { get; }

        /// <summary>
        /// Constructs a new instance of AddWorkRequest
        /// </summary>
        /// <param name="parameters">Parameters to the executable that will be ran</param>
        public AddWorkJob(IDictionary<string, string> parameters)
        {
            Parameters = parameters;
        }
    }
}
