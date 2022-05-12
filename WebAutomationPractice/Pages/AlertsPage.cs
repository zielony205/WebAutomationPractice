using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomationPractice.Pages.Common;

namespace WebAutomationPractice.Pages
{
    class AlertsPage : BasePage
    {
        public AlertsPage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickSimpleAlertButton()
        {
            ClickButton("/html/body/main/div/button[1]");
        }

        public void ClickPromptAlertButton()
        {
            ClickButton("/html/body/main/div/button[2]");
        }

        public void ClickConfirmAlertButton()
        {
            ClickButton("/html/body/main/div/button[3]");
        }

        public void ClickDelayedAlertButton()
        {
            ClickButton("/html/body/main/div/button[4]");
        }

        private void ClickButton(string xPath)
        {
            var button = driver.FindElement(By.XPath(xPath));
            button.Click();
        }
    }
}
