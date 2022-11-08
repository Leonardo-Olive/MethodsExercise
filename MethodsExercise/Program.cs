using System;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Hello, what is your name?");
            var username = Console.ReadLine();

            Console.WriteLine($"What a beautiful name you have {username}.");
            Console.WriteLine("Now, what is your favorite food?");
             String food = Console.ReadLine();

            if (food == "Burger")
            {
                Console.WriteLine("No way! All we need is some fries to make it perfect!");
                Console.WriteLine($"What is your favorite color {username}?");
                var favoritColor = Console.ReadLine();
                Console.WriteLine("OMG! That`s my favorite too!");
                Console.WriteLine($"Your name is {username} and likes to eat {food}. Your favorite color is {favoritColor}. I think we will be best friends!");
            }
           
           else
            { Console.WriteLine("Got it!");
                Console.WriteLine($"What is your favorite color {username}?");
                var favoritColor = Console.ReadLine();
                Console.WriteLine("OMG! That`s my favorite too!");
                Console.WriteLine($"Your name is {username} and likes to eat {food}. Your favorite color is {favoritColor}. I think we will be best friends!");
            }
            Console.ReadLine();
           
        }
    }
}
