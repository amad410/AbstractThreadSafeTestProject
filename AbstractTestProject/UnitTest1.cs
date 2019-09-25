using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace AbstractTestProject
{
    [TestClass]
    public class UnitTest1
    {
        public IWebDriver driver;
        public DriverFactory d;
        [TestMethod]
        public void TestMethod1()
        {
            GoogleHomePage h = new GoogleHomePage(d);
            h.SearchTerm("test");
        }

        [TestInitialize]
        public void Setup()
        {
            d = new DriverFactory();
            d.StartDriver();
            driver = d.WebDriver;
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.google.com";
        }
        [TestCleanup]
        public void TearDown()
        {
            d.CloseWebDriver();
        }
    }
}
