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
          WordCounterClass newWord = new WordCounterClass("hi", "", 1);
          Assert.AreEqual(typeof(WordCounterClass), newWord.GetType());
        }

        [TestMethod]
        public void GetWord_ReturnsWord_String()
        {
          //Arrange
          string word = "hello";
          WordCounterClass newWord = new WordCounterClass(word, "", 1);
          //Act
          string result = newWord.GetWord();
          //Assert
          Assert.AreEqual(word, result);

        }
    }
}
