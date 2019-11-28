using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace RecMax
{
    public class NextNumber
    {
        public void Start()
        {
            Console.WriteLine(FindNextBiggerNumber(3456432));
        }

        public int FindNextBiggerNumber(int number)
        {

            int[] numberArray = new int[number.ToString().Length];
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = int.Parse(number.ToString()[i].ToString());
            }

            if (HasNoBiggerNumber(numberArray))
            {
                return -1;
            }

            int lastIndex = -1;
            for (int i = numberArray.Length - 1; i >= 0; i--)
            {
                if (numberArray[i] > numberArray[i - 1])
                {
                    Swap(ref numberArray[i], ref numberArray[i - 1]);
                    lastIndex = i;
                    break;
                }
            }
            Array.Sort(numberArray,lastIndex, numberArray.Length - lastIndex);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (int i in numberArray)
            {
                stringBuilder.Append(i);
            }

            return int.Parse(stringBuilder.ToString());
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static bool HasNoBiggerNumber(int[] array)
        {
            int a = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i + 1])
                {
                    a++;
                }
            }

            if (a == array.Length - 1)
            {
                return true;
            }

            return false;
        }
    }
}
