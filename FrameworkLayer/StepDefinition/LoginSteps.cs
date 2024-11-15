using TechTalk.SpecFlow;

[Binding]
public class LoginSteps
{
    [Given(@"I navigate to the login page")]
    public void GivenINavigateToTheLoginPage()
    {
        // Navigate to login page
    }

    [When(@"I login with username '(.*)' and password '(.*)'")]
    public void WhenILoginWithUsernameAndPassword(string username, string password)
    {
        // Enter username and password and submit form
    }

    [Then(@"the login '(.*)' be successful")]
    public void ThenTheLoginBeSuccessful(string result)
    {
        // Validate login result
    }
}