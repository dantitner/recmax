using System;
using System.Collections.Generic;
using System.Text;

namespace RecMax
{
    public class Rle
    {
        int[] randomArray;

        public void Start()
        {
            Console.WriteLine("Enter array length:");
            int length = Convert.ToInt32(Console.ReadLine());
            randomArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                randomArray[i] = ReadVar.Readinteger();
            }
            //генерация массива
            Console.WriteLine(randomArray.Print());
            Console.WriteLine(FindIndexOfBalance(randomArray)+1);

            Console.ReadKey();
        }

        public int FindIndexOfBalance(int[] array)
        {
            int result = 0;

            if (array.Length < 3)
                return -1;

            for (int i = 1; i < array.Length-2; i++)
            {
                int? leftSum = array.SumAtoB(0, i-1);
                int? rightSum = array.SumAtoB(i + 1, array.Length-1);
                if (leftSum == rightSum)
                    return i;
            }

            return result;
        }


    }
}
