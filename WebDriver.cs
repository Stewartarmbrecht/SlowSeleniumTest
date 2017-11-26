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
<<<<<<< HEAD
			            System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|webDriver = new PhantomJSDriver(\".\\\"); Start");
						bool isWindows = System.Runtime.InteropServices.RuntimeInformation
                                               .IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Windows);
						if(isWindows)
						{
							webDriver = new PhantomJSDriver(".\\");
						}
						else
						{
							webDriver = new PhantomJSDriver(".");
						}
			            System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|webDriver = new PhantomJSDriver(\".\\\"); End");
=======
						Logger.Log(() => {
							webDriver = new PhantomJSDriver(".");
						},"webDriver = new PhantomJSDriver();");
>>>>>>> 8d7242a99e9bacb7f3198725c7f303007f689e74
					}
					return webDriver;
				}
			}
		} 
		
		public static void Close()
		{
			if(webDriver != null)
			{
<<<<<<< HEAD
				System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|webDriver.Close(); Start");
				webDriver.Close();
				System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|webDriver.Close(); End");
				System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|webDriver.Quit(); Start");
				webDriver.Quit();
				System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|webDriver.Quit(); End");
				System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|webDriver.Dispose(); Start");
				webDriver.Dispose();
				System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|webDriver.Dispose(); End");
=======
				Logger.Log(() => {
					webDriver.Close();
				},"webDriver.Close();");
				Logger.Log(() => {
					webDriver.Quit();
				},"webDriver.Quit();");
				Logger.Log(() => {
					webDriver.Dispose();
				},"webDriver.Dispose();");
>>>>>>> 8d7242a99e9bacb7f3198725c7f303007f689e74
			}
		}
	}
}