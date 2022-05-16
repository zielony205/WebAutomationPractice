using NUnit.Framework;
using OpenQA.Selenium;
using WebAutomationPractice.Driver;
using WebAutomationPractice.Pages;

namespace WebAutomationPractice.Tests
{
    public class AlertsPageTests
    {
        private DriverFactory driverFactory;

        [SetUp]
        public void Setup()
        {
            driverFactory = new DriverFactory("chrome");
        }

        [Test]
        public void Test1()
        {
            var driver = driverFactory.GetDriver();
            var page = new AlertsPage(driver);

            page.Load();
            page.ClickPromptAlertButton();
            page.DismissAlert();

            Assert.Pass();
        }
    }
}