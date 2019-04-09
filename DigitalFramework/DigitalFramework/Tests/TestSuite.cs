using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace DigitalFramework.Tests
{
    [TestFixture]
    class TestSuite
    {
        IWebDriver driver;

        [SetUp]
        public void Iniit() {
            driver = new ChromeDriver(@"C:\\WebDrivers");
        } 
            
        [Test]
        public void OpenBrowser()
        {
            driver.Url = "https://racq.com.au";
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
