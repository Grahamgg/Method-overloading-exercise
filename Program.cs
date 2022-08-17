using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
        }

        public static int Add(int num1, int num2)
        {
           return num1 + num2;
           
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;   
        }

        public static string Add(int num1, int num2, bool dollarCheck)
        {
            var sum = num1 + num2;

            if (dollarCheck == true && sum < 1)
            {
                return $"{sum} dollars";

            } else if (dollarCheck == true && sum > 1)

            {
                return $"{sum} dollars";

            } else if (dollarCheck == true && sum == 1)
            
            {
                return $"{sum} dollar";
            }
                else
            {
                return $"it's a secret to everybody +50 rupees";
            }

                
                
        }
            

    }
}
