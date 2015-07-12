using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string word = Console.ReadLine();
        Dictionary<char, int> occurences = new Dictionary<char, int> ();
        string output;

        foreach(char letter in word)
        {
            if(occurences.ContainsKey(letter))
            {
                 occurences[letter]++;  
            }
            else
            {
                 occurences[letter] = 1;       
            }
        }
        
        if(occurences.Count == 1)
        {
            //corner case: words consisting of only single letter (can have multiple occurences) always a palindrome
            output = "YES";
        }
        else
        {
            bool hasOddNumberOfLetters = word.Length % 2 == 1;
            int lettersWithOddOccurences = 0;

            foreach(KeyValuePair<char, int> letter in occurences)
            {
                //Console.WriteLine(letter.Key + ": " + letter.Value);  
                if(letter.Value % 2 == 1)
                {
                    lettersWithOddOccurences++;
                }
            }
            

            if(hasOddNumberOfLetters)
            {
               output = lettersWithOddOccurences == 1 ? "YES": "NO";
            }
            else
            {
                output = lettersWithOddOccurences == 0 ? "YES": "NO";
            }
        }
        
        Console.WriteLine(output);
    }
}