using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void WordConstructor_CreatesInstanceOfWord_Word()
        {
          WordCounterClass newWord = new WordCounterClass("hi", "");
          Assert.AreEqual(typeof(WordCounterClass), newWord.GetType());
        }

        [TestMethod]
        public void GetWord_ReturnsWord_String()
        {
          //Arrange
          string word = "hello";
          WordCounterClass newWord = new WordCounterClass(word, "");
          //Act
          string result = newWord.GetWord();
          //Assert
          Assert.AreEqual(word, result);
        }

        [TestMethod]
        public void GetSentence_ReturnsSentence_String()
        {
          //Arrange
          string sentence = "hello hello";
          WordCounterClass newSentence = new WordCounterClass("", sentence);
          //Act
          string result = newSentence.GetSentence();
          //Assert
          Assert.AreEqual(sentence, result);
        }

        [TestMethod]
        public void Count_ReturnCount_Int()
        {
          string word = "hi";
          string sentence = "hi Hi";
          WordCounterClass testCheck = new WordCounterClass(word, sentence);
          int result = testCheck.Count();
          Assert.AreEqual(2, result);
        }
  }
}
