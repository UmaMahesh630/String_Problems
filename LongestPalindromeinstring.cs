//{ Driver Code Starts
//Initial Template for C#


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode
{

    class GFG
    {
        static void Main(string[] args)
        {
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {
                string s = Console.ReadLine().Trim();
                Solution obj = new Solution();
                string res = obj.longestPalin(s);
                Console.Write(res);
                Console.Write("\n");
          }

        }
    }
}

// } Driver Code Ends


//User function Template for C#

class Solution
    {
        //Complete this function
        //Function to return a string representing the longest palindrome
        //that can be made by deleting one character from the given string.
        public string longestPalin(string s)
        {
            //Your code here
            if(s == null || s.Length < 1)
            {
                return "";
            }
            int start=0, maxlength=1;
            
            for(int i=0; i<s.Length;i++)
            {
               int len1 =  checkpalindrome(s,i,i);
               int len2 = checkpalindrome(s,i,i+1);
               
               int len = Math.Max(len1,len2);
               if(len > maxlength )
               {
                   maxlength = len;
                   start = i - (len-1)/2;
               }
                
            }
            return s.Substring(start,maxlength);
        }
        public int checkpalindrome(string str, int left,int right)
        {
            while(left >= 0 && right < str.Length && str[left] == str[right])
            {
                left--;
                right++;
            }
            return right-left-1;
            
        }

    }