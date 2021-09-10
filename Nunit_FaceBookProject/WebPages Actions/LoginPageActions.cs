using OpenQA.Selenium;
using Nunit_FaceBookProject.WebPages;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace Nunit_FaceBookProject.WebPages_Actions
{
    public class LoginPageActions
    {
        public static LoginPage login;
        public static Actions notify;
        public static void TitleAfterLaunching(IWebDriver driver)
        {
            string title1 = "Facebook - உள்நுழையவும் அல்லது பதிவுசெய்யவும்";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        public static void LoginToFacebook(IWebDriver driver)
        {
            login = new LoginPage(driver);
            login.email.SendKeys("9843801062");
            System.Threading.Thread.Sleep(1000);
            login.password.SendKeys("Velskar@1");
            System.Threading.Thread.Sleep(1000);
            login.loginbutton.Click();
            System.Threading.Thread.Sleep(10000);
            notify = new Actions(driver);
            notify.SendKeys(Keys.Escape).Build().Perform();
            System.Threading.Thread.Sleep(10000);
            login.home.Click();
            System.Threading.Thread.Sleep(11000);
            //login.photo.Click();
            //System.Threading.Thread.Sleep(9000);

        }
       
    }
}
