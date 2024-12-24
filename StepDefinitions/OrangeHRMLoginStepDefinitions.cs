using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class OrangeHRMLoginStepDefinitions
    {
        [When(@"User enters the ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersTheAnd(string usrname, string passwd)
        {
            Console.WriteLine("The username is " +usrname + "....."+" The password is "+passwd);
        }

        [When(@"User clicks on login button")]
        public void WhenUserClicksOnLoginButton()
        {
            Console.WriteLine("User clicked on login button");
        }

        [Then(@"user is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            Console.WriteLine("User is on the home page");
        }

        [Then(@"User selects city and country information")]
        public void ThenUserSelectsCityAndCountryInformation(Table table)
        {
            foreach (var row in table.Rows)
            {
                string city = row["city"];
                string country = row["country"];
                Console.WriteLine(city + " , " + country);
            }
        }
    }
}
