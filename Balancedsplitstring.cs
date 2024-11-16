
using System.Text;

public class Solution {
    public int RestoreString(string s)
    {
       int l=0,r=0,count=0;
        for(int i=0; i<s.Length;i++){
            if(s[i] == 'R'){
                r++;
            }
            else
            {
                l++;
            }
            if(r==l){
                count++;
                r=0;l=0;
            }
        }
        return count;
    }
    public static void Main()
    {
        Solution result = new Solution();
        int[] voulme1 = new int[]{2,1,4,3};
        int[] volumes2 = new int[] { 1, 4, 3, 2, 5 } ;
        int books = result.RestoreString("RLRRLLRLRL");
        Console.WriteLine(books);

    }
}