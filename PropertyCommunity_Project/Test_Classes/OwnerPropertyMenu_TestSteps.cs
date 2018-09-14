using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using PropertyCommunity_Project.Page_Objects;

namespace PropertyCommunity_Project.Test_Classes
{
    [Binding]
    public class OwnerPropertyMenu_TestSteps
    {
        [Given(@"I have Login successfully using Property Owner Credentials")]
        public void GivenIHaveLoginSuccessfullyUsingPropertyOwnerCredentials()
        {
            OwnerProperty_Menu.Can_Do_Login();
        }
        
        [Given(@"I have redirected to the Dashboard page")]
        public void GivenIHaveRedirectedToTheDashboardPage()
        {
            String currentPageTitle = OwnerProperty_Menu.Can_getAfterLogin_pageTitle();
            String dashboardPageTitle = "Dashboard";
            Assert.AreEqual(dashboardPageTitle, currentPageTitle);
        }
        
        [When(@"I click on Owner and then Properties menu")]
        public void WhenIClickOnOwnerAndThenPropertiesMenu()
        {
            OwnerProperty_Menu.Can_Goto_MyProperty();
        }
        
        [Then(@"I should have redirected to the MyProperties page")]
        public void ThenIShouldHaveRedirectedToTheMyPropertiesPage()
        {
            String actualPageTitle = OwnerProperty_Menu.Check_MyProperty_Title();
            String expectedPageTitle = "Properties | Property Community";
            Assert.AreEqual(expectedPageTitle, actualPageTitle);
            OwnerProperty_Menu.CloseBrowser();
        }
    }
}
