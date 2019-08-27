namespace JabbesPanel.Locators
{
    public class LoginPageLocators
    {
        public const string LoginFieldLocator = "Login";
        public const string PasswordFieldLocator = "Password";
        public const string SubmitButtonLocator = "//button[@class ='btn btn-primary']";
        public const string ValidationContainerLocator = "//li[contains(text(),'Niepoprawny login lub hasło.')]";
        public const string LoginErrorFieldLocator = "Login-error";
        public const string PasswordErrorFieldLocator = "Password-error";
        public const string LanguageDropdownLocator = "navbarDropdown";
        public const string RegistrationButtonLocator = "login__link";
    }
}
