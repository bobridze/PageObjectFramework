using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowFramework.PageObjects
{
    public class AzureInformationProtectionPage : BasePage
    {
        public AzureInformationProtectionPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
        //Products
        private IWebElement PremiumP2 => _driver.FindElement(By.XPath("(//ui-pc-item-box)[1]"));
        private IWebElement PremiumP1Nonprofit => _driver.FindElement(By.XPath("(//ui-pc-item-box)[2]"));
        private IWebElement PremiumP2Nonprofit => _driver.FindElement(By.XPath("(//ui-pc-item-box)[3]"));

        public void PremiumP2BuyNowClick()
        {
            ProductPlanModel prod = InitialiseProductPlan(PremiumP2);
            prod.BuyNowButton.Click();
        }

        public void PremiumP1NonprofitBuyNowClick()
        {
            ProductPlanModel prod = InitialiseProductPlan(PremiumP1Nonprofit);
            prod.BuyNowButton.Click();
        }

        public void PremiumP2NonprofitBuyNowClick()
        {
            ProductPlanModel prod = InitialiseProductPlan(PremiumP2Nonprofit);
            prod.BuyNowButton.Click();
        }
        private ProductPlanModel InitialiseProductPlan(IWebElement planName)
        {
            return new ProductPlanModel
            {
                PlanTitle = planName.FindElement(By.XPath("//div/div/div/a")).Text,
                Description = planName.FindElement(By.XPath("//div/div/div[2]/p")).Text,
                MoreInfoLink = planName.FindElement(By.XPath("//div/div/div[2]/a")),
                BuyNowButton = planName.FindElement(By.XPath("//app-buy-button/span/a")),
                ProductName = planName.FindElement(By.XPath("//span[@autotest='name-block']")).Text
            };
        }

    }
}
