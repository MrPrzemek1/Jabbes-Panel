using JabbesPanel.Locators;
using JabbesPanel.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace JabbesPanel.Helpers
{
    public static class TestDataHelper
    {
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomEmail()
        {
            return string.Format("{0}@test.pl", RandomString(5));
        }

        public static void ClickRandomGridCell(IList<IWebElement> list)
        {
            list[random.Next(list.Count)].Click();
            WebDriverFactory.BrowserWaitInstance.Until(ExpectedConditions.ElementIsVisible(By.XPath(TestDataLocators.HelpElementLocator)));
        }
        public static void ClickRandomDate(IWebElement dateGrid)
        {
            dateGrid.Click();
            IWebElement today = WebDriverFactory.Driver.TryFindElement(By.XPath(TestDataLocators.GridCellLocator));
            today.Click();
        }
    }
}

