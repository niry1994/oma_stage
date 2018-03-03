using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testLog
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int zero = 0;
                int result = 5 / zero;
            }
            catch (DevideByZeroException ex)
            {
                Logger g = LogManager.GetCurrentClassLogger();
                g.ErrorException("test", ex);e
            }
            Console.WriteLine("test");
            Console.ReadKey();
        }
    }
}
