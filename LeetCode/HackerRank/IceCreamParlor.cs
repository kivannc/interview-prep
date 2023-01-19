namespace InterviewPrep.HackerRank;

internal partial class Questions
{
    public static List<int> IceCreamParlor(int m, List<int> arr)
    {
        var hash = new Dictionary<int, int>();
        for( int i= 0; i<arr.Count; i++){
            var n =arr[i];
            if (n>= m) continue;
            var diff = m - n;
            if (hash.ContainsKey(diff)){
                var result = new List<int>{ hash[diff]+1, i+1 };
                result.Sort();
                return result;
            }

            if (!hash.ContainsKey(n))
            {
                hash.Add(n, i);  
            }
        }   
        return new List<int>();
    }
}