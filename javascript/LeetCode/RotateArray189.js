/**
 * @param {number[]} nums
 * @param {number} k
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var rotateMy = function (nums, k) {
  k = k % nums.length;
  var rotatedArray = [];
  for (i = nums.length - k; i < nums.length; i++) {
    rotatedArray.push(nums[i]);
  }
  for (i = 0; i < nums.length - k; i++) {
    rotatedArray.push(nums[i]);
  }

  for (let i = 0; i < rotatedArray.length; i++) {
    nums[i] = rotatedArray[i];
  }
};

const rotate = (nums, k) => {
  k = k % nums.length;
  reverse(nums, 0, nums.length - 1);
  reverse(nums, 0, k - 1);
  reverse(nums, k, nums.length - 1)

}

const swap = (nums, i, j) => {
  var temp = nums[i];
  nums[i] = nums[j];
  nums[j] = temp;
}

const reverse = (nums, left, right) => {
  while (left < right) {
    swap(nums, left, right);
    left++;
    right--;
  }
}
// var rotate = function (nums, k) {
//   var k = k % nums.length;
//   var rotatedArray = [];
//   for (i = nums.length - k; i < nums.length; i++) {
//     rotatedArray.push(nums[i]);
//   }
//   for (i = 0; i < k + 1; i++) {
//     rotatedArray.push(nums[i]);
//   }
//   return rotatedArray;
// };


console.log(rotate([1, 2, 3, 4, 5, 6, 7, 8], 3))
console.log(rotate([-1, -100, 3, 99], 2))