using OpenQA.Selenium;

namespace JabbesPanel.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver Factory;

        public BasePage()
        {
            Factory = WebDriverFactory.DriverInstance;
        }
    }
}