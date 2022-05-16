using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebAutomationPractice.Pages.Common;

namespace WebAutomationPractice.Pages
{
    public class AlertsPage : BasePage
    {
        public AlertsPage(IWebDriver driver) : base(driver)
        {
            url = "https://seleniumui.moderntester.pl/alerts.php";
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

        public string GetAlertMessage()
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

        public void WaitForDelayedLabel()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.SwitchTo().Alert());
        }
    }
}
