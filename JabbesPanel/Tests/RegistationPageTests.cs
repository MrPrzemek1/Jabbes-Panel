using JabbesPanel.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            RegistrationPage registrationPageAfterSubmit = registrationPage.FillAndSubmitRegistrationForm(TestDataHelper.RandomString(10), TestDataHelper.RandomEmail(), TestDataHelper.RandomString(10), TestDataHelper.RandomString(10), TestDataHelper.RandomString(10), "123456","123456", TestDataHelper.RandomString(10));
            Assert.IsTrue(registrationPageAfterSubmit.ConfirmationMessage.Displayed);
        }
    }
}
