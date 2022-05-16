using NUnit.Framework;
using OpenQA.Selenium;
using WebAutomationPractice.Driver;
using WebAutomationPractice.Pages;

namespace WebAutomationPractice.Tests
{
    public class AlertsPageTests
    {
        private DriverFactory driverFactory;

        [OneTimeSetUp]
        public void Setup()
        {
            driverFactory = new DriverFactory("chrome");
        }

        [Test]
        public void SimpleAlertAcceptTest()
        {
            using var driver = driverFactory.GetDriver();
            var page = new AlertsPage(driver);

            page.Load();
            page.ClickSimpleAlertButton();
            page.DismissAlert();
            var label = page.GetSimpleAlertLabel();

            Assert.IsTrue(label == "OK button pressed");
        }

        [Test]
        public void PromptAlertCancelTest()
        {
            using var driver = driverFactory.GetDriver();
            var page = new AlertsPage(driver);

            page.Load();
            page.ClickPromptAlertButton();
            page.DismissAlert();
            var label = page.GetPropmptAlertLabel();

            Assert.IsTrue(label == "User cancelled the prompt.");
        }

        [Test]
        [TestCase("Lorem Ipsum")]
        [TestCase("dolor sit amet")]
        public void PromptAlertAcceptTest(string text)
        {
            using var driver = driverFactory.GetDriver();
            var page = new AlertsPage(driver);

            page.Load();
            page.ClickPromptAlertButton();
            page.SetPromptAlertText(text);
            page.AcceptAlert();
            var label = page.GetPropmptAlertLabel();

            Assert.IsTrue(label == $"Hello {text}! How are you today?");
        }

        [Test]
        public void ConfirmAlertCancelTest()
        {
            using var driver = driverFactory.GetDriver();
            var page = new AlertsPage(driver);

            page.Load();
            page.ClickConfirmAlertButton();
            page.DismissAlert();
            var label = page.GetConfirmAlertLabel();

            Assert.IsTrue(label == "You pressed Cancel!");
        }

        [Test]
        public void ConfirmAlertAcceptTest()
        {
            using var driver = driverFactory.GetDriver();
            var page = new AlertsPage(driver);

            page.Load();
            page.ClickConfirmAlertButton();
            page.AcceptAlert();
            var label = page.GetConfirmAlertLabel();

            Assert.IsTrue(label == "You pressed OK!");
        }

        [Test]
        public void DelayedAlertAcceptTest()
        {
            using var driver = driverFactory.GetDriver();
            var page = new AlertsPage(driver);

            page.Load();
            page.ClickDelayedAlertButton();
            page.WaitForDelayedLabel();
            page.AcceptAlert();
            var label = page.GetDelayedAlertLabel();

            Assert.IsTrue(label == "OK button pressed");
        }
    }
}