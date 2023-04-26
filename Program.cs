using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guessCount;
            while(playAgain==true)
            {
                guess = 0;
                guessCount = 0;
                number = random.Next(min, max+1);

                while(guess != number)
                {
                    guessCount++;
                    Console.WriteLine("Guess a number between"+min+" - "+ max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guess > number)
                    {
                        Console.WriteLine("this number is higher than the required number");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine("This number is lesser than the required number");
                    }
                }
                Console.WriteLine("The number is -"+number);
                Console.WriteLine("You win!!");
                Console.WriteLine("number of guesses =" + guessCount);
                Console.WriteLine("Would you like to play again?");
                string response = Console.ReadLine();
                response = response.ToUpper();
                if(response == "Y")
                {
                    playAgain = true;
                }else playAgain = false;
            }
        }
    }
}
