using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowFramework.PageObjects
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
        private IWebElement LoginHeader => _driver.FindElement(By.XPath("//div/span[contains(text(),'Log in')]"));

        public string GetHeaderText => LoginHeader.Text;
    }
}
