using System;

namespace WordCounter.Models
{
  public class WordCounterClass
  {
    private string _word;
    private string _sentence;
    private int _count;

    public WordCounterClass (string word, string sentence, int count)
    {
      _word = word;
      _sentence = sentence;
      _count = count;
    }

    public string GetWord()
    {
      return _word;
    }


  }
}
