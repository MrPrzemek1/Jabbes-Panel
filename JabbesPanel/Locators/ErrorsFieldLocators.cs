using System;
using System.Collections.Generic;
using System.Text;

namespace JabbesPanel.Locators
{
    public class ErrorsFieldLocators
    {
        public const string LoginErrorFieldLocator = "UserName-error";
        public const string EmailErrorFieldLocator = "Email-error";
        public const string NameErrorFieldLocator = "FirstName-error";
        public const string SurnameErrorFieldLocator = "LastName-error";
        public const string PhoneErrorFieldLocator = "Phone-error";
        public const string PasswordErrorFieldLocator = "Password-error";
        public const string ConfirmPasswordErrorFieldLocator = "ConfirmPassword-error";
        public const string BirthDateErrorFieldLocator = "BirthDate-error";
        public const string UnitErrorFieldLocator = "StructureItemEncryptedId-error";
        public const string ExistingAccountErrorFieldLocator = "//div[@class='text-danger validation-summary-errors']";
    }
}
