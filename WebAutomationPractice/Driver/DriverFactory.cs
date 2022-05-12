using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomationPractice.Driver
{
    class DriverFactory
    {
        private string browser;

        public DriverFactory(string browser)
        {
            this.browser = browser;
        }

        public IWebDriver GetDriver()
        {
            switch(browser)
            {
                case "chrome":
                    return new ChromeDriver(@"C:\drivers");
                case "firefox":
                    return new FirefoxDriver(@"C:\drivers");
                default:
                    throw new Exception("Wrong browser type provided");
            }
        }
    }
}
