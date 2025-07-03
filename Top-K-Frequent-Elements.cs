public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Method 1 - Sorting - O(nlogn)
        // var count = new Dictionary<int, int>();
        // foreach (int num in nums) {
        //     if (count.ContainsKey(num)) count[num]++;
        //     else count[num] = 1;
        // }

        // List<int[]> arr = count.Select(entry => new int[] { entry.Value, entry.Key }).ToList();
        // arr.Sort((a, b) => b[0].CompareTo(a[0]));

        // int[] res = new int[k];
        // for (int i=0;i<k;i++) {
        //     res[i] = arr[i][1];
        // }

        // return res;

        Dictionary<int, int> count = new Dictionary<int, int>();
        List<int>[] freq = new List<int>[nums.Length + 1];
        
        // O(N + 1)
        for (int i = 0; i < freq.Length; i++) {
            freq[i] = new List<int>();
        }

        // O(N)
        foreach (int n in nums) {
            if (count.ContainsKey(n)) {
                count[n]++;
            } else {
                count[n] = 1;
            }
        }

        // O(M)
        foreach (var entry in count) {
            freq[entry.Value].Add(entry.Key);
        }

        int[] res = new int[k];
        int index = 0;
        // O(N) Worst | O(K) Best
        for (int i = freq.Length - 1; i > 0 && index < k; i--) {
            foreach (int n in freq[i]) {
                res[index++] = n;
                if (index == k) {
                    return res;
                }
            }
        }
        return res;
    }
}