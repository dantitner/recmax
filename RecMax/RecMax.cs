using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RecMax
{
    public class RecMax
    {
        int[] randomArray;

        /// <summary>
        /// Start the task
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Enter array length:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Generated array: ");
            //генерация массива
            randomArray = randomArray.GenerateArray(length);
            Console.WriteLine(randomArray.Print());
            Console.WriteLine("Max: " + randomArray.MaxRec(randomArray[0]));
            Console.ReadKey();
        }


    }
}

    
