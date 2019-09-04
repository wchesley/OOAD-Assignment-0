using System;
namespace Assignment_0
{
    class Menu
    {
        public char DisplayMenu()
        {
            Console.WriteLine("Please select from the following:");
            Console.WriteLine("a. Enter Expression");
            Console.WriteLine("b. Check Your Answer");
            Console.WriteLine("c. Display Score");
            Console.WriteLine("d. Exit");
            string userInput = Console.ReadLine();
            return userInput[0];
        }
    }
}