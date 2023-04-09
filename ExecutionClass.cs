using System;
using System.Drawing;
using System.Security.Policy;
using System.Web.UI.WebControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.DevTools;
using static SeleniumMSTestReport.BaseClass;

namespace SeleniumMSTestReport

{
    [TestClass]
    public class ExecutionClass
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #region ObjectInitialization
        LoginClass loginClass = new LoginClass();
        // SearchPage searchPage = new SearchPage();
        #endregion       


        #region TestInitializationAndCleanUp
        [TestInitialize]
        public void TestInit()
        {
            
            DriverInit();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            DriverCLose();
        }
        #endregion

        #region LoginTestCases

        [TestMethod]
        [DataRow("https://adactinhotelapp.com/", "jabbasam", "123456")]
        public void LoginWithValidUserPass(string url, string user, string pass)
        {
            try
            {
                loginClass.LoginWithValid(url, user, pass);
                log.Info("Passed" + "Login done with valid User Pass");
            }
            catch (Exception ex)
            {
                log.Info("Failed!" + "Login failed with valid User Pass" + "Error:" + ex);
            }
        }

        [TestMethod]
        [DataRow("https://adactinhotelapp.com/", "jabbasam", "12345678")]
        public void LoginWithInValidUserPass(string url, string user, string pass)
        {

            loginClass.LoginWithInValid(url, user, pass);
        }

        #endregion
    }
}