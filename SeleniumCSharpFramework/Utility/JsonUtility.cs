using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Text.Json;

namespace SeleniumCSharpFramework.Utility
{
	public static class JsonUtility 
	{

		public static T readJson <T>(string filepath)
		{
			return JsonSerializer.Deserialize<T>(File.ReadAllText(filepath));
		}
    }
}

