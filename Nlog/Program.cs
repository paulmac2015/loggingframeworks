using System;
using NLog;

namespace Nlog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The application has started!");
            Console.WriteLine("========================================================================");
            Console.WriteLine(NlogTestClass.CalculateValue(100, 0));            
            Console.ReadLine();
        }
    }

    static class NlogTestClass
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static public decimal CalculateValue(int val1, int val2)
        {
            try
            {
                return val1 / val2;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "An error has occurred!..." + ex.Message);
                return 0;
            }
        }
    }
}
