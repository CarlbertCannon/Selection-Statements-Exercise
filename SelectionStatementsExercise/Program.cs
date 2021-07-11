using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //var favNumber = (13);

            //Console.WriteLine("Try to guess my favorite number");

            //var userInput = int.Parse(Console.ReadLine());

            //if (userInput < favNumber)
            //{
            //    Console.WriteLine("too low");
            //}

            //else if (userInput > favNumber)
            //{
            //    Console.WriteLine("too high");
            //}

            //else
            //{
            //    Console.WriteLine("Nevermind");
            //}

            Console.WriteLine($"What was your favorite subject in School?");
            var reply = Console.ReadLine();

            switch (reply)
            {
                case "Science":
                    Console.WriteLine($"Physics is really cool");
                    break;
                case "History":
                    Console.WriteLine($"There's so much to learn");
                    break;
                case "Band":
                    Console.WriteLine($"I love my instrument");
                    break;
                case "Home economics":
                    Console.WriteLine($"This is where I learned to do taxes");
                    break;
                case "Theatre arts":
                    Console.WriteLine($"I learned the art of acting here");
                    break;
                default:
                    Console.WriteLine($"I don't have one");
                    break;
            }
        }
    }
}
