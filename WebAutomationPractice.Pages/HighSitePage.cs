using OpenQA.Selenium;
using WebAutomationPractice.Pages.Common;

namespace WebAutomationPractice.Pages
{
    public class HighSitePage : BasePage
    {
        public HighSitePage(IWebDriver driver) : base(driver)
        {
            url = "https://seleniumui.moderntester.pl/high-site.php";
        }


    }
}
