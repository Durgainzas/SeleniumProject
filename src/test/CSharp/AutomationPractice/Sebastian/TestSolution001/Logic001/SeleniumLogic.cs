using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Logic001
{
    public class SeleniumLogic
    {
        IWebDriver Driver;

        public SeleniumLogic(IWebDriver Driver)
        {
            this.Driver = Driver;
        }
        public void TakeScreenshot(string ssName = "default")
        {
            try
            {
                Screenshot ss = ((ITakesScreenshot)Driver).GetScreenshot();
                ss.SaveAsFile(@"C:\Automation\SelScr\" + ssName + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
