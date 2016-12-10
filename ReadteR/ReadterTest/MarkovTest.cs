using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ReadteR;

namespace ReadterTest
{
    /* Класс тестов реализации алгоритма Марковских цепей, модифицированного под задачи приложения. */
    [TestClass]
    public class MarkovTest
    {
        // Даём на вход пустую строку.
        [TestMethod]
        public void EmptyString()
        {
            MarkovChain markovChain = new MarkovChain();
            markovChain.Load("");
            string output = markovChain.Output();
     
            Assert.AreEqual("", output);
        }

        // Проверка метода, который возводит первую букву строки в верхний регистр.
        [TestMethod]
        public void LetterUppering()
        {
            string lowerCaseString = "hello world";
            MarkovChain markovChain = new MarkovChain();
            string actual = markovChain.FirstLetterToUpper(lowerCaseString);

            Assert.AreEqual("Hello world", actual);
        }

        // При вводе маленького текста получаем такую же строку на выходе.
        [TestMethod]
        public void LittleTextTest()
        {
            string testText = "Hello, my beautiful world!";
            MarkovChain markovChain = new MarkovChain();
            markovChain.Load(testText);
            string output = markovChain.Output();

            bool contains = false;
            if(output.Contains("Hello, my beautiful world!"))
            {
                contains = true;
            }

            Assert.AreEqual(true, contains);
        }

        // Твиттер ограничивает размер твита 140 символами. Проверяется генерация текста длиной не более 140 символов.
        [TestMethod]
        public void TweetSizeTest()
        {
            string testText = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                               Duis id leo magna. Vestibulum eget accumsan ipsum, eget tristique leo.
                               Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.
                               Pellentesque et elementum elit. Sed pulvinar egestas mauris.";
            MarkovChain markovChain = new MarkovChain();
            markovChain.Load(testText);
            string output = markovChain.Output();

            bool size = false;
            if(output.Length <= 140)
            {
                size = true;
            }

            Assert.AreEqual(true, size);
        }
    }
}
