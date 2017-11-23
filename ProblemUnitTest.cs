using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;


namespace SeleniumPerformanceTest
{
    [TestClass]
    public class ProblemUnitTest
    {
        [TestMethod]
        public async Task ValidateAreas()
        {
            var directory = System.IO.Directory.GetCurrentDirectory();
            var path = "file:///" + directory + "\\TestPage.html";

            WebBrowser browser = new WebBrowser(WebDriver.Current);
            browser.Load(new PageLocation("Test Html Page", path));
            // there should be a section under the area name that displays feature statistics about the area
            await browser.WaitTillVisibleById("area-3-feature-stats");
            // the total number of features should show as a badge to the right of the area name with a value of 3
            await browser.WaitTillVisible(AreaFeatureStats.Total(3));
            browser.ElementHasText(AreaFeatureStats.Total(3), "3");
            // the badge should show 'Features' when the user hovers over it
            browser.ElementHasTitle(AreaFeatureStats.Total(3), "Features");
            // the section should show the number of passed features with a value of 1
            browser.ElementHasText(AreaFeatureStats.Passed(3), "1");
            // the section should show the number of skipped features with a value of 1
            browser.ElementHasText(AreaFeatureStats.Skipped(3), "1");
            // the section should show the number of failed features with a value of 1
            browser.ElementHasText(AreaFeatureStats.Failed(3), "1");
            // "the section should a green, yellow, and red bar chart of the percentages of passed, skipped, and failed features
            await browser.WaitTillVisible(AreaFeatureStats.BarChart(3));
            // the passed, green bar should have a width of 33%
            browser.ElementStyleMatches(AreaFeatureStats.SuccessBar(3), ".*width: 33\\..*");
            // the skipped, yellow bar should have a width of 33%
            browser.ElementStyleMatches(AreaFeatureStats.SkippedBar(3), ".*width: 33\\..*");
            // the failed, red bar should have a width of 33%
            browser.ElementStyleMatches(AreaFeatureStats.FailedBar(3), ".*width: 33\\..*");

            // System.Diagnostics.Trace.TraceInformation("Client Logs");
            // var logs = WebDriver.Current.Manage().Logs.GetLog("client");
            // foreach(var logEntry in logs) 
            // {
            //     System.Diagnostics.Trace.TraceInformation("|" + logEntry.Timestamp + "|" + logEntry.Message);
            // }

            System.Diagnostics.Trace.TraceInformation("browser Logs");
            var logs = WebDriver.Current.Manage().Logs.GetLog("browser");
            foreach(var logEntry in logs) 
            {
                System.Diagnostics.Trace.TraceInformation("|" + logEntry.Timestamp + "|" + logEntry.Message);
            }

            // System.Diagnostics.Trace.TraceInformation("Driver Logs");
            // logs = WebDriver.Current.Manage().Logs.GetLog("driver");
            // foreach(var logEntry in logs) 
            // {
            //     System.Diagnostics.Trace.TraceInformation("|" + logEntry.Timestamp + "|" + logEntry.Message);
            // }

            // System.Diagnostics.Trace.TraceInformation("Server Logs");
            // logs = WebDriver.Current.Manage().Logs.GetLog("server");
            // foreach(var logEntry in logs) 
            // {
            //     System.Diagnostics.Trace.TraceInformation("|" + logEntry.Timestamp + "|" + logEntry.Message);
            // }

        }
        [TestMethod]
        public async Task ValidateAreasSimple()
        {
            var directory = System.IO.Directory.GetCurrentDirectory();
            var path = "file:///" + directory + "\\TestPage.Simple.html";

            WebBrowser browser = new WebBrowser(WebDriver.Current);
            browser.Load(new PageLocation("Test Html Page", path));
            // there should be a section under the area name that displays feature statistics about the area
            await browser.WaitTillVisibleById("area-3-feature-stats");
            // the total number of features should show as a badge to the right of the area name with a value of 3
        }
    }
}
