using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebAutomationPractice.Pages.Common
{
    public class BasePage : LoadableComponent<BasePage>
    {
        protected IWebDriver driver;
        protected string url;
        NavigationPanel navigation;

        public NavigationPanel Navigation 
        { 
            get => navigation;
        }

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            navigation = new NavigationPanel(driver);
            url = @"https://seleniumui.moderntester.pl/";
        }

        protected string GetLabelText(string xPath)
        {
            var label = driver.FindElement(By.XPath(xPath));
            return label.Text;
        }

        protected void ClickButton(string xPath)
        {
            var button = driver.FindElement(By.XPath(xPath));
            button.Click();
        }

        protected bool IsElementVisible(string xPath)
        {
            var element = driver.FindElement(By.XPath(xPath));
            return element.Displayed;
        }

        protected override void ExecuteLoad()
        {
            driver.Navigate().GoToUrl(url);
        }

        protected override bool EvaluateLoadedStatus()
        {
            string currentUrl = driver.Url;
            return currentUrl == url;
        }
    }
}
