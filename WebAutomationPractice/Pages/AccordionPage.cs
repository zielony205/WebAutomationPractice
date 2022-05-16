using OpenQA.Selenium;
using WebAutomationPractice.Pages.Common;

namespace WebAutomationPractice.Pages
{
    class AccordionPage : BasePage
    {
        public AccordionPage(IWebDriver driver) : base(driver)
        {
            url = @"https://seleniumui.moderntester.pl/accordion.php";
        }

        public void ToggleHeader1()
        {
            ClickButton(@"/html/body/main/div/div/h3[1]");
        }

        public void ToggleHeader2()
        {
            ClickButton(@"/html/body/main/div/div/h3[2]");
        }

        public void ToggleHeader3()
        {
            ClickButton(@"/html/body/main/div/div/h3[3]");
        }

        public void ToggleHeader4()
        {
            ClickButton(@"/html/body/main/div/div/h3[4]");
        }
    }
}
