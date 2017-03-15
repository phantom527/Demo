using System;

namespace Trial3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faulted Hello World!");
            System.Diagnostics.Debugger.Break();
            try
            {
                throw new NotFiniteNumberException();
            }
            catch (Exception)
            {
                System.Diagnostics.Debugger.Break();
            }
        }
    }
}
