using Shopping.Test.Core.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Shopping.Test.Core
{
    public class BasePage
    {
        protected IWebDriver webDriver;

        public BasePage(IWebDriver driver)
        {
            this.webDriver = driver;
        }

        protected void ScrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].scrollIntoView();", element);
        }

        public void mouseOver(IWebElement element)
        {
            Actions builder = new Actions(webDriver);
            builder.MoveToElement(element).Perform();
        }
    }
}
