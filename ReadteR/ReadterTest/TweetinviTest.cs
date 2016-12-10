using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ReadteR;
using Tweetinvi;
using Tweetinvi.Models;

namespace ReadterTest
{
    /* Тестирование корректной работы используемой библиотеки. */
    [TestClass]
    public class TweetinviTest
    {
        // Проходит ли аутентификация правильно, если да, то имя пользователя совпадет с ожидаемым.
        [TestMethod]
        public void NameGetting()
        {
            Secret secrets = new Secret();     
            ITwitterCredentials testCredentials = new TwitterCredentials(secrets.CONSUMER_KEY, secrets.CONSUMER_SECRET, secrets.ACCESS_TOKEN, secrets.ACCESS_TOKEN_SECRET);
            Auth.SetCredentials(testCredentials);
            var authenticatedUser = User.GetAuthenticatedUser();

            Assert.AreEqual("GlaticuS", authenticatedUser.ScreenName);
        }

        // Загрузка ленты твитов пользователя. У тестового пользователя она не пустая.
        [TestMethod]
        public void UserTimeLineTest()
        {
            Secret secrets = new Secret();
            ITwitterCredentials testCredentials = new TwitterCredentials(secrets.CONSUMER_KEY, secrets.CONSUMER_SECRET, secrets.ACCESS_TOKEN, secrets.ACCESS_TOKEN_SECRET);
            Auth.SetCredentials(testCredentials);
            var authenticatedUser = User.GetAuthenticatedUser();
            var userTweets = Timeline.GetUserTimeline(authenticatedUser);

            Assert.IsNotNull(userTweets);
        }
    }
}
