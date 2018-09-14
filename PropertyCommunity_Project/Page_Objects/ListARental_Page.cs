using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PropertyCommunity_Project.Common_Classes;
using PropertyCommunity_Project.DataDriven;
using System;
using System.Text;
using System.Threading;


namespace PropertyCommunity_Project.Page_Objects
{
    class ListARental_Page
    {
        public static void Can_Open_RentalPage()
        {
            //BrowserUtility.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(5000);
            IWebElement listARentalButton = Browser.Instance.FindElement(By.LinkText("List A Rental"));

            listARentalButton.Click();
        }

        public static bool Can_Enter_Input()
        {
            Thread.Sleep(2000);

            SelectElement selElement = new SelectElement(Browser.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div.field > select")));
                                                                                                     
            IWebElement titleInput = Browser.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(4) > div:nth-child(1) > input[type='text']:nth-child(2)"));
            IWebElement movingCostInput = Browser.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(4) > div:nth-child(1) > input[type='text']:nth-child(6)"));
            IWebElement targetRentInput = Browser.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(5) > div:nth-child(1) > input[type='text']"));
            IWebElement availableDateInput = Browser.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(6) > div:nth-child(1) > input[type='text']"));

            IWebElement occupantsCountInput = Browser.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(7) > div:nth-child(1) > input[type='text']"));
            IWebElement descriptionInput = Browser.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(4) > div:nth-child(2) > textarea"));

            List_A_Rental_Excel excelData = new List_A_Rental_Excel();
            List_A_Rental_Excel.getRentalInput();
            String rentalProperty = List_A_Rental_Excel.selectProperty;
            String title = List_A_Rental_Excel.title;
            int movingCost = List_A_Rental_Excel.movingCost;
            int targetRent = List_A_Rental_Excel.targetRent;
            DateTime availableDate = List_A_Rental_Excel.availableDate;
            int occupantsCount = List_A_Rental_Excel.occupantsCount;
            String description = List_A_Rental_Excel.description;
            List_A_Rental_Excel.closeAllObject();
            //"50 Nelson, Penshurst, Sydney, 3333";
            bool rentalPropertyFound = false;
            foreach (IWebElement rentalElement in selElement.Options)
            {
                if (rentalElement.Text == rentalProperty)
                {
                    rentalPropertyFound = true;
                    rentalElement.Click();
                    break;
                }
            }

            if (rentalPropertyFound == true)
            {
                titleInput.SendKeys(title);
                movingCostInput.SendKeys(movingCost.ToString());
                targetRentInput.SendKeys(targetRent.ToString());
                availableDateInput.SendKeys(availableDate.ToString());
                occupantsCountInput.SendKeys(occupantsCount.ToString());
                descriptionInput.SendKeys(description.ToString());
                return true;
            }
            else
            {
                return false;
            }

            //-----------------------------------------------------------------------

        }

        public static Boolean Can_Save_All_Input()
        {
            IWebElement saveButton = Browser.Instance.FindElement(By.CssSelector("#main-content > div > form > fieldset > div.ui.grid > div > button.teal.ui.button"));
            if (saveButton.Enabled == true)
            {
                saveButton.Click();
                Browser.Instance.SwitchTo().Alert().Accept();
                return true;
            }
            else
                return false;


        }

        public static string returnPageTitleAfterSave()
        {
            String rentalListingPageTitle = "";
            //BrowserUtility.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            WebDriverWait waitForElement = new WebDriverWait(Browser.Instance, TimeSpan.FromSeconds(30));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#main-content > div.container.segment > div:nth-child(1) > div.highlighted > div > div.middle.aligned.eight.wide.column > a")));
            rentalListingPageTitle = Browser.Instance.Title;
            return (rentalListingPageTitle);

        }

        public static void CloseBrowser()
        {
            Browser.CloseBrowser();
        }
    }
}
