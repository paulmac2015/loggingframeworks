using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnterpriseLibrary;

namespace EnterpriseLibrary
{
    public class EntLibLoggingTestClass
    {
        public static decimal CalculateValue(int Val1, int Val2)
        {
            try
            {
                return Val1 / Val2;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
