using System;

namespace NewProject
{
    class Inches
    {
        static void Main(string [] args)
        {
            long inches;
            long meters;

            meters = 400;
            inches = meters * 100 * 40;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("inches: {0}; meters: {1}", inches, meters);
            
            long kilogram;
            long gram;
            kilogram = 5;
            gram = kilogram * 5 * 1000;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("kilogram: {0}; gram: {1}", kilogram, gram);
            string str1 = new string("E.S.N.Channel");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            string str2 = "New Channel";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}