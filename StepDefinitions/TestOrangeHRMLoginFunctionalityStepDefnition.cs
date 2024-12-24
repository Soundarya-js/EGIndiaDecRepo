﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    internal class TestOrangeHRMLoginFunctionalityStepDefnition
    {
        [Binding]
        public class TestOrangeHRMLoginFunctionalityStepDefinitions
        {

            private readonly ScenarioContext _scenarioContext;
            private IWebDriver _driver;

            public TestOrangeHRMLoginFunctionalityStepDefinitions(ScenarioContext scenarioContext)
            {

                _scenarioContext = scenarioContext;
                _driver = _scenarioContext["WebDriver"] as IWebDriver;

            }

            [Given(@"User is on the login page")]
            public void GivenUserIsOnTheLoginPage()
            {
                new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                _driver = new FirefoxDriver();

                _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
                _driver.Manage().Window.Maximize();
                Thread.Sleep(1000);
            }

            [When(@"User enters the Username and Password")]
            public void WhenUserEntersTheUsernameAndPassword()
            {
                //throw new PendingStepException();
                IWebElement username = _driver.FindElement(By.XPath("//input[@name='username']"));
                username.SendKeys("Admin");
                IWebElement password = _driver.FindElement(By.XPath("//input[@name='password']"));
                username.SendKeys("admin123");
            }

            [When(@"User clicks on login butn")]
            public void WhenUserClicksOnLoginButn()
            {
                IWebElement Login = _driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
                Login.Click();
                Thread.Sleep(3000);
            }

            [Then(@"User is navigated to home pg")]
            public void ThenUserIsNavigatedToHomePg()
            {
                Console.WriteLine("Entered to home page");
            }

        }
    }
}

