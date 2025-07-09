//type alias
var user1 = {
    id: 4,
    name: 'Rohan',
};
console.log(user1);
var admin = {
    id: 4,
    name: 'Rohan',
    role: 'Admin',
};
console.log(admin);
//Enum
var WeekEnd;
(function (WeekEnd) {
    WeekEnd[WeekEnd["SUNDAY"] = 0] = "SUNDAY";
    WeekEnd["SATURDAY"] = "Party";
})(WeekEnd || (WeekEnd = {}));
var today = WeekEnd.SATURDAY;
console.log(today);
//Generics
function getArray(items) {
    return new Array().concat(items);
}
var numArray = getArray([1, 2, 3, 4]);
console.log(numArray);
var digit1 = { value: 123 };
console.log(digit1);
function pair(first, second) {
    return [first, second];
}
var result = pair('Rohan', 24);
console.log(result);
//Union and Intersection Types
function printId(id) {
    console.log("Your ID is: " + id);
}
printId(101);
printId("RGK12");
var myLunch = {
    shape: 'round',
    color: 'brown',
    size: 10,
    price: 50
};
console.log(myLunch);
