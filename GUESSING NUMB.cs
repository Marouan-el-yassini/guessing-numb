using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();
            int randomNumb = random.Next(1, 10);
            Console.WriteLine("Welcome to guess number");
            Console.WriteLine("1-----10 number are availble");
            Console.WriteLine("if you guess the correct number you win");
            while (!isCorrectGuess)
            {
                Console.WriteLine("enter your guess numb");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess > randomNumb)
                {
                    Console.WriteLine("the guess is high");
                }
                else if (guess < randomNumb)
                {
                    Console.WriteLine("the guess is not high");
                }
                else
                {
                    Console.WriteLine("you win");
                }
            }
        }
    }
}
