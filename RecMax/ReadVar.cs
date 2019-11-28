using System;
using System.Collections.Generic;
using System.Text;

namespace RecMax
{
    public class ReadVar
    {
        
        public static int Readinteger()
        {
            int variable;

            Console.WriteLine("Enter variable");
            if (!int.TryParse(Console.ReadLine(), out variable))
            {
                Console.WriteLine("Try again");
                variable = Readinteger();
            }
            return variable;
        }

        public static string ReadString()
        {
            Console.WriteLine("Enter line");
            return Console.ReadLine();
        }
    }
}
