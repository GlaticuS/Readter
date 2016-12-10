using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ReadteR;
// REST API
using Tweetinvi;
using Tweetinvi.Models;

namespace ReadterTest
{
    /// <summary>
    /// <c>GeneralWindowTest</c> будет проверять, правильно ли загружаются элементы в текстовых полях окна
    /// </summary>
    [TestClass]
    public class GeneralWindowTest
    {
        public GeneralWindowTest()
        {
            //
            // TODO: добавьте здесь логику конструктора
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            Secret secrets = new Secret();
            //Auth.SetUserCredentials(secrets.CONSUMER_KEY, secrets.CONSUMER_SECRET, secrets.ACCESS_TOKEN, secrets.ACCESS_TOKEN_SECRET);
            ITwitterCredentials testCredentials = new TwitterCredentials(secrets.CONSUMER_KEY, secrets.CONSUMER_SECRET, secrets.ACCESS_TOKEN, secrets.ACCESS_TOKEN_SECRET);
            GeneralWindow nextWindow = new GeneralWindow(testCredentials);
            //var authenticatedUser = User.GetAuthenticatedUser();
        }
        #region Дополнительные атрибуты тестирования
        //
        // При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        // ClassInitialize используется для выполнения кода до запуска первого теста в классе
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // TestInitialize используется для выполнения кода перед запуском каждого теста 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // TestCleanup используется для выполнения кода после завершения каждого теста
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void GetUserName()
        {
            GeneralWindow nextWindow = new GeneralWindow(testCredentials);
        }
    }
}
