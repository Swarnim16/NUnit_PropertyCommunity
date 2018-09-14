using PropertyCommunity_Project.Page_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyCommunity_Project.Common_Classes
{
    class Base
    {
        public static void Do_Login()
        {
            //BrowserUtility.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            String userName = "vincent.nguyen@mvpstudio.co.nz";
            String password = "ntmv2682";
            Login_Page.Go_To_Login_Page();
            Login_Page.Enter_LoginData(userName, password);
            Login_Page.Can_Click_Login();
            Browser.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

        }

        public static void Tear_Down()
        {
            Browser.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Browser.CloseBrowser();
        }
    }
}
