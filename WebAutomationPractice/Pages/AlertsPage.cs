using OpenQA.Selenium;
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

        public void AcceptAlert()
        {
            var alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        public void DismissAlert()
        {
            var alert = driver.SwitchTo().Alert();
            alert.Dismiss();
        }

        public string GetPromptAlertText()
        {
            var alert = driver.SwitchTo().Alert();
            return alert.Text;
        }

        public void SetPromptAlertText(string text)
        {
            var alert = driver.SwitchTo().Alert();
            alert.SendKeys(text);
        }

        public string GetSimpleAlertLabel()
        {
            var text = GetLabelText("/html/body/main/div/p[1]");
            return text;
        }

        public string GetPropmptAlertLabel()
        {
            var text = GetLabelText("/html/body/main/div/p[2]");
            return text;
        }

        public string GetConfirmAlertLabel()
        {
            var text = GetLabelText("/html/body/main/div/p[3]");
            return text;
        }

        public string GetDelayedAlertLabel()
        {
            var text = GetLabelText("/html/body/main/div/p[4]");
            return text;
        }

        private string GetLabelText(string xPath)
        {
            var label = driver.FindElement(By.XPath(xPath));
            return label.Text;
        }

        private void ClickButton(string xPath)
        {
            var button = driver.FindElement(By.XPath(xPath));
            button.Click();
        }
    }
}
