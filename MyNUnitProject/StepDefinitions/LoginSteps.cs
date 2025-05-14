using TechTalk.SpecFlow;

namespace MyNUnitProject.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"the user is on the login page")]
        public void GivenTheUserIsOnTheLoginPage()
        {
            Console.WriteLine("Navigating to login page...");
        }

        [When(@"the user enters valid credentials")]
        public void WhenTheUserEntersValidCredentials()
        {
            Console.WriteLine("Entering credentials...");
        }

        [Then(@"the user is redirected to the dashboard")]
        public void ThenTheUserIsRedirectedToTheDashboard()
        {
            Console.WriteLine("Checking dashboard...");
        }
    }
}
