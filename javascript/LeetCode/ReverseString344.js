/**
 * @param {character[]} s
 * @return {void} Do not return anything, modify s in-place instead.
 */
var reverseString = function (s) {

  let start = 0;
  let end = s.length - 1;
  let temp = '';
  while (start <= end) {
    temp = s[start];
    s[start] = s[end];
    s[end] = temp;
    start++
    end--;
  }
  console.log(s);
};

let hello = "hello";
reverseString(hello)