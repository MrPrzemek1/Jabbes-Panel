using JabbesPanel.Locators;
using JabbesPanel.Tests;
using OpenQA.Selenium;
using System;

namespace JabbesPanel.Pages
{
    public class LoginPage : BasePage
    {
        public IWebElement LoginField { get; private set; }
        public IWebElement PasswordField { get; private set; } 
        public IWebElement SubmitButton { get; private set; }
        public IWebElement IncorrectDataField { get; private set; }
        public IWebElement LoginErrorField { get; private set; }
        public IWebElement PasswordErrorField { get; private set; }
        public IWebElement LanguageDropDown { get; private set; }
        public IWebElement RegistrationButton { get; private set; }

        public LoginPage() : base()
        { 
            LoginField = Factory.TryFindElement(By.Id(LoginPageLocators.LoginFieldLocator));
            PasswordField = Factory.TryFindElement(By.Id(LoginPageLocators.PasswordFieldLocator));
            SubmitButton = Factory.TryFindElement(By.XPath(LoginPageLocators.SubmitButtonLocator));
            LanguageDropDown = Factory.TryFindElement(By.Id(LoginPageLocators.LanguageDropdownLocator));
            IncorrectDataField = Factory.TryFindElement(By.XPath(LoginPageLocators.ValidationContainerLocator));
            LoginErrorField = Factory.TryFindElement(By.Id(LoginPageLocators.LoginErrorFieldLocator));
            PasswordErrorField = Factory.TryFindElement(By.Id(LoginPageLocators.PasswordErrorFieldLocator));
            RegistrationButton = Factory.TryFindElement(By.ClassName(LoginPageLocators.RegistrationButtonLocator));
        }
        public HomePage FillLoginFormAndSubmit(string login, string password)
        {
            LoginField.SendKeys(login);
            PasswordField.SendKeys(password);
            SubmitButton.Submit();
            return new HomePage();
        }
        public LoginPage FillLoginFormWithIncorrectDataAndSubmit(string login, string password)
        {
            LoginField.SendKeys(login);
            PasswordField.SendKeys(password);
            SubmitButton.Submit();
            return new LoginPage();
        }
        public string GetValidationErrorText()
        {
            return IncorrectDataField.Text;
        }
        public LoginPage ChangeLanguage()
        {
            if (LanguageDropDown.Text.Contains("English"))
            {
                LanguageDropDown.Click();
                Factory.TryFindElement(By.XPath("//a[@href='/Common/Language?l=pl']")).Click();
                return new LoginPage();              
            }
            else
            {
                return this;
            }
        }

        public RegistrationPage GoToRegestrationPage()
        {
            RegistrationButton.Click();
            return new RegistrationPage();
        }
    }
}
