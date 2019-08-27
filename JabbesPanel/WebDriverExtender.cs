using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace JabbesPanel
{
    public static class WebDriverExtender
    {
        public static IWebElement TryFindElement(this IWebDriver driver,By by)
        {
            try
            {
                return driver.FindElement(by);
            }
            catch (NoSuchElementException ex)
            {
               Console.WriteLine(ex.Message);
               return null ;
            }           
        }
        public static IList<IWebElement> TryFindElements(this IWebDriver driver, By by)
        {
            try
            {
                return driver.FindElements(by);
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
