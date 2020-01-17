using System;

namespace MathOperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string askForNumber = "Give me a number.";

            TalkToUser(askForNumber);

            string userInput = GetUserData();
            int num1 = int.Parse(userInput);

            TalkToUser(askForNumber);

            userInput = GetUserData();
            int num2 = int.Parse(userInput);

            int answer = Add(num1, num2);
            Console.WriteLine($"The sum is = {answer}");

            Console.WriteLine("Subtraction:");
            Console.WriteLine($"{num1} - {num2} = {Subtract(num1, num2)}");
            Console.WriteLine("Press any key.");
            Console.ReadLine();

            Console.WriteLine("Multiplication:");
            Console.WriteLine($"{num1} * {num2} = {Multiply(num1, num2)}");
            Console.WriteLine("Press any key.");
            Console.ReadLine();

            Console.WriteLine("Division:");
            Console.WriteLine($"{num1} / {num2} = {Divide(num1, num2)}");
            Console.WriteLine("Press any key.");
            Console.ReadLine();
        }

        public static void TalkToUser(string dialouge)
        {
            Console.WriteLine(dialouge);
        }

        public static string GetUserData()
        {
            return Console.ReadLine();
        }

        public static int Add(int firstNumber, int secondNumber)
        {
            int answer = firstNumber + secondNumber;
            return answer;
        }

        public static int Subtract(int firstNumber, int secondNumber)
        {
            int answer = firstNumber - secondNumber;
            return answer;
        }

        public static int Multiply(int firstNumber, int secondNumber)
        {
            int answer = firstNumber * secondNumber;
            return answer;
        }

        public static double Divide(double firstNumber, double secondNumber)
        {
            double answer = firstNumber / secondNumber;
            return answer;
        }
    }
}
