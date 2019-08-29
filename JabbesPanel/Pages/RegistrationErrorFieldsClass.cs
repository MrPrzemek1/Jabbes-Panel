using JabbesPanel.Locators;
using OpenQA.Selenium;

namespace JabbesPanel.Pages
{
    public partial class RegistrationErrorFieldsClass : BasePage
    {
        public IWebElement LoginErrorField { get; private set; }
        public IWebElement EmailErrorField { get; private set; }
        public IWebElement NameErrorField { get; private set; }
        public IWebElement SurnameErrorField { get; private set; }
        public IWebElement PhoneErrorField { get; private set; }
        public IWebElement PasswordErrorField { get; private set; }
        public IWebElement ConfirmPasswordErrorField { get; private set; }
        public IWebElement BirthDateErrorField { get; private set; }
        public IWebElement UnitErrorField { get; private set; }
        public IWebElement ExistingAccountErrorField { get; private set; }
            
        public RegistrationErrorFieldsClass() : base()
        {
            LoginErrorField = Factory.TryFindElement(By.Id(ErrorsFieldLocators.LoginErrorFieldLocator));
            EmailErrorField = Factory.TryFindElement(By.Id(ErrorsFieldLocators.EmailErrorFieldLocator));
            NameErrorField = Factory.TryFindElement(By.Id(ErrorsFieldLocators.NameErrorFieldLocator));
            SurnameErrorField = Factory.TryFindElement(By.Id(ErrorsFieldLocators.SurnameErrorFieldLocator));
            PhoneErrorField = Factory.TryFindElement(By.Id(ErrorsFieldLocators.PhoneErrorFieldLocator));
            PasswordErrorField = Factory.TryFindElement(By.Id(ErrorsFieldLocators.PasswordErrorFieldLocator));
            ConfirmPasswordErrorField = Factory.TryFindElement(By.Id(ErrorsFieldLocators.ConfirmPasswordErrorFieldLocator));
            BirthDateErrorField = Factory.TryFindElement(By.Id(ErrorsFieldLocators.BirthDateErrorFieldLocator));
            UnitErrorField = Factory.TryFindElement(By.Id(ErrorsFieldLocators.UnitErrorFieldLocator));
            ExistingAccountErrorField = Factory.TryFindElement(By.XPath(ErrorsFieldLocators.ExistingAccountErrorFieldLocator));
        }
    }
}