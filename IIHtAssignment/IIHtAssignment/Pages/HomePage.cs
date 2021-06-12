
using OpenQA.Selenium;
using System;

namespace IIHtAssignment.Steps
{

    class HomePage : DriverHelper
    {

        IWebElement lnkLogin = Driver.FindElement(By.XPath("//*[text() = 'Partner Login' ]"));
        public void ClickLogin() => lnkLogin.Click();
       
     /*   public void ClickOrigin(String OriginCity)
        {
           
        }
     */
        
       // IWebElement DestinationValue = Driver.FindElement(By.XPath("//*[@class='source-code-desktop'][1]"));
      // public void Destination() => DestinationValue.Click();
       
    }
}