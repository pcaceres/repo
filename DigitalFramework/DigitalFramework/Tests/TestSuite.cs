using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DigitalFramework.Tests
{
    class TestSuite
    {
        public IWebDriver driver = new ChromeDriver(@"C:\\WebDrivers");

        public void OpenBrowser()
        {
            driver.Url = "https://racq.com.au";
        }

        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
