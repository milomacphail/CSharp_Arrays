using System;

namespace Arrays_Intro
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[3];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[1]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] {"Milo", "Charlotte", "Hi"}

        }
    }
}
