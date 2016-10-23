using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Logic001
{
    public class WebObjects
    {
        public IWebElement element;
        public IWebDriver driver;
        public WebObjects(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement UseElement(string elementName, int elementSearchType)
        {
            switch (elementSearchType)
            {
                case 1:
                    element = driver.FindElement(By.ClassName(elementName));
                    break;
                case 2:
                    element = driver.FindElement(By.Id(elementName));
                    break;
                

                default:
                    element = null;
                    break;
            }

            return element;
        }


    }
}
