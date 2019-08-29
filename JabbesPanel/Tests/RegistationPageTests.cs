using JabbesPanel.Helpers;
using JabbesPanel.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace JabbesPanel.Tests
{
    [TestClass]
    public class RegistationPageTests : BaseTest
    {
        public RegistationPageTests() : base() { }

        [TestMethod]
        public void CorrectRegistration()
        {
            RegistrationPage registrationPage = loginPage.GoToRegestrationPage();
            RegistrationPage registrationPageAfterSubmit = registrationPage.FillAndSubmitRegistrationForm(TestDataHelper.RandomString(10), TestDataHelper.RandomEmail(), TestDataHelper.RandomString(10), TestDataHelper.RandomString(10), TestDataHelper.RandomString(10), "123456","123456");
            Assert.IsTrue(registrationPageAfterSubmit.ConfirmationMessage.Displayed);
        }

        [TestMethod]
        [DataRow("test1","test","asd","asd","asd","123456","123456")]
        public void ExistingLogin(string login, string email, string name, string surname, string phone, string password, string confirmPassword)
        {
            RegistrationPage registrationPage = loginPage.GoToRegestrationPage();
            RegistrationPage registrationPageAfterSubmit = registrationPage.FillAndSubmitRegistrationForm(login, email+"@"+email+".pl", name, surname, phone, password, confirmPassword);
            Assert.IsTrue(registrationPageAfterSubmit.Errors.ExistingAccountErrorField.Displayed);
        }

        [TestMethod]
        [DataRow("", "test", "asd", "asd", "asd", "123456", "123456")]
        public void EmptyLoginField(string login, string email, string name, string surname, string phone, string password, string confirmPassword)
        {
            RegistrationPage registrationPage = loginPage.GoToRegestrationPage();
            RegistrationPage registrationPageAfterSubmit = registrationPage.FillAndSubmitRegistrationForm(login, email + "@" + email + ".pl", name, surname, phone, password, confirmPassword);
            Assert.IsTrue(registrationPageAfterSubmit.Errors.LoginErrorField.Displayed);
        }

        [TestMethod]
        [DataRow("bvcx", "", "asd", "asd", "asd", "123456", "123456")]
        public void EmptyEmailField(string login, string email, string name, string surname, string phone, string password, string confirmPassword)
        {
            RegistrationPage registrationPage = loginPage.GoToRegestrationPage();
            RegistrationPage registrationPageAfterSubmit = registrationPage.FillAndSubmitRegistrationForm(login, email, name, surname, phone, password, confirmPassword);
            Assert.IsTrue(registrationPageAfterSubmit.Errors.EmailErrorField.Displayed);
        }

        [TestMethod]
        [DataRow("bvcx", "asd", "asd", "asd", "asd", "123456", "123456")]
        public void WrongEmail(string login, string email, string name, string surname, string phone, string password, string confirmPassword)
        {
            RegistrationPage registrationPage = loginPage.GoToRegestrationPage();
            RegistrationPage registrationPageAfterSubmit = registrationPage.FillAndSubmitRegistrationForm(login, email, name, surname, phone, password, confirmPassword);
            Assert.IsTrue(registrationPageAfterSubmit.Errors.EmailErrorField.Displayed && registrationPageAfterSubmit.Errors.EmailErrorField.Text.Equals("Adres email jest niepoprawny."));
        }
        [TestMethod]
        [DataRow("bvcx", "asd", "", "asd", "asd", "123456", "123456")]
        public void EmptyNameField(string login, string email, string name, string surname, string phone, string password, string confirmPassword)
        {
            RegistrationPage registrationPage = loginPage.GoToRegestrationPage();
            RegistrationPage registrationPageAfterSubmit = registrationPage.FillAndSubmitRegistrationForm(login, email + "@" + email + ".pl", name, surname, phone, password, confirmPassword);
            Assert.IsTrue(registrationPageAfterSubmit.Errors.NameErrorField.Displayed);
        }
        [TestMethod]
        [DataRow("bvcx", "asd", "asd", "", "asd", "123456", "123456")]
        public void EmptySurnameField(string login, string email, string name, string surname, string phone, string password, string confirmPassword)
        {
            RegistrationPage registrationPage = loginPage.GoToRegestrationPage();
            RegistrationPage registrationPageAfterSubmit = registrationPage.FillAndSubmitRegistrationForm(login, email + "@" + email + ".pl", name, surname, phone, password, confirmPassword);
            Assert.IsTrue(registrationPageAfterSubmit.Errors.SurnameErrorField.Displayed);
        }
        [TestMethod]
        [DataRow("bvcx", "asd", "asd", "asd", "", "123456", "123456")]
        public void EmptyPhoneField(string login, string email, string name, string surname, string phone, string password, string confirmPassword)
        {
            RegistrationPage registrationPage = loginPage.GoToRegestrationPage();
            RegistrationPage registrationPageAfterSubmit = registrationPage.FillAndSubmitRegistrationForm(login, email + "@" + email + ".pl", name, surname, phone, password, confirmPassword);
            Assert.IsTrue(registrationPageAfterSubmit.Errors.PhoneErrorField.Displayed);
        }
        [TestMethod]
        [DataRow("bvcx", "asd", "asd", "asdasd", "asd", "", "123456")]
        public void EmptyPasswordField(string login, string email, string name, string surname, string phone, string password, string confirmPassword)
        {
            RegistrationPage registrationPage = loginPage.GoToRegestrationPage();
            RegistrationPage registrationPageAfterSubmit = registrationPage.FillAndSubmitRegistrationForm(login, email + "@" + email + ".pl", name, surname, phone, password, confirmPassword);
            Assert.IsTrue(registrationPageAfterSubmit.Errors.PasswordErrorField.Displayed);
        }
        [TestMethod]
        [DataRow("bvcx", "asd", "asd", "asdasd", "asd", "123456", "")]
        public void EmptyConfirmPasswordField(string login, string email, string name, string surname, string phone, string password, string confirmPassword)
        {
            RegistrationPage registrationPage = loginPage.GoToRegestrationPage();
            RegistrationPage registrationPageAfterSubmit = registrationPage.FillAndSubmitRegistrationForm(login, email + "@" + email + ".pl", name, surname, phone, password, confirmPassword);
            Assert.IsTrue(registrationPageAfterSubmit.Errors.ConfirmPasswordErrorField.Displayed);
        }
        [TestMethod]
        [DataRow("bvcx", "asd", "asd", "asdasd", "asd", "123456", "123457")]
        public void DifferentPasswords(string login, string email, string name, string surname, string phone, string password, string confirmPassword)
        {
            RegistrationPage registrationPage = loginPage.GoToRegestrationPage();
            RegistrationPage registrationPageAfterSubmit = registrationPage.FillAndSubmitRegistrationForm(login, email + "@" + email + ".pl", name, surname, phone, password, confirmPassword);
            Assert.IsTrue(registrationPageAfterSubmit.Errors.ConfirmPasswordErrorField.Displayed && registrationPageAfterSubmit.Errors.ConfirmPasswordErrorField.Text.Equals("Hasła nie są zgodne."));
        }
    }
}
