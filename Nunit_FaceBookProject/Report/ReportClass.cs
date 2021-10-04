using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nunit_FaceBookProject.Report
{
    public class ReportClass
    {
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentReports extent;
        public static ExtentTest test;

        public static ExtentReports report()
        {

            if (extent == null)
            {

                string reportPath = @"C:\Users\vedhashni.v\source\repos\Nunit_FaceBookProject\Nunit_FaceBookProject\Report\FaceBookReport.html";
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS", "Windows");
                extent.AddSystemInfo("UserName", "vedhashni");
                extent.AddSystemInfo("ProviderName", "vedhashni");
                extent.AddSystemInfo("Domain", "QA");
                extent.AddSystemInfo("ProjectName", "FaceBook Automation");
                string conifgPath = @"C:\Users\vedhashni.v\source\repos\Nunit_FaceBookProject\Nunit_FaceBookProject\Report\extent-congig.xml";
                htmlReporter.LoadConfig(conifgPath);
            }
            return extent;
        }
    }
}
