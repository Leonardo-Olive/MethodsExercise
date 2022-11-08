using System;
using System.Linq;

namespace MethodsExercise
{
    public class Program
    {
    public static int Sum (int numb1, int numb2)
        {
            return numb1 + numb2;
        }

        public static int Multiply (int numb1, int numb2, int numb3)
        {
            return numb1 * numb2 * numb3;
        }

        public static int Sumimproved (params int[] numbersSum)
        {
            int sum = 0;
            foreach (var number in numbersSum)
            {
                sum = sum + number;
            }
            return sum;
        }

        public static int ArraySum(IEnumerable<int> numbersSum)
        {
            int sum = 0;
            foreach (var number in numbersSum)
            {
                sum = sum + number;
            }
            return sum;
        }
        public static int ArrayMulti(IEnumerable<int> numbersMult)
        {
            int Multiply = 1;
            foreach (var number in numbersMult)
            {
                Multiply = Multiply * number;
            }
            return Multiply;
        }

            public static int Multimproved (params int[] numberMult)
        {
            int Multiply = 1;
            foreach (var number in numberMult)
            {
                Multiply = Multiply * number;
            }
            return Multiply;
        }
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
              
               
            }
            else
            {
                Console.WriteLine("Got it!");
            }

            Console.WriteLine($"What is your favorite color {username}?");
            var favoritColor = Console.ReadLine();
            Console.WriteLine("OMG! That`s my favorite too!");
            Console.WriteLine($"Your name is {username} and likes to eat {food}. Your favorite color is {favoritColor}. I think we will be best friends!");
           
            Console.WriteLine("Now let`s do some Math! Please choose any amount of numbers (comma separated):");

            var numberString = Console.ReadLine();
            var numbers = numberString.Split(",")
                .Select(number => int.Parse(number));

            Console.WriteLine($"The sum of these numbers is {ArraySum(numbers)}");
            Console.WriteLine($"This is what we get when we multiply your numbers: {ArrayMulti(numbers)}");
            Console.ReadLine();
             
        }
    }
}
       