using System;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
namespace SeleniumPerformanceTest
{
	public class WebDriver
	{
		static object locker = new object();
		static IWebDriver webDriver;
		public static IWebDriver Current 
		{
			get
			{
				lock(locker)
				{
					if(webDriver == null)
					{
			            System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|webDriver = new PhantomJSDriver(\".\\\"); Start");
						PhantomJSOptions options = new PhantomJSOptions();
						options.PageLoadStrategy = PageLoadStrategy.Eager;
						options.SetLoggingPreference("browser", LogLevel.All);
						options.SetLoggingPreference("driver", LogLevel.All);
						options.SetLoggingPreference("client", LogLevel.All);
						options.SetLoggingPreference("performance", LogLevel.All);
						options.SetLoggingPreference("server", LogLevel.All);
						PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService(".\\");
						service.LogFile = ".\\mylogs.txt";
						webDriver = new PhantomJSDriver(service,options);
						
			            System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|webDriver = new PhantomJSDriver(\".\\\"); End");
					}
					return webDriver;
				}
			}
		} 
		
		public static void Close()
		{
			if(webDriver != null)
			{
				Console.WriteLine("Shutting down PhantomJSDriver.");
				webDriver.Close();
				webDriver.Quit();
				webDriver.Dispose();
			}
		}
	}
}