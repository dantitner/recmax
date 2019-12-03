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
            Console.WriteLine("String concat - 3");
            Console.WriteLine("Next number - 4");
            Console.WriteLine("Find numbers with digit - 5");

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
                case "3":
                    StringConcat obj3 = new StringConcat();
                    obj3.Start();
                    break;
                case "4":
                    NextNumber obj4 = new NextNumber();
                    obj4.Start();
                    break;
                case "5":
                    NumOutOfDig obj5 = new NumOutOfDig();
                    obj5.Start();
                    break;
                default:
                    ChooseTask();
                    break;
            }
        }
    }
}
