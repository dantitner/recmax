﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RecMax
{
    public static class Extension
    {
        static Random r = new Random();

        /// <summary>
        /// генерация позитивного массива
        /// </summary>
        /// <param name="array"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static int[] GenerateArrayPos(this int[] array, int length)
        {
            array = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1, 100);
            }

            return array;
        }

        /// <summary>
        /// генерация массива
        /// </summary>
        /// <param name="array"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static int[] GenerateArray(this int[] array, int length)
        {
            array = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-100, 100);
            }

            return array;
        }

        public static int[] GenerateArray(this int[] array, int length, int limit)
        {
            array = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-limit, limit);
            }

            return array;
        }

        public static int? MaxRecPos(this int[] array)
        {
            //первый положительный элемент и его индекс
            int subject = array.First(n => n > 0);
            int subjectIndex = Array.IndexOf(array, subject);
            int nextPositive = subjectIndex;

            //следующий положительный элемент
            for (int i = subjectIndex + 1; i < array.Length; i++)
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
            if (subject > array[nextPositive])
            {
                array[nextPositive] = -array[nextPositive];
                subject = (int)MaxRecPos(array);
            }
            else
            {
                array[subjectIndex] = -array[subjectIndex];
                subject = (int)MaxRecPos(array);
            }

            return subject;
        }

        public static int? MaxRec(this int[] array, int subject)
        {
            if (array.Length > 2)
            {
                int[] newarrray = array.CloneFrom(1, array.Length - 1);

                if (subject < array[1])
                {
                    subject = array[1];
                }
                subject = (int)MaxRec(newarrray, subject);
            }
            else if (array.Length == 2)
            {
                if (subject < array[1])
                {
                    subject = array[1];
                }
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

        /// <summary>
        /// Клонирует массив от начального элемента до конечного
        /// </summary>
        /// <param name="array"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static int[] CloneFrom(this int[] array, int start, int end)
        {
            int[] newarray = new int[end - start + 1];
            int j = start;
            for (int i = 0; i < end - start + 1; i++)
            {
                newarray[i] = array[j];
                j++;
            }
            return newarray;

        }


        public static int? SumAtoB(this int[] array, int start, int end)
        {
            try
            {
                int sum = 0;

                for (int i = start; i <= end; i++)
                {
                    sum += array[i];
                }

                return sum;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

