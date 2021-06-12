using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace IIHtAssignment.Steps
{
    [Binding]
    public class LogInFeatureSteps : DriverHelper
    {

        

        [Given(@"I Navigate to application")]
        public void GivenINavigateToApplication()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.airasia.com/en/home.page");
            Driver.Manage().Window.Maximize();
           // Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [Given(@"I click on the login link")]
        public void GivenIClickOnTheLoginLink()
        {

            HomePage homepage = new HomePage();
            homepage.ClickLogin();
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            LoginPage loginpage = new LoginPage();
            dynamic data = table.CreateDynamicInstance();
            loginpage.EnterUserNameAndPassword(data.userName, data.passWord);
        }

        [Given(@"I click on siginin button")]
        public void GivenIClickOnSigininButton()
        {
            LoginPage loginpage = new LoginPage();
            loginpage.ClickLogin();
        }

        [Then(@"Verify that error message displayed on screen")]
        public void ThenVerifyThatErrorMessageDisplayedOnScreen()
        {
            LoginPage loginpage = new LoginPage();
            Assert.That(loginpage.IsLogOffExist(), Is.True, "Either username / password is incorrect, Please try again");
        }
    }
}