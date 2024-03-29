﻿using JabbesPanel.Helpers;
using JabbesPanel.Pages;
using JabbesPanel.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace JabbesPanel.Tests
{
    public abstract class BaseTest
    {
        public BaseTest() { }

        public LoginPage loginPage;

        [TestInitialize]
        public void TestInitialize()
        {
            WebDriverFactory.CreateWebDriver(BrowserType.Chrome);
            WebDriverFactory.Driver.Navigate().GoToUrl(TestDataHelper.url);
            loginPage = new LoginPage();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            WebDriverFactory.Driver.Close();
            WebDriverFactory.Driver.Quit();
        }
    }
}

