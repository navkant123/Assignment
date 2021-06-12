using IIHtAssignment.Steps;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace IIHtAssignment.Hooks
{
    [Binding]
    public sealed class Hooks1 : DriverHelper
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions option = new ChromeOptions();
                    option.AddArguments("--headless");
                      new DriverManager().SetUpDriver(new ChromeConfig());
                      Console.WriteLine("Setup");
                    Driver = new ChromeDriver(option);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            Driver.Quit();
        }
    }
}
