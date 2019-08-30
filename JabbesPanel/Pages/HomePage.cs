using JabbesPanel.Locators;
using JabbesPanel.Resources;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace JabbesPanel.Pages
{
    public class HomePage : BasePage
    {
        public IWebElement MyEnvironmentDropDown { get; private set; }
        public IWebElement MyProgramDropDown { get; private set; }
        public IWebElement MyMaterialsDropDown { get; private set; }
        public IWebElement MySupportDropDown { get; private set; }
        public IWebElement MyProfileDropDown { get; private set; }
        public IWebElement LogoutButton { get; private set; }

        public HomePage() : base()
        {
            MyEnvironmentDropDown = Factory.TryFindElement(By.XPath(HomePageLocators.MyEnvironmentButtonLocator));
            MyProgramDropDown = Factory.TryFindElement(By.XPath(HomePageLocators.MyProgramButtonLocator));
            MyMaterialsDropDown = Factory.TryFindElement(By.XPath(HomePageLocators.MyMaterialsButtonLocator));
            MySupportDropDown = Factory.TryFindElement(By.XPath(HomePageLocators.MySupportButtonLocator));
            MyProfileDropDown = Factory.TryFindElement(By.XPath(HomePageLocators.MyProfileButtonLocator));
            LogoutButton = Factory.TryFindElement(By.LinkText(HomePageLocators.LogoutButtonLocator));
        }

        public T SelectOptionFromMyEnviornmentDropDown<T>(DropDownOptions optionName) where T : class
        {
            MyEnvironmentDropDown.Click();
            switch (optionName)
            {
                case DropDownOptions.Structure:
                    WebDriverFactory.BrowserWaitInstance.Until(ExpectedConditions.ElementToBeClickable(MyEnvironmentDropDown.FindElement(By.XPath(HomePageLocators.StructureButtonLocator)))).Click();
                    Thread.Sleep(2000);
                    return (T)Activator.CreateInstance(typeof(T));
                case DropDownOptions.Users:
                    MyEnvironmentDropDown.FindElement(By.LinkText(HomePageLocators.UsersButtonLocator)).Click();
                    return (T)Activator.CreateInstance(typeof(T));
                case DropDownOptions.Participants:
                    MyEnvironmentDropDown.FindElement(By.LinkText(HomePageLocators.ParticipantsButtonLocator)).Click();
                    return (T)Activator.CreateInstance(typeof(T));
                case DropDownOptions.Orders:
                    MyEnvironmentDropDown.FindElement(By.LinkText(HomePageLocators.OrdersButtonLocator)).Click();
                    return (T)Activator.CreateInstance(typeof(T));
                default:
                    throw new ArgumentOutOfRangeException("Option in dropdown doesn't find.");
            }
        }
    }
}