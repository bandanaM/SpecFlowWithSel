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
    class TestCase1
    {
        private IWebDriver driver;
        public TestCase1(IWebDriver _driver)
        {
            driver = _driver;
        }
        [Given(@"I enter url in Browser")]
        public void GivenIEnterUrlInBrowser()
        {
            driver.Navigate().GoToUrl("http://myhcl.com");
        }

        [Then(@"I enter UserName in username field")]
        public void ThenIEnterUserNameInUsernameField(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            driver.FindElement(By.Id("txtUserID")).SendKeys((String)data.UserName);
        }

        [Then(@"I enter Password in password field")]
        public void ThenIEnterPasswordInPasswordField(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            driver.FindElement(By.Id("txtPassword")).SendKeys((String)data.Password);
        }

        [Then(@"I select Domain  from domain dropdown")]
        public void ThenISelectDomainFromDomainDropdown(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            SelectElement oselect = new SelectElement(driver.FindElement(By.Id("ddlDomain")));
            oselect.SelectByText((String)data.Domain);
        }

        [Then(@"Click submit button")]
        public void ThenClickSubmitButton()
        {
            driver.FindElement(By.Id("btnSubmit")).Click();
        }

        [Then(@"verify Welcome Page")]
        public void ThenVerifyWelcomePage()
        {
            var element = driver.FindElement(By.ClassName("userName"));
            Assert.That(element.Text, Is.Not.Null, "Header Text is not Found");


         }

       }
    }
