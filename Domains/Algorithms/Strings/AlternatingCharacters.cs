using System;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int cases = Convert.ToInt32(Console.ReadLine());
        while(cases-- > 0)
        {
            int deletions = 0;
            string word = Console.ReadLine().Trim();
            char lastLetter = '\0';
            
            foreach(char letter in word)
            {
                if(letter == lastLetter)
                    deletions++;
                
                lastLetter = letter;
            }       
            
            Console.WriteLine(deletions);
        }
    }
}