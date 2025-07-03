public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        // Method 3 - Optimized Method - O(n)
        HashSet<int> data = new HashSet<int>();
        for (int i=0;i<nums.Length;i++) {
            if (data.Contains(nums[i])) {
                return true;
            }
            data.Add(nums[i]);
        }

        return false;
    }
}