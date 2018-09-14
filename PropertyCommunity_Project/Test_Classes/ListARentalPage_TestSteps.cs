using NUnit.Framework;
using PropertyCommunity_Project.Common_Classes;
using PropertyCommunity_Project.Page_Objects;
using System;
using TechTalk.SpecFlow;

namespace PropertyCommunity_Project.Test_Classes
{
    [Binding]
    public class ListARentalPage_TestSteps
    {
        [Given(@"I have logged in successfully using Property Owner Credentials")]
        public void GivenIHaveLoggedInSuccessfullyUsingPropertyOwnerCredentials()
        {
            Base.Do_Login();
        }
        
        [Given(@"I have redirected to the Property page")]
        public void GivenIHaveRedirectedToThePropertyPage()
        {
            OwnerProperty_Menu.Can_getAfterLogin_pageTitle();
            OwnerProperty_Menu.Can_Goto_MyProperty();
            OwnerProperty_Menu.Check_MyProperty_Title();
        }
        
        [When(@"I clicked the List A Rental button")]
        public void WhenIClickedTheListARentalButton()
        {
            ListARental_Page.Can_Open_RentalPage();
        }
        
        [When(@"I entered valid values into List Rental Property page")]
        public void WhenIEnteredValidValuesIntoListRentalPropertyPage()
        {
            bool propertyFound = ListARental_Page.Can_Enter_Input();
            //Assert.AreEqual(propertyFound, false);
        }
        
        [When(@"I clicked the Save button")]
        public void WhenIClickedTheSaveButton()
        {
            Boolean saveButtonIsEnable = true;
            saveButtonIsEnable = ListARental_Page.Can_Save_All_Input();
            Assert.AreEqual(saveButtonIsEnable, true);
        }
        
        [Then(@"successfull save message should deisplay")]
        public void ThenSuccessfullSaveMessageShouldDeisplay()
        {
            String expectedTitle = "Rental Listings";
            String actualTitle = ListARental_Page.returnPageTitleAfterSave();
            Assert.AreEqual(expectedTitle, actualTitle);
            ListARental_Page.CloseBrowser();
        }
    }
}
