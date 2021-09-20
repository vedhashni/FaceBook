using NUnit.Framework;

namespace Nunit_FaceBookProject
{
    public class Tests:Base.BaseClass
    {
        //Used to test the signup button/registration process
        //[Test, Order(0)]
        //public void TestMethodForSignUpIntoFaceBook()
        //{
        //    WebPages.RegisterPage.SignUpintoFacebookWithClass(driver);
        //}

        //Used to test the login operation
        [Test, Order(1)]
        public void TestMethodForLoginIntoFaceBook()
        {
            WebPages_Actions.LoginPageActions.TitleAfterLaunching(driver);
            WebPages_Actions.LoginPageActions.LoginToFacebook(driver);

        }

        ////Used to test after login went to dashbord
        //[Test, Order(2)]
        //public void TestMethodForAfterLoginIntoDashBoard()
        //{
        //    WebPages_Actions.LoginPageActions.LoginToFacebook(driver);
        //    WebPages_Actions.LoginPageActions.TitleAfterLogin(driver);
        //}
    }
}