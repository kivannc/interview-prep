/**
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var moveZeroes = function (nums) {

  let index = nums.length - 1;
  let zeroIndex = nums.length - 1;
  let numberOfZeros = 0;

  //sondaki sifirlari atladik.
  while (nums[index] == 0 && index >= 0) {
    numberOfZeros++;
    zeroIndex--;
    index--;
  }

  if (index == -1) return nums; // All Zero array


  for (let i = index; i >= 0; i--) {
    const number = nums[i];
    if (number == 0) {
      zeroIndex = i;
      numberOfZeros++;
      shiftToEnd(nums, zeroIndex, nums.length - numberOfZeros);
    }
  }
};

const shiftToEnd = (nums, index, endIndex) => {
  //Given index will be shift right until another zero is found
  for (let i = index; i < endIndex; i++) {
    swap(nums, i, i + 1);
  }
}

const swap = (nums, left, right) => {
  //Swap two indexes in given array
  if (left == right) return;
  let temp = nums[right];
  nums[right] = nums[left];
  nums[left] = temp;
}

const moveZeroes2 = (nums) => {
  let nonZeroIndex = 0;
  for (let i = 0; i < nums.length; i++) {
    const number = nums[i];
    if (number === 0) {
      continue;
    }
    nums[nonZeroIndex] = nums[i];
    nonZeroIndex++;
  }

  for (let i = nonZeroIndex; i < nums.length; i++) {
    nums[i] = 0;
  }
  console.log(nums);
}

console.log(moveZeroes([0, 0, 0, 1, 2, 3, 4, 5]))
console.log(moveZeroes([1, 2, 3, 0, 0, 4]))
console.log(moveZeroes([0, 1, 0, 2, 0, 3]))
console.log(moveZeroes([1, 0, 2, 0, 3, 0]))
console.log(moveZeroes([1, 2, 3, 4, 0, 0]))
console.log(moveZeroes([1, 2, 3, 4]))

console.log("moveZeroes2");

console.log(moveZeroes2([0, 0, 0, 1, 2, 3, 4, 5]))
console.log(moveZeroes2([1, 2, 3, 0, 0, 4]))
console.log(moveZeroes2([0, 1, 0, 2, 0, 3]))
console.log(moveZeroes2([1, 0, 2, 0, 3, 0]))
console.log(moveZeroes2([1, 2, 3, 4, 0, 0]))
console.log(moveZeroes2([1, 2, 3, 4]))



/*

  [0,0,0,1,2,3,4,5]
  [1,2,3,0,0,4]
  [0,1,0,2,0,3]
  [1,0,2,0,3,0]
  [1,2,3,4,0,0]
  [1,2,3,4]
  []





*/