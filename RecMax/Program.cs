using System;

namespace RecMax
{
    class Program
    {
        static void Main(string[] args)
        {
            ChooseTask();
        }

        public static void ChooseTask()
        {
            Console.WriteLine("Max number with recursion - 1");

            string responce= Console.ReadLine();
            switch (responce)
            {
                case "1":
                    RecMax obj = new RecMax();
                    obj.Start();
                    break;
                default:
                    ChooseTask();
                    break;
            }
        }
    }
}
