using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTestProject
{
    public abstract class basePage : DriverFactory
    {
        public DriverFactory _driverFactory;
        public basePage(DriverFactory driverFactory)
        {
            _driverFactory = driverFactory;
        }
        public void Search(string value)
        {
            _driverFactory.WebDriver.FindElement(By.Name("q")).SendKeys(value);


        }
    }
}
