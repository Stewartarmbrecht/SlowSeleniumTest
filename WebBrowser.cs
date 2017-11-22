using System;
using System.Threading.Tasks;
using System.Diagnostics;
using OpenQA.Selenium;

namespace SeleniumPerformanceTest
{
    public class WebBrowser
    {
        IWebDriver driver;
        public WebBrowser(IWebDriver driver)
        {
            this.driver = driver;
        }
        public static int DefaultWait = 500;
        
        public void Load(PageLocation location)
        {
            System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|driver.Url = location.Url; Start " + location.Url.ToString());
            driver.Url = location.Url;
            System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|driver.Url = location.Url; End" + location.Url.ToString());
        }

        private IWebElement FindElementBySelector(string selector)
        {
            System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|driver.FindElement(By.CssSelector(element.Selector)); Start " + selector);
            IWebElement webElement = driver.FindElement(By.CssSelector(selector));
            System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|driver.FindElement(By.CssSelector(element.Selector)); End");
            return webElement;
        }
        
        public void ElementHasText(PageElement element, string text)
        {
            System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|ElementHasText Start");
            var webElement = FindElementBySelector(element.Selector);
            if (webElement == null)
                throw new Exception("The web element (" + element.Description + " - " + element.Selector + ") was not found.");
            else
            {
                var foundText = webElement.Text;
                if(foundText.CompareTo(text) != 0)
                   throw new Exception("The web element (" + element.Description + " - " + element.Selector + ") did not have text '" + text + "' it was '" + foundText + "'.");
                
            }
            System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|ElementHasText End");
        }

        public void ElementStyleMatches(PageElement element, string styleRegEx)
        {
            System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|ElementStyleMatches Start " + element.Selector);
            var webElement = FindElementBySelector(element.Selector);
            if (webElement == null)
                throw new Exception("The web element (" + element.Description + " - " + element.Selector + ") was not found.");
            else
            {
                string styleFound = webElement.GetAttribute("style"); 
                if(!System.Text.RegularExpressions.Regex.Match(styleFound, styleRegEx).Success)
                   throw new Exception("The web element (" + element.Description + " - " + element.Selector + ") did not have a style that matched '" + styleRegEx + "' it was '" + styleFound + "'.");
            }
            System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|ElementStyleMatches End");
        }

        public void ElementHasTitle(PageElement element, string title)
        {
            System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|ElementHasTitle Start " + element.Selector);
            var webElement = FindElementBySelector(element.Selector);
            if (webElement == null)
                throw new Exception("The web element (" + element.Description + " - " + element.Selector + ") was not found.");
            else
            {
                string titleFound = webElement.GetAttribute("title"); 
                if(titleFound != title)
                   throw new Exception("The web element (" + element.Description + " - " + element.Selector + ") did not have text '" + title + "' it was '" + titleFound + "'.");
            }
            System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|ElementHasTitle End");
        }

        public Task WaitTillVisible(PageElement element, int waitMilliseconds = -1)
        {
            return Task.Run(() =>
            {
                System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|WaitTillVisible Start " + element.Selector);
                // System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + " Set ImplicitWait to 0 Start");
                // driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0);
                // System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + " Set ImplicitWait to 0 End");

                if (waitMilliseconds == -1)
                    waitMilliseconds = DefaultWait;

                var webElement = FindElementBySelector(element.Selector);

                var visible = false;
                Stopwatch sw = new Stopwatch();
                sw.Start();
                int passCount = 0;
                while (sw.ElapsedMilliseconds < waitMilliseconds && visible == false)
                {
                    ++passCount;
                    if(webElement == null)
                    {
                        webElement = FindElementBySelector(element.Selector);
                    }
                    if(webElement != null)
                    {
                        System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "| webElement.Displayed Start " + element.Selector);
                        if (webElement.Displayed)
                            visible = true;
                        System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "| webElement.Displayed End");
                    }
                }
                System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|Pass Count = " + passCount.ToString());

                if (webElement == null)
                    throw new Exception("The web element (" + element.Description + " - " + element.Selector + ") was not found.");

                if (!visible)
                    throw new Exception("The web element (" + element.Description + " - " + element.Selector + ") was not visible");
                System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|WaitTillVisible End");
            });
        }
    }
}