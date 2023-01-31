/**
 * @param {string} s
 * @return {string}
 */
var reverseWords = function (s) {
  var words = s.split(" ");
  for (let i = 0; i < words.length; i++) {
    const word = words[i];
    words[i] = word.split('').reverse().join('');
  }
  return words.join(" ");
};

const reverseWordsNew = (s) => {
  const words = s.split(' ');
  const reversedWords = words.map(word => word.split('').reverse().join(''));
  return reversedWords.join(" ");
}

console.log(reverseWords("Let's take LeetCode contest"));
console.log(reverseWordsNew("Let's take LeetCode contest"));