public class Solution {
    public string MergeAlternately(string word1, string word2) {
        
        int m = word1.Length > word2.Length ? word1.Length : word2.Length;
        string results = "";
        
        for(int i = 0; i < m; ++i)
        {
            if(i < word1.Length)
                results+=word1[i];
            if(i < word2.Length)
                results+=word2[i];
        }
        
        return results;
        
        
    }
}