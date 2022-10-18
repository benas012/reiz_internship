using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    internal class Input
    {
        public static int InputNumber(string message, Func<int, Boolean>? Validation = null)
        {
            int num = 0;
            Console.WriteLine(message);
            try
            {
                num = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return -1;
            }

            if(Validation is null)
            {
                return num;
            }
            if (Validation(num))
            {
                return num;
            }
            return -1;
        }
    }
}
