/* Two Sum
taken from Leetcode (https://leetcode.com/problems/two-sum/description/)
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 

Constraints:

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.
 

Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
*/
using System;
using System.Collections.Generic;

public class Program { //public class Solution on the actual website
    public static void Main(string[] args) {
        int[] nums1 = {2, 7, 11, 15};
        int target1 = 9;
        Console.WriteLine(string.Join(", ", TwoSum(nums1, target1))); // Expected Output: 0, 1

        int[] nums2 = {3, 2, 4};
        int target2 = 6;
        Console.WriteLine(string.Join(", ", TwoSum(nums2, target2))); // Expected Output: 1, 2

        int[] nums3 = {3, 3};
        int target3 = 6;
        Console.WriteLine(string.Join(", ", TwoSum(nums3, target3))); // Expected Output: 0, 1
    }

    public static int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i]; // The value we are looking for
            if (dic.ContainsKey(complement)) {
                return new int[] { dic[complement], i };
            }
            dic[nums[i]] = i; // Store the index of the current number
        }

        throw new Exception("No valid pair found"); // If no solution is found, throw an error
    }
}

