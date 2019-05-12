using System;

namespace WordCounter.Models
{
  public class WordCounterClass
  {
    private string _word;
    private string _sentence;
    // private int _count;

    public WordCounterClass (string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
      // _count = count;
    }

    public string GetWord()
    {
      return _word;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public int Count()
    {
      int counter = 0;
      string lowerSentence = _sentence.ToLower();
      string[] wordsinSentence = lowerSentence.Split(' ');
      foreach(var element in wordsinSentence)
      {
          if(_word == element)
          {
            counter++;
          }
      }
      return counter;
    }


  }
}
