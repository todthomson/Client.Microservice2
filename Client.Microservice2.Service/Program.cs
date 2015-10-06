using System;
using System.Threading;

namespace Client.Microservice2.Service
{
    class Program
    {
        // ReSharper disable once FunctionNeverReturns
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Hello, Microservice2!");
                Thread.Sleep(1000);
            }
        }
    }
}
