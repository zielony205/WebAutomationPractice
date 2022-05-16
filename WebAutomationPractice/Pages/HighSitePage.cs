using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomationPractice.Pages.Common;

namespace WebAutomationPractice.Pages
{
    class HighSitePage : BasePage
    {
        public HighSitePage(IWebDriver driver) : base(driver)
        {
            url = "https://seleniumui.moderntester.pl/high-site.php";
        }


    }
}
