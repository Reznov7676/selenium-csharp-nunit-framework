using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpFramework.Utility;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SeleniumCSharpFramework.Base
{
    public class BaseTest 
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        protected Page page;

        [SetUp]
        public void Setup()
        {
         
            
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            page = new Page(driver, wait);
            
            page.GetInstance<BrowserActions>().openUrl(ConfigReader.GetUrl());
        }

        
       

       /* [TearDown]
        public void TearDown()
        {
            driver.Quit();
        } */
    }
}
