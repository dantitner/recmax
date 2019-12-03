using System;
using System.Collections.Generic;
using System.Text;

namespace RecMax
{
    public class NumOutOfDig
    {
        public void Start()
        {
            int[] incoming = new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
            int[] result = FilterDigit(incoming,7);
            Console.WriteLine(result.Print());
        }

        public static int[] FilterDigit(int[] numbers, int filter)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                string temp = numbers[i].ToString();
                bool haveDigit = false;

                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[j].ToString() == filter.ToString())
                        haveDigit = true;
                }

                if (haveDigit)
                    result.Add(numbers[i]);
            }

            return result.ToArray();
        }
    }
}
