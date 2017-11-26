# SlowSeleniumTest
Contains an .Net Core MSTest project that has a slow running unit test that uses Selenium WebDriver and PhantomJS.

You will need the latest version of dotnet installed.

Run the following commands to see the performance:
1. dotnet build
2. dotnet test -v n --no-build --no-restore

Below are the times running the test on Windows 10.

# Windows 10 Results

## Validate Areas 

<table><tr><th>Milliseconds</th><th>Code</th></tr>
 <tr><td>3045</td><td>webDriver = new PhantomJSDriver();</td></tr>
 <tr><td>1644</td><td>driver.Url = location.Url;</td></tr>
 <tr><td>1045</td><td>wait.Until(driver => driver.FindElement(By.Id(id))); area-3-feature-stats</td></tr>
 <tr><td>1034</td><td>wait.Until(driver => driver.FindElement(By.CssSelector(element.Selector))); #area-3 span.badge.total</td></tr>
 <tr><td>1018</td><td>driver.FindElement(By.CssSelector(selector)); #area-3 span.badge.total</td></tr>
 <tr><td>1019</td><td>driver.FindElement(By.CssSelector(selector)); #area-3 span.badge.total</td></tr>
 <tr><td>1036</td><td>webElement.GetAttribute("title");</td></tr>
 <tr><td>1045</td><td>driver.FindElement(By.CssSelector(selector)); #area-3-feature-stats td.passed</td></tr>
 <tr><td>1035</td><td>driver.FindElement(By.CssSelector(selector)); #area-3-feature-stats td.skipped</td></tr>
 <tr><td>1033</td><td>driver.FindElement(By.CssSelector(selector)); #area-3-feature-stats td.failed</td></tr>
 <tr><td>1035</td><td>wait.Until(driver => driver.FindElement(By.CssSelector(element.Selector))); #area-3-feature-stats td.outcome-bar-chart</td></tr>
 <tr><td>1035</td><td>driver.FindElement(By.CssSelector(selector)); #area-3-feature-stats td.passed-bar</td></tr>
 <tr><td>1034</td><td>driver.FindElement(By.CssSelector(selector)); #area-3-feature-stats td.skipped-bar</td></tr>
 <tr><td>1037</td><td>driver.FindElement(By.CssSelector(selector)); #area-3-feature-stats td.failed-bar</td></tr>
 </table>

## Validate Areas Simple 

 <table><tr><th>Milliseconds</th><th>Code</th></tr>
 <tr><td>1021</td><td>driver.Url = location.Url;</td></tr>
 <tr><td>1020</td><td>wait.Until(driver => driver.FindElement(By.Id(id))); area-3-feature-stats</td></tr>
 </table>

 Below are the times for running the tests on a mac.
 
 # Mac Results