using System;
using System.Collections.Generic;

namespace Conversie
{
    class Program
    {
        static void Main(string[] args)
        {
            //number conversion from base 10 into any other base
            int b;

            Console.WriteLine("###############################################");
            Console.WriteLine("Number conversion from base10 in any other base");
            Console.WriteLine("###############################################");

            Console.WriteLine("What is the number you want to convert?");
            string Line = Console.ReadLine();
            int Number = int.Parse(Line);

            //TODO exception handling


            Console.WriteLine("What base do you want your number to be converted into?(between 2 and 16)");
            Line = Console.ReadLine();
            int NumberBase = int.Parse(Line);
            //TODO set bounds for the numberbase input

            int Quotient, Remainder;
            int Result = 0, Power = 1;
            string Result1 = "";
            Stack<int> MyStack = new Stack<int>();
            while (Number > 0)
            {
                Quotient = Number / NumberBase;
                Remainder = Number % NumberBase;
                MyStack.Push(Remainder);

                Number /= NumberBase;
                
               // Result = Result + Remainder * Power;
                //Power *= 10;
            }
            while(MyStack.Count!=0)
            {
                Result1=Result1 + Convert.ToString(MyStack.Pop());
            }
            Console.WriteLine(Result1);
        }
    }
}
