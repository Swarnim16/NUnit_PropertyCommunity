using NUnit.Framework;
using PropertyCommunity_Project.Common_Classes;
using PropertyCommunity_Project.Sprint1.Page_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyCommunity_Project.Sprint1.Test_Scripts
{
    [TestFixture]
    class Sprint2 : Base
    {
        Property_Owner_InspectionPage InspectionPageObj = new Property_Owner_InspectionPage();
        [Test]
        public void searchPropertyAtInspection()
        {
            Owner_Inspection_Menu inspectionMenuObj = new Owner_Inspection_Menu();


            Base.Do_Login();

            
            inspectionMenuObj.Can_Goto_Inspection();
            Browser.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            Thread.Sleep(2000);
            InspectionPageObj.Can_Search_Property();

            Base.Tear_Down();
        }
    }
}
