using NUnit.Framework;

namespace Nunit_FaceBookProject
{
    public class Tests:Base.BaseClass
    {
        [Test, Order(0)]
        public void InputValuesFor_SignUp()
        {
            WebPages.RegisterClass.SignUpintoFacebook(driver);
        }


        [Test, Order(1)]
        public void InputEmailAndPassword_into_InputFields()
    {
        WebPages.LoginPage.AssertAfterLaunching(driver);
        WebPages.LoginPage.LoginToFacebook(driver);
    }
}
}