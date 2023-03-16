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
            Thread.Sleep(5000);
            securityPage.ClickAIPProduct();

            Thread.Sleep(5000);
            //securityPage.ViewOffersAzureInformProtection();

            AzureInformationProtectionPage aipPage = new AzureInformationProtectionPage(driver);
        
            aipPage.PremiumP1NonprofitBuyNowClick();
            Thread.Sleep(5000);
            //Assert.AreEqual(20, sidebar.GetCategoriesFromSideBar(driver).Length);

            AuthorisationMethodPopUp authPopUp = new AuthorisationMethodPopUp(driver);
            authPopUp.ClickLogInButton();
            Thread.Sleep(5000);
            LoginPage loginPage = new LoginPage(driver);
            Assert.AreEqual("Log in", loginPage.GetHeaderText);
        }
    }
}
