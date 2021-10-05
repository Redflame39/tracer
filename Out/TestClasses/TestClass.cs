using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tracer;

namespace Tracer.TestClasses
{
    public class TestClass
    {

        private ITracer _tracer;

        public TestClass(ITracer tracer)
        {
            _tracer = tracer;
        }

        public void StartMethod()
        {
            AnotherThread anotherThread = new AnotherThread(_tracer);
            Thread thread = new Thread(new ThreadStart(anotherThread.AnotherThreadMethod));
            thread.Start();
            Method();
            AnotherMethod();
        }

        private void Method()
        {
            _tracer.StartTrace();
            InnerMethod1();
            InnerMethod2();
            _tracer.StopTrace();

        }

        private void AnotherMethod()
        {
            _tracer.StartTrace();
            AnotherInnerMethod1();
            AnotherInnerMethod2();
            _tracer.StopTrace();
        }

        private void InnerMethod1()
        {
            _tracer.StartTrace();
            Thread.Sleep(100);
            _tracer.StopTrace();
        }

        private void InnerMethod2()
        {
            _tracer.StartTrace();
            Thread.Sleep(200);
            _tracer.StopTrace();
        }

        private void AnotherInnerMethod1()
        {
            _tracer.StartTrace();
            Thread.Sleep(200);
            _tracer.StopTrace();
        }

        private void AnotherInnerMethod2()
        {
            _tracer.StartTrace();
            Thread.Sleep(400);
            _tracer.StopTrace();
        }
    }
}
