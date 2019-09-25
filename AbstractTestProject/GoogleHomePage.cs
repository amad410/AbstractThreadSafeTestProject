using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTestProject
{
    public class GoogleHomePage : basePage
    {
        public DriverFactory _driverFactory;
        public GoogleHomePage(DriverFactory driverFactory) : base(driverFactory)
        {
            
        }
        public void SearchTerm(string value)
        {
            Search(value);
        }
    }
}
