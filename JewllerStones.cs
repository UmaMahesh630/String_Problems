public int NumJewelsInStones(string jewels, string stones){
            int count=0;
            HashSet<char> set = new HashSet<char>();
            foreach(char c in jewels)
            {
                set.Add(c);
            }
            foreach(char c in stones)
            {
                if(set.Contains(c))
                {
                    count++;
                }
            }
            return count;
    }