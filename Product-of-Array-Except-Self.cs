public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // Method 1 - Bruteforce
        // int[] result = new int[nums.Length];
        // for (int i=0;i<nums.Length;i++) {
        //     int prod = 1;
        //     for (int j=0;j<nums.Length;j++) {
        //         if (i==j) continue;
        //         prod = prod * nums[j];
        //     }
        //     result[i] = prod;
        // }

        // return result;
        
        // Method 2 - Division
        // int[] result = new int[nums.Length];
        // int zeroCount = 0;
        // int prodValue = 1;

        // for (int i=0;i<nums.Length;i++) {
        //     if (nums[i] == 0) zeroCount++;
        //     else prodValue *= nums[i];
        // }

        // if (zeroCount > 1) return result;

        // for (int j=0;j<nums.Length;j++) {
        //     if (nums[j] == 0) result[j] = prodValue;
        //     else if (zeroCount == 1) continue;
        //     else result[j] = prodValue/nums[j];
        // }

        // return result;
        
        // Method 3 - Using prefix and suffix prod
        int[] result = new int[nums.Length];
        int[] prefixProd = new int[nums.Length];
        int[] suffixProd = new int[nums.Length];
        int prefixProdVal = 1;
        int suffixProdVal = 1;

        int i=0;
        int j=nums.Length - 1;
        while (i<nums.Length) {
            prefixProdVal = prefixProdVal * nums[i];
            suffixProdVal = suffixProdVal * nums[j];

            prefixProd[i] = prefixProdVal;
            suffixProd[j] = suffixProdVal;

            i++;
            j--;
        }

        for (int k=0;k<nums.Length;k++) {
            if (k == 0) result[k] = 1 * suffixProd[k+1];
            else if (k == nums.Length - 1) result[k] = 1 * prefixProd[k-1];
            else result[k] = prefixProd[k-1] * suffixProd[k+1];
        }

        return result;
    }
}
