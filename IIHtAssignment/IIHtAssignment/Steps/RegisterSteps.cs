using IIHtAssignment.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace IIHtAssignment.Steps
{
    [Binding]
    public class RegisterSteps : DriverHelper
    {
      
        [Given(@"Navigate to Homepage")]
        public void GivenNavigateToHomepage()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("http://demo.guru99.com/test/newtours/");
            Driver.Manage().Window.Maximize();
        }
        
        [Given(@"Click on Register link")]
        public void GivenClickOnRegisterLink()
        {
            IWebElement registerLink = Driver.FindElement(By.XPath("//*[text()='REGISTER']"));
            registerLink.Click();
        }
        
        [When(@"User enter (.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*)")]
        public void WhenUserEnter(string FirstName, string LastName, Int64 Phone, string Email, string Address, string City, string State, Int64 PostalCode)
        {
           IWebElement firstName = Driver.FindElement(By.XPath("//input[@name='firstName']"));
            firstName.SendKeys(FirstName);
            IWebElement lastName = Driver.FindElement(By.XPath("//input[@name='lastName']"));
            lastName.SendKeys(LastName);
            IWebElement PhoneNumber = Driver.FindElement(By.XPath("//input[@name='phone']"));
            String PhoneNumberStringValue = Phone.ToString();
            PhoneNumber.SendKeys(PhoneNumberStringValue);
            IWebElement EmailId = Driver.FindElement(By.Id("userName"));
            EmailId.SendKeys(Email);
            IWebElement address = Driver.FindElement(By.XPath("//input[@name='address1']"));
            address.SendKeys(Address);
            IWebElement city = Driver.FindElement(By.XPath("//input[@name='city']"));
            city.SendKeys(City);
            IWebElement state = Driver.FindElement(By.XPath("//input[@name='state']"));
            state.SendKeys(State);
            IWebElement postalCode = Driver.FindElement(By.XPath("//input[@name='postalCode']"));
            String PostalCodeString=PostalCode.ToString();
            postalCode.SendKeys(PostalCodeString);







        }
        
        [When(@"Select the country")]
        public void WhenSelectTheCountry()
        {
            IWebElement selectContry = Driver.FindElement(By.XPath("//*[@name='country'][1]"));
               selectContry.Click();
        }

        [When(@"enter (.*),(.*)")]
        public void WhenEnter(string UserName, string PassWord)
        {
            IWebElement SelectUserName = Driver.FindElement(By.Id("email"));
            SelectUserName.SendKeys(UserName);
            IWebElement SelectPassWord = Driver.FindElement(By.Name("password"));
            SelectPassWord.SendKeys(PassWord);
            IWebElement SelectConformPassWord = Driver.FindElement(By.Name("confirmPassword"));
            SelectConformPassWord.SendKeys(PassWord);


        }


        [Then(@"Click On submit button")]
        public void ThenClickOnSubmitButton()
        {
            IWebElement SubmitButton = Driver.FindElement(By.Name("submit"));
            SubmitButton.Click();
        }
    }
}
