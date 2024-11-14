
using System.Text;

public class Solution {
    public string RemoveVowels(string target) {

          HashSet<char> set = new HashSet<char>();
          set.Add('a');
          set.Add('e');
          set.Add('i');
          set.Add('o');
          set.Add('u');
         StringBuilder str = new StringBuilder();
          foreach(char c in target)
          {
            if(set.Contains(c))
            {
                str.Append(c);

            }
          }
      return str.ToString();
    }
    public static void Main()
    {
        Solution result = new Solution();
        int[] voulme1 = new int[]{2,1,4,3};
        int[] volumes2 = new int[] { 1, 4, 3, 2, 5 } ;
       
        string books = result.RemoveVowels("aeioul");
        Console.WriteLine(books);

    }
}