using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbstractTestProject
{
    public class DriverFactory
    {
        public IWebDriver _driver;
        ThreadLocal<IWebDriver> ThreadDriver;

        public DriverFactory()
        {

            //Do not instance out side
        }
        public static DriverFactory instance = new DriverFactory();
        public static DriverFactory Instance()
        {
            return instance;
        }
        /// <summary>
        /// This method is use for return WebDriver
        /// </summary>
        /// 
        public IWebDriver WebDriver
        {
            get
            {
                if (ThreadDriver.Value == null)
                //if (webDriver == null)
                {
                    throw new NullReferenceException("The driver instance was not initialized. You should first call the method startDriver.");
                }
                return ThreadDriver.Value;
                //return webDriver;
            }

            set
            {
                _driver = value;
            }
        }
        public void StartDriver()
        {
            ThreadDriver = new ThreadLocal<IWebDriver>(() =>
            {
                return new ChromeDriver();
            }, true);

            
        }
        /// <summary>
        /// This method is use for close WebDriver
        /// </summary>
        public void CloseWebDriver()
        {
            //WebDriver.Close();
            //WebDriver.Quit();
            //WebDriver = null;
            //ThreadDriver.Value.Close();
            ThreadDriver.Value.Quit();
            ThreadDriver.Values.Clear();
        }





        //public void SetDriver()
        //{
        //    _driver = new ChromeDriver();
        //    DriverContext = _driver;
        //    _driver.Manage().Window.Maximize();
        //    _driver.Navigate().GoToUrl("http://www.google.com");


        //}

        //public void SendKeys(string value)
        //{
        //    WebDriver.FindElement(By.Name("q")).SendKeys(value);
        //}
        //public static IWebDriver DriverContext
        //{
        //    get
        //    {
        //        return _driver;
        //    }
        //    set
        //    {
        //        _driver = value;
        //    }
        //}

    }
}
