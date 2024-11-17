//Given a string S, return the number of substrings that have only one distinct letter.

/*Example 1:
Input: S = “aaaba”
Output: 8
Explanation: The substrings with one distinct letter are “aaa”, “aa”, “a”, “b”.
“aaa” occurs 1 time.
“aa” occurs 2 times.
“a” occurs 4 times.
“b” occurs 1 time.
So the answer is 1 + 2 + 4 + 1 = 8. */


using System.Text;

public class Solution {
    public int RestoreString(string s)
    {
       int i=0,j=0,count=0;
       int l = s.Length;
       while(i < l)
       {
        while((j<l) && s[j] == s[i])
        {
            j++;
            count++;
        }
           j= ++i;
       }
       return count;
    }
    public static void Main()
    {
        Solution result = new Solution();
        int[] voulme1 = new int[]{2,1,4,3};
        int[] volumes2 = new int[] { 1, 4, 3, 2, 5 } ;
        int books = result.RestoreString("aaaba");
        Console.WriteLine(books);

    }
}