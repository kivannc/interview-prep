//Hash Table
/*
insert O(1)
look up O(1)
delete O(1)
search O(1)
*/

let user = {
  age: 54,
  name: 'Kyle',
  magic: true,
  scream: function () {
    console.log('ahhhhhh!');
  }
}

console.log(user.age);
user.spell = 'abra kadabra';

console.log(user);

// Map allows you save any datatype as key and value
// it maintains insertion order 
const a = new Map(); 

//Set only allows you to save values
const n = new Set();
                    

