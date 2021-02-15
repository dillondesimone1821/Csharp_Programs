using System;

namespace C__Programs
{
    class Program
    {
        public static void TestIfElse(int n)
        {
            if (n < 10)
            {
                Console.WriteLine("n is less than 10");
            }
            else if (n < 20)
            {
                Console.WriteLine("n is less than 20");
            }
            else if (n < 30)
            {
                Console.WriteLine("n is less than 30");
            }
            else
            {
                Console.WriteLine("n is greater than or equal to 30");
            }
        }
        public static void TestSwitch(int op1, int op2, char opr)
            {
                int result; 
                switch (opr)
                {
                    case '+':
                        result = op1 + op2; 
                        break;
                    case '-':
                        result = op1 - op2; 
                        break;
                    case '*':
                        result = op1 * op2; 
                        break;
                    case '/':
                        result = op1 / op2; 
                        break;
                        default:
                        Console.WriteLine("Unknown Operator"); return;
                }
                Console.WriteLine("Result: {0}", result); return;
            }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestIfElse(25);
            TestSwitch(10, 20, '+');
        }
    }
}