using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program displays two strings of motivational quotes upon choosing yes.

            //Array
            string[] motivationalQuotes =
            {
                "If you can dream it, you can do it. - Walt Disney",
                "Change your life today. Don't gamble on the future, act now, without delay. - Simone de Beauvior",
                "Life is 10% what happens to you and 90% how you react to it. - Charles R. Swindoll",
                "Problems are not stop signs, they are guidelines. - Robert H. Schuller",
                "Be kind whenever possible. It is always possible. - Dalai Lama",
                "Start where you are. Use what you have. Do what you can. - Arthur Ashe",
                "With the new day comes new strength and new thoughts. - Eleanor Jackson",
                "Set your goals high, and don't stop till you get there. - Bo Jackson",
                "It always seem impossible until it's done. - Nelson Mandela",
                "Knowing is not enough; we must apply. Willing is not enough; we must do. - Johann Wolfgang von Goethe"
            };

            //Random Number Generator
            Random randomNumber = new Random();

            //Calling variables
            char yes = 'Y';
            char no = 'N';
            char userInput;

            //Program
            Write("Do you want some motivational quotes? Y or N: ");
            userInput = Convert.ToChar(ReadLine());

            while(userInput != no)
            {
                if(userInput != yes)
                {
                    Write("\nSorry didn't catch that letter. \n\nDo you want some motivational quotes? Y or N: ");
                    userInput = Convert.ToChar(ReadLine());
                } else if(userInput == yes)
                {
                    int i1 = randomNumber.Next(0, 10);
                    int i2 = randomNumber.Next(0, 10);
                    while(i1 == i2)
                    {
                        i2 = randomNumber.Next(0, 10);
                    }
                    WriteLine("\nMotivational Quotes: \n{0} \n\n{1}", motivationalQuotes[i1], motivationalQuotes[i2]);
                    Write("\nDo you want more motivational quotes? Y or N: ");
                    userInput = Convert.ToChar(ReadLine());
                }
            }

            //End
            WriteLine("\nThank you for using my program. I hope you liked it.");

            //For more information about this program, please check caption or dm me. I would love to help you!
        }
    }
}
