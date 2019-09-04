// Walker Chesley
// 09/03/2019
using System;
namespace Assignment_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            int argOne = 0; 
            int argTwo = 0;
            int answer = 0;
            char ch;
            do
            {
                ch = menu.DisplayMenu();
                switch (ch)
                {
                    case 'a':
                        Expressions.ReadExpression(out argOne, out argTwo, out answer);
                    break;
                    case 'b':
                        Expressions.CheckExpression(argOne, argTwo, answer);
                        break;
                    case 'c':
                        Expressions.DisplayScore(); 
                        break;
                }
            } while (ch != 'd');
        }
    }
}
