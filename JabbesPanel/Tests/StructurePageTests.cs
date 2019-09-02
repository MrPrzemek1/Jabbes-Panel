using JabbesPanel.Pages;
using JabbesPanel.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JabbesPanel.Tests
{
    [TestClass]
    public class StructurePageTests : BaseTest
    {
        public StructurePageTests() : base() { }

        [TestMethod]
        public void ValidPageIsDisplayed()
        {
            StructurePage structurePage = GotoStructurePage(); 
            Assert.IsTrue(structurePage.IsDisplayed());
        }

        private StructurePage GotoStructurePage()
        {
            HomePage homePage = loginPage.FillLoginFormAndSubmit("admin", "admin");
            return homePage.SelectOptionFromMyEnviornmentDropDown<StructurePage>(DropDownOptions.Structure);
        }
    }
}
