using System;

namespace Out
{

    public interface ITracer
    {
        void StartTrace();

        void StopTrace();

 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    struct TraceResult
    {

    }
}
