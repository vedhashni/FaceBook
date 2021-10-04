using AventStack.ExtentReports;
using NUnit.Framework;
using Nunit_FaceBookProject.ActionDo;
using Nunit_FaceBookProject.Email;
using Nunit_FaceBookProject.Report;

namespace Nunit_FaceBookProject
{
    public class FaceBookTests:Base.BaseClass
    {
        public static DoAction pageaction;
        public static EmailClass email;
        ExtentReports report = ReportClass.report();
        ExtentTest test;

        [Test,Order(0)]
        public void TestMethodForSignUpIntoFaceBook()
        {
            pageaction = new DoAction();
            pageaction.RegisterIntoFaceBook();
        }

        [Test,Order(1)]
        public void TestMethodForLogIntoFaceBook()
        {
            test = report.CreateTest("FaceBookTests");
            test.Log(Status.Info, "FaceBook Automation");
            pageaction = new DoAction();
            pageaction.LoginToFaceBook();
            TakeScreenShot();
            System.Threading.Thread.Sleep(200);
            test.Info("ScreenShot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\vedhashni.v\source\repos\Nunit_FaceBookProject\Nunit_FaceBookProject\ScreenShots\FaceBookTest.png").Build());
            test.Log(Status.Pass, "TestCases Passed");
            report.Flush();
        }

        [Test,Order(2)]
        public void TestMethodForToUploadPhoto()
        {
            pageaction = new DoAction();
            pageaction.ToPostInFaceBook();
        }

        [Test,Order(3)]
        public void TestMethodForToLogoutFromFaceBook()
        {
            pageaction = new DoAction();
            pageaction.ToLogoutFromFaceBook();
        }

        [Test,Order(4)]
        public void TestMethodForInvalidLogin()
        {
            pageaction = new DoAction();
            pageaction.CheckInvalidLogin();
        }

        [Test,Order(5)]
        public void TestMethodForReportSendingThroughEmail()
        {
            email = new EmailClass();
            email.ToSendReportThroughEmail();
        }
    }
}