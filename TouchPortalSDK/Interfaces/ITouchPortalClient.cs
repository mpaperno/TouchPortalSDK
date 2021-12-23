﻿namespace TouchPortalSDK.Interfaces
{
    public interface ITouchPortalClient : ICommandHandler
    {
        /// <summary>
        /// Connects, pairs, and listens to the Touch Portal application.
        /// </summary>
        /// <returns>connection success status</returns>
        bool Connect();

        /// <summary>
        /// Closes the connection to Touch Portal and shutdowns the plugin in a safe manner.
        /// </summary>
        void Close();
    }
}