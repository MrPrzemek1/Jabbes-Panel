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


//interface ITest
//{
//    void StartTest();
//}
//--------------------------------------------------------------------------------------------
//class TestStructure : ITest
//{
//    void StartTest()
//    {
//	..........................
//}
//}
//--------------------------------------------------------------------------------------------
//class TestUsers : ITest
//{
//    void StartTest()
//    {
//	..........................
//}
//}
//--------------------------------------------------------------------------------------------
//Dictionary<DropDownOptions, ITest> TestDictionary
//{

//    { DropDownOptions.Structure, new TestStructure},

//    { DropDownOptions.Users, new TestUsers},
//}
//--------------------------------------------------------------------------------------------
//public void SelectOptionFromMyEnviornmentDropDown(DropDownOptions optionName)
//{
//    ITest myTest = TestDictionary[optionName];
//    myTest.StartTest();
//}
//interface ITest
//{
//    void StartTest();
//}
//--------------------------------------------------------------------------------------------
