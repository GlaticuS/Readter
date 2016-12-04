using System;
using System.Windows.Forms;

// REST API
using Tweetinvi;
using Tweetinvi.Models;

namespace ReadteR
{
    /// <summary>
    /// Класс для входа в приложение через свой аккаунт в Твиттере.
    /// </summary>
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Уникальный код, получаемый через браузер для входа в приложение.
        /// </summary>
        public string pinCode;

        public IAuthenticationContext authenticationContext { get; private set; }
        public ITwitterCredentials userCredentials;

        /// <summary>
        /// Конструктор класса. Инициализирует данные приложения и заходит в бразер на вкладку с аутентификацией.
        /// </summary>
        public LoginForm()
        {
            Secret secrets = new Secret();
            InitializeComponent();
            // Create a new set of credentials for the application.
            var appCredentials = new TwitterCredentials(secrets.CONSUMER_KEY, secrets.CONSUMER_SECRET);

            // Init the authentication process and store the related `AuthenticationContext`.
            authenticationContext = AuthFlow.InitAuthentication(appCredentials);

            // Go to the URL so that Twitter authenticates the user and gives him a PIN code.
            System.Diagnostics.Process.Start(authenticationContext.AuthorizationURL);

        }

        private void PINBox_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// При нажатии на кнопку "Войти!" данные из текстового поля передаются на проверку системе
        /// аутентификации Твиттера. Если пинкод верен, переходим в окно приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            pinCode = PINBox.Text;

            // With this pin code it is now possible to get the credentials back from Twitter                
            userCredentials = AuthFlow.CreateCredentialsFromVerifierCode(pinCode, authenticationContext);

            // Use the user credentials in your application
            Auth.SetCredentials(userCredentials);

            GeneralWindow nextWindow = new GeneralWindow(userCredentials);
            nextWindow.Show();
        }

    }
}
