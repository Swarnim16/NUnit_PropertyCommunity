using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyCommunity_Project.Common_Classes
{
    class Browser
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            //ChromeOptions options = new ChromeOptions();
            //options.AddArguments("--disable-notifications");
            Instance = new ChromeDriver();
            Instance.Manage().Window.Maximize();
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        public static void GoToURL(string url)
        {
            Instance.Url = url;
        }

        public static string ReturnTitle()
        {
            return Instance.Title;
        }


        public static void CloseBrowser()
        {
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Instance.Close();
            Instance.Dispose();
        }
    }
}
