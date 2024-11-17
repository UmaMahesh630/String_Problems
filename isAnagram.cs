
/*Given two strings s and t, return true if t is an 
anagram
 of s, and false otherwise.

 

Example 1:

Input: s = "anagram", t = "nagaram"

Output: true
*/
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        int[] anagram = new int[26];

        foreach(char c in s) {
            anagram[c-'a']++;
        }
        foreach(char c in t) {
            if(anagram[c-'a'] > 0){
                anagram[c-'a']--;
            }
            else
            {
                return false;
            }
        
        }
        return true;
    }
}