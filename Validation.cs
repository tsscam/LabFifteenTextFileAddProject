using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFifteen
{
    class Validation
    {
        public static int GetIntWithRange()
        {
            int Min = 1;
            int Max = 3;
            int value;

            while (true)
            {
                if (!Int32.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("Must Enter 1, 2 or 3 only.");
                }
                else if (value < Min || value > Max)
                {
                    Console.WriteLine("The number you entered was not {0} or {1}. Try Again!");
                }
            }
        }
    }
}
  