/**
 * @param {number[]} nums
 * @return {boolean}
 */
var containsDuplicate = function (nums) {
  var hash = {}
  for (let i = 0; i < nums.length; i++) {
    const item = nums[i];
    if (hash[item]) {
      return true;
    }
    hash[item] = true;
  };
  return false;
};

/*

*/