using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using WebAutomationPractice.Pages.Common;

namespace WebAutomationPractice.Pages
{
    class DraggablePage : BasePage
    {
        public DraggablePage(IWebDriver driver) : base(driver)
        {
            url = "https://seleniumui.moderntester.pl/draggable.php";
        }

        public void DragAndDropByOffset(int offsetX, int offsetY)
        {
            var element = driver.FindElement(By.XPath(@"/html/body/main/div/div"));
            var builder = new Actions(driver);
            var dragAndDrop = builder.DragAndDropToOffset(element, offsetX, offsetY)
                .Build();
            dragAndDrop.Perform();
        }
    }
}
