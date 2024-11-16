public class Solution {
    public string ToLowerCase(string s) {
        StringBuilder str = new StringBuilder();
        foreach(var item in s)
        {
            if(item >= 65 && item <= 90)
              str.Append((char)(item+32));
            else
              str.Append(item);
        }
        return str.ToString();
    }
}