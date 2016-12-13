using System;

namespace WorkManager.Messages
{
    public class Message
    {
        /// <summary>
        /// Unique identifier for the message
        /// </summary>
        public Guid Id { get; } = Guid.NewGuid();
    }
}