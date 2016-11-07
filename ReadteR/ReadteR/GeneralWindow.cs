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
    public partial class GeneralWindow : Form
    {
        public IAuthenticatedUser authenticatedUser;
        public GeneralWindow(ITwitterCredentials userCredentials)
        {
            authenticatedUser = User.GetAuthenticatedUser(userCredentials);
            //var tweet = Tweet.GetTweet(779706403107864576);
            //спроектировать заполнение формы !!!!!
            InitializeComponent();
            //tweetBox.Text = tweet.Text;
            userName.Text = authenticatedUser.ScreenName;
            var newsTweets = Timeline.GetHomeTimeline();
            var userTweets = Timeline.GetUserTimeline(authenticatedUser);
            foreach(var tweet in newsTweets)
            {
                newsBox.AppendText(tweet.Text + "\n");
            }
            foreach (var tweet in userTweets)
            {
                tweetBox.AppendText(tweet.Text + "\n");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
