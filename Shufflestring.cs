 public string RestoreString(string s)
    {
        int[] indicies = new int[]{4,5,6,7,0,2,1,3};
            char[] charray = new char[s.Length];

        for(int i=0; i<charray.Length; i++)
        {
            charray[indicies[i]] = s[i];
        }
        return new string(charray);
    }