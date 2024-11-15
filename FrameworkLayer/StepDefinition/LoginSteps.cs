using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using PageObjectsLayer;
using UtilityLayer;

namespace FrameworkLayer.StepDefinition
{
    [Binding]
    public class LoginSteps
    {
        private IWebDriver _driver;
        private LoginPage _loginPage;

        public LoginSteps(IWebDriver driver)
        {
            _driver = driver;
            _loginPage = new LoginPage(_driver);
        }

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When(@"I enter username as '(.*)' and password as '(.*)'")]
        public void WhenIEnterUsernameAsAndPasswordAs(string username, string password)
        {
            _loginPage.EnterUsername(username);
            _loginPage.EnterPassword(password);
        }

        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            _loginPage.ClickLoginButton();
        }

        [Then(@"I should be logged in successfully")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {
            Assert.IsTrue(_loginPage.IsLoggedInSuccessfully());
        }

        [Then(@"I should see the error message '(.*)'")]
        public void ThenIShouldSeeTheErrorMessage(string expectedErrorMessage)
        {
            string actualErrorMessage = _loginPage.GetErrorMessage();
            Assert.AreEqual(expectedErrorMessage, actualErrorMessage);
        }
    }
}
