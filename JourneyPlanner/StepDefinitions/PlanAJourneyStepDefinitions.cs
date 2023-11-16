using JourneyPlanner.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using TechTalk.SpecFlow;

namespace JourneyPlanner.StepDefinitions
{
    [Binding]
    public class PlanAJourneyStepDefinitions
    {
        PlanAJourneyPage planAJourneyPage = new PlanAJourneyPage();

        [Given(@"I navigate to Tfl website ""([^""]*)""")]
        public void GivenINavigateToTflWebsite(string url)
        {
            planAJourneyPage.Navigate(url);
        }

        [When(@"I click on cookies button")]
        public void WhenIClickOnCookiesButton()
        {
            planAJourneyPage.Cookies();
        }
        

        [Then(@"plan a journey page is displayed")]
        public void ThenPlanAJourneyPageIsDisplayed()
        {
            Assert.IsTrue(planAJourneyPage.IsPlanAJourneyDisplayed());
        }

        [When(@"I enter from a location ""([^""]*)""")]
        public void WhenIEnterFromALocation(string fromtxt)
        {
            planAJourneyPage.FromALocation(fromtxt);
        }

        [When(@"I enter to a location ""([^""]*)""")]
        public void WhenIEnterToALocation(string totxt)
        {
            planAJourneyPage.ToALocation(totxt);
        }

        [When(@"I click change time link")]
        public void WhenIClickChangeTimeLink()
        {
            planAJourneyPage.ChangeTimeLink();
        }
        [Then(@"I verify that leaving tab is enabled")]
        public void ThenIVerifyThatLeavingTabIsEnabled()
        {
            Assert.IsTrue(planAJourneyPage.LeavingTabIsEnabled());
        }

        
        [When(@"I select leaving date")]
        public void WhenISelectLeavingDate()
        {
            planAJourneyPage.LeavingDate();
        }

        [When(@"I select leaving time")]
        public void WhenISelectLeavingTime()
        {
           planAJourneyPage.LeavingTime();
        }

        [When(@"I click plan my journey")]
        public void WhenIClickPlanMyJourney()
        {
            planAJourneyPage.PlanMyJourney();
        }

       
        [Then(@"""([^""]*)"" and ""([^""]*)"" messages displayed")]
        public void ThenAndMessagesDisplayed(string fromFieldError, string toFieldError)
        {
            Assert.IsTrue(planAJourneyPage.FromFAndToFieldError(fromFieldError, toFieldError));
        }


        [Then(@"journey results is displayed")]
        public void ThenJourneyResultsIsDisplayed()
        {
            Assert.IsTrue(planAJourneyPage.JourneyResultIsDisplayed());
        }

        [Then(@"quieter Times Message Displayed")]
        public void ThenQuieterTimesMessageDIsplayed()
        {
            Assert.IsTrue(planAJourneyPage.QuieterTimesMessagesDisplayed());
        }


        [When(@"I click on home")]
        public void WhenIClickOnHome()
        {
            planAJourneyPage.Home();
        }

        [When(@"I click on New tab")]
        public void WhenIClickOnNewTab()
        {
            planAJourneyPage.NewTab();
        }

        [Then(@"error ""([^""]*)"" will be displayed")]
        public void ThenErrorWillBeDisplayed(string messagetxt)
        {
            Assert.IsTrue(planAJourneyPage.ErrorMessageDisplayed(), messagetxt);
        }

        
        [Then(@"I verify that arriving tab is enabled")]
        public void ThenIVerifyThatArrivingTabIsEnabled()
        {
            Assert.IsTrue(planAJourneyPage.ArrivingTab());
        }

        [When(@"I select arriving date")]
        public void WhenISelectArrivingDate()
        {
            planAJourneyPage.ArrivingDate();
        }

        [When(@"I select arriving time")]
        public void WhenISelectArrivingTime()
        {
           planAJourneyPage.ArrivingTime();
        }
                     

        [When(@"I click edit journey")]
        public void WhenIClickEditJourney()
        {
           planAJourneyPage.EditJourney();
        }

        [When(@"I click update journey")]
        public void WhenIClickUpdateJourney()
        {
            planAJourneyPage.UpdateJourney();
        }

        
        [When(@"I click recents tab on the widget")]
        public void WhenIClickRecentsTabOnTheWidget()
        {
            
            planAJourneyPage.RecentsTab();
           
        }

        [Then(@"a list of recently planned journeys displayed")]
        public void ThenAListOfRecentlyPlannedJourneysDisplayed()
        {
            Assert.IsTrue(planAJourneyPage.RecentlyPlannedJourney());
        }

        [When(@"I click arriving tab")]
        public void WhenIClickArrivingTab()
        {
            Thread.Sleep(10000);
            planAJourneyPage.ArrivingTab();
        }

        
        [Then(@"Journey results dispplayed")]
        public void ThenJourneyResultsDispplayed()
        {
            Assert.IsTrue(planAJourneyPage.JourneyResultIsDisplayed());
        }


        


    }
}
