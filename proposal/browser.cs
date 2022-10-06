using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proposal
{
    internal class browser
    {
      static  IWebDriver driver = null;
      public  browser (IWebDriver Driver)
        {
            driver = Driver;
        }
        public static IWebDriver BrowserInit(string Browser)
        {
            if (Browser.Equals("chrome", StringComparison.InvariantCultureIgnoreCase))
                
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();

            }
            else if (Browser.Equals("Firefox", StringComparison.InvariantCultureIgnoreCase))
            {
                driver = new FirefoxDriver();
                driver.Manage().Window.Maximize();
            }
            return driver;
        }
        public void DriverQuit()
        {
            driver.Quit();
        }
    }
}
