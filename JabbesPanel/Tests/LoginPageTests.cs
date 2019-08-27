using JabbesPanel.Pages;
using JabbesPanel.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace JabbesPanel
{
    [TestClass]
    public class LoginPageTests : BaseTest
    {
        public LoginPageTests() : base() { }

        [TestMethod]
        public void LoginCorrectly()
        {
            HomePage homePage = loginPage.FillLoginFormAndSubmit("Admin","admin");
            Assert.IsTrue(homePage.LogoutButton.Displayed);
        }
        [TestMethod]
        public void IncorrectlyLogin()
        {
            LoginPage loginPageAfterSubmitFrom = loginPage.FillLoginFormWithIncorrectDataAndSubmit("asd","asd");
            Assert.AreEqual("Niepoprawny login lub has³o.", loginPageAfterSubmitFrom.GetValidationErrorText());
        }

        [TestMethod]
        public void EmptyLoginField()
        {
            LoginPage loginPageAfterSubmitFrom = loginPage.FillLoginFormWithIncorrectDataAndSubmit("", "asd");
            Assert.AreEqual("Pole jest wymagane.", loginPageAfterSubmitFrom.LoginErrorField.Text);
        }
        [TestMethod]
        public void EmptyPasswordField()
        {
            LoginPage loginPageAfterSubmitFrom = loginPage.FillLoginFormWithIncorrectDataAndSubmit("asd", "");
            Assert.AreEqual("Pole jest wymagane.", loginPageAfterSubmitFrom.PasswordErrorField.Text);
        }
        [TestMethod]
        public void EmptyLoginAndPasswordField()
        {
            LoginPage loginPageAfterSubmitFrom = loginPage.FillLoginFormWithIncorrectDataAndSubmit("", "");
            Assert.IsTrue(loginPageAfterSubmitFrom.PasswordErrorField.Displayed & loginPageAfterSubmitFrom.PasswordErrorField.Text.Equals("Pole jest wymagane."));
            Assert.IsTrue(loginPageAfterSubmitFrom.LoginErrorField.Displayed & loginPageAfterSubmitFrom.LoginErrorField.Text.Equals("Pole jest wymagane."));
        }
    }
}
