using System;
using Log4NetTests;
using log4net;
using log4net.Config;

// Configure log4net using the .log4net file
// This will cause log4net to look for a configuration file
// called TestApp.exe.log4net in the application base
// directory (i.e. the directory containing TestApp.exe)
// The config file will be watched for changes.
[assembly: XmlConfigurator(ConfigFileExtension = "log4net", Watch = true)]
namespace Log4Net
{ 
    public class Program
    {
        // Define a static logger variable so that it references the
        // Logger instance named "MyApp".
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            // Set up a simple configuration that logs on the console...code has beed commented out to allow Log4Net to use a
            // configuration file set with the "assembly" directive listed above.
            // BasicConfigurator.Configure();

            log.Info("Entering application.");
            Log4NetTestClass Log4NetTestClass = new Log4NetTestClass();
            Log4NetTestClass.CalculateValue(100, 0);
            log.Info("Exiting application.");
            Console.ReadKey();
        }
    }
}


