using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string text = Console.ReadLine();
            task2(text);
        }

        static void task2(string s)
        {
            IDictionary<string, int> numWord = new Dictionary<string, int>();
            Regex regex = new Regex(@"[a-zA-Z][a-zA-Z']*");
            MatchCollection formatMatch = regex.Matches(s);
            foreach (Match match in formatMatch)
            {
                try
                {
                    numWord.Add(match.Value, 1);
                }
                catch
                {
                    numWord[match.Value] += 1;
                }
            }
            string[] arr = new string[numWord.Count];
            numWord.Keys.CopyTo(arr, 0);

            if (numWord.Count < 3)
            {
                Array.Clear(arr, 0, arr.Length);
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(numWord.OrderByDescending(key => key.Value).ElementAt(i).Key.ToLower());
                }
            }
        }
    }
}
