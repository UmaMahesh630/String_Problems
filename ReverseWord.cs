//{ Driver Code Starts
// Initial Template for C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode {

class GFG {
    static void Main(string[] args) {
        int testcases; // Taking testcase as input
        testcases = Convert.ToInt32(Console.ReadLine());
        while (testcases-- > 0) // Looping through all testcases
        {

            string s = Console.ReadLine().Trim();
            Solution obj = new Solution();
            string res = obj.reverseWords(s);
            Console.Write(res);
            Console.Write("\n");
        }
    }
}
}

// } Driver Code Ends


// User function Template for C#

class Solution {
    // Complete this function
    // Function to reverse words in a given string.
    public string reverseWords(string str) {
        // code here
        char[] chararray = str.ToCharArray();
        int n = chararray.Length;
        
        Reverse(chararray,0,n-1);
        
        int start=0;
        
        for(int i=0; i<n; i++)
        {
            if(chararray[i] == '.')
            {
                Reverse(chararray,start,i-1);
                start = i+1;
            }
        }
        
        Reverse(chararray,start,n-1);
        
        return new string(chararray);
        
    }
    static void Reverse(char[] charArray, int left, int right)
    {
        while (left < right)
        {
            // Swap the characters
            char temp = charArray[left];
            charArray[left] = charArray[right];
            charArray[right] = temp;
            left++;
            right--;
        }
    }
    
}