using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace JabbesPanel.Pages
{
    public partial class ErrorFieldsClass
    {
        IWebElement UserErrorField => WebDriverFactory.Driver.TryFindElement(By.Id("")); 
    }
}
