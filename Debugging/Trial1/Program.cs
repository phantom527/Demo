using System;

namespace Trial1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World2");
            System.Diagnostics.Debugger.Break();
            Method("Hello World3", "Hello World4");
        }

        public static void Method(string hello1, string hello2)
        {
            System.Diagnostics.Debugger.Break();
            Console.WriteLine(hello1 + hello2);
        }
    }
}
