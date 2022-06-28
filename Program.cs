using System;

namespace QuestionNo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input two numbers, separately 
            Console.WriteLine("Please enter the first number:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            int B = Convert.ToInt32(Console.ReadLine());

            // create a variable C and add variables A,B
            int C = A + B;

            // string concatenate to represent the final statement 
            Console.WriteLine("The sum of the two numbers is: " + C + " !");

        }
    }
}
