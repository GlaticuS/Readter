using System;
using System.Windows.Forms;

// REST API
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;


namespace ReadteR
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Secret secrets = new Secret();
            Auth.SetUserCredentials(secrets.CONSUMER_KEY, secrets.CONSUMER_SECRET, secrets.ACCESS_TOKEN, secrets.ACCESS_TOKEN_SECRET);

            var user = User.GetAuthenticatedUser();
            Auth.ApplicationCredentials = new TwitterCredentials(secrets.CONSUMER_KEY, secrets.CONSUMER_SECRET, secrets.ACCESS_TOKEN, secrets.ACCESS_TOKEN_SECRET);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());


        }
    }
}
