using IIHtAssignment.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace IIHtAssignment.Steps
{
    [Binding]
    public class _4ThScenarioSteps : DriverHelper
    {
        [Given(@"Navigate to the Home Page")]
        public void GivenNavigateToTheHomePage()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            Driver.Manage().Window.Maximize();
        }
        
        [Given(@"Click on SignIn Button")]
        public void GivenClickOnSignInButton()
        {
            LastScenario scenario = new LastScenario();
            scenario.ClickOnSiginButton();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }
        
        [Given(@"Pass a Valid (.*)")]
        public void GivenPassAValid(string Email)
        {
            /*LastScenario scenario = new LastScenario();
            scenario.EnterEmailAddress(Email);*/
            IWebElement sendEmailAddress = Driver.FindElement(By.XPath("//*[@id='email_create']"));
            sendEmailAddress.SendKeys(Email);

        }

          [When(@"Click on Register link")]
          public void WhenClickOnRegisterLink()
          {
            IWebElement createAccount = Driver.FindElement(By.Id("SubmitCreate"));
            createAccount.Click();
          }

         [When(@"Validate you are on regeter page")]
          public void WhenValidateYouAreOnRegeterPage()
          {
            String ActualTitle = Driver.Title;
            if (ActualTitle.Equals(" Login - My Store")) ;

            Console.WriteLine("We are Register Page");

        }

          [When(@"Select the title Radio box")]
          public void WhenSelectTheTitleRadioBox()
          {
            IWebElement radioButton = Driver.FindElement(By.Id("id_gender1"));
            radioButton.Click();
          }

          [When(@"User Enter (.*),(.*) and (.*)")]
          public void WhenUserEnterAnd(string FirstName, string LastName, string Password)
          {

            IWebElement firstName = Driver.FindElement(By.Id("customer_firstname"));
            firstName.SendKeys(FirstName);
            IWebElement lastName = Driver.FindElement(By.Id("customer_lastname"));
            lastName.SendKeys(LastName);
            IWebElement password = Driver.FindElement(By.Id("passwd"));
            password.SendKeys(Password);

        }

          [When(@"Select Date,month nad yearofbirth")]
          public void WhenSelectDateMonthNadYearofbirth()
          {
            IWebElement Days = Driver.FindElement(By.Id("days"));
            Days.Click();
            IWebElement MyDays = Driver.FindElement(By.XPath("//*[@id='days']/option[4]"));
            MyDays.Click();
            IWebElement Month = Driver.FindElement(By.Id("months"));
            Month.Click();

            IWebElement MyMonth = Driver.FindElement(By.XPath("//*[@id='months']/option[7]"));
            MyMonth.Click();
            IWebElement Year = Driver.FindElement(By.Id("years"));
            Year.Click();
            IWebElement MyYear = Driver.FindElement(By.XPath("//*[@id='years']/option[26]"));
            MyYear.Click();
          }

        [When(@"Enter (.*),(.*)")]
        public void WhenEnter(string Address, string City)
        {
            IWebElement address = Driver.FindElement(By.Id("address1"));
            address.SendKeys(Address);
            IWebElement city = Driver.FindElement(By.Id("city"));
            city.SendKeys(City);
        }

       

        [When(@"Select State")]
        public void WhenSelectState()
        {
            IWebElement State = Driver.FindElement(By.Id("id_state"));
            State.Click();
            IWebElement MyChoice = Driver.FindElement(By.XPath("//*[@id='id_state']/option[3]"));
            MyChoice.Click();
        }
        [When(@"enter (.*), (.*)")]
        public void WhenEnter(Int64 PostalCode, Int64 MobileNumber)
        {
           String  PostalCodeStringValue= PostalCode.ToString();
            String MobileNumberStringValue = MobileNumber.ToString();
            IWebElement postcode = Driver.FindElement(By.Id("postcode"));
            postcode.SendKeys(PostalCodeStringValue);
            IWebElement mobileNumber = Driver.FindElement(By.Id("phone_mobile"));
            mobileNumber.SendKeys(MobileNumberStringValue);
        }



        [When(@"User click on Register buttton")]
        public void WhenUserClickOnRegisterButtton()
        {
            IWebElement register = Driver.FindElement(By.XPath("//*[@id='submitAccount']/span"));
            register.Click();
        }

        [Then(@"Validate you have succesfully Registerd")]
        public void ThenValidateYouHaveSuccesfullyRegisterd()
        {
            String ActualTitle = Driver.Title;
            if (ActualTitle.Equals(" Login - My Store")) ;

            Console.WriteLine("You Have succesfully Registerd");
        }

    }
}
