using JabbesPanel.Pages;
using JabbesPanel.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace JabbesPanel.Tests
{
    public abstract class BaseTest
    {
        IWebDriver driver;
        private string url = "http://jabbes-panel-release.azurewebsites.net";
        public BaseTest() { }

        public LoginPage loginPage;

        [TestInitialize]
        public void TestInitialize()
        {
            WebDriverFactory.CreateWebDriver(BrowserType.Chrome);

            WebDriverFactory.Driver.Navigate().GoToUrl(url);
            WebDriverFactory.Driver.Manage().Window.Maximize();
            var login = new LoginPage();
            loginPage = login.ChangeLanguage();          
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            WebDriverFactory.Driver.Close();
            WebDriverFactory.Driver.Quit();
        }
    }
}

