public class UtilityMethods
{
    public void EnterText(IWebDriver driver, By locator, string text)
    {
        driver.FindElement(locator).SendKeys(text);
    }

    public void ClickButton(IWebDriver driver, By locator)
    {
        driver.FindElement(locator).Click();
    }

    public string GetElementText(IWebDriver driver, By locator)
    {
        return driver.FindElement(locator).Text;
    }

    public void WaitForPageLoad(IWebDriver driver)
    {
        new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
    }
}