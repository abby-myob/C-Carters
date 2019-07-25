using System;
using System.ComponentModel.Design;
using System.Net;

namespace ConsoleApp1
{
    class Program
    {
        private static void Main()
        {
            const int secretNum = 301;
            var numOfTries = 1;
            var num = 0;


            while (num != secretNum)
            {
                var prevNum = num;
                Console.WriteLine("Give me a number.");
                var response = Console.ReadLine();
                if (int.TryParse(response, out num))
                {
                    num = int.Parse(response);
                    if (num == prevNum) continue;
                    if (num == secretNum) continue;
                    numOfTries += 1;
                }
                else
                {
                    IllegalInputResponse();
                    continue;
                }
                 
                
                if (secretNum > num)
                {
                    Console.WriteLine("Close but no cigar");
                    Console.WriteLine("You're too low\n");
                }
                else
                {
                    Console.WriteLine("Close but no cigar");
                    Console.WriteLine("You're too high\n");
                }
            }

            Console.WriteLine(
                numOfTries > 0
                    ? $"Congratulations, you guessed the secret number. It took you {numOfTries} tries."
                    : $"Congratulations, you guessed the secret number. It took you {numOfTries} try.");
        }

        private static void IllegalInputResponse()
        {
            Console.WriteLine("That wasn't a number dude.\n");
        }
    }
    
    
    
}