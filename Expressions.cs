using System;
namespace Assignment_0
{
    class Expressions
    {
      
        public static int totalCounter
        {
           get; set;
        }
        public static int correctCounter
        {
            get; set; 
        }
        public static int ReadExpression(out int userInputOne, out int userInputTwo, out int userAnswer)
        {
            string input = null;
            Int32[] ParsedInput = new Int32[3];
            Console.WriteLine("Enter a full multiplication expression: ie. 5*6=30\nYou must supply the correct answer to receive points");
            Console.Write("Please Enter your Expression Here: ");
            input = Console.ReadLine();
            if (input.Contains('*') && input.Contains('='))
            {
                totalCounter++; 
                ParsedInput = ParseInput(input);
                userInputOne = ParsedInput[0];
                userInputTwo = ParsedInput[1];
                userAnswer = ParsedInput[2];
                return 1;
            }
            else
            {
                Console.WriteLine("Couldn't find '*' or '=' in expression, please try again");
                userInputOne = 0;
                userInputTwo = 0;
                userAnswer = 0;
                return 0; 
            }
        }
        public static int[] ParseInput(string input)
        {

            char[] delimiterChars = { ' ', '*', '=' };
            string[] extractedNumsAsString = input.Split(delimiterChars);
            Int32[] inputExpressions = new Int32[extractedNumsAsString.Length];
            for (int i = 0; i < extractedNumsAsString.Length; i++)
            {
                int tmp;
                if (int.TryParse(extractedNumsAsString[i], out tmp))
                {
                    inputExpressions[i] = tmp;
                }
                else
                {
                    Console.WriteLine($"Failed to parse {extractedNumsAsString[i]}, please try again");
                }
            }
            return inputExpressions;
        }
        public static int CheckExpression(int userInputOne, int userInputTwo, int userAnswer)
        {
            int correctAnswer = userInputOne * userInputTwo;
            if (userAnswer == correctAnswer)
            {
                Console.WriteLine($"Your input of {userInputOne.ToString()} * {userInputTwo.ToString()} = {userAnswer.ToString()} is correct!");
                correctCounter++;
                return 1;
            }
            else
            {
                Console.WriteLine($"Your input of {userInputOne.ToString()} * {userInputTwo.ToString()} = {userAnswer.ToString()} was incorrect\nThe correct answer is {userInputOne.ToString()} * {userInputTwo.ToString()} = {correctAnswer.ToString()}");
                return 0;
            }
        }
        public static void DisplayScore()
        {
            Console.WriteLine($"Your score is {correctCounter.ToString()} out of {totalCounter.ToString()}");
        }
    }
}