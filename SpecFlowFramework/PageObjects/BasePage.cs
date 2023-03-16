using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowFramework.PageObjects
{
    public class BasePage
    {
        protected IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        //private IWebElement sideBarSection => driver.FindElement(By.Id(""));
        //private IWebElement header => sideBarSection.FindElement(By.XPath("//div[@class='header']"));
        
        //private List<IWebElement> categoriesList => driver.FindElements(By.XPath("//*[@id='sidebarSection']/div/app-product-catalog-sidebar/div/ul"));

        //public string GetHeaderText => header.Text;
  
        public string GetCurrentUrl()
        {
            return _driver.Url;
        }

        public BasePage scrollUp()
        {
            IWebElement s = _driver.FindElement(By.Id("your_locator")); ;
            IJavaScriptExecutor je = (IJavaScriptExecutor)_driver;
            je.ExecuteScript("arguments[0].scrollIntoView(false);", s);
            return this;
        }
    }
}
