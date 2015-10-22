using System;
// Import log4net classes.  This allows the class to use the configuration
using log4net;

namespace Log4NetTests
{
    public class Log4NetTestClass
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Log4NetTestClass));

        public decimal CalculateValue(int Val1, int Val2)
        {
            log.Info("Simple log entry!");

            try
            {
                return Val1 / Val2;
            }
            catch (Exception ex)
            {
                log.Debug("An error has occurred!", ex);
                return 0;
            }
        }
    }
}