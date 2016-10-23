using System;
using Logic001;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TestSolution001
{
    [TestClass]
    public class UnitTest1
    {

        IWebDriver driver;
        WebObjects webObjects;
        SeleniumLogic seleniumLogic;


        [TestInitialize]
        public void DriverInitialize()
        {
            driver = new ChromeDriver();
            //Move browser to screen on right
            driver.Manage().Window.Position = new System.Drawing.Point(2000, 1);
            driver.Manage().Window.Maximize();
            //Initialize help classes
            webObjects = new WebObjects(driver);
            seleniumLogic = new SeleniumLogic(driver);
        }
        [TestCleanup]
        public void CleanUp()
        {
            driver.Quit();
        }
        [TestMethod]
        public void CreateAccount_InvalidEmailFormat()
        {
            driver.Url = "http://automationpractice.com/";

            webObjects.UseElement("login", 1).Click();
            webObjects.UseElement("email_create", 2).SendKeys("ssautomatemail.cz");

            webObjects.UseElement("SubmitCreate", 2).Click();

            seleniumLogic.TakeScreenshot("01Test");
        }


        [TestMethod]
        public void CreateAccount_Valid()
        {
            driver.Url = "http://automationpractice.com/";

            webObjects.UseElement("login", 1).Click();
            webObjects.UseElement("email_create", 2).SendKeys("ssautomat@email.cz");

            //webObjects.UseElement("SubmitCreate", 2).Click();

            seleniumLogic.TakeScreenshot("02Test");
        }

        [TestMethod]
        public void LogIn_InvalidEmailFormat()
        {
            driver.Url = "http://automationpractice.com/";

            webObjects.UseElement("login", 1).Click();
            webObjects.UseElement("email", 2).SendKeys("ssautomatemail.cz");
            webObjects.UseElement("passwd", 2).SendKeys("somesink22");
            webObjects.UseElement("SubmitLogin", 2).Click();

            seleniumLogic.TakeScreenshot("03Test");
        }

        [TestMethod]
        public void LogIn_UnknownUser()
        {
            driver.Url = "http://automationpractice.com/";

            webObjects.UseElement("login", 1).Click();
            webObjects.UseElement("email", 2).SendKeys("nonExistingEmail@email.cz");
            webObjects.UseElement("passwd", 2).SendKeys("somesink22");
            webObjects.UseElement("SubmitLogin", 2).Click();

            seleniumLogic.TakeScreenshot("04Test");
        }


        [TestMethod]
        public void LogIn_Valid()
        {
            driver.Url = "http://automationpractice.com/";

            webObjects.UseElement("login", 1).Click();
            webObjects.UseElement("email", 2).SendKeys("ssautomatemail@email.cz");
            webObjects.UseElement("passwd", 2).SendKeys("somesink22");
            //webObjects.UseElement("SubmitLogin", 2).Click();

            seleniumLogic.TakeScreenshot("05Test");
        }
    }
}
