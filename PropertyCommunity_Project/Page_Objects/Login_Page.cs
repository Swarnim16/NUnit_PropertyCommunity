
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PropertyCommunity_Project.Common_Classes;

namespace PropertyCommunity_Project.Page_Objects
{
    class Login_Page
    {
        public static string url = "http://new-keys.azurewebsites.net/Account/Login";

        #region
        [FindsBy(How=How.Id, Using = "UserName")]
        private IWebElement UserNameEle { get; set; }

        [FindsBy(How=How.Id, Using = "Password")]
        private IWebElement PasswordEle { get; set; }
        #endregion
        public static void Go_To_Login_Page()
        {
            Browser.Initialize();
            Browser.GoToURL(url);

        }

        public static void Can_Enter_LoginData(String userName, String password)
        {
            //id="UserName" and id="Password"
            //var userNameElement = Browser.Instance.FindElement(By.Id("UserName"));
            //var passwordElement = Browser.Instance.FindElement(By.Id("Password"));


            //userNameElement.Clear();
            //userNameElement.SendKeys(userName);

            //passwordElement.Clear();
            //passwordElement.SendKeys(password);

            Login_Page loginPageObj = new Login_Page();
            loginPageObj.UserNameEle.Clear();
            loginPageObj.UserNameEle.SendKeys(userName);

            loginPageObj.PasswordEle.Clear();
            loginPageObj.PasswordEle.SendKeys(password);

        }

        public static void Enter_LoginData(String userName, String password)
        {
            //id="UserName" and id="Password"
            var userNameElement = Browser.Instance.FindElement(By.Id("UserName"));
            var passwordElement = Browser.Instance.FindElement(By.Id("Password"));


            userNameElement.Clear();
            userNameElement.SendKeys(userName);

            passwordElement.Clear();
            passwordElement.SendKeys(password);

        }

        public static void Can_Click_Login()
        {
            var loginButtonElement = Browser.Instance.FindElement(By.XPath("//*[@id='sign_in']/div[1]/div[4]/button"));

            loginButtonElement.Click();
            //Giving some wait time to load page fully
            Browser.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            IWebElement skipButtonElement = Browser.Instance.FindElement(By.XPath("/html/body/div[5]/div/div[5]/a[1]"));
            skipButtonElement.Click();

        }

        public static string Return_Title()
        {
            return Browser.Instance.Title;

        }
        public static void Can_Do_Logout()
        {
            //Giving some wait time to load page fully
            // Browser.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

            //WebDriverWait waitForElement = new WebDriverWait(Browser.Instance, TimeSpan.FromMinutes(1));
            //waitForElement.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[1]/div/div[2]/div[4]")));
            Thread.Sleep(1000);

            IWebElement profileIconElement = Browser.Instance.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[4]"));
            profileIconElement.Click();
            Browser.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement logoutItemElement = Browser.Instance.FindElement(By.CssSelector("body > div.ui.fixed.top.text.menu > div > div.right.menu > div.ui.dropdown.item.active.visible > div > a:nth-child(4)"));
            //XPath("/html/body/div[1]/div/div[2]/div[4]/div/a[4]"));
            logoutItemElement.Click();
        }
        public static void Close_Browser()
        {
            Browser.CloseBrowser();
        }
    }
}
