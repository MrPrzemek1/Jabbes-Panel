using JabbesPanel.Locators;
using OpenQA.Selenium;

namespace JabbesPanel.Pages
{
    public class StructurePage : BasePage
    {
        public IWebElement NewStructureButton;
        public IWebElement StructureGrid;

        public StructurePage() : base()
        {
            NewStructureButton = Factory.TryFindElement(By.XPath(StructurePageLocators.NewStructureButtonLocator));
            StructureGrid = Factory.TryFindElement(By.XPath(StructurePageLocators.StructureGridLocator));
        }

        public bool IsDisplayed()
        {
            if (Factory.Title.Contains("Struktura") && NewStructureButton.Displayed)
            {
                return true;
            }
            return false;
        }
    }
}