using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// REST API
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

namespace ReadteR
{
    public partial class LoginForm : Form
    {
        const string CONSUMER_KEY = "3feLvf1UVIf9mWbGK1fPuJ4kS";
        const string CONSUMER_SECRET = "XAhlpKVGwy5Ql7KRIx2TUDXZ8nZfX46gV5xbZGpZ1HnFpzPmzA";
        const string ACCESS_TOKEN = "701407404-FqEYE8BVx3JWqk45p6daYznhJPHoeoerPW4HPs5h";
        const string ACCESS_TOKEN_SECRET = "6IEaNqxFlPdaz2LJdYeZPbktd76nUQpAHF8qia8wlL8da";
        public string pinCode;

        public IAuthenticationContext authenticationContext { get; private set; }
        public ITwitterCredentials userCredentials;

        public LoginForm()
        {
            InitializeComponent();
            // Create a new set of credentials for the application.
            var appCredentials = new TwitterCredentials(CONSUMER_KEY, CONSUMER_SECRET);

            // Init the authentication process and store the related `AuthenticationContext`.
            authenticationContext = AuthFlow.InitAuthentication(appCredentials);

            // Go to the URL so that Twitter authenticates the user and gives him a PIN code.
            System.Diagnostics.Process.Start(authenticationContext.AuthorizationURL);

        }

        private void PINBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            pinCode = PINBox.Text;

            // With this pin code it is now possible to get the credentials back from Twitter                
            userCredentials = AuthFlow.CreateCredentialsFromVerifierCode(pinCode, authenticationContext);

            // Use the user credentials in your application
            Auth.SetCredentials(userCredentials);

           // Hide();
            GeneralWindow nextWindow = new GeneralWindow(userCredentials);
            nextWindow.Show();
        }

    }
}
