using System;
using System.IO;

namespace C__Programs
{
    class Program
    {
        public static void TestIfElse(int n)
        {
            Console.WriteLine("TestIfElse:");
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
            Console.WriteLine("\n");
        }
        public static void TestSwitch(int op1, int op2, char opr)
        {
            Console.WriteLine("TestSwitch:");
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
            Console.WriteLine("Result: {0}", result); Console.WriteLine("\n"); return;

        }

        private static void WhileTest()
        {
            Console.WriteLine("WhileTest:");
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("The value of i = {0}", i);
                i++;
            }
            Console.WriteLine("\n");
        }
        private static void DoWhileTest()
        {
            Console.WriteLine("DoWhileTest:");
            int i = 1; do
            {
                Console.WriteLine("The value of i = {0}", i);
                i++;
            }
            while (i <= 5);
            Console.WriteLine("\n");
        }

        private static void ForTest()
        {
            Console.WriteLine("ForLoopTest:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("The value of i = {0}", i);
            }
            Console.WriteLine("\n");
        }
        private static void ForEachTest()
        {
            Console.WriteLine("ForEachLoopTest:");
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int i in numbers)
            {
                Console.WriteLine("The value of i = {0}", i);
            }
            Console.WriteLine("\n");
        }

        public static int Factorial(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("The value of n:" + " " + n);
                return 1; //base case: This is part specifies the terminating condition and doesn’t call the method again. If you don’t have a base case in your recursive algorithm, you create an infinite recursion. An infinite recursion will cause your computer to run out of memory and throw a System.StackOverflowException exception.
            }
            else
            {
                Console.WriteLine("The value of n:" + " " + n);
                return n * Factorial(n - 1); //recursive case: This is the part that moves the algorithm toward the base case. The recursive case in the Factorial method is the else part, where you call the method again but with a smaller value progressing toward the base case.
            }
        }
        private static void ExceptionTest()
        {
            Console.WriteLine("\n");
            StreamReader sr = null;
            try
            {
                sr = File.OpenText("/Users/dillondesimone/Documents/C#_Programs/Csharp_Programs/data.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void TryCatchFinallyTest()
        {
            Console.WriteLine("\n");
            StreamReader sr = null; try
            {
                sr = File.OpenText("/Users/dillondesimone/Documents/C#_Programs/Csharp_Programs/data.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Hello World!");
            Console.WriteLine("\n");
            TestIfElse(25);
            TestSwitch(10, 20, '+');
            WhileTest();
            DoWhileTest();
            ForTest();
            ForEachTest();
            { Console.WriteLine("FactorialTest"); }
            Factorial(5);
            ExceptionTest();
            TryCatchFinallyTest();
        }
    }
}