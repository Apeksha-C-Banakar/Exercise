using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Edge;

namespace LabSessionNUnint.LocaterSelenium
{
    internal class orange
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            //launch chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //initialize the web driver
            driver = new EdgeDriver();
        }
        [Test]
        public void testcase1()
        {
            //launch application URL
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/index.html");
            //locators
            //ID
            Thread.Sleep(5000);
            IWebElement UserName = driver.FindElement(By.Id("user-name"));
            UserName.SendKeys("standard_user");
            Thread.Sleep(5000);
            IWebElement Password = driver.FindElement(By.Id("password"));
            Password.SendKeys("secret_sauce");
            Thread.Sleep(5000);
            IWebElement Login = driver.FindElement(By.Id("login-button"));
            Login.Click();
            Thread.Sleep(5000);
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
