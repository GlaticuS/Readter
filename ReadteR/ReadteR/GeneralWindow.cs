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

// STREAM API
using Tweetinvi.Streaming;
using Stream = Tweetinvi.Stream;

// Others
using Tweetinvi.Exceptions; // Handle Exceptions
using Tweetinvi.Core.Extensions; // Extension methods provided by Tweetinvi
using Tweetinvi.Models.DTO; // Data Transfer Objects for Serialization
using Tweetinvi.Json; // JSON static classes to get json from Twitter.


namespace ReadteR
{
    public partial class GeneralWindow : Form
    {
        public IAuthenticatedUser authenticatedUser;
        public string homeTimeLine = "";
        public GeneralWindow(ITwitterCredentials userCredentials)
        {
            authenticatedUser = User.GetAuthenticatedUser(userCredentials);
            //спроектировать заполнение формы !!!!!
            InitializeComponent();
            userName.Text = authenticatedUser.ScreenName;

            //заполнить формы лентой пользователя и профилем пользователя
            getTimelines();
        }

        private void getTimelines()
        {
            var newsTweets = Timeline.GetHomeTimeline();
            var userTweets = Timeline.GetUserTimeline(authenticatedUser);
            
            /*
             * Вся лента пользователя. Тут же производится и сбор текста для последующей его "очистки"
             * и генерации твита.
             */
            foreach (var tweet in newsTweets)       
            {
                if(!tweet.IsRetweet)        //Не обрабатываем ретвиты
                {
                    newsBox.AppendText(tweet.Text + "\n\n");
                   // Console.WriteLine(tweet.Text + "\n");
                    homeTimeLine += tweet.Text + "\n";
                }
            }

            foreach (var tweet in userTweets)       //Просто отображение твитов пользователя
            {
                if (!tweet.IsRetweet)
                    tweetBox.AppendText(tweet.Text + "\n\n");
            }
            //Console.WriteLine(homeTimeLine);
        }

        MarkovChain markovChain = new MarkovChain();
        private void generateButton_Click(object sender, EventArgs e)
        {
            markovChain.Load(homeTimeLine);             //Загружаем в марковскую цепь наш список твитов
            generationBox.Text = markovChain.Output();  //получаем выходные данные и постим их
        }
    }
}
