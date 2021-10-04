using AutoItX3Lib;
using NUnit.Framework;
using Nunit_FaceBookProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace Nunit_FaceBookProject.ActionDo
{
    public class DoAction:Base.BaseClass
    {
        public static ExcelOperation excel;
        public static LoginPage login;
        public static HomePageData data;
        public static LogoutPage logout;
        public static SignUpPage sign;

        public void RegisterIntoFaceBook()
        {
            sign = new SignUpPage(driver);
            excel = new ExcelOperation();
            sign.createnewaccountbtn.Click();
            System.Threading.Thread.Sleep(1000);
            //Here we are reading the data from excel
            excel.PopulateFromExcel(@"C:\Users\vedhashni.v\source\repos\Nunit_FaceBookProject\Nunit_FaceBookProject\DataForTesting\ExcelData.xlsx");
            System.Threading.Thread.Sleep(1000);
            sign.FirstName.SendKeys(excel.ReadData(1, "FirstName"));
            sign.SurName.SendKeys(excel.ReadData(1, "SurName"));
            sign.Email.SendKeys(excel.ReadData(1, "EmailForSignUp"));
            sign.ReConfirmEmail.SendKeys(excel.ReadData(1, "ConfirmEmail"));
            sign.Password.SendKeys(excel.ReadData(1, "PasswordForSignUp"));
            SelectElement element = new SelectElement(sign.Date);
            Assert.IsFalse(element.IsMultiple);
            element.SelectByText("12");
            SelectElement element1 = new SelectElement(sign.Month);
            Assert.IsFalse(element.IsMultiple);
            element1.SelectByValue("1");
            SelectElement element2 = new SelectElement(sign.Year);
            Assert.IsFalse(element.IsMultiple);
            element2.SelectByValue("1999");
            sign.Gender.Click();
            Assert.IsTrue(sign.Gender.Enabled);
            sign.SignUp.Click();
            TakeScreenShot();
            System.Threading.Thread.Sleep(1000);
        }

        public void LoginToFaceBook()
        {
            excel = new ExcelOperation();
            login = new LoginPage(driver);
            if (login.logo.Displayed)
            {
                string title1 = "Facebook - உள்நுழையவும் அல்லது பதிவுசெய்யவும்";
                string title = driver.Title;
                //AreEqual is used to compare expected and actual result
                Assert.AreEqual(title1, title);
                //TakeScreenShot();
                //Here we are reading the data from excel
                excel.PopulateFromExcel(@"C:\Users\vedhashni.v\source\repos\Nunit_FaceBookProject\Nunit_FaceBookProject\DataForTesting\ExcelData.xlsx");
                //By invoking the readdate method values in table is retrived
                login.email.SendKeys(excel.ReadData(1, "Email"));
                //is used to wait in a particular page before taking another action
                System.Threading.Thread.Sleep(1000);
                //By invoking the readdate method values in table is retrived
                login.password.SendKeys(excel.ReadData(1, "Password"));
                System.Threading.Thread.Sleep(1000);
                if (login.email != null && login.password != null)
                {
                    login.loginbutton.Click();
                    System.Threading.Thread.Sleep(1000);
                    TakeScreenShot();
                    string title2 = "Facebook";
                    string title3 = driver.Title;
                    //AreEqual is used to compare expected and actual result
                    Assert.AreEqual(title2, title3);
                    Console.WriteLine("Successfully Logged In");
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Login Credential is not provided");
                }
            }
            else
            {
                Console.WriteLine("Browser is not launched");
            }
        }

        public void ToPostInFaceBook()
        {
            data = new HomePageData(driver);
            LoginToFaceBook();
            if (data.dashboard.Displayed)
            {
                data.home.Click();
                System.Threading.Thread.Sleep(9000);
                data.createpost.Click();
                //TakeScreenShot();
                System.Threading.Thread.Sleep(9000);
                data.message.SendKeys("Vacation Begins!!");
                System.Threading.Thread.Sleep(9000);
                data.photo.Click();
                System.Threading.Thread.Sleep(9000);
                data.addphoto.Click();
                System.Threading.Thread.Sleep(9000);
                //AutoIt- Handle Windows that do not belong to Browser
                AutoItX3 autoIt = new AutoItX3();
                autoIt.ControlFocus("Open", "", "Edit1");
                var picture = autoIt.ControlSetText("Open", "", "Edit1", @"C:\Users\vedhashni.v\Downloads\vacation.jpg");
                Assert.NotNull(picture);
                System.Threading.Thread.Sleep(3000);
                autoIt.ControlClick("Open", "", "Button1");
                System.Threading.Thread.Sleep(4000);
                data.post.Click();
                System.Threading.Thread.Sleep(1000);
                TakeScreenShot();
                if (data.successfulpost.Displayed)
                {
                    Console.WriteLine("Photo Uploaded successfully");
                }
                else
                {
                    Console.WriteLine("Photo Not Uploaded successfully");
                }
                ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0,1500)");
                System.Threading.Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Not Logged In");
            }
        }

        public void ToLogoutFromFaceBook()
        {
            logout = new LogoutPage(driver);
            ToPostInFaceBook();
            logout.accountbtn.Click();
            System.Threading.Thread.Sleep(2000);
            logout.logout.Click();
            TakeScreenShot();
            bool flag = logout.logoutsuccessful.Displayed;
            if (flag)
            {
                Console.WriteLine("Logout Successfully");
            }
            else
            {
                Console.WriteLine("Not Logout Successfully");
            }
        }

        public void CheckInvalidLogin()
        {
            excel = new ExcelOperation();
            login = new LoginPage(driver);
            excel.PopulateFromExcel(@"C:\Users\vedhashni.v\source\repos\Nunit_FaceBookProject\Nunit_FaceBookProject\DataForTesting\ExcelData.xlsx");
            login.email.SendKeys(excel.ReadData(2, "Email"));
            login.password.SendKeys(excel.ReadData(2, "Password"));
            login.loginbutton.Click();
            TakeScreenShot();
            Assert.IsTrue(login.alertmessage.Displayed);
        }
    }
}
