using NUnit.Framework;
using SeleniumCSharpFramework.Base;
using SeleniumCSharpFramework.TestAreas.HomePage.PageObjects;
using System;
using SeleniumCSharpFramework.Utility;
using SeleniumCSharpFramework.TestAreas.HomePage.JsonDataObjects;
using System.IO;
namespace SeleniumCSharpFramework.TestAreas.HomePage.TestCases;

//hell0
public class tc02 : BaseTest
{
    [Test]
    public void tc02_openMultiple_FooterLinks()
    {
        string filepath = Path.Combine(
     AppDomain.CurrentDomain.BaseDirectory,
     "TestAreas/HomePage/TestData/tc01.json");

        var testData = JsonUtility.readJson<AmazonHomePage>(filepath);
        page.GetInstance<HomePageMethods>().openMultiple_bottomFooterLinks();

    }
}

