using System;
using TechTalk.SpecFlow;
using PropertyCommunity_Project.Sprint1.Page_Objects;
using NUnit.Framework;
using PropertyCommunity_Project.Common_Classes;

namespace PropertyCommunity_Project.Sprint1.Test_Scripts
{
    [Binding]
    public class Owner_Inspections_Module_TestSteps
    {
        Property_Owner_InspectionPage InspectionPageObj = new Property_Owner_InspectionPage();

        [Given(@"I have logged in successfully using Owner Credentials")]
        public void GivenIHaveLoggedInSuccessfullyUsingOwnerCredentials()
        {
            InspectionPageObj.Can_Do_Login();
        }
        
        [Given(@"I have redirected to Dashboard page")]
        public void GivenIHaveRedirectedToDashboardPage()
        {            
            String actualPageTitle= InspectionPageObj.Can_getAfterLogin_pageTitle();
            String expectedPageTitle= "Dashboard";
            Assert.AreEqual(expectedPageTitle, actualPageTitle);
        }
        
        [Given(@"I have redirected to the Inspection page")]
        public void GivenIHaveRedirectedToTheInspectionPage()
        {
            String expectedTitle = "Properties | Inspections";
            String actualTitle = InspectionPageObj.Can_OpenInspectionPage();
            Assert.AreEqual(actualTitle, expectedTitle);
        }
        
        [When(@"I clicked the Detail button")]
        public void WhenIClickedTheDetailButton()
        {
            InspectionPageObj.Can_Click_Deatails_Btn();
        }
        
        [Then(@"new page should open about the inspection detail")]
        public void ThenNewPageShouldOpenAboutTheInspectionDetail()
        {
            String expectedTitle = "Properties | Inspections";
            String actualTitle = Browser.ReturnTitle();
            Assert.AreEqual(actualTitle, expectedTitle);
            InspectionPageObj.CloseBrowser();
        }
    }
}
