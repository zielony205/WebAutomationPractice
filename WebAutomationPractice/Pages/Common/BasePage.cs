using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebAutomationPractice.Pages.Common
{
    class BasePage : LoadableComponent<BasePage>
    {
        NavigationPanel navigationPanel;
        protected IWebDriver driver;
        protected string url;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            navigationPanel = new NavigationPanel(driver);
            url = @"https://seleniumui.moderntester.pl/";
        }
        public void ClickBasicAlerts()
        {
            navigationPanel.ClickBasicAlerts();
        }

        public void ClickInteractionsDraggable()
        {
            navigationPanel.ClickInteractionsDraggable();
        }

        public void ClickWidgetsAccordion()
        {
            navigationPanel.ClickWidgetsAccordion();
        }

        public void ClickOthersHighSite()
        {
            navigationPanel.ClickOthersHighSite();
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
