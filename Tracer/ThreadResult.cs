using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tracer
{
    class ThreadResult
    {
        private int _threadId;
        private int _executionTime;
        private List<MethodResult> _methods;

        public ThreadResult()
        {
            _threadId = Thread.CurrentThread.ManagedThreadId;
            _methods = new List<MethodResult>();
        }

        public int ThreadId { get; }

        public int ExecutionTime { get; }

        public List<MethodResult> Methods { 
            get
            {
                return new List<MethodResult>(_methods);
            }
        }

        public void AddMethod(MethodResult method)
        {
            _methods.Add(method);
        }
        
    }
}
