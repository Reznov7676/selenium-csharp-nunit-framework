using NUnit.Framework;
using SeleniumCSharpFramework.Base;
using SeleniumCSharpFramework.TestAreas.HomePage.PageObjects;
using System;
using SeleniumCSharpFramework.Utility;
using SeleniumCSharpFramework.TestAreas.HomePage.JsonDataObjects;
using System.IO;
namespace SeleniumCSharpFramework.TestAreas.HomePage.TestCases;


public class tc01 : BaseTest
{
    [Test]
    public void tc01_VerifyBottomFooter_HomePage()
    {
        // string filepath = "Users/jaymaldikar/Projects/SeleniumCSharpFramework/SeleniumCSharpFramework/TestAreas/HomePage/JsonDataObjects/tc01.json";
        string filepath = Path.Combine(
     AppDomain.CurrentDomain.BaseDirectory,
     "TestAreas/HomePage/TestData/tc01.json");

        var testData = JsonUtility.readJson<AmazonHomePage>(filepath);
        page.GetInstance<HomePageMethods>().verify_footerLinkNames(testData.bottomLinks);

    }
}

