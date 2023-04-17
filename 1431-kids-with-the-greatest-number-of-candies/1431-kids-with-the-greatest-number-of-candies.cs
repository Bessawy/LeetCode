public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int max = int.MinValue;
        
        for(int i = 0; i < candies.Length; ++i)
            max = Math.Max(candies[i], max);
        
        IList<bool> results = new List<bool>(candies.Length);
        
        for(int j = 0; j < candies.Length; ++j)
        {
            if(candies[j] + extraCandies >= max)
                results.Add(true);
            else
                results.Add(false);
        }
        
        return results;
    }
}