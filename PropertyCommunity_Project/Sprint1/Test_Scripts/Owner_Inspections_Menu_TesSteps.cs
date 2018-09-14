using System;
using TechTalk.SpecFlow;
using PropertyCommunity_Project.Sprint1.Page_Objects;
using NUnit.Framework;

namespace PropertyCommunity_Project.Sprint1_Inspection_.Test_Scripts
{
    [Binding]
    public class Owner_Inspections_Menu_TesSteps
    {
        Owner_Inspection_Menu InspectionMenuObj = new Owner_Inspection_Menu();

        [Given(@"I have Login successfully as Property Owner")]
        public void GivenIHaveLoginSuccessfullyAsPropertyOwner()
        {
            InspectionMenuObj.Can_Do_Login();
        }
        
        [Given(@"I am on the Dashboard page")]
        public void GivenIAmOnTheDashboardPage()
        {
            String currentPageTitle= InspectionMenuObj.Can_getAfterLogin_pageTitle();
            String dashboardPageTitle = "Dashboard";
            Assert.AreEqual(dashboardPageTitle, currentPageTitle);
        }
        
        [When(@"I click on Owner and then Inspection menu")]
        public void WhenIClickOnOwnerAndThenInspectionMenu()
        {
            InspectionMenuObj.Can_Goto_Inspection();
        }
        
        [Then(@"I should have redirected to the Inspections page")]
        public void ThenIShouldHaveRedirectedToTheInspectionsPage()
        {
            String currentPageTitle=InspectionMenuObj.Check_Inspection_Title();
            String inspectionPageTitle = "Properties | Inspections";
            Assert.AreEqual(inspectionPageTitle, currentPageTitle);

            InspectionMenuObj.CloseBrowser();
        }
    }
}
