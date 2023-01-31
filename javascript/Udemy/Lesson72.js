//Merge Sorted Array

const mergeSortedArray = (arr1, arr2) => {
  const mergedArray = [];

  if (arr1.length === 0) return arr2;
  if (arr2.length === 0) return arr1;
  let i = 0;
  let j = 0;
  while (i < arr1.length && j < arr2.length) {
    if (arr1[i] < arr2[j]) {
      mergedArray.push(arr1[i]);
      i++;
    } else {
      mergedArray.push(arr2[j]);
      j++;
    }
  }
  while (i < arr1.length) {
    mergedArray.push(arr1[i]);
    i++;
  }
  while (j < arr2.length) {
    mergedArray.push(arr2[j]);
    j++;
  }

  return mergedArray;
};

const arr1 = [1, 3, 5, 7, 9, 11, 13, 15];
const arr2 = [0, 1, 2, 4, 6, 8, 10];

console.log(mergeSortedArray(arr1, arr2));