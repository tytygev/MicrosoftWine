using System.Collections.Generic;

namespace MicrosoftWine.ParcerClasses
{
	public class WordsList
	{
		public List<Word> Words;

		public WordsList WordsListBuild(string text)
		{
			Words = new List<Word>();
			string[] words = text.Split(',');
			foreach (string item in words)
			{
				Word word = new Word(item);
				Words.Add(word);
			}
			return this;
		}
	}
}
