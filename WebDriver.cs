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
						Logger.Log(() => {
							webDriver = new PhantomJSDriver(".");
						},"webDriver = new PhantomJSDriver();");
					}
					return webDriver;
				}
			}
		} 
		
		public static void Close()
		{
			if(webDriver != null)
			{
				Logger.Log(() => {
					webDriver.Close();
				},"webDriver.Close();");
				Logger.Log(() => {
					webDriver.Quit();
				},"webDriver.Quit();");
				Logger.Log(() => {
					webDriver.Dispose();
				},"webDriver.Dispose();");
			}
		}
	}
}