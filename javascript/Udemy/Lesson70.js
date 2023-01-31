//Reverse a string

function reverse(str) {
  var reverseStr = "";
  for (var i = str.length - 1; i >= 0; i--) {
    reverseStr += str[i];
  }
  return reverseStr;
}

function reverse2(str) {
  return str.split("").reverse().join("");
}

const reverse3 = str => [...str].reduce((prev, current) => current + prev, "");
const reverse4 = str => [...str].reverse().join("");

console.log(reverse("Hello My Name is Kivanc"));
console.log(reverse2("Hello"));
console.log(reverse3("Hello My Name is Kivanc"));
console.log(reverse4("Hello My Name is Kivanc"));

