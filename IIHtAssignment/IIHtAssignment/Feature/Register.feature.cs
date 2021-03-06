// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.8.0.0
//      SpecFlow Generator Version:3.8.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace IIHtAssignment.Feature
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.8.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Register")]
    public partial class RegisterFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Register.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Feature", "Register", "\tAsa user should be able to register with valid details", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Register User With Data")]
        [NUnit.Framework.CategoryAttribute("travel")]
        [NUnit.Framework.TestCaseAttribute("Navkant", "Yadav", "7808170913", "navkantraj1997@gmail.com", "Olipur", "Madhubani", "Bihar", "847403", "Navi0123", "Password@1234", "Password@1234", null)]
        [NUnit.Framework.TestCaseAttribute("Navi", "Kumar", "7808170913", "navkantraj1997@gmail.com", "Olipur", "Madhubani", "Bihar", "847403", "Navi0123", "Password@1234", "Password@1234", null)]
        [NUnit.Framework.TestCaseAttribute("Mounika", "Yadav", "7808170913", "navkantraj1997@gmail.com", "Olipur", "Madhubani", "Bihar", "847403", "Navi0123", "Password@1234", "Password@1234", null)]
        [NUnit.Framework.TestCaseAttribute("Rava", "Yadav", "7808170913", "navkantraj1997@gmail.com", "Olipur", "Madhubani", "Bihar", "847403", "Navi0123", "Password@1234", "Password@1234", null)]
        [NUnit.Framework.TestCaseAttribute("Aparna", "Yadav", "7808170913", "navkantraj1997@gmail.com", "Olipur", "Madhubani", "Bihar", "847403", "Navi0123", "Password@1234", "Password@1234", null)]
        [NUnit.Framework.TestCaseAttribute("Choubey", "Yadav", "7808170913", "navkantraj1997@gmail.com", "Olipur", "Madhubani", "Bihar", "847403", "Navi0123", "Password@1234", "Password@1234", null)]
        [NUnit.Framework.TestCaseAttribute("Nida", "Yadav", "7808170913", "navkantraj1997@gmail.com", "Olipur", "Madhubani", "Bihar", "847403", "Navi0123", "Password@1234", "Password@1234", null)]
        [NUnit.Framework.TestCaseAttribute("Affreen", "Yadav", "7808170913", "navkantraj1997@gmail.com", "Olipur", "Madhubani", "Bihar", "847403", "Navi0123", "Password@1234", "Password@1234", null)]
        [NUnit.Framework.TestCaseAttribute("Anil", "Yadav", "7808170913", "navkantraj1997@gmail.com", "Olipur", "Madhubani", "Bihar", "847403", "Navi0123", "Password@1234", "Password@1234", null)]
        [NUnit.Framework.TestCaseAttribute("Nav", "Yadav", "7808170913", "navkantraj1997@gmail.com", "Olipur", "Madhubani", "Bihar", "847403", "Navi0123", "Password@1234", "Password@1234", null)]
        public virtual void RegisterUserWithData(string firstName, string lastName, string phone, string email, string address, string city, string state, string postalCode, string userName, string passWord, string conformPassWord, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "travel"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("FirstName", firstName);
            argumentsOfScenario.Add("LastName", lastName);
            argumentsOfScenario.Add("Phone", phone);
            argumentsOfScenario.Add("Email", email);
            argumentsOfScenario.Add("Address", address);
            argumentsOfScenario.Add("City", city);
            argumentsOfScenario.Add("State", state);
            argumentsOfScenario.Add("PostalCode", postalCode);
            argumentsOfScenario.Add("UserName", userName);
            argumentsOfScenario.Add("PassWord", passWord);
            argumentsOfScenario.Add("ConformPassWord", conformPassWord);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Register User With Data", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
 testRunner.Given("Navigate to Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.And("Click on Register link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 8
 testRunner.When(string.Format("User enter {0},{1},{2},{3},{4},{5},{6},{7}", firstName, lastName, phone, email, address, city, state, postalCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.And("Select the country", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And(string.Format("enter {0},{1}", userName, passWord), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.Then("Click On submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
