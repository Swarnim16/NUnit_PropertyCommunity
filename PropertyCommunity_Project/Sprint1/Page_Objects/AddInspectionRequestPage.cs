
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using PropertyCommunity_Project.Common_Classes;
using PropertyCommunity_Project.DataDriven;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyCommunity_Project.Sprint1.Page_Objects
{
    class AddInspectionRequestPage
    {
        #region WebElements Definition
        //[FindsBy(How = How.CssSelector, Using = "#mainPage > div.highlighted > div > div.middle.aligned.eight.wide.column > a")]
        //private IWebElement AddInspectionRequestButton { set; get; }

       // [FindsBy(How = How.XPath, Using = "//*[@id='main - content']/div/form/fieldset/div[1]/div[2]/div[1]/div[1]")]
        //private IWebElement PropertyNameSelect { set; get; }

        //[FindsBy(How = How.Id, Using = "tenant-select")]
        //private IWebElement TenantSelect { set; get; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='main - content']/div/form/fieldset/div[1]/div[2]/div[2]/div/textarea")]
        //private IWebElement DescriptionInput { set; get; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='main - content']/div/form/fieldset/div[1]/div[2]/div[1]/div[3]/input")]
        //private IWebElement DueDateInput { set; get; }

        [FindsBy(How = How.Id, Using = "file-upload")]
        private IWebElement UploadImageInput { set; get; }

        #endregion

        public void Can_ClickAddNewInspectionRequestButton()
        {
            //Browser.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement AddInspectionRequestButton = Browser.Instance.FindElement(By.CssSelector("#mainPage > div.highlighted > div > div.middle.aligned.eight.wide.column > a"));
            AddInspectionRequestButton.Click();            
        }

        public String Check_InspectionRequestPageTitle()
        {
            Browser.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            return Browser.Instance.Title;
        }

        public Boolean Can_EnterInspectionRequestInput()
        {
            Browser.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(90);
            //Thread.Sleep(5000);
            //WebDriverWait waitForElement = new WebDriverWait(Browser.Instance, TimeSpan.FromMinutes(5));
            //waitForElement.Until(ExpectedConditions.ElementToBeSelected(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(1) > div.two.fields > div:nth-child(1) > div.ui.fluid.selection.dropdown")));
            //Thread.Sleep(1000);
            //SelectElement selElement = new SelectElement(Browser.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(1) > div.two.fields > div:nth-child(1) > div.ui.fluid.selection.dropdown")).FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(1) > div.two.fields > div:nth-child(1) > div.ui.fluid.selection.dropdown > select")));
            //selElement.SelectByValue("5915");
            IWebElement propertyDropDown = Browser.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(1) > div.two.fields > div:nth-child(1) > div.ui.fluid.selection.dropdown"));
            Thread.Sleep(1000);
            propertyDropDown.Click();
            //Actions actions = new Actions(Browser.Instance);
            //actions.MoveToElement(propertyDropDown);
            //actions.Click();
            //actions.Build().Perform();
            IWebElement propertySelectItem = Browser.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(1) > div.two.fields > div:nth-child(1) > div.ui.fluid.selection.dropdown.active.visible > div.menu.transition.visible > div:nth-child(3)"));
            Thread.Sleep(1000);
            propertySelectItem.Click();
            //IWebElement selProperty= Browser.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(1) > div.two.fields > div:nth-child(1) > div.ui.fluid.selection.dropdown"));
            SelectElement selectTenant = new SelectElement(Browser.Instance.FindElement(By.Id("tenant-select")));

            //IWebElement selectTenant = Browser.Instance.FindElement(By.Id("tenant-select"));
            // IWebElement selectTenant = Browser.Instance.FindElement(By.Id("tenant-select"));
            //("//*[@id='main - content']/div/form/fieldset/div[1]/div[2]/div[1]/div[2]/div"));
            //  #main-content > div > form > fieldset > div:nth-child(1) > div.two.fields > div:nth-child(1) > div:nth-child(5) > input[type="text"]
            IWebElement dueDateInput = Browser.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(1) > div.two.fields > div:nth-child(1) > div:nth-child(5) > input[type='text']"));
            IWebElement descriptionInput = Browser.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(1) > div.two.fields > div:nth-child(2) > div > textarea"));


            ExcelFileHandler excelData = new ExcelFileHandler();
            excelData.GetInspectionRequestInput();
            String selectProperty = excelData.selectProperty;
            String selTenant = excelData.selectTenant;
            DateTime dueDate = excelData.dueDate;
            String description = excelData.description;

            excelData.closeAllObject();

            bool propertyFound = false;
            //foreach (IWebElement propertyElement in selElement.Options)
            {
                //if (propertyElement.Text.Contains(selectProperty))                
                {
                    //selElement.SelectByIndex(4);
                    propertyFound = true;
                    //propertyElement.Click();
                    //break;
                }
            }

            //selProperty.SendKeys(selectProperty);
            //selectTenant.SendKeys(selTenant);
            bool tenantFound = true;
            if (propertyFound == true)
            {
                foreach (IWebElement tenantElement in selectTenant.Options)
                {
                    if (tenantElement.Text.Contains(selTenant))
                    {
                        tenantFound = true;
                        tenantElement.Click();
                        break;
                    }
                }
            }

            if (tenantFound == true)
            {

                dueDateInput.SendKeys(dueDate.ToString());
                descriptionInput.SendKeys(description);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
