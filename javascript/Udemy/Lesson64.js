const strings = ['a', 'b', 'c', 'd']; // 4x4 = 16 bytes of storage

strings.push('e'); // O(1)


strings.pop(); //O(1)

strings.unshift('x'); // O(n)

strings.splice(2, 0, 'alien'); // O(n)



console.log(strings);