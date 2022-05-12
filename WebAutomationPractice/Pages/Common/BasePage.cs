using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomationPractice.Pages.Common
{
    class BasePage
    {
        NavigationPanel navigationPanel;
        protected IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            navigationPanel = new NavigationPanel(driver);
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
    }
}
