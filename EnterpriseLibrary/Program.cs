using System;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners;

namespace EnterpriseLibrary
{
    public class Program
    {
        public static LogWriter logWriter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            try
            {
                logWriter = ConfigureEntLibLogging.ConfigureLogWriter();

                if (logWriter.IsLoggingEnabled())
                {
                    using (logWriter)
                    {
                        logWriter.Write("Enterprise Library Logging test app has been started!");
                    }
                }

                //EntLibLogTest logTest = new EntLibLogTest();
                //logTest.PrintLogEvent();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                return;
            }
            finally
            {
                logWriter.Dispose();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public static class ConfigureEntLibLogging
        {
            public static LogWriter ConfigureLogWriter()
            {
                //var textFileFormatter = new TextFormatter();
                var flatFileListener = new RollingFlatFileTraceListener(@"C:\Temp\EntLibLgoFile.log");
                var asynFlatFileTraceListener = new AsynchronousTraceListenerWrapper(flatFileListener, true);

                EventLog ev = new EventLog("Application", ".", "EntLibLogging");
                EventLog eventLog = new EventLog("Application");
                var eventLogListener = new EventLogTraceListener(ev);
                var asyncEventLogListener = new AsynchronousTraceListenerWrapper(eventLogListener, true);

                var loggingConfig = new LoggingConfiguration();
                loggingConfig.AddLogSource("EntLibFlatFileLogging", SourceLevels.All, false, asynFlatFileTraceListener);
                loggingConfig.AddLogSource("EntLibEventLogLogging", SourceLevels.All, false, asyncEventLogListener);
                logWriter = new LogWriter(loggingConfig);
                return logWriter;
            }
        }
    }
}
