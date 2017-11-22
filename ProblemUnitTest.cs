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
        public async Task TestMethod1()
        {
            var directory = System.IO.Directory.GetCurrentDirectory();
            var path = "file:///" + directory + "\\TestPage.html";

            WebBrowser browser = new WebBrowser(WebDriver.Current);
            browser.Load(new PageLocation("Test Html Page", path));
            // there should be a section under the area name that displays feature statistics about the area
            await browser.WaitTillVisible(AreaFeatureStats.Section(3));
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
        }
    }
}
