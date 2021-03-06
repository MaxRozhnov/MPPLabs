﻿using System;
using System.Diagnostics;

namespace Tracer_Lib
{

    //C# naming convention
    
    public class Tracer : ITracer
    {
        private readonly Stopwatch _stopwatch = new Stopwatch();
        public void StartTrace()
        {
            _stopwatch.Start();
        }

        public void StopTrace()
        {
            _stopwatch.Stop();
        }

        public TraceResult GetTraceResult()
        {
            var result = new TraceResult {exactTime = _stopwatch.ElapsedMilliseconds};
            return result;
        }
    }
}