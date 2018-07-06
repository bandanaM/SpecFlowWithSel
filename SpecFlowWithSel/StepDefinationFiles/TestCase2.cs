using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowWithSel.StepDefinationFiles
{
    [Binding]
    class TestCase2
    {
        private IWebDriver driver;
        public TestCase2(IWebDriver _driver)
        {
            driver = _driver;
        }
        [Given(@"I enter url on Browser")]
        public void GivenIEnterUrlInBrowser()
        {
            driver.Navigate().GoToUrl("http://myhcl.com");
        }

        [Then(@"I enter UserName on username field")]
        public void ThenIEnterUserNameInUsernameField(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            driver.FindElement(By.Id("txtUserID")).SendKeys((String)data.UserName);
        }

        [Then(@"I enter Password on password field")]
        public void ThenIEnterPasswordInPasswordField(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            driver.FindElement(By.Id("txtPassword")).SendKeys((String)data.Password);
        }

        [Then(@"I select Domain  from domain dropdown in myHcl login Page")]
        public void ThenISelectDomainFromDomainDropdownInMyHclLoginPage(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            SelectElement oselect = new SelectElement(driver.FindElement(By.Id("ddlDomain")));
            oselect.SelectByText((String)data.Domain);
        }

        [Then(@"Click Login button")]
        public void ThenClickSubmitButton()
        {
            driver.FindElement(By.Id("btnSubmit")).Click();
        }

        [Then(@"verify Login Error Message")]
        public void ThenVerifyLoginErrorMessage()
        {
            var element = driver.FindElement(By.Id("lblMsg"));
            Assert.That(element.Text, Is.Not.Null, "Header Text is not Found");
     
        }
    }
}
