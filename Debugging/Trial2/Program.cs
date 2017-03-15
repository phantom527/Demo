using System;
using System.Linq;
using System.Threading.Tasks;

namespace Trial2
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new object();

            lock (obj)
            {
                System.Diagnostics.Debugger.Break();
                Console.WriteLine("Locked Hello World");
            }
            Method();
        }

        static void Method()
        {
            var obj = new object();
            Parallel.ForEach(Enumerable.Range(0, 2), (x) =>
            {
                lock (obj)
                {
                    System.Diagnostics.Debugger.Break();
                    Console.WriteLine("Locked Hello World");
                }
            });
        }
    }
}
