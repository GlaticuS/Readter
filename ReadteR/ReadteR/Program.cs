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
        const string CONSUMER_KEY = "3feLvf1UVIf9mWbGK1fPuJ4kS";
        const string CONSUMER_SECRET = "XAhlpKVGwy5Ql7KRIx2TUDXZ8nZfX46gV5xbZGpZ1HnFpzPmzA";
        const string ACCESS_TOKEN = "701407404-FqEYE8BVx3JWqk45p6daYznhJPHoeoerPW4HPs5h";
        const string ACCESS_TOKEN_SECRET = "6IEaNqxFlPdaz2LJdYeZPbktd76nUQpAHF8qia8wlL8da";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Auth.SetUserCredentials(CONSUMER_KEY, CONSUMER_SECRET, ACCESS_TOKEN, ACCESS_TOKEN_SECRET);

            var user = User.GetAuthenticatedUser();
            Auth.ApplicationCredentials = new TwitterCredentials(CONSUMER_KEY, CONSUMER_SECRET, ACCESS_TOKEN, ACCESS_TOKEN_SECRET);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());


        }
    }
}
