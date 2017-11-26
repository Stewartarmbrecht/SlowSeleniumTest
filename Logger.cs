using System; 
using System.Diagnostics.Tracing;
namespace SeleniumPerformanceTest
{
	public static class Logger
	{
		public static void Log(Action action, string description)
		{
                  var stopwatch = new System.Diagnostics.Stopwatch();
                  stopwatch.Start();
                  action();
                  stopwatch.Stop();
                  System.Diagnostics.Trace.TraceInformation("<tr><td>"+ stopwatch.ElapsedMilliseconds + "</td><td>" + description + "</td></tr>");
		}
		public static T Log<T>(Func<T> func, string description)
		{
                  var stopwatch = new System.Diagnostics.Stopwatch();
                  stopwatch.Start();
                  var returnValue = func();
                  stopwatch.Stop();
                  System.Diagnostics.Trace.TraceInformation("<tr><td>"+ stopwatch.ElapsedMilliseconds + "</td><td>" + description + "</td></tr>");
                  return returnValue;
            }
	}
}