/**
 * @param {number[]} nums
 * @return {number[]}
 */
var sortedSquares = function (nums) {
  var sortedArray = [];

  if (nums.length === 1 || nums[0] >= 0) {
    return nums.map(item => item * item);
  }

  if (nums[nums.length - 1] < 0) {
    for (let i = nums.length - 1; i >= 0; i--) {
      sortedArray.push(square(nums[i]));
    }
    return sortedArray;
  }

  let left = 0;
  let right = 0
  for (let i = 0; i < nums.length; i++) {
    const item = nums[i];
    if (item >= 0) {
      left = i - 1;
      right = i;
      break;
    }
  }

  while (left >= 0 && right <= nums.length - 1) {
    var squareLeft = square(nums[left]);
    var squareRight = square(nums[right]);
    if (squareLeft <= squareRight) {
      sortedArray.push(squareLeft)
      left--;
    }
    else {
      sortedArray.push(squareRight)
      right++;
    }
  }

  while (left >= 0) {
    sortedArray.push(square(nums[left]))
    left--;
  }

  while (right <= nums.length - 1) {
    sortedArray.push(square(nums[right]))
    right++;
  }


  return sortedArray;
}

const square = (num) => {
  return num * num;
}


console.log(sortedSquares([-3, -3, -2, 0, 6]));