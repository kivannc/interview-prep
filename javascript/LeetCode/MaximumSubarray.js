
//O(n^3)
const maxSubArrayOn3 = (nums) => {
  let max = -Infinity;
  for (let i = 0; i < nums.length; i++) {
    for (let j = i; j < nums.length; j++) {
      let sum = 0;
      for (let k = i; k <= j; k++) {
        sum += nums[k];
      }
      if (sum > max) {
        max = sum;
      }
    }
  }
  return max;
}

//O(n^2) - Brute Force
const maxSubArrayOn2 = (nums) => {
  let max = -Infinity;
  for (let i = 0; i < nums.length; i++) {
    let sum = 0;
    for (let j = i; j < nums.length; j++) {
      sum += nums[j];
      if (sum > max) {
        max = sum;
      }
    }
  }
  return max;
}

//O(n) - Kadane's Algorithm Dynamic Programming
const maxSubArray = (nums) => {
  let max = nums[0];
  let currentMax = nums[0];
  for (let i = 1; i < nums.length; i++) {
    var item = nums[i];
    var sumWithCurrentMax = currentMax + item;
    currentMax = Math.max(sumWithCurrentMax, item);
    max = Math.max(max, currentMax);
  }
  return max;
}


//O(n) - Divide and Conquer
const maxSubArrayDivideAndConquer = (nums) => {
  return maxSubArrayDivideAndConquerHelper(nums, 0, nums.length - 1);
}

const maxSubArrayDivideAndConquerHelper = (nums, left, right) => {
  if (left === right) {
    return nums[left];
  }
  const mid = Math.floor((left + right) / 2);
  const leftMax = maxSubArrayDivideAndConquerHelper(nums, left, mid);
  const rightMax = maxSubArrayDivideAndConquerHelper(nums, mid + 1, right);
  const crossMax = maxCrossingSubArray(nums, left, mid, right);
  return Math.max(leftMax, rightMax, crossMax);
}

const maxCrossingSubArray = (nums, left, mid, right) => {
  let leftSum = -Infinity;
  let sum = 0;
  for (let i = mid; i >= left; i--) {
    sum += nums[i];
    if (sum > leftSum) {
      leftSum = sum;
    }
  }

  let rightSum = -Infinity;
  sum = 0;
  for (let i = mid + 1; i <= right; i++) {
    sum += nums[i];
    if (sum > rightSum) {
      rightSum = sum;
    }
  }

  return leftSum + rightSum;
}

console.log(maxSubArrayOn3([-2, 1, -3, 4, -1, 2, 1, -5, 4]));
console.log(maxSubArrayOn2([-2, 1, -3, 4, -1, 2, 1, -5, 4]));
console.log(maxSubArray([-2, 1, -3, 4, -1, 2, 1, -5, 4]))
console.log(maxSubArrayDivideAndConquer([-2, 1, -3, 4, -1, 2, 1, -5, 4]));