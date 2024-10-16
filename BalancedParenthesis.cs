class Solution
{
    //Complete this function
    //Function to check if brackets are balanced or not.
    public bool ispar(string x)
    {
        //Your code here
        Stack<char> stack = new Stack<char>();
        
        foreach(char ch in x)
        {
            if(ch == '[' || ch == '{' || ch == '(')
            {
                stack.Push(ch);
            }
            else if(ch == ']' || ch == '}' || ch == ')' )
            {
                if(stack.Count == 0)
                {
                    return false;
                }
                char top = stack.Pop();
                if(ch == '}' && top != '{' || 
                   ch == ']' && top != '[' ||
                   ch == ')' && top != '(')
                   {
                       return false;
                   }
            }
        }
        return stack.Count == 0;
    }
}