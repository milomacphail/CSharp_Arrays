using System;


namespace Reverse_String
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a string: ");

            var input = Console.ReadLine();

            var stringInput = new char[input.Length];

            for (int letter = input.Length; letter > 0; letter--)
            {
                stringInput[input.Length - letter] = input[letter - 1];
            }

            var stringReversed = new string(stringInput);
            Console.WriteLine(stringReversed);
            
        }
    }
}
