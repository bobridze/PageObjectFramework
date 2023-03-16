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
        private string popUpTitle => _driver.FindElement(By.XPath("/html/body/div[5]/div/div[1]/div/div[1]/div/div/div")).Text;
        private IWebElement loginButton => _driver.FindElement(By.XPath("//div[contains(text(),'Log in')]"));
        private IWebElement registerButton => _driver.FindElement(By.XPath("//div[contains(text(),'Register')]"));

        public string GetPopUpTitle()
        {
            return popUpTitle;
        }

        public void ClickLogInButton()
        {
            loginButton.Click();
        }

        public void ClickRegisterButton()
        {
            registerButton.Click();
        }
    }
}
