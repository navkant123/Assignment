using IIHtAssignment.Steps;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace IIHtAssignment.Pages
{
    class LastScenario : DriverHelper
    {
        IWebElement sigIn = Driver.FindElement(By.XPath("//*[@title='Log in to your customer account']"));
        public void ClickOnSiginButton() => sigIn.Click();


     /*   IWebElement sendEmailAddress = Driver.FindElement(By.XPath("//*[@id='email_create']"));

        public void EnterEmailAddress(String Email)
        {
            sendEmailAddress.SendKeys(Email);
        }*/
    }
}
