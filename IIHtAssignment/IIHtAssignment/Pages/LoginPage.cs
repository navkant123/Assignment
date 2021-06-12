

using OpenQA.Selenium;


namespace IIHtAssignment.Steps 
{
    class LoginPage : DriverHelper
    {
        

        IWebElement txtUserName = Driver.FindElement(By.Id("username"));

        IWebElement txtPassword = Driver.FindElement(By.Id("text"));
        IWebElement btnLogin => Driver.FindElement(By.ClassName("btnTextAlignment"));


        public void EnterUserNameAndPassword(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }
        public bool IsLogOffExist() => btnLogin.Displayed;
    }
}

