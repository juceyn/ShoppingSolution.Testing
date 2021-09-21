using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Test.Core
{
    public class BaseTest
    {
        protected static IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            ConfigDriver();
        }

        private void ConfigDriver()
        {
            driver = new ChromeDriver(Environment.CurrentDirectory + @"\driver\");
            driver.Manage().Timeouts().ImplicitWait = new TimeSpan(10000);
            int a = 1;
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
                driver.Quit();
        }
    }
}
