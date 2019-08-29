using JabbesPanel.Helpers;
using JabbesPanel.Locators;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace JabbesPanel.Pages
{
    public class RegistrationPage : BasePage
    {
        public IWebElement LoginField { get; private set; }
        public IWebElement EmailField { get; private set; }
        public IWebElement NameField { get; private set; }
        public IWebElement SurnameField { get; private set; }
        public IWebElement PhoneField { get; private set; }
        public IWebElement PasswordField { get; private set; }
        public IWebElement RepeatPasswordField { get; private set; }
        public IWebElement BirthDateField { get; private set; }
        public IWebElement UnitField { get; private set; }
        public IWebElement ConfirmationButton { get; private set; }
        public IWebElement ConfirmationMessage { get; private set; }
        public IList<IWebElement> EridCells { get; private set; }
        public RegistrationErrorFieldsClass Errors { get;}

        public RegistrationPage() : base()
        {
            LoginField = Factory.TryFindElement(By.Id(RegistrationPageLocators.LoginFieldLocator));
            EmailField = Factory.TryFindElement(By.Id(RegistrationPageLocators.EmailFieldLocator));
            NameField = Factory.TryFindElement(By.Id(RegistrationPageLocators.NameFileLocator));
            SurnameField = Factory.TryFindElement(By.Id(RegistrationPageLocators.SurnameFieldLocator));
            PhoneField = Factory.TryFindElement(By.Id(RegistrationPageLocators.PhoneFieldLocator));
            PasswordField = Factory.TryFindElement(By.Id(RegistrationPageLocators.PasswordFieldLocator));
            RepeatPasswordField = Factory.TryFindElement(By.Id(RegistrationPageLocators.RepeatPasswordFieldLocator));
            BirthDateField = Factory.TryFindElement(By.ClassName(RegistrationPageLocators.BirthDateFieldLocator));
            UnitField = Factory.TryFindElement(By.Id(RegistrationPageLocators.UnitFieldLocator));
            ConfirmationMessage = Factory.TryFindElement(By.ClassName(RegistrationPageLocators.ConfirmationMessageLocator));
            ConfirmationButton = Factory.TryFindElement(By.XPath(RegistrationPageLocators.ConfirmationButtonLocator));
            Errors = new RegistrationErrorFieldsClass();
        }

        public RegistrationPage FillAndSubmitRegistrationForm(string login, string email, string name, string surname, string phone, string password, string confirmPassword)
        {
            LoginField.SendKeys(login);
            EmailField.SendKeys(email);
            NameField.SendKeys(name);
            SurnameField.SendKeys(surname);
            PhoneField.SendKeys(phone);
            PasswordField.SendKeys(password);
            RepeatPasswordField.SendKeys(confirmPassword);
            TestDataHelper.ClickRandomDate(BirthDateField);
            UnitField.Click();
            EridCells = Factory.TryFindElements(By.XPath(RegistrationPageLocators.GridCellsLocator));
            TestDataHelper.ClickRandomGridCell(EridCells);
            ConfirmationButton.Click();
            return new RegistrationPage();
        }
        public RegistrationPage aa(string birthDate, params string[] vs)
        {
            foreach (var item in vs)
            {
                LoginField.SendKeys(item);
                EmailField.SendKeys(item);
                NameField.SendKeys(item);
                SurnameField.SendKeys(item);
                PhoneField.SendKeys(item);
                PasswordField.SendKeys(item);
                RepeatPasswordField.SendKeys(item);
            }          
            TestDataHelper.ClickRandomDate(BirthDateField);
            UnitField.Click();
            EridCells = Factory.TryFindElements(By.XPath(RegistrationPageLocators.GridCellsLocator));
            TestDataHelper.ClickRandomGridCell(EridCells);
            ConfirmationButton.Click();
            return new RegistrationPage();
        }
    }
}