using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using PropertyCommunity_Project.Common_Classes;
using PropertyCommunity_Project.Page_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyCommunity_Project.Sprint1.Page_Objects
{
    class Owner_Inspection_Menu
    {
        #region WebElements Definition

        //Define search bar        
        //[FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]")]
        //public IWebElement OwnerMenu { get; set; }

        //[FindsBy(How= How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]/div/a[7]")]
        //public IWebElement InspectionMenu { set; get; }

        #endregion

        public void Can_Do_Login()
        {
            Base.Do_Login();
        }
        public String Can_getAfterLogin_pageTitle()
        {
            Browser.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            
            return Login_Page.Return_Title();
        }

        public void Can_Goto_Inspection()
        {
            //Browser.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            Thread.Sleep(1000);
            //Owner_Inspection_Menu inspectionObj = new Owner_Inspection_Menu();
            IWebElement ownerMenu = Browser.Instance.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]"));
            ownerMenu.Click();
            //inspectionObj.OwnerMenu.Click();

            IWebElement inspectionMenu = Browser.Instance.FindElement(By.CssSelector("body > div.ui.fixed.top.text.menu > div > div.right.menu > div.ui.dropdown.item.active.visible > div > a:nth-child(7)"));
            inspectionMenu.Click();
            //InspectionMenu.Click();
            Thread.Sleep(1000);
        }

        public String Check_Inspection_Title()
        {
            Browser.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            return Browser.Instance.Title;
        }
        public void CloseBrowser()
        {
            Browser.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Browser.CloseBrowser();
        }
    }
}
