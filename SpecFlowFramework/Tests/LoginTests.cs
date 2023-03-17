using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowFramework.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecFlowFramework.Tests
{
    public class LoginTests : BaseTest
    {
        [Test]
        public void UnregisteredUserSelectProductPlanTest()
        {
            SideBar sidebar = new SideBar(driver);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            Assert.AreEqual("CATEGORIES", sidebar.GetHeaderText);

            sidebar.ViewAllCategories();
            sidebar.SecurityButtonClick();

            SecurityPage securityPage = new SecurityPage(driver);
            //Thread.Sleep(5000);
            securityPage.ClickAIPProduct();

            //Thread.Sleep(5000);
            //securityPage.ViewOffersAzureInformProtection();

            ProductsPage productsPage = new ProductsPage(driver);

            productsPage.PremiumP1NonprofitBuyNowClick();
            //Thread.Sleep(5000);
            //Assert.AreEqual(20, sidebar.GetCategoriesFromSideBar(driver).Length);

            AuthorisationMethodPopUp authPopUp = new AuthorisationMethodPopUp(driver);
            authPopUp.ClickLogInButton();
            //Thread.Sleep(5000);
            LoginPage loginPage = new LoginPage(driver);
            Assert.AreEqual("Log in", loginPage.GetHeaderText);
        }

        [Test]
        public void CategoriesTest()
        {
            SideBar sidebar = new SideBar(driver);
            sidebar.ViewAllCategories();

            string categoryName = sidebar.GetCategoryName("1");
            string countOfProducts = sidebar.GetCategoryCount("1");
            Assert.AreEqual("OnboardingIntegration", categoryName);
            Assert.AreEqual("59", countOfProducts);

            categoryName = sidebar.GetCategoryName("2");
            countOfProducts = sidebar.GetCategoryCount("2");
            Assert.AreEqual("First place 1", categoryName);
            Assert.AreEqual("1", countOfProducts);

            categoryName = sidebar.GetCategoryName("3");
            countOfProducts = sidebar.GetCategoryCount("3");
            Assert.AreEqual("First4", categoryName);
            Assert.AreEqual("2", countOfProducts);

            categoryName = sidebar.GetCategoryName("4");
            countOfProducts = sidebar.GetCategoryCount("4");
            Assert.AreEqual("Featured", categoryName);
            Assert.AreEqual("45", countOfProducts);

            categoryName = sidebar.GetCategoryName("5");
            countOfProducts = sidebar.GetCategoryCount("5");
            Assert.AreEqual("NCE", categoryName);
            Assert.AreEqual("136", countOfProducts);

            categoryName = sidebar.GetCategoryName("6");
            countOfProducts = sidebar.GetCategoryCount("6");
            Assert.AreEqual("Adobe1", categoryName);
            Assert.AreEqual("2", countOfProducts);

            categoryName = sidebar.GetCategoryName("7");
            countOfProducts = sidebar.GetCategoryCount("7");
            Assert.AreEqual("Cisco", categoryName);
            Assert.AreEqual("4", countOfProducts);

            categoryName = sidebar.GetCategoryName("8");
            countOfProducts = sidebar.GetCategoryCount("8");
            Assert.AreEqual("21087_check", categoryName);
            Assert.AreEqual("1", countOfProducts);

            categoryName = sidebar.GetCategoryName("9");
            countOfProducts = sidebar.GetCategoryCount("9");
            Assert.AreEqual("Workshops", categoryName);
            Assert.AreEqual("5", countOfProducts);

            categoryName = sidebar.GetCategoryName("10");
            countOfProducts = sidebar.GetCategoryCount("10");
            Assert.AreEqual("NonCPQ - editing subscription", categoryName);
            Assert.AreEqual("3", countOfProducts);
        }
    }
}
