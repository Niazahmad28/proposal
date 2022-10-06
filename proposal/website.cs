using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proposal
{
    internal class website
    {
        static IWebDriver driver = null;
        public website(IWebDriver Driver)
        {
            driver = Driver;
        }
        public void websiteSetting(string url)
        {
            driver.Url = url;
        }
    }
}
