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
        private IWebElement categoriesCatalog => _driver.FindElement(By.XPath("//div/ul"));
        private IWebElement ViewAllButton => _driver.FindElement(By.ClassName("view-all"));
        private IWebElement SecurityButton => _driver.FindElement(By.XPath("//*[@id='sidebarSection']/div/app-product-catalog-sidebar/div/ul/app-pcs-item[26]/li/span[1]"));
        private IWebElement Header => _driver.FindElement(By.XPath("//div[@class='header']"));

        #endregion

        //private readonly IWebDriver _webDriver;

        public SideBar(IWebDriver webDriver) :
            base(webDriver)
        {
            _driver = webDriver;
            Thread.Sleep(10000);
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
        }

        public string GetHeaderText => Header.Text;

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
            if (!ViewAllButton.Enabled)
            {
                return;
            }
            ViewAllButton.Click();
        }

        public void SecurityButtonClick()
        {
            if (!SecurityButton.Enabled)
            {
                return;
            }
            SecurityButton.Click();
        }

        //public int GetCategoriesFromSideBar()
        //{

        //    return allText;
        //}

        public string GetCategoryName (string p0)
        {
            string xPathCatName = String.Format("//div[@class]/ul/app-pcs-item[{0}]/li/span[1]", p0);
            IWebElement item = _driver.FindElement(By.XPath(xPathCatName));
            return item.Text;
        }

        public string GetCategoryCount(string p0)
        {
            string xPathCatCount = String.Format("//div[@class]/ul/app-pcs-item[{0}]/li/span[2]", p0);
            IWebElement item = _driver.FindElement(By.XPath(xPathCatCount));
            return item.Text;
        }
        //private SideBarCategoryModel InitialiseSideBarCategogies(IWebElement sideBarCatalogCatalog)
        //{
        //    return new SideBarCategoryModel
        //    {
        //        CategoryName = sideBarCatalogCatalog.FindElement(By.XPath("//div/div/div/a")).Text,
        //        ProductsCount = sideBarCatalogCatalog.FindElement(By.XPath("//div/div/div[2]/p")).Text,
        //        OpenCategoryButton = sideBarCatalogCatalog.FindElement(By.XPath("//div/div/div[2]/a"))
        //    };
        //}
    }
}
