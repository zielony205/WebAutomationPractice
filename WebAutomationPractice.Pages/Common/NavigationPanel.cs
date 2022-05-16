using OpenQA.Selenium;

namespace WebAutomationPractice.Pages.Common
{
    public class NavigationPanel
    {
        IWebDriver driver;
        public NavigationPanel(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickBasicAlerts()
        {
            var basic = driver.FindElement(By.XPath("/html/body/nav/div/ul/li[1]/a"));
            basic.Click();
            var alerts = driver.FindElement(By.XPath("/html/body/nav/div/ul/li[1]/div/a[1]"));
            alerts.Click();
        }

        public void ClickInteractionsDraggable()
        {
            var interactions = driver.FindElement(By.XPath("/html/body/nav/div/ul/li[2]/a"));
            interactions.Click();
            var draggable = driver.FindElement(By.XPath("/html/body/nav/div/ul/li[2]/div/a[1]"));
            draggable.Click();
        }

        public void ClickWidgetsAccordion()
        {
            var widgets = driver.FindElement(By.XPath("/html/body/nav/div/ul/li[3]/a"));
            widgets.Click();
            var accordion = driver.FindElement(By.XPath("/html/body/nav/div/ul/li[3]/div/a[1]"));
            accordion.Click();
        }

        public void ClickOthersHighSite()
        {
            var others = driver.FindElement(By.XPath("/html/body/nav/div/ul/li[4]/a"));
            others.Click();
            var highSite = driver.FindElement(By.XPath("/html/body/nav/div/ul/li[4]/div/a[1]"));
            highSite.Click();
        }
    }
}
