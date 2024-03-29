/**
 * Definition for isBadVersion()
 * 
 * @param {integer} version number
 * @return {boolean} whether the version is bad
 * isBadVersion = function(version) {
 *     ...
 * };
 */

/**
 * @param {function} isBadVersion()
 * @return {function}
 */
var solution = function (isBadVersion) {
  /**
   * @param {integer} n Total versions
   * @return {integer} The first bad version
   */
  return function (n) {
    var l = 0;
    var r = n;

    if (n == 1) return 1;
    while (l <= r) {
      var mid = l + Math.floor((r - l) / 2);

      if (!isBadVersion(mid) && isBadVersion(mid + 1)) {
        return mid + 1;
      }

      if (isBadVersion(mid)) {
        r = mid - 1;
      }
      else {
        l = mid + 1;
      }
    }
  };
};