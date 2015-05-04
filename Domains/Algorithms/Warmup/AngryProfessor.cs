using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        int cases = Int32.Parse(Console.ReadLine());
        while(cases-- > 0)
        {
            string[] testData = Console.ReadLine().Split();
            int studentsRequired = Int32.Parse(testData[1]);
            int studentsOnTime = Console.ReadLine().Split().Count(n => Int32.Parse(n) <=0);
            
            if(studentsOnTime >= studentsRequired)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
            
        }
    }
}