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
            int length;
            Console.WriteLine("Enter array length:");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Generated array: ");
            //генерация массива
            randomArray = randomArray.GenerateArray(length);
            Console.WriteLine(randomArray.Print());
            Console.WriteLine("Max: " + randomArray.MaxRec());
            Console.ReadKey();
        }
    }

    public static class Extension
    {
        static Random r = new Random();
        public static int[] GenerateArray(this int[] array, int length)
        {
            array = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1, 100);
            }

            return array;
        }

        public static int? MaxRec(this int[] array)
        {
            //первый положительный элемент и его индекс
            int subject = array.First(n => n > 0);
            int subjectIndex = Array.IndexOf(array, subject);
            int nextPositive = subjectIndex;

            //следующий положительный элемент
            for (int i = subjectIndex+1; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    nextPositive = i;
                    break;
                } 

            }

            //если они равны то значение  найдено
            if (subjectIndex == nextPositive)
                return subject;

            //сравнение с ихменением значения на отрицательное
            if (subject > array[ nextPositive])
            {
                array[nextPositive] = -array[nextPositive];
                subject = (int)MaxRec(array);
            }
            else
            {
                array[subjectIndex] = -array[subjectIndex];
                subject = (int)MaxRec(array);
            }

            return subject;
        }
        /// <summary>
        /// Создать строку из массива
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static string Print(this int[] array)
        {
            string result = null;

            foreach (var item in array)
            {
                result += item.ToString();
                result += " ";
            }

            return result;
        }

    }
}
