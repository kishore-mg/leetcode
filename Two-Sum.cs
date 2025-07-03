public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Method 1 - Bruteforce
        // for (int i=0; i<nums.Length;i++) {
        //     for (int j=i+1;j<nums.Length;j++) {
        //         if (nums[i] + nums[j] == target) return new int[] { i, j};
        //     }
        // }

        // return null;

        // Method 2 - Two pass hashmap
        // Dictionary<int, int> data = new Dictionary<int, int>();
        // for (int i=0;i<nums.Length;i++) {
        //     data[nums[i]] = i;
        // }

        // for (int i=0;i<nums.Length;i++) {
        //     int complement = target - nums[i];
        //     if (data.ContainsKey(complement) && data[complement] != i) {
        //         return new int[] { i, data[complement] };
        //     }
        // }

        // return null;

        // Method 3 - One pass hashmap
        Dictionary<int, int> data = new Dictionary<int, int>();
        for (int i=0;i<nums.Length;i++) {
            int complement = target - nums[i];
            if (data.ContainsKey(complement)) {
                return new int[] { data[complement], i };
            }
            data[nums[i]] = i;
        }

        return new int[]{};
    }
}