using Shopping.Test.Core;
using Shopping.Test.Pages;
using NUnit.Framework;
using System.Threading;

[assembly: LevelOfParallelism(4)]

namespace Shopping.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ShoppingTest : BaseTest
    {
        private Home home;
        private ListingResult resultPage;

        [Test]
        [NonParallelizable]
        public void TestSearchByShoeBrands()
        {
            home = new Home(driver);
            resultPage = new ListingResult(driver);
            home.LoadHomePage();
            home.SearchBy("Shoes");

            Warn.If(resultPage.GetTotalResult() < 150000, "Inventory is low!!");

            //Assert.Fail("Forced failed test");

            //Approach for Soft Asserts
            //Assert.Multiple(() =>
            //{
            //    Assert.IsTrue(resultPage.CheckBrandsAreMainFilters("adidas", "Skechers"));
            //    Assert.IsTrue(resultPage.CheckBrandsAreMainFilters("adidas", "Skechers1"));
            //});

            Assert.IsTrue(resultPage.CheckBrandsAreMainFilters("adidas", "Skechers"));
        }

        [Test]
        [NonParallelizable]
        public void Test1()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(500);
            }
            Assert.IsTrue(true);
        }
        [Test]
        [NonParallelizable]
        public void Test2()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(500);
            }
            Assert.IsTrue(true);
        }
        [Test]
        public void Test3()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(500);
            }
            Assert.IsTrue(true);
        }
        [Test]
        public void Test4()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(500);
            }
            Assert.IsTrue(true);
        }
    }
}


