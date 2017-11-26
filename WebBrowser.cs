using System;
using System.Threading.Tasks;
using System.Diagnostics;
using OpenQA.Selenium;
<<<<<<< HEAD
using OpenQA.Selenium.PhantomJS;
=======
using OpenQA.Selenium.Support;
>>>>>>> 8d7242a99e9bacb7f3198725c7f303007f689e74
using OpenQA.Selenium.Support.UI;

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
            Logger.Log(() => {
                driver.Url = location.Url;
            }, "driver.Url = location.Url;");
        }

        private IWebElement FindElementBySelector(string selector)
        {
<<<<<<< HEAD
            System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|driver.FindElement(By.CssSelector(element.Selector)); Start " + selector);
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement webElement = wait.Until(drv => drv.FindElement(By.CssSelector(selector)));
            System.Diagnostics.Trace.TraceInformation("|"+DateTime.Now.ToString("HH:mm:ss.fff") + "|driver.FindElement(By.CssSelector(element.Selector)); End");
            return webElement;
=======
            return Logger.Log<IWebElement>(() => {
                IWebElement webElement = driver.FindElement(By.CssSelector(selector));
                return webElement;
            },"driver.FindElement(By.CssSelector(selector)); "+ selector);
>>>>>>> 8d7242a99e9bacb7f3198725c7f303007f689e74
        }
        
        public void ElementHasText(PageElement element, string text)
        {
            var webElement = FindElementBySelector(element.Selector);
            if (webElement == null)
                throw new Exception("The web element (" + element.Description + " - " + element.Selector + ") was not found.");
            else
            {
                var foundText = webElement.Text;
                if(foundText.CompareTo(text) != 0)
                throw new Exception("The web element (" + element.Description + " - " + element.Selector + ") did not have text '" + text + "' it was '" + foundText + "'.");
                
            }
        }

        public void ElementStyleMatches(PageElement element, string styleRegEx)
        {
            var webElement = FindElementBySelector(element.Selector);
            if (webElement == null)
                throw new Exception("The web element (" + element.Description + " - " + element.Selector + ") was not found.");
            else
            {
                string styleFound = webElement.GetAttribute("style"); 
                if(!System.Text.RegularExpressions.Regex.Match(styleFound, styleRegEx).Success)
                   throw new Exception("The web element (" + element.Description + " - " + element.Selector + ") did not have a style that matched '" + styleRegEx + "' it was '" + styleFound + "'.");
            }
        }

        public void ElementHasTitle(PageElement element, string title)
        {
            var webElement = FindElementBySelector(element.Selector);
            if (webElement == null)
                throw new Exception("The web element (" + element.Description + " - " + element.Selector + ") was not found.");
            else
            {
                var titleFound = Logger.Log<string>(() => {
                    return webElement.GetAttribute("title"); 
                }, "webElement.GetAttribute(\"title\");");
            
                if(titleFound != title)
                   throw new Exception("The web element (" + element.Description + " - " + element.Selector + ") did not have text '" + title + "' it was '" + titleFound + "'.");
            }
        }

        public Task WaitTillVisibleById(string id)
        {
            return Task.Run(() =>
            {
                Logger.Log(() => {
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    IWebElement webElement = wait.Until(driver => driver.FindElement(By.Id(id)));
                }, "wait.Until(driver => driver.FindElement(By.Id(id))); " + id);
            });
        }
        public Task WaitTillVisible(PageElement element, int waitMilliseconds = -1)
        {
            return Task.Run(() =>
            {
                Logger.Log(() => {
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    IWebElement webElement = wait.Until(driver => driver.FindElement(By.CssSelector(element.Selector)));
                }, "wait.Until(driver => driver.FindElement(By.CssSelector(element.Selector))); " + element.Selector);
            });
        }
    }
}