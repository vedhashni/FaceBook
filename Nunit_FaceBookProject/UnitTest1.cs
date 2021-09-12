using NUnit.Framework;

namespace Nunit_FaceBookProject
{
    public class Tests:Base.BaseClass
    {
        [Test, Order(0)]
        public void InputValuesFor_SignUp()
        {
            WebPages.RegisterClass.SignUpintoFacebookWithClass(driver);
        }


        [Test, Order(1)]
        public void InputEmailAndPassword_into_InputFields()
        {
            WebPages_Actions.LoginPageActions.TitleAfterLaunching(driver);
            WebPages_Actions.LoginPageActions.LoginToFacebook(driver);
            
        }
}
}