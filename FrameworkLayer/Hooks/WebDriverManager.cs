using TechTalk.SpecFlow;

[Binding]
public class WebDriverManager
{
    private readonly IObjectContainer _objectContainer;
    private IWebDriver _webDriver;

    public WebDriverManager(IObjectContainer objectContainer)
    {
        _objectContainer = objectContainer;
    }

    [BeforeScenario]
    public void InitializeWebDriver()
    {
        _webDriver = new ChromeDriver();
        _objectContainer.RegisterInstanceAs(_webDriver);
    }

    [AfterScenario]
    public void TearDownWebDriver()
    {
        _webDriver.Quit();
    }
}