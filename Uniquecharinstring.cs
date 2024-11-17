public class Solution {
    public int FirstUniqChar(string s) {
        var freq = new int[26];
        foreach (var c in s)
            freq[c - 'a']++;
        for(var i=0; i< s.Length; i++)
           if(freq[s[i]-'a']==1) return i;

           return -1;
    }
}
