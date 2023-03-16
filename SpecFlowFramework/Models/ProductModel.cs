using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowFramework.PageObjects
{
    public class ProductModel
    {
        public string ProductName
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }
        public IWebElement ViewOffersLink
        {
            get; set;
        }

        public string Tag
        {
            get; set;
        }
    }

}
