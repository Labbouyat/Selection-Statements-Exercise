using System;

namespace SelectionStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 94;

            Console.WriteLine("Guess my favorite number. Hint: between 1 - 100");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favoriteNumber)
            {
                Console.WriteLine("too LOW!!!!");
            }
            else if (userGuess > favoriteNumber)
            {
                Console.WriteLine("too HIGH!!!");
            }
            else if (userGuess == favoriteNumber)
            {
                Console.WriteLine("Good job! That's correct");
            }

            else
            {
               Console.WriteLine("Nevermind");
            }


            string subject = "C#";


            Console.WriteLine("Guess my favCoding subject");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {

                case "C#":
                    Console.WriteLine("You are in the right subject");
                    break;
                case "Java":
                    Console.WriteLine("C# is better then java");
                    break;
                case "Paython":
                    Console.WriteLine("C# is better subject");
                    break;
                default:
                    Console.WriteLine("The right subject is: C#");
                    break;
            }


            }
        }
}
