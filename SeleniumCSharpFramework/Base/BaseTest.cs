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

            ChromeOptions options = new ChromeOptions();

            options.AddArgument("--headless=new");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--window-size=1920,1080");

            driver = new ChromeDriver(options);
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
