using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
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
            driver.Manage().Window.Maximize();
            Assert.AreEqual("Roadside Assistance, Insurance, Banking, Motoring, Travel - RACQ", driver.Title);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement insuranceHeader = driver.FindElement(By.XPath("//div[@class='navbar l-container']/..//li/a[text()='Insurance']"));

            Actions actions = new Actions(driver);
            actions.MoveToElement(insuranceHeader).Build().Perform();

 
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement getQuote = driver.FindElement(By.XPath("//div[@class='dropdown']//div/a[text()='Get insurance quote']"));
            wait.Until(g => getQuote);
            
  
            getQuote.Click();

        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
