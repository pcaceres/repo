using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace DigitalFramework 
{
    class Program
    { 
        static void Main(string[] args)
        {
            Tests.TestSuite ts = new Tests.TestSuite();

            ts.Iniit();
            ts.OpenBrowser();
            ts.CloseBrowser();
           
            
        }

    }
}
