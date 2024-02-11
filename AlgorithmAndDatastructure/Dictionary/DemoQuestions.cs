using System;
using System.Collections.Generic;

namespace AlgorithmAndDatastructure.Dictionary
{
	public class DemoQuestions
	{
		public DemoQuestions()
		{
		}

		// First non-repeated char in string
		public static char GetNonRepeatedChar(string s)
		{
			Dictionary<char, int> charsInDictionray = new Dictionary<char, int>();
			for (int i = 0; i <s.Length; i++)
			{

				if (charsInDictionray.ContainsKey(s[i]))
				{
					charsInDictionray[s[i]] = charsInDictionray.GetValueOrDefault(s[i]) + 1;
				}
				else
				{
					charsInDictionray.Add(s[i], 1);
				}
			}

			foreach (KeyValuePair<char, int> item in charsInDictionray)
			{
				if (item.Value == 1) return item.Key;
			}

			return char.MinValue;
		}

		// FirstRepeatedChar
		public static char FirstRepeatedChar(string s)
		{
			HashSet<char> chars = new HashSet<char>();
			for (int i = 0; i < s.Length; i++)
			{
				if (chars.Contains(s[i])) return s[i];
				chars.Add(s[i]);
			}

			return char.MinValue;
		}
	}
}

