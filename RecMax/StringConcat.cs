using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RecMax
{
    public class StringConcat
    {
        public void Start()
        {
            string first = ReadVar.ReadString();
            string second = ReadVar.ReadString();
            first = new string(first.Distinct().ToArray());
            second = new string(second.Distinct().ToArray());
            Console.WriteLine("Result: ");
            Console.WriteLine(first+second);
            Console.ReadKey();
        }



    }
}
