using OpenQA.Selenium;
using Nunit_FaceBookProject.WebPages;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using AutoItX3Lib;


namespace Nunit_FaceBookProject.WebPages_Actions
{
    public class LoginPageActions
    {
        public static LoginPage login;
        public static Actions notify;

        //Used to check title given and retived are same
        public static void TitleAfterLaunching(IWebDriver driver)
        {
            string title1 = "Facebook - உள்நுழையவும் அல்லது பதிவுசெய்யவும்";
            string title = driver.Title;
            //AreEqual is used to compare expected and actual result
            Assert.AreEqual(title1, title);
        }

        //Used for implementing login operations
        public static void LoginToFacebook(IWebDriver driver)
        {
            login = new LoginPage(driver);
            //By using sendkeys the value is sended into the field
            login.email.SendKeys("9843801062");
            System.Threading.Thread.Sleep(1000);
            //By using sendkeys the value is sended into the field
            login.password.SendKeys("Velskar@1");
            System.Threading.Thread.Sleep(1000);
            login.loginbutton.Click();
            System.Threading.Thread.Sleep(10000);
            //Is used to escape the notification in facebook after login
            notify = new Actions(driver);
            notify.SendKeys(Keys.Escape).Build().Perform();
            System.Threading.Thread.Sleep(10000);
            login.home.Click();
            System.Threading.Thread.Sleep(9000);
            login.createpost.Click();
            System.Threading.Thread.Sleep(9000);
            login.message.SendKeys("Vacation Begins!!");
            System.Threading.Thread.Sleep(9000);
            login.photo.Click();
            System.Threading.Thread.Sleep(5000);
            login.addphoto.Click();
            System.Threading.Thread.Sleep(4000);
            //AutoIt- Handle Windows that do not belong to Browser
            AutoItX3 autoIt = new AutoItX3();
            //Activate so that next set of Action happen on this window
            autoIt.WinActivate("Open");
            //Upload an image
            autoIt.Send(@"C:\Users\vedhashni.v\Downloads\vacation.jpg");
            System.Threading.Thread.Sleep(2000);
            autoIt.Send("{Enter}");

            System.Threading.Thread.Sleep(4000);
            login.post.Click();
            System.Threading.Thread.Sleep(15000);
        }

        //Used to check title given and retived are same
        public static void TitleAfterLogin(IWebDriver driver)
        {
            string title1 = "Facebook";
            string title = driver.Title;
            //AreEqual is used to compare expected and actual result
            Assert.AreEqual(title1, title);
        }

    }
}
