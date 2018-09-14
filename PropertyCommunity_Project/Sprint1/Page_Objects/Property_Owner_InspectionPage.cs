
using OpenQA.Selenium;
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
    class Property_Owner_InspectionPage
    {
        #region WebElements Definition

        //Define search bar        
        //[FindsBy(How = How.Id, Using = "SearchBox")]
        //private IWebElement SearchBar { set; get; }

        //Define search button  //*[@id="mainPage"]/table/tbody/tr[1]/td[5]/button[1]
        //[FindsBy(How = How.XPath, Using = "//*[@id='search - wrap']/form/div/div/button")]
        //private IWebElement SearchButton { set; get; }        

        //[FindsBy(How = How.XPath, Using = "//*[@id='mainPage']/table/tbody/tr[1]/td[5]/button[1]")]
        private IWebElement DetailButton { set; get; }

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

        public String Can_OpenInspectionPage()
        {
            Owner_Inspection_Menu inspectionMenuObj = new Owner_Inspection_Menu();
            inspectionMenuObj.Can_Goto_Inspection();
            Browser.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

            return inspectionMenuObj.Check_Inspection_Title();
        }

        //public void Can_EnterIn_SearchInput()
        //{

        //}

        public void Can_Click_Deatails_Btn()
        {
            DetailButton = Browser.Instance.FindElement(By.XPath("//*[@id='mainPage']/table/tbody/tr[1]/td[5]/button[1]"));
            DetailButton.Click();
            Browser.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            
        }

        public void Can_Search_Property()
        {
            //Thread.Sleep(2000);
            IWebElement SearchBar=Browser.Instance.FindElement(By.Id("SearchBox"));
            //SearchBar.FindElement(By.Id("SearchBox"));
            SearchBar.SendKeys("Lake Road");
            Browser.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            IWebElement SearchButton=Browser.Instance.FindElement(By.Id("icon-submitt"));
            //SearchButton.FindElement(By.Id("icon-submitt"));
            SearchButton.Click();
        }

        public void CloseBrowser()
        {
            Browser.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Browser.CloseBrowser();
        }
    }
}
