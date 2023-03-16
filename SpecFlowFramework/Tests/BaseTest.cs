using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowFramework.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);
            driver.Navigate().GoToUrl("https://appxite-rethink-front-p3-test-01.azurewebsites.net/Catalog/OnboardingIntegration");

        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
