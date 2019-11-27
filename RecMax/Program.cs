using System;

namespace RecMax
{
    public class Program
    {
        static void Main(string[] args)
        {
            ChooseTask();
        }

        public static void ChooseTask()
        {
            Console.WriteLine("Max number with recursion - 1");
            Console.WriteLine("Left/Right elements equal - 2");


            string responce = Console.ReadLine();
            switch (responce)
            {
                case "1":
                    RecMax obj = new RecMax();
                    obj.Start();
                    break;
                case "2":
                    Rle obj2 = new Rle();
                    obj2.Start();
                    break;
                default:
                    ChooseTask();
                    break;
            }
        }
    }
}
