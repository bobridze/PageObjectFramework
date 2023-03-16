using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowFramework.Interfaces
{
    public interface IBasePage
    {
        IWebDriver WebDriver { get; }

        //string GetCurrentUrl();

        //void ClickLinkByText(string link);

        //void NavigateToUrl(string url);

        //void WaitForSpinner(int pollingInterval);

        //bool IsElementClickable(string text);
    }
}
