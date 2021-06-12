using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace IIHtAssignment.Steps
{
    [Binding]
    public class SearchFlightSteps : DriverHelper
    {
        [Given(@"Navigate to the site URL")]
        public void GivenNavigateToTheSiteURL()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.airasia.com/en/home.page");
            Driver.Manage().Window.Maximize();

        }

        [When(@"Verify the title")]
        public void WhenVerifyTheTitle()
        {
            String ActualTitle = Driver.Title;
            if (ActualTitle.Equals("AirAsia India - Book Your Flights and Explore India")) ;
            Console.WriteLine("Title Verified");
        }
        [When(@"enter origin as ""(.*)""")]
        public void WhenEnterOriginAs(string Bengaluru)
        {
           // IWebElement OriginValue = Driver.FindElement(By.XPath("//*[@class='source-code-desktop']"));
       //  OriginValue.Click();
         // OriginValue.SendKeys(Bengaluru);

           // IWebElement PassValue = Driver.FindElement(By.XPath("//*[@class='recent-list-items list-group']"));
           // PassValue.Click();
        }

        [When(@"enter  destination as ""(.*)""")]
        public void WhenEnterDestinationAs(string Pune)
        {

           // IWebElement destination = Driver.FindElement(By.XPath("//*[@id='list - item']"));
           //destination.Click();
        }


       
        [When(@"select the depart date as ""(.*)""")]
        public void WhenSelectTheDepartDateAs(string date)
        {
         //  IWebElement departDate = Driver.FindElement(By.XPath("//*[@id='flight - tab']/div[3]/img"));
           // departDate.Click();

        }
        
        [Then(@"Verify the flight page")]
        public void ThenVerifyTheFlightPage()
        {
            Console.WriteLine("We are on FlightPage");
        }
    }
}
