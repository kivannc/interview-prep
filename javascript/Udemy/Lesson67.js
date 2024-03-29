//Classes


//reference types 

var object1 = { value: 10 };
var object2 = object1;
var object3 = { value: 10 };


//context vs scope
console.log(this); // what is object enviroment of this

// instantiation
class Player {
  constructor(name, type) {
    this.name = name;
    this.type = type;
  }
  introduce() {
    console.log(`Hi I am ${this.name}, I am a ${this.type}`);
  }
}

class Wizard extends Player {
  constructor(name, type) {
    super(name, type);
  }
  play() {
    console.log(`Weee, I'm a ${this.type}`);
  }
}

const wizard1 = new Wizard('Shelly', 'Healer');
const wizard2 = new Wizard('Shawn', 'Dark Magic');

wizard1.play();
wizard1.introduce();
wizard2.play();
wizard2.introduce();