using Shopping.Test.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Shopping.Test.Pages
{
    public class ListingResult : BasePage
    {
        public ListingResult(IWebDriver driver) : base(driver)
        {
        }        

        private IWebElement BrandSearch => webDriver.FindElement(By.Id("c3-subPanel-_x-searchable-0-1-textbox"));
        private List<IWebElement> DefaultShoesFilterItems => webDriver.FindElements(By.XPath("//ul[contains(@aria-labelledby,'p_89-title')]/li")).ToList();
        public IWebElement SeeAllLink => webDriver.FindElement(By.XPath("//body[1]/div[4]/div[5]/ul[1]/li[1]/ul[1]/li[2]/ul[1]/li[1]/div[2]/div[1]/div[1]/button[1]"));
        public IWebElement TotalResult => webDriver.FindElement(By.XPath("//div[contains(@class,'a-section a-spacing-small a-spacing-top-small')]/span"));

        public int GetTotalResult()
        {
            var total = int.Parse(TotalResult.Text.Replace(",","").Replace(".", "").Split(" ")[6]);
            return total;
        }

        public bool CheckBrandsAreMainFilters(params string[] brands)
        {
            var res = DefaultShoesFilterItems.FindAll(item => brands.Contains(item.Text));
            return res.Count() == brands.Length;
        }

        public void FilterByBrand(string brand)
        {
            ScrollToElement(SeeAllLink);
            SeeAllLink.Click();
            BrandSearch.SendKeys(brand);
        }


    }
}
