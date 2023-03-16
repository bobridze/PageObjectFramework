using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowFramework.PageObjects
{
    public class SecurityPage : BasePage
    {
        public SecurityPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
        //Product blocks
        private IWebElement AzureAdvancedThreatProtection => _driver.FindElement(By.XPath("(//div[@autotest='product-block'])[1]"));
        private IWebElement AzureInformationProtection => _driver.FindElement(By.XPath("(//div[@autotest='product-block'])[2]"));
        private IWebElement AzureActiveDirectory => _driver.FindElement(By.XPath("(//div[@autotest='product-block'])[3]"));

        //temp produst name
        private IWebElement AIPHeaderLink => _driver.FindElement(By.XPath("(//div[@autotest='product-block'])[2]/div/div[2]/div/span[@autotest]"));
        public void ClickAIPProduct()
        {
            AIPHeaderLink.Click();
        }

        public void ViewOffersAzureInformProtection()
        {
            ProductModel prod = InitialiseProduct(AzureAdvancedThreatProtection);
            prod.ViewOffersLink.Click();
        }

        //public void ViewOffersAzureActiveDirectory()
        //{
        //    Product prod = InitialiseProduct(AzureActiveDirectory);
        //    prod.ViewOffersLink.Click();
        //}
        //public void ViewOffersAzureAdvancedThreat()
        //{
        //    Product prod = InitialiseProduct(AzureAdvancedThreatProtection);
        //    prod.ViewOffersLink.Click();
        //}

        private ProductModel InitialiseProduct(IWebElement productName)
        {
            return new ProductModel
            {
                ProductName = productName.FindElement(By.XPath("//span[@autotest='name-block']")).Text,
                Description = productName.FindElement(By.XPath("//p[@autotest='description-block']")).Text,
                Tag = productName.FindElement(By.XPath("//div[@class='tags']")).Text,
                ViewOffersLink = productName.FindElement(By.XPath("//a[@autotest='viewOffers-link']")),
            };
        }
    }
}
