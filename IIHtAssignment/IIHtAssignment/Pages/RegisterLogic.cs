using IIHtAssignment.Steps;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace IIHtAssignment.Pages
{
    class RegisterLogic : DriverHelper
    {
        IWebElement registerLink = Driver.FindElement(By.XPath("//*[text()='REGISTER']"));
        public void clickOnRegister() => registerLink.Click();


        IWebElement firstName = Driver.FindElement(By.XPath("//input[@name='firstName']"));
        IWebElement lastName = Driver.FindElement(By.XPath("//input[@name='lastName']"));
        IWebElement PhoneNumber = Driver.FindElement(By.XPath("//input[@name='phone']"));
        IWebElement EmailId = Driver.FindElement(By.Id("userName"));
        IWebElement address = Driver.FindElement(By.XPath("//input[@name='address1']"));
        IWebElement city = Driver.FindElement(By.XPath("//input[@name='city']"));
        IWebElement state = Driver.FindElement(By.XPath("//input[@name='state']"));
        IWebElement postalCode = Driver.FindElement(By.XPath("//input[@name='postalCode']"));
        public void EnterUserDetails(string FirstName, string LastName, string Phone, string Email, string Address, string City, string State, string PostalCode)
        {
            firstName.SendKeys(FirstName);
            lastName.SendKeys(LastName);
            PhoneNumber.SendKeys(Phone);
            EmailId.SendKeys(Email);
            address.SendKeys(Address);
            city.SendKeys(City);
            state.SendKeys(State);
            postalCode.SendKeys(PostalCode);
        }

        IWebElement selctContry=Driver.FindElement(By.XPath("//*[@name='country'][1]"));
        public void selectCountryFromDropDown() => selctContry.Click();

        IWebElement SelectUserName = Driver.FindElement(By.Id("email"));
        IWebElement SelectPassWord =Driver.FindElement(By.Name("password"));
        IWebElement SelectConformPassWord = Driver.FindElement(By.Name("confirmPassword"));

        public void EneterSecondDetails(String UserName, String PassWord, String ConformPassWord)
        {
            SelectUserName.SendKeys(UserName);
            SelectPassWord.SendKeys(PassWord);
            SelectConformPassWord.SendKeys(ConformPassWord);
        }


        IWebElement SubmitButton = Driver.FindElement(By.Name("submit"));
        public void clickOnSubmit() => SubmitButton.Click();


    }
}
