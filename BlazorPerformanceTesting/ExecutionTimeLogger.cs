using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BlazorPerformanceTesting
{
    public class ExecutionTimeLogger : IDisposable
    {
        private readonly string _methodName;
        private readonly Stopwatch _stopwatch;

        public ExecutionTimeLogger([CallerMemberName] string methodName = "")
        {
            _methodName = methodName;
            _stopwatch = Stopwatch.StartNew();
        }

        public void Dispose()
        {
            var message = _methodName + "() took " + _stopwatch.ElapsedMilliseconds + " ms.";
            Debug.WriteLine(message);
            Console.WriteLine(message);
            GC.SuppressFinalize(this);
        }
    }
}