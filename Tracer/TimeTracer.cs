using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Tracer
{
    public class TimeTracer : ITracer
    {

        private TraceResult _result;
        private DateTime _startTime;
        private DateTime _stopTime;
        private string _callerMethodName;
        private string _callerClassName;

        public TraceResult GetTraceResult()
        {
            return _result;
        }

        public void StartTrace()
        {
            _startTime = DateTime.Now;
            StackTrace s = new StackTrace(0);
            StackFrame callerFrame = s.GetFrame(1);
            _callerMethodName = callerFrame.GetMethod().Name;
            _callerClassName = callerFrame.GetMethod().DeclaringType.Name;
        }

        public void StopTrace()
        {
            _stopTime = DateTime.Now;

            long startTicks = _startTime.Ticks;
            long stopTicks = _stopTime.Ticks;
            long executionTimeTicks = startTicks - stopTicks;
            _result = new TraceResult();
            _result.ExecutionTime = executionTimeTicks;
            _result.MethodName = _callerMethodName;
            _result.ClassName = _callerClassName;
        }
    }
}
