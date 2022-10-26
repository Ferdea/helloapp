using System;

namespace HelloApp
{
    internal class Program
    {
        private static void GreetBlack()
        {
            Console.WriteLine("hello black");
        }
        
        private static void GreetWhite()
        {
            Console.WriteLine("hello white");
        }
        
        private static void PrintHello()
        {
            Console.WriteLine("hello everyone");
        }
        
        public static void Main(string[] args)
        {
            PrintHello();
        }
    }
}