/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var search = function (nums, target) {
  let leftIndex = 0;
  let rightIndex = nums.length - 1;
  while (leftIndex <= rightIndex) {
    const mid = leftIndex + Math.floor((rightIndex - leftIndex) / 2);

    if (nums[mid] === target) {
      return mid;
    }

    if (nums[mid] < target) {
      leftIndex = mid + 1;
    } else {
      rightIndex = mid - 1;
    }
  }
  return -1;
};

console.log(search([-1, 0, 3, 5, 9, 12], 9));
