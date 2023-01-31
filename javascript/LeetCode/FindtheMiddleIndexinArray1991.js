/*
Given a 0-indexed integer array nums, find the leftmost middleIndex (i.e., the smallest amongst all the possible ones).

A middleIndex is an index where nums[0] + nums[1] + ... + nums[middleIndex-1] == nums[middleIndex+1] + nums[middleIndex+2] + ... + nums[nums.length-1].

If middleIndex == 0, the left side sum is considered to be 0. Similarly, if middleIndex == nums.length - 1, the right side sum is considered to be 0.

Return the leftmost middleIndex that satisfies the condition, or -1 if there is no such index.

 

Example 1:

Input: nums = [2,3,-1,8,4]
Output: 3
Explanation: The sum of the numbers before index 3 is: 2 + 3 + -1 = 4
The sum of the numbers after index 3 is: 4 = 4
Example 2:

Input: nums = [1,-1,4]
Output: 2
Explanation: The sum of the numbers before index 2 is: 1 + -1 = 0
The sum of the numbers after index 2 is: 0
Example 3:

Input: nums = [2,5]
Output: -1
Explanation: There is no valid middleIndex.
 

Constraints:

1 <= nums.length <= 100
-1000 <= nums[i] <= 1000
*/

/**
 * @param {number[]} nums
 * @return {number}
 */
var findMiddleIndex = function (nums) {
  if (nums.length === 1) return 0;
  for (let i = 0; i < nums.length; i++) {
    let leftSum = 0;
    for (let j = 0; j < i; j++) {
      leftSum += nums[j];
    }
    let rightSum = 0;
    for (let k = i + 1; k < nums.length; k++) {
      rightSum += nums[k];
    }
    if (leftSum === rightSum) {
      return i;
    }
  }

  return -1;
};

var findMiddleIndex2 = function (nums) {
  let leftSum = 0;
  let rightSum = 0;
  for (let i = 0; i < nums.length; i++) {
    rightSum += nums[i];
  }
  for (let i = 0; i < nums.length; i++) {
    if (leftSum === rightSum) {
      return i;
    }
    leftSum += nums[i];
    rightSum -= nums[i];
  }
  return -1;
}
//prefix sum solution
var findMiddleIndex3 = function (nums) {
  let prefixSum = [];
  prefixSum[0] = nums[0];
  for (let i = 1; i < nums.length; i++) {
    prefixSum[i] = prefixSum[i - 1] + nums[i];
  }

  if (nums[0] === prefixSum[nums.length - 1]) {
    return 0;
  }

  for (let i = 1; i < nums.length; i++) {
    if (prefixSum[i - 1] === prefixSum[nums.length - 1] - prefixSum[i]) {
      return i;
    }
  }
  return -1;
}

// console.log(findMiddleIndex([2, 3, -1, 8, 4]));
// console.log(findMiddleIndex([1, -1, 4]));
// console.log(findMiddleIndex([2, 5]));

// console.log(findMiddleIndex2([2, 3, -1, 8, 4]));
// console.log(findMiddleIndex2([1, -1, 4]));
// console.log(findMiddleIndex2([2, 5]));

console.log(findMiddleIndex3([1, 1]));
console.log(findMiddleIndex3([2, 3, -1, 8, 4]));
console.log(findMiddleIndex3([1, -1, 4]));
console.log(findMiddleIndex3([4, -1, 1, 3, -2, -1]))
console.log(findMiddleIndex3([2, 5]));