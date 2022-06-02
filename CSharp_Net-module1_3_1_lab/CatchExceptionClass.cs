using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_3_1_lab
{
    class CatchExceptionClass
    {
        public void CatchExceptionMethod()
        {
            try
            {
                MyArray ma = new MyArray();

                // 3) replace second elevent of array by 0
                
                int[] arr = new int[4] { 1, 4, 8, 5 };
                arr[1] = 0;
                ma.Assign(arr, 4);
                arr = null;
                ma.Assign(arr, 5);
            }
           
                // 8) catch all other exceptions here
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception : " + ex.Message);
                Console.WriteLine("Stack Trace : " + ex.StackTrace);
                Console.WriteLine("Source : " + ex.Source);
                Console.WriteLine("HelpLink : " + ex.HelpLink);
                Console.WriteLine("TargetSite : " + ex.TargetSite);
                // 9) print System.Exception properties:
                // HelpLink, Message, Source, StackTrace, TargetSite

            }

            // 10) add finally block, print some message
            // explain features of block finally
            finally
            {
                Console.WriteLine("Finally, block which will be always showed )");
            }
        }
    }
}
