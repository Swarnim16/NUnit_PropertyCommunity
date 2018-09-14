using NUnit.Framework;
using PropertyCommunity_Project.Page_Objects;
using System;
using TechTalk.SpecFlow;

namespace PropertyCommunity_Project.Test_Classes
{
    [Binding]
    public class LoginTestSteps
    {
        [Given(@"I have opened the Login page")]
        public void GivenIHaveOpenedTheLoginPage()
        {
            Login_Page.Go_To_Login_Page();
        }
        
        [Given(@"I have entered valid (.*), valid (.*)")]
        public void GivenIHaveEnteredValidVincent_NguyenMvpstudio_Co_NzValidNtmv(String userName, String password)
        {
            Login_Page.Can_Enter_LoginData(userName, password);
        }
        
        [When(@"I click on Login button")]
        public void WhenIClickOnLoginButton()
        {
            Login_Page.Can_Click_Login();
        }
        
        [Then(@"the Dashboard page should open")]
        public void ThenTheDashboardPageShouldOpen()
        {
            string title = Login_Page.Return_Title();

            Assert.AreEqual("Dashboard", title);
        }
        
        [Then(@"I should able to do Logout")]
        public void ThenIShouldAbleToDoLogout()
        {
            Login_Page.Can_Do_Logout();
        }
    }
}
