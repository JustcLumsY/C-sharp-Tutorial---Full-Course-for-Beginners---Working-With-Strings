using System;

namespace C_sharp_Tutorial___Full_Course_for_Beginners___Working_With_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Get Academy";

            Console.WriteLine(phrase.Substring(phrase.IndexOf("Academy")) );

            Console.ReadLine();
        }
    }
}
