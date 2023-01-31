/**
 * @param {number[]} numbers
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function (numbers, target) {

  if (numbers.length == 2) return [1, 2];
  let left = 0;
  let right = 1;

  while (left < numbers.length - 1) {

    if (numbers[left] + numbers[right] === target) {
      return [left + 1, right + 1];
    }

    if (right === numbers.length - 1 || (numbers[right] + numbers[left]) > target) {
      left++;
      right = left + 1;
    } else {
      right++;
    }
  }
};

var twoSum2 = function (numbers, target) {

  let index1 = 0;
  let index2 = numbers.length - 1;

  while (index1 <= index2) {
    if (index1 === index2) break;
    let sum = numbers[index1] + numbers[index2];
    if (sum === target) {
      return [index1 + 1, index2 + 1]
    }
    else if (sum < target) {
      index1++;
    }
    else {
      index2--;
    }
  }
};

var twoSum3 = function (numbers, target) {

  if (numbers.length === 2) return [1, 2];
  let index1 = Math.floor(numbers.length / 2);
  let index2 = index1 + 1;

  while (1) {
    let sum = numbers[index1] + numbers[index2];
    if (sum === target) {
      return [index1 + 1, index2 + 1]
    }
    if (sum > target) {
      index2--;
      if (index1 == index2) {
        index1--;
      }
    }
    else {
      index1++;
      if (index1 == index2) {
        index2++;
      }
    }
  }
};


console.log(twoSum3([0, 2, 11, 15], 13));
console.log(twoSum3([2, 3, 4,], 6));
console.log(twoSum3([2, 3, 4], 7));
console.log(twoSum3([3, 3, 4, 5], 6));
console.log(twoSum3([2, 7, 11, 15], 26));
console.log(twoSum3([-1, 0], -1));


/*
  [2,7,11,15] , 9 = [1,2]
  [2,3,4,] , 6 = [1,3]
  [2,3,4] , 7 = [2,3]
  [-1,0] , -1 = [1,2]
  [3,4,4,5] , 8  = [1,4]  
*/
