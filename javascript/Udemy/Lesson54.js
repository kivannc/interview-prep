const checkCommonItems = (arr1, arr2) => {
  for (let i = 0; i < arr1.length; i++) {
    for (let j = 0; j < arr2.length; j++) {
      if (arr1[i] === arr2[j]) {
        return true
      }
    }
  }
  return false
} // O(a*b) O(1) Space Complexity


const checkCommonItems2 = (arr1, arr2) => {
  let arr1Set = new Set(arr1)
  for (let i = 0; i < arr2.length; i++) {
    if (arr1Set.has(arr2[i])) {
      return true
    }
  }
  return false
} // O(a+b) O(a) Space Complexity


const checkCommonItems3 = (arr1, arr2) => {
  let map = {}
  for (let i = 0; i < arr1.length; i++) {
    if (!map[arr1[i]]) {
      const item = arr1[i];
      map[item] = true;
    }
  }
  for (let i = 0; i < arr2.length; i++) {
    if (map[arr2[i]]) {
      return true
    }
  }
  return false
} // O(a+b) O(a) Space Complexity


//Error Checks 

const checkCommonItems4 = (arr1, arr2) => {
  return arr1.some(item => arr2.includes(item));
}
const markStart = "mark_start";
const mark1 = "mark_1";
const mark2 = "mark_2";
const mark3 = "mark_3";
const mark4 = "mark_4";

performance.mark(markStart);
console.log(checkCommonItems(['a', 'b', 'c'], ['d', 'e', 'f']));
performance.mark(mark1);
console.log(checkCommonItems2(['a', 'b', 'c'], ['d', 'e', 'f']));
performance.mark(mark2);
console.log(checkCommonItems3(['a', 'b', 'c', 'd'], ['d', 'e', 'f']));
performance.mark(mark3);
console.log(checkCommonItems4(['a', 'b', 'c', 'd'], ['d', 'e', 'f']));
performance.mark(mark4);

performance.measure('checkCommonItems', markStart, mark1);
performance.measure('checkCommonItems 2', mark1, mark2);
performance.measure('checkCommonItems 3', mark2, mark3);
performance.measure('checkCommonItems 4', mark3, mark4);
console.log(performance.getEntriesByType('measure'));



