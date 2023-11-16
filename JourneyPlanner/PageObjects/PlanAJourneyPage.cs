using JourneyPlanner.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;

namespace JourneyPlanner.PageObjects
{    
    public class PlanAJourneyPage
    {
       public IWebDriver driver;
        public PlanAJourneyPage()
        {
            driver = BaseTest.driver;
        }


        private By cookies = By.Id("CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll");
        private By fromALocation = By.Id("InputFrom");
        private By toALocation = By.XPath("//*[@id=\"InputTo\"]");
        private By changeTimeLink = By.XPath("//a[@class='change-departure-time']");
        private By leavingTabIsEnabled = By.XPath("//label[@for='departing']    ");
        private By leavingDate = By.CssSelector("select[id ='Date']");
        private By leavingTime = By.CssSelector("select[id='Time']");
        private By planMyJourney = By.CssSelector("input[id='plan-journey-button']");
        private By journeyResult = By.XPath("//span[@class='jp-results-headline']");
        private By quieterTimesMessageDisplayed = By.CssSelector(".journey-busy-stations-information");
        private By errorMessageDisplayed = By.XPath("//li[@class='field-validation-error']"); 
        private By fromFieldsError= By.Id("InputFrom-error");
        private By toFieldsError = By.Id("InputTo-error");
        private By arrivingTab = By.CssSelector("label[for='arriving']");
        private By arrivingDate = By.Id("Date");
        private By arrivingTime = By.Id("Time");
        private By clearIconFromLocation= By.CssSelector("[class='remove-content hide-text'[2]]");
        private By clearIconToLocation = By.CssSelector("\"[class='remove-content hide-text'[3]]\"");
        private By editJourney = By.XPath("//span[text()='Edit journey']");
        private By updateJourney = By.XPath("//input[@id='plan-journey-button']");
        private By recentsTab = By.CssSelector("#jp-recent-tab-home");
        private By recentlyPlannedJourneys= By.XPath("//li[@id][3]");
        private By home = By.XPath("//span[text()='Home']");
        private By newTab = By.CssSelector("#jp-new-tab-home > a");
        private By planAJourney = By.Id("plan-journey-button");
        
        
        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void RefreshPage()
        {
            driver.Navigate().Refresh();
        }
        public void NavigateToPrviousPage()
        {
            driver.Navigate().GoToUrl("https://tfl.gov.uk");
            
        }

        public void Cookies()
        {
            driver.FindElement(cookies).Click();
        }
        public void FromALocation(string fromtxt)
        {
            driver.FindElement(fromALocation).SendKeys(fromtxt);
        }
        public void ToALocation(string totxt)
        {
            driver.FindElement(toALocation).SendKeys(totxt);
        }
        public void ChangeTimeLink()
        {
            driver.FindElement(changeTimeLink).Click();
        }
        public bool LeavingTabIsEnabled()
        {
            return driver.FindElement(leavingTabIsEnabled).Enabled;
        }

        public void LeavingDate()
        {
            SelectElement select = new SelectElement(driver.FindElement(leavingDate));
            select.SelectByValue("20231123");
        }
        public void LeavingTime()
        {
            SelectElement select = new SelectElement(driver.FindElement(leavingTime));
            select.SelectByValue("1100");
        }
        public void PlanMyJourney()
        {
           driver.FindElement(planMyJourney).Click();
        }
        public bool JourneyResultIsDisplayed()
        {
            //Task.Delay(5000).Wait();
            return driver.FindElement(journeyResult).Displayed;
        }

        public bool ErrorMessageDisplayed()
        {
            return driver.FindElement(errorMessageDisplayed).Displayed;
        }

        public bool QuieterTimesMessagesDisplayed()
        {
            return driver.FindElement(quieterTimesMessageDisplayed).Displayed;
        }

       public bool FromFAndToFieldError(string from, string to)
        {
            return driver.FindElement(fromFieldsError).Displayed;
            return driver.FindElement(toFieldsError).Displayed;
        }
        public bool ArrivingTab()
        {
            return driver.FindElement(arrivingTab).Enabled;
        }

       public void ArrivingDate()
        {
            SelectElement select = new SelectElement(driver.FindElement(arrivingDate));
            select.SelectByValue("20231123");
        }
        public void ArrivingTime()
        {
            SelectElement select = new SelectElement(driver.FindElement(arrivingTime));
            select.SelectByValue("1100");
        }
        public void ClearIconFromLocation()
        {
            driver.FindElement(clearIconFromLocation).Click();
        }
        public void ClearIconToLocation()
        {
            driver.FindElement(clearIconToLocation).Click();
        }
        public void EditJourney()
        {
            driver.FindElement(editJourney).Click();
        }
        public void UpdateJourney()
        {
            driver.FindElement(updateJourney).Click();
        }
        public void RecentsTab() 
        {
           
            driver.FindElement(recentsTab).Click();            
        }

        public bool RecentlyPlannedJourney()
        {
           
            return driver.FindElement(recentlyPlannedJourneys).Displayed;
           
        }
           
        public void Home()
        {
            driver.FindElement(home).Click();
            driver.Navigate().Refresh();
            
        }

        public void NewTab()
        {
            driver.FindElement(newTab).Click();
        }
        public bool IsPlanAJourneyDisplayed()
        {
            return driver.FindElement(planAJourney).Displayed;
        }


        public void setCoookies(string name, string value)
        {
            Cookie cookie = new Cookie("tfl", "journey");
            driver.Manage().Cookies.AddCookie(cookie);
          
            
        }
        
    }
}
