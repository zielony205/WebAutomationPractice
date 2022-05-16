using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace WebAutomationPractice.Driver
{
    public class DriverFactory
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
