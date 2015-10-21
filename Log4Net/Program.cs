using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The application has started!");
            Console.WriteLine("========================================================================");
            Console.WriteLine(Log4NetTestClass.CalculateValue(100, 0));
            Console.ReadLine();
        }
    }

    static class Log4NetTestClass
    {
        //private static Logger logger = LogManager.GetCurrentClassLogger();

        static public decimal CalculateValue(int val1, int val2)
        {
            try
            {
                return val1 / val2;
            }
            catch (Exception ex)
            {
                //logger.Error(ex, "An error has occurred!..." + ex.Message);
                return 0;
            }
        }
    }
    }
