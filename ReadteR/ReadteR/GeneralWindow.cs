using System;
using System.Windows.Forms;

// REST API
using Tweetinvi;
using Tweetinvi.Models;


namespace ReadteR
{
    /// <summary>
    /// Класс для основного окна приложения, именно здесь и осуществляется большая часть функционала. 
    /// Первое поле отображает ленту твитов пользователя, поле посередине - новостную ленту, основанную на подписках
    /// пользователя, крайнее поле нужно для генерации твитов.
    /// </summary>
    public partial class GeneralWindow : Form
    {
        public IAuthenticatedUser authenticatedUser;
        public string homeTimeLine = "";
        /// <summary>
        ///         Функция для обработки данных пользователя, пришедших из окна логина. Конструктор класса.
        ///     <para>
        ///         Сначала происходит определение пользователя по его учётным данным, инициализируется окно и заполняется поле
        ///         с именем пользователя.
        ///     </para>
        ///     <para>
        ///         Определяется таймер (сейчас 30 секунд), с этой частотой окно приложения будет обновляться, отображая
        ///         изменения в ленте пользователя.
        ///     </para>
        /// </summary>
        /// <param name="userCredentials"> Учётные данные пользователя, получаемые в окне логина.</param>
        public GeneralWindow(ITwitterCredentials userCredentials)
        {
            if (userCredentials != null)
            {
                authenticatedUser = User.GetAuthenticatedUser(userCredentials);
            }
            else
            {
                Close();
            }

            InitializeComponent();
            userName.Text = authenticatedUser.Name;

              EventArgs e = null;
            //заполнить формы лентой пользователя и профилем пользователя
            getTimelines(this, e);

            Timer1.Interval = 30000;
            Timer1.Enabled = true;
            Timer1.Tick += new EventHandler(getTimelines);
           
        }

        /// <summary>
        ///     Обработчик события - функция для отображения новостной ленты и ленты твитов пользователя.
        ///     <para>
        ///         Порядок отображения:
        ///         <list type="string">
        ///         Не отображаются ретвиты;
        ///         В ленте новостей не отображаются твиты пользователя;
        ///         Твиты разделены между собой пустыми строками, содержат ссылки на контент.
        ///         </list>
        ///     </para>
        ///     
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Событие, в данном случае - тик таймера.</param>
        private void getTimelines(object sender, EventArgs e)
        {
            var newsTweets = Timeline.GetHomeTimeline();
            var userTweets = Timeline.GetUserTimeline(authenticatedUser);

            if (newsBox.Text != null)
                newsBox.Clear();

            if (tweetBox.Text != null)
                tweetBox.Clear();
            /*
             * Вся лента пользователя. Тут же производится и сбор текста для последующей его "очистки"
             * и генерации твита.
             */
            if(newsTweets != null && userTweets != null)
            {
                foreach (var tweet in newsTweets)       
                {
                    if(!tweet.IsRetweet && (tweet.CreatedBy.ToString() != authenticatedUser.ToString()))        //Не обрабатываем ретвиты
                    {
                        newsBox.AppendText(tweet.Text + "\n\n");
                        homeTimeLine += tweet.Text + "\n";
                    }
                }

                foreach (var tweet in userTweets)       //Просто отображение твитов пользователя
                {
                    if (!tweet.IsRetweet)
                    {
                        tweetBox.AppendText(tweet.Text + "\n\n");
                    }          
                }
            }
        }

        /// <summary>
        /// Экземпляр класса <c>MarkovChain</c> для генерации твита.
        /// </summary>
        MarkovChain markovChain = new MarkovChain();

        /// <summary>
        /// Переменная для сгенерированного твита.
        /// </summary>
        string output;

        /// <summary>
        ///     Действие при нажатии на кнопку <c>Сгенерировать!</c>
        ///     <para>
        ///         Загружаем для последующей обработки новостную ленту пользователя.
        ///         Затем получаем выходные данные и постим их в текстбоксе.
        ///     </para>
        /// </summary>
        private void generateButton_Click(object sender, EventArgs e)
        {
            markovChain.Load(homeTimeLine);             //Загружаем в марковскую цепь наш список твитов
            generationBox.Text = markovChain.Output();  //получаем выходные данные и постим их
            output = markovChain.Output();
        }

        /// <summary>
        ///     Действие при нажатии на кнопку <c>Твитнуть!</c>
        ///     <para>
        ///         Публикуем твит в веб-профиле залогинившегося пользователя.
        ///     </para>
        /// </summary>
        private void tweetButton_Click(object sender, EventArgs e)
        {
            var tweet = Tweet.PublishTweet(output);
        }

        private void GeneralWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
