//Prototype Inheritance in JavaScript

const Animal ={
  type : "Terrestrial",
  speak(){
    console.log("Each animal have their own sound");
  },
  isMammal: function() {
    return true;
  }
};

const Dog = Object.create(Animal);
Dog.speak = function() {
  console.log("Bow..! Bow..!");
};

const Cat = Object.create(Animal);
Cat.speak = function() {
  console.log("Meow..! Meow..!");
};


Dog.speak(); 
console.log("Type: " + Dog.type);
console.log(Dog.isMammal()); 

Cat.speak();
console.log("Type: " + Cat.type);
console.log(Cat.isMammal());
