using System;
using System.Collections.Generic;

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

    public bool CheckIfEmpty()
    {
      if (string.IsNullOrEmpty(_word) && string.IsNullOrEmpty(_sentence))
      {
        return true;
      }
       else
       {
          return false;
       }
    }

    public int Count()
    {
      int counter = 0;
      string lowerWord = _word.ToLower();
      string lowerSentence = _sentence.ToLower();
      string[] wordsinSentence = lowerSentence.Split(' ', '.', ',', '!', '?', '/', ';');
      foreach(var element in wordsinSentence)
      {
          if(lowerWord == element)
          {
            counter++;
          }
      }
      return counter;
    }


  }
}
