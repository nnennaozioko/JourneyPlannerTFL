using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace JourneyPlanner.Hooks
{
    [Binding]
    public class BaseTest
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Cookies.AllCookies.Equals(true);
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Task.Delay(5000);
           driver.Quit();
           Kill("ChromeDriver");
        }
        public static void Kill(string processName)
        {
            try
            {
                Process[] runingProcesses = Process.GetProcesses();
                foreach (var process in runingProcesses)
                {
                    if (process.ProcessName.Contains(processName))
                    {
                        process.Kill();
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}



