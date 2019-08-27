using JabbesPanel.Locators;
using JabbesPanel.Resources;
using OpenQA.Selenium;
using System;

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

        private void ExpandDropDown(IWebElement element)
        {
            element.Click();
        }

        private T SelectOptionFromMyEnviornmentDropDown<T>(DropDownOptions optionName) where T : new()
        {
            MyEnvironmentDropDown.Click();
            switch (optionName)
            {
                case DropDownOptions.Structure:
                    MyEnvironmentDropDown.FindElement(By.LinkText(HomePageLocators.StructureButtonLocator)).Click();
                    return new T();
                case DropDownOptions.Users:
                    MyEnvironmentDropDown.FindElement(By.LinkText(HomePageLocators.StructureButtonLocator)).Click();
                    return new T();
                case DropDownOptions.Participants:
                    MyEnvironmentDropDown.FindElement(By.LinkText(HomePageLocators.StructureButtonLocator)).Click();
                    return new T();
                case DropDownOptions.Orders:
                    MyEnvironmentDropDown.FindElement(By.LinkText(HomePageLocators.StructureButtonLocator)).Click();
                    return new T();
                default:
                    throw new ArgumentOutOfRangeException("Option in dropdown doesn't find.");
            }
        }
    }
}