using System;

class Program
{
    static void Main(string[] args)
    {
	string word = "Holberton";
	string word_first_3 = word.Substring(0,3);
    string word_last_2 = word.Substring(7,2);
    string middle_word = word.Substring(1,7);
    Console.WriteLine("First 3 letters: {0}", word_first_3);
	Console.WriteLine("Last 2 letters: {0}", word_last_2);
	Console.WriteLine("Middle word: {0}", middle_word);
    }
}
