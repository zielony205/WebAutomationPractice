using NUnit.Framework;
using OpenQA.Selenium;
using WebAutomationPractice.Driver;
using WebAutomationPractice.Pages;

namespace WebAutomationPractice.Tests
{
    public class AlertsPageTests
    {
        private DriverFactory driverFactory;
        private IWebDriver driver;
        private AlertsPage page;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            driverFactory = new DriverFactory("chrome");
        }

        [SetUp]
        public void Setup()
        {
            driver = driverFactory.GetDriver();
            page = new AlertsPage(driver);
            page.Load();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }

        [Test]
        public void SimpleAlertAcceptTest()
        {
            page.ClickSimpleAlertButton();
            page.DismissAlert();
            var label = page.GetSimpleAlertLabel();

            Assert.IsTrue(label == "OK button pressed");
        }

        [Test]
        public void PromptAlertCancelTest()
        {
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
            page.ClickPromptAlertButton();
            page.SetPromptAlertText(text);
            page.AcceptAlert();
            var label = page.GetPropmptAlertLabel();

            Assert.IsTrue(label == $"Hello {text}! How are you today?");
        }

        [Test]
        public void ConfirmAlertCancelTest()
        {
            page.ClickConfirmAlertButton();
            page.DismissAlert();
            var label = page.GetConfirmAlertLabel();

            Assert.IsTrue(label == "You pressed Cancel!");
        }

        [Test]
        public void ConfirmAlertAcceptTest()
        {
            page.ClickConfirmAlertButton();
            page.AcceptAlert();
            var label = page.GetConfirmAlertLabel();

            Assert.IsTrue(label == "You pressed OK!");
        }

        [Test]
        public void DelayedAlertAcceptTest()
        {
            page.ClickDelayedAlertButton();
            page.WaitForDelayedAlert();
            page.AcceptAlert();
            var label = page.GetDelayedAlertLabel();

            Assert.IsTrue(label == "OK button pressed");
        }
    }
}