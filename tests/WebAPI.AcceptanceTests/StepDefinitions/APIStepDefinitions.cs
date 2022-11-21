using System;
using TechTalk.SpecFlow;

namespace CleanArchitectureBDD.WebUI.AcceptanceTests.StepDefinitions
{
    [Binding]
    public class APIStepDefinitions
    {
        [When(@"I enter the shop")]
        public void WhenIEnterTheShop()
        {
            throw new PendingStepException();
        }
    }
}
