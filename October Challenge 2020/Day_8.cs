public class Solution {
    private int SearchInternal(int[] nums,int target, int low, int high) {
      if (low <= high) {
          int mid = (low + high)/2;
          if (nums[mid] == target) {
              return mid;
          } else if (target > nums[mid]) {
              return SearchInternal(nums, target, mid + 1, high);
          } else {
              return SearchInternal(nums, target, low, mid - 1);
          }
      } else {
          return -1;
      }
    }
    
    public int Search(int[] nums, int target) {
        return SearchInternal(nums, target, 0, nums.Length - 1);
    }
}
