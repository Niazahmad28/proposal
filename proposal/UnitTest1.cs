using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace proposal
{
    [TestClass]
    public class UnitTest1

    {
        #region Initializer 
        string Url = "https://www.airsial.com/";
        static IWebDriver driver = browser.BrowserInit("chrome");
        browser browser = new browser(driver);
        website web = new website(driver);


        #endregion
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }
        [TestMethod]
        public void ms()
        {

            web.websiteSetting(Url);
           
            
            //var originselect = driver.FindElement(By.XPath("//select[@name='origin']"));
            //originselect.Click();


            //var selectdropdown = new SelectElement(originselect);
            //selectdropdown.SelectByValue("KHI");

            //var destinationselect = driver.FindElement(By.XPath("//select[@name='destination']"));
            ////driver.FindElement(By.XPath("//select[@name='destination']")).Click();
            //destinationselect.Click();

            //var selectdropdowns = new SelectElement(destinationselect);
            //selectdropdowns.SelectByValue("LHE");

            //Thread.Sleep(3000);

            //driver.FindElement(By.XPath("//input[@value='round']")).Click();

            //driver.FindElement(By.Id("dpDate")).Click();
            //driver.FindElement(By.XPath("/html/body/div[3]/div[1]/table/tbody/tr[5]/td[3]")).Click();

            //Thread.Sleep(3000);

            //driver.FindElement(By.XPath("//input[@name='returnDate']")).Click();
            //driver.FindElement(By.XPath("/html/body/div[3]/div[1]/table/tbody/tr[5]/td[6]")).Click();
            //Thread.Sleep(3000);
            //////var dateselect = driver.FindElement(By.Id("dpDate"));
            //////var selectdropdwns = new SelectElement(dateselect);
            //////selectdropdwns.SelectByValue("LHE");
            /////

            //var dropdown = driver.FindElement(By.XPath("//*[@id=\"building_search\"]/form/div[2]/div[1]/div/div[1]/div"));
            //dropdown.Click();
            //var input =driver.FindElement(By.Name("adult"));
            //input.Clear();
            //input.SendKeys("3");
            //Thread.Sleep(3000);
            //driver.FindElement(By.XPath("//*[@id=\"building_search\"]/form/div[2]/div[2]/button")).Click();

        }

    }
}