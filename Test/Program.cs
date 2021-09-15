using System;

using Tracer;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Method();
        }

        private static void Method()
        {
            TimeTracer tracer = new TimeTracer();
            tracer.StartTrace();
            tracer.StopTrace();
            TraceResult result = tracer.GetTraceResult();
            Console.WriteLine(result.MethodName);
            Console.WriteLine(result.ClassName);
        }
    }
}
