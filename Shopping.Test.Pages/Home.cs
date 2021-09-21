using Shopping.Test.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Shopping.Test.Pages
{
    public class Home : BasePage
    {

        public Home(IWebDriver driver) : base(driver)
        {
        }
     
        
        public IWebElement SearchField => webDriver.FindElement(By.Id("twotabsearchtextbox"));
        public IWebElement SearchButton => webDriver.FindElement(By.Id("nav-search-submit-button"));

        public void LoadHomePage()
        {
            webDriver.Url = "https://www.amazon.com/";
        }

        public void SearchBy(string searchText)
        {
            SearchField.SendKeys(searchText);
            SearchButton.Click();
        }
    }
}
