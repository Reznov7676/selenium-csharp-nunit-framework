
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SeleniumCSharpFramework.Utility
{
	public class ConfigReader
	{
        private static IConfiguration config;

        static ConfigReader()
        {
            config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        }


        public static string GetUrl()
        {
            return config["Application:Url"];
        }

        public static string GetUsername()
        {
            return config["Application:Username"];
        }

        public static string GetPassword()
        {
            return config["Application:Password"];
        }

        public static string GetBrowser()
        {
            return config["Browser:Name"];
        }
    }
}

