# SlowSeleniumTest
Contains an .Net Core MSTest project that has a slow running unit test that uses Selenium WebDriver and PhantomJS.

You will need the latest version of dotnet installed.

Run the following commands to see the performance:
1. dotnet build
2. dotnet test -v n --no-build --no-restore

<table>
<th>Time</th><th>Description</th><th>Milliseconds</th><th>Duration (ms)</th>
<tr><td>09:56:29.296</td><td>webDriver = new PhantomJSDriver(".\"); Start</td><td>35789296</td><td>0</td></tr>
<tr><td>09:56:31.987</td><td>webDriver = new PhantomJSDriver(".\"); End</td><td>35791987</td><td>2691</td></tr>
<tr><td>09:56:31.987</td><td>driver.Url = location.Url; Start file:///C:\Users\stearm01\Source\SeleniumPerformanceTest\bin\Debug\netcoreapp2.0\TestPage.html</td><td>35791987</td><td>0</td></tr>
<tr><td>09:56:33.351</td><td>driver.Url = location.Url; End</td><td>35793351</td><td>1364</td></tr>
<tr><td>09:56:33.354</td><td>WaitTillVisible Start #area-3-feature-stats</td><td>35793354</td><td>3</td></tr>
<tr><td>09:56:33.355</td><td>driver.FindElement(By.CssSelector(element.Selector)); Start #area-3-feature-stats</td><td>35793355</td><td>1</td></tr>
<tr><td>09:56:34.379</td><td>driver.FindElement(By.CssSelector(element.Selector)); End</td><td>35794379</td><td>1024</td></tr>
<tr><td>09:56:34.379</td><td> webElement.Displayed Start #area-3-feature-stats</td><td>35794379</td><td>0</td></tr>
<tr><td>09:56:35.399</td><td> webElement.Displayed End</td><td>35795399</td><td>1020</td></tr>
<tr><td>09:56:35.399</td><td>Pass Count = 1</td><td>35795399</td><td>0</td></tr>
<tr><td>09:56:35.399</td><td>WaitTillVisible End</td><td>35795399</td><td>0</td></tr>
<tr><td>09:56:35.399</td><td>WaitTillVisible Start #area-3 span.badge.total</td><td>35795399</td><td>0</td></tr>
<tr><td>09:56:35.399</td><td>driver.FindElement(By.CssSelector(element.Selector)); Start #area-3 span.badge.total</td><td>35795399</td><td>0</td></tr>
<tr><td>09:56:36.439</td><td>driver.FindElement(By.CssSelector(element.Selector)); End</td><td>35796439</td><td>1040</td></tr>
<tr><td>09:56:36.439</td><td> webElement.Displayed Start #area-3 span.badge.total</td><td>35796439</td><td>0</td></tr>
<tr><td>09:56:37.457</td><td> webElement.Displayed End</td><td>35797457</td><td>1018</td></tr>
<tr><td>09:56:37.457</td><td>Pass Count = 1</td><td>35797457</td><td>0</td></tr>
<tr><td>09:56:37.457</td><td>WaitTillVisible End</td><td>35797457</td><td>0</td></tr>
<tr><td>09:56:37.458</td><td>ElementHasText Start</td><td>35797458</td><td>1</td></tr>
<tr><td>09:56:37.458</td><td>driver.FindElement(By.CssSelector(element.Selector)); Start #area-3 span.badge.total</td><td>35797458</td><td>0</td></tr>
<tr><td>09:56:38.473</td><td>driver.FindElement(By.CssSelector(element.Selector)); End</td><td>35798473</td><td>1015</td></tr>
<tr><td>09:56:39.503</td><td>ElementHasText End</td><td>35799503</td><td>1030</td></tr>
<tr><td>09:56:39.504</td><td>ElementHasTitle Start #area-3 span.badge.total</td><td>35799504</td><td>1</td></tr>
<tr><td>09:56:39.504</td><td>driver.FindElement(By.CssSelector(element.Selector)); Start #area-3 span.badge.total</td><td>35799504</td><td>0</td></tr>
<tr><td>09:56:40.513</td><td>driver.FindElement(By.CssSelector(element.Selector)); End</td><td>35800513</td><td>1009</td></tr>
<tr><td>09:56:41.530</td><td>ElementHasTitle End</td><td>35801530</td><td>1017</td></tr>
<tr><td>09:56:41.530</td><td>ElementHasText Start</td><td>35801530</td><td>0</td></tr>
<tr><td>09:56:41.530</td><td>driver.FindElement(By.CssSelector(element.Selector)); Start #area-3-feature-stats td.passed</td><td>35801530</td><td>0</td></tr>
<tr><td>09:56:42.547</td><td>driver.FindElement(By.CssSelector(element.Selector)); End</td><td>35802547</td><td>1017</td></tr>
<tr><td>09:56:43.573</td><td>ElementHasText End</td><td>35803573</td><td>1026</td></tr>
<tr><td>09:56:43.573</td><td>ElementHasText Start</td><td>35803573</td><td>0</td></tr>
<tr><td>09:56:43.573</td><td>driver.FindElement(By.CssSelector(element.Selector)); Start #area-3-feature-stats td.skipped</td><td>35803573</td><td>0</td></tr>
<tr><td>09:56:44.591</td><td>driver.FindElement(By.CssSelector(element.Selector)); End</td><td>35804591</td><td>1018</td></tr>
<tr><td>09:56:45.628</td><td>ElementHasText End</td><td>35805628</td><td>1037</td></tr>
<tr><td>09:56:45.628</td><td>ElementHasText Start</td><td>35805628</td><td>0</td></tr>
<tr><td>09:56:45.628</td><td>driver.FindElement(By.CssSelector(element.Selector)); Start #area-3-feature-stats td.failed</td><td>35805628</td><td>0</td></tr>
<tr><td>09:56:46.642</td><td>driver.FindElement(By.CssSelector(element.Selector)); End</td><td>35806642</td><td>1014</td></tr>
<tr><td>09:56:47.673</td><td>ElementHasText End</td><td>35807673</td><td>1031</td></tr>
<tr><td>09:56:47.673</td><td>WaitTillVisible Start #area-3-feature-stats td.outcome-bar-chart</td><td>35807673</td><td>0</td></tr>
<tr><td>09:56:47.673</td><td>driver.FindElement(By.CssSelector(element.Selector)); Start #area-3-feature-stats td.outcome-bar-chart</td><td>35807673</td><td>0</td></tr>
<tr><td>09:56:48.688</td><td>driver.FindElement(By.CssSelector(element.Selector)); End</td><td>35808688</td><td>1015</td></tr>
<tr><td>09:56:48.688</td><td> webElement.Displayed Start #area-3-feature-stats td.outcome-bar-chart</td><td>35808688</td><td>0</td></tr>
<tr><td>09:56:49.706</td><td> webElement.Displayed End</td><td>35809706</td><td>1018</td></tr>
<tr><td>09:56:49.707</td><td>Pass Count = 1</td><td>35809707</td><td>1</td></tr>
<tr><td>09:56:49.707</td><td>WaitTillVisible End</td><td>35809707</td><td>0</td></tr>
<tr><td>09:56:49.708</td><td>ElementStyleMatches Start #area-3-feature-stats td.passed-bar</td><td>35809708</td><td>1</td></tr>
<tr><td>09:56:49.708</td><td>driver.FindElement(By.CssSelector(element.Selector)); Start #area-3-feature-stats td.passed-bar</td><td>35809708</td><td>0</td></tr>
<tr><td>09:56:50.723</td><td>driver.FindElement(By.CssSelector(element.Selector)); End</td><td>35810723</td><td>1015</td></tr>
<tr><td>09:56:51.744</td><td>ElementStyleMatches End</td><td>35811744</td><td>1021</td></tr>
<tr><td>09:56:51.744</td><td>ElementStyleMatches Start #area-3-feature-stats td.skipped-bar</td><td>35811744</td><td>0</td></tr>
<tr><td>09:56:51.744</td><td>driver.FindElement(By.CssSelector(element.Selector)); Start #area-3-feature-stats td.skipped-bar</td><td>35811744</td><td>0</td></tr>
<tr><td>09:56:52.767</td><td>driver.FindElement(By.CssSelector(element.Selector)); End</td><td>35812767</td><td>1023</td></tr>
<tr><td>09:56:53.784</td><td>ElementStyleMatches End</td><td>35813784</td><td>1017</td></tr>
<tr><td>09:56:53.785</td><td>ElementStyleMatches Start #area-3-feature-stats td.failed-bar</td><td>35813785</td><td>1</td></tr>
<tr><td>09:56:53.785</td><td>driver.FindElement(By.CssSelector(element.Selector)); Start #area-3-feature-stats td.failed-bar</td><td>35813785</td><td>0</td></tr>
<tr><td>09:56:54.800</td><td>driver.FindElement(By.CssSelector(element.Selector)); End</td><td>35814800</td><td>1015</td></tr>
<tr><td>09:56:55.814</td><td>ElementStyleMatches End</td><td>35815814</td><td>1014</td></tr>

</table>