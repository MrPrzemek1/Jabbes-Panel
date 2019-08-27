using JabbesPanel.Resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace JabbesPanel.Pages
{
    public static class WebDriverFactory
    {
        public static IWebDriver Driver { get; set; }
        private static WebDriverWait BrowserWait { get; set; }

        public static IWebDriver DriverInstance
        {
            get
            {
                if (Driver==null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start."); ;
                }
                return Driver;
            }
            private set => Driver = value;
        }

        public static WebDriverWait BrowserWaitInstance
        {
            get
            {
                if (BrowserWait == null || Driver == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
                }
                return BrowserWait;
            }
            private set => BrowserWait = value;
        }

        public static void CreateWebDriver(BrowserType browserType, double timeOut = 10, int pollingInterval = 500)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:                  
                    DriverInstance = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    break;
                default:
                    throw new ArgumentOutOfRangeException ("No such browser exists");
            }
            BrowserWait = new WebDriverWait(Driver,TimeSpan.FromSeconds(timeOut));
            BrowserWait.PollingInterval = TimeSpan.FromMilliseconds(pollingInterval);
        }
    }
}