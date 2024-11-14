//Given a valid (IPv4) Internet Protocol address S, the task is to find the defanged version of that IP address.
//Defanged Version of IP Address: is in which every period “.” is replaced by “[.]”. 

//Examples: 
//Input: S = “1.1.1.1” 
//Output: 1[.]1[.]1[.]1

//Input: S = “255.100.50.0” 
//Output: 255[.]100[.]50[.]0  


using System.Text;

public class Solution {
    public string AddIPconfig(string target) {
            StringBuilder str = new StringBuilder();
          for(int i=0; i<target.Length;i++)
          {
            char current = target[i];
            if(current == '.')
            {
                str.Append("[.]");
            }else
            {
                str.Append(current);
            }
          }
      return str.ToString();
    }
    public static void Main()
    {
        Solution result = new Solution();
        int[] voulme1 = new int[]{2,1,4,3};
        int[] volumes2 = new int[] { 1, 4, 3, 2, 5 } ;
       
        string books = result.AddIPconfig("255.100.344.043");
        Console.WriteLine(books);

    }
}