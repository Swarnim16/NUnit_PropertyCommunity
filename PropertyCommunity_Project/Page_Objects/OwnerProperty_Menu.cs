using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PropertyCommunity_Project.Common_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyCommunity_Project.Page_Objects
{
    class OwnerProperty_Menu
    {
        public static void Can_Do_Login()
        {
            Base.Do_Login();

        }
        public static String Can_getAfterLogin_pageTitle()
        {
            Browser.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            //Debug.WriteLine("Getting Title");

            return Login_Page.Return_Title();

        }
        public static void Can_Goto_MyProperty()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Instance, TimeSpan.FromMinutes(1));
            //Giving some wait time to load page fully
            //BrowserUtility.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //Debug.WriteLine("Getting Property Menu page ");
            Thread.Sleep(1000);

            //wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/div/div[2]/div[1]")));
            //  "//*[@class='ui dropdown item']//*[text()='Owners')]")));
            //AND Contains(text(), 'Owners')
            //wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[1]/div/div[2]/div[1]")));
            //BrowserUtility.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement ownerMenu = Browser.Instance.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]"));
            ownerMenu.Click();
            //ownerMenu.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/a[1]"));
            //SelectElement ownerMenu = new SelectElement(BrowserUtility.Instance.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/i")));
            //ownerMenu.SelectByText("Properties");
            // BrowserUtility.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            // wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/a[1]")));
            IWebElement propertyMenu = Browser.Instance.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/a[1]"));
            propertyMenu.Click();
        }

        public static String Check_MyProperty_Title()
        {
            Browser.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            return Browser.Instance.Title;
        }
        public static void CloseBrowser()
        {
            //BrowserUtility.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Browser.CloseBrowser();
        }
    }
}
