using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecFlowFramework.PageObjects
{
    public class SideBar : BasePage
    {
        #region Selectors
        private IWebElement viewAllButton => _driver.FindElement(By.ClassName("view-all"));
        private IWebElement securityButton => _driver.FindElement(By.XPath("//*[@id='sidebarSection']/div/app-product-catalog-sidebar/div/ul/app-pcs-item[26]/li/span[1]"));
        private IWebElement header => _driver.FindElement(By.XPath("//div[@class='header']"));

        #endregion

        //private readonly IWebDriver _webDriver;

        public SideBar(IWebDriver webDriver) :
            base(webDriver)
        {
            _driver = webDriver;
            Thread.Sleep(10000);
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
        }

        public string GetHeaderText => header.Text;

        //public void SelectCategory(string category)
        //{
        //    if (!OptionLabel(category).Enabled)
        //    {
        //        return;
        //    }
        //    OptionLabel(category).Click();
        //}

        public void ViewAllCategories()
        {
            if (!viewAllButton.Enabled)
            {
                return;
            }
            viewAllButton.Click();
        }

        public void SecurityButtonClick()
        {
            if (!securityButton.Enabled)
            {
                return;
            }
            securityButton.Click();
        }

        public String[] GetCategoriesFromSideBar(IWebDriver driver)
        {
            IList<IWebElement> all = driver.FindElements(By.XPath("//*[@id='sidebarSection']/div/app-product-catalog-sidebar/div/ul/li"));

            String[] allText = new String[all.Count];
            int i = 0;
            foreach (IWebElement element in all)
            {
                allText[i++] = element.Text;
            }
            return allText;
        }
    }
}
