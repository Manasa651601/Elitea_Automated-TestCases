public class Actions
{
    private readonly IWebDriver _webDriver;

    public Actions(IWebDriver webDriver)
    {
        _webDriver = webDriver;
    }

    public void EnterCredentials(string username, string password)
    {
        _webDriver.FindElement(Locators.UsernameField).SendKeys(username);
        _webDriver.FindElement(Locators.PasswordField).SendKeys(password);
    }

    public void ClickLoginButton()
    {
        _webDriver.FindElement(Locators.LoginButton).Click();
    }

    public string GetErrorMessage()
    {
        return _webDriver.FindElement(Locators.ErrorMessage).Text;
    }
}