using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowFramework.PageObjects
{
    public class AuthorisationMethodPopUp : BasePage
    {
        public AuthorisationMethodPopUp(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
        //Products
        private string PopUpTitle => _driver.FindElement(By.XPath("/html/body/div[5]/div/div[1]/div/div[1]/div/div/div")).Text;
        private IWebElement LoginButton => _driver.FindElement(By.XPath("//div[contains(text(),'Log in')]"));
        private IWebElement RegisterButton => _driver.FindElement(By.XPath("//div[contains(text(),'Register')]"));

        public string GetPopUpTitle()
        {
            return PopUpTitle;
        }

        public void ClickLogInButton()
        {
            LoginButton.Click();
        }

        public void ClickRegisterButton()
        {
            RegisterButton.Click();
        }
    }
}
