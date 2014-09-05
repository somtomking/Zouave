using System.Collections.Generic;
using Zouave.Domain.Logging;
using Zouave.Domain.Users;

namespace Zouave.Application.Logging
{
    public partial interface ILogger
    {
        /// <summary>
        /// Determines whether a log level is enabled
        /// </summary>
        /// <param name="level">Log level</param>
        /// <returns>Result</returns>
        bool IsEnabled(LogLevel level);

        /// <summary>
        /// Deletes a log item
        /// </summary>
        /// <param name="log">Log item</param>
        void DeleteLog(Log log);

        /// <summary>
        /// Clears a log
        /// </summary>
        void ClearLog();

     
        /// <summary>
        /// Gets a log item
        /// </summary>
        /// <param name="logId">Log item identifier</param>
        /// <returns>Log item</returns>
        Log GetLogById(int logId);

        /// <summary>
        /// Get log items by identifiers
        /// </summary>
        /// <param name="logIds">Log item identifiers</param>
        /// <returns>Log items</returns>
        IList<Log> GetLogByIds(int[] logIds);

        /// <summary>
        /// Inserts a log item
        /// </summary>
        /// <param name="logLevel">Log level</param>
        /// <param name="shortMessage">The short message</param>
        /// <param name="fullMessage">The full message</param>
        /// <param name="customer">The customer to associate log record with</param>
        /// <returns>A log item</returns>
        Log InsertLog(LogLevel logLevel, string shortMessage, string fullMessage = "", User user = null);
    }
}
