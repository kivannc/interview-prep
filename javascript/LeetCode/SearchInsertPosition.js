/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */

var searchInsert = function (nums, target) {
  var l = 0;
  var r = nums.length - 1;
  if (nums[0] > target) return 0;
  if (nums[r] < target) return r + 1;
  while (l <= r) {
    var mid = l + Math.floor((r - l) / 2);

    if (nums[mid] === target) {
      return mid;
    }

    if (nums[mid] < target && nums[mid + 1] > target) {
      return mid + 1;

    }

    if (nums[mid] < target) {
      l = mid + 1;
    }
    else {
      r = mid - 1;
    }
  }
};