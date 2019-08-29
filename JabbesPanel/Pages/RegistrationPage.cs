using JabbesPanel.Helpers;
using JabbesPanel.Locators;
using JabbesPanel.Pages;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace JabbesPanel.Tests
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
        public IList<IWebElement> gridCells { get; private set; }

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
        }

        public RegistrationPage FillAndSubmitRegistrationForm(string login, string email, string name, string surname, string phone, string password, string confirmPassword, string birthDate)
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
            gridCells = Factory.TryFindElements(By.XPath(RegistrationPageLocators.GridCellsLocator));
            TestDataHelper.ClickRandomGridCell(gridCells);
            ConfirmationButton.Click();
            return new RegistrationPage();
        }
    }
}