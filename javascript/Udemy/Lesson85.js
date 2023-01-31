//First recurring char

const firstRecurringChar = (arr) => {
  var map = {};
  for (let i = 0; i < arr.length; i++) {
    const item = arr[i];
    if (map[item]) {
      return item;
    }
    map[item] = true;
  }


  return undefined;
}

const firstRecurringChar2 = (arr) => {
  var map = new Map();
  for (let i = 0; i < arr.length; i++) {
    const item = arr[i];
    if (map.has(item)) {
      return item;
    }
    map.set(item, true);
  }
}

const arr1 = [2, 5, 5, 1, 2, 3, 5, 1, 2, 4];
const arr2 = [2, 1, 1, 1, 2, 3, 5, 2, 1, 4];
const arr3 = [2, 3, 4, 5]
console.log(firstRecurringChar(arr1));
console.log(firstRecurringChar(arr2));
console.log(firstRecurringChar(arr3));
console.log(firstRecurringChar2(arr1));
console.log(firstRecurringChar2(arr2));
console.log(firstRecurringChar2(arr3));