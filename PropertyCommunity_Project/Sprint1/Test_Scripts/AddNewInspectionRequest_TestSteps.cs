using NUnit.Framework;
using PropertyCommunity_Project.Sprint1.Page_Objects;
using System;
using TechTalk.SpecFlow;

namespace PropertyCommunity_Project.Sprint1.Test_Scripts
{
    [Binding]
    public class AddNewInspectionRequest_TestSteps
    {
        //Property_Owner_InspectionPage InspectionPageObj = new Property_Owner_InspectionPage();
        Owner_Inspection_Menu InspectionMenuObj = new Owner_Inspection_Menu();
        AddInspectionRequestPage InspectionRequestPageObj = new AddInspectionRequestPage();

        [Given(@"I have login successfully using property owner credentials\.")]
        public void GivenIHaveLoginSuccessfullyUsingPropertyOwnerCredentials_()
        {
            InspectionMenuObj.Can_Do_Login();
        }
        
        [Given(@"I have redirected to dashboard page")]
        public void GivenIHaveRedirectedToDashboardPage()
        {
            //String actualPageTitle = InspectionPageObj.Can_getAfterLogin_pageTitle();
            //String expectedPageTitle = "Dashboard";
            //Assert.AreEqual(expectedPageTitle, actualPageTitle);

            String currentPageTitle = InspectionMenuObj.Can_getAfterLogin_pageTitle();
            String dashboardPageTitle = "Dashboard";
            Assert.AreEqual(dashboardPageTitle, currentPageTitle);
        }

        //[Given(@"I have redirected to the Inspection page")]
        //public void GivenIHaveRedirectedToTheInspectionPage()
        //{
        //    String expectedTitle = "Properties | Inspections";
        //    String actualTitle = InspectionPageObj.Can_OpenInspectionPage();
        //    Assert.AreEqual(actualTitle, expectedTitle);
        //}

        [Given(@"I have opened Inspection page from owner menu")]
        public void GivenIHaveOpenedInspectionPageFromOwnerMenu()
        {
            InspectionMenuObj.Can_Goto_Inspection();
            String currentPageTitle = InspectionMenuObj.Check_Inspection_Title();
            String inspectionPageTitle = "Properties | Inspections";
            Assert.AreEqual(inspectionPageTitle, currentPageTitle);
        }


        [When(@"I clicked the Add New Inspection Reuest button")]
        public void WhenIClickedTheAddNewInspectionReuestButton()
        {
            InspectionRequestPageObj.Can_ClickAddNewInspectionRequestButton();
        }
        
        [When(@"I redirected to the Inspection Request page")]
        public void WhenIRedirectedToTheInspectionRequestPage()
        {
            //Property Owner | Add New Request

            String currentPageTitle = InspectionRequestPageObj.Check_InspectionRequestPageTitle();
            String inspectionPageTitle = "Property Owner | Add New Request";
            Assert.AreEqual(inspectionPageTitle, currentPageTitle);
        }

        [When(@"I entered valid input values in all mandatory fields")]
        public void WhenIEnteredValidInputValuesInAllMandatoryFields()
        {
            Boolean IsAbleToEnter = InspectionRequestPageObj.Can_EnterInspectionRequestInput();
            Assert.AreEqual(IsAbleToEnter, true);
        }
        
        [When(@"I clicked Save button")]
        public void WhenIClickedSaveButton()
        {
           
        }
        
        [Then(@"the Property Inspection page should open")]
        public void ThenThePropertyInspectionPageShouldOpen()
        {
            InspectionMenuObj.CloseBrowser();
        }
    }
}
