//array

const array = [1,2,'r'];
console.log(array);

array.push(6);
array.push('s');
console.log(array);
array.pop();
array.unshift(0);
array.shift();
console.log(array);
array.splice(3); 

for (let i = 0; i < array.length; i++) {
  console.log(array[i]);
}

//objects

const obj = {
  name: 'Rohan',
    age: 25,
    city: 'Shimoga',
    greet : function() {
      console.log(`Hii, ${this.name}`);
    }
};

obj.greet();
console.log(obj.city);
console.log(obj['age']);

//Functions


function add(a,  b){
    return a + b;
}
console.log(add(5, 10));

let sum = (a, b) => {
    return a + b;
};

console.log(sum(5, 8));
