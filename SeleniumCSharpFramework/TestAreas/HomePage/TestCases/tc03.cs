using NUnit.Framework;
using SeleniumCSharpFramework.Base;
using SeleniumCSharpFramework.TestAreas.HomePage.PageObjects;
using System;
using SeleniumCSharpFramework.Utility;
using SeleniumCSharpFramework.TestAreas.HomePage.JsonDataObjects;
using System.IO;
namespace SeleniumCSharpFramework.TestAreas.HomePage.TestCases;


public class tc03 : BaseTest
{
    [Test]
    [Category("Smoke")]
    public void tc03_VerifyBottomFooter_LinkWorking()
    {
        page.GetInstance<HomePageMethods>().verifyFooterLinks_working();

    }
}

