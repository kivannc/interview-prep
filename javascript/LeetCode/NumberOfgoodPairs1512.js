/**
 * @param {number[]} nums
 * @return {number}
 */
var numIdenticalPairs = function (nums) {
  var map = new Map();

  //create a Map
  for (let i = 0; i < nums.length; i++) {
    const item = nums[i];
    if (map.has(item)) {
      map.set(item, [...map.get(item), i]);
    }
    else {
      map.set(item, [i]);
    }
  }
  let totalPairs = 0;
  for (const value of map.values()) {
    if (value.length > 1) {
      totalPairs += value.length * (value.length - 1) / 2
    }
  }
  return totalPairs
};

var numIdenticalPairs2 = function (nums) {
  var hashSet = {};

  //create a Map
  for (let i = 0; i < nums.length; i++) {
    const item = nums[i];
    if (hashSet[item]) {
      hashSet[item].push(i);
    }
    else {
      hashSet[item] = [i];
    }
  }
  let totalPairs = 0;
  for (const value of Object.values(hashSet)) {
    if (value.length > 1) {
      totalPairs += value.length * (value.length - 1) / 2
    }
  }
  return totalPairs
};

console.log(numIdenticalPairs([1, 2, 3, 1, 1, 3]));
console.log(numIdenticalPairs2([1, 2, 3, 1, 1, 3]));