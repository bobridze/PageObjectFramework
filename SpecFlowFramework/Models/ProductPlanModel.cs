using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowFramework.PageObjects
{
    public class ProductPlanModel
    {
        public string PlanTitle
        {
            get; set;
        }

        public string ProductName
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }
        public IWebElement MoreInfoLink
        {
            get; set;
        }
        public IWebElement BuyNowButton
        {
            get; set;
        }
    }
}
