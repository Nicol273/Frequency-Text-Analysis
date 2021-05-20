/*
 * Created by SharpDevelop.
 * User: Nicol
 * Date: 20.5.2021 г.
 * Time: 22:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace dictionary
{
	class Program
	{
		public static void Main(string[] args)
		{
			string line;
			char[] separators = {' ', '.', ',', '-', '?', '!', '"'};
			SortedDictionary<string,int> allWordsCounter = new SortedDictionary<string, int>();
			do
			{
				Console.Write(">>> ");
				line = Console.ReadLine().ToLower();
				string[] wordsInThisLine = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
				foreach(string word in wordsInThisLine)
				{
					if(!allWordsCounter.ContainsKey(word)) allWordsCounter.Add(word, 1);
					else allWordsCounter[word] ++;
				}
			}
			while(line != "");
			Console.WriteLine("Използвани думи:");
			foreach(KeyValuePair<string,int> pair in allWordsCounter)
			{
				Console.WriteLine("Думата '{0}' се среща {1} път/и", pair.Key, pair.Value);
			}
			Console.ReadKey(true);
		}
	}
}