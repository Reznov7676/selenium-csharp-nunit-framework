using NUnit.Framework;
using SeleniumCSharpFramework.Base;
using System;

namespace SeleniumCSharpFramework.Tests
{
    public class SampleTest : BaseTest
    {
        [Test]
        public void OpenWebsiteTest()
        {
            string abc=driver.Title.ToString();
            Console.WriteLine(abc);
           // Assert.IsTrue(driver.Title.Length > 0);
        }
    }
}
