//type alias

type UserID = string | number;

type User = {
    id: UserID;
    name: string;
    email?: string;    
};

const user1: User = {
    id: 4,
    name: 'Rohan',
};

console.log(user1);

//Interface

interface UserInterface {
    id: number;
    name: string;
    email?: string;
}

interface AdminInterface extends UserInterface {
    role: string;
}

const admin: AdminInterface = {
    id: 4,
    name: 'Rohan',
    role: 'Admin',
};
console.log(admin);


//Enum

enum WeekEnd {
    SUNDAY,
    SATURDAY = 'Party',
}

const today: WeekEnd = WeekEnd.SATURDAY;
console.log(today);


//Generics

function getArray<T>(items: T[]): T[] {
    return new Array<T>().concat(items);
}
let numArray = getArray<number>([1, 2, 3, 4]);
console.log(numArray);


interface Digit<T> {
  value: T;
}
const digit1: Digit<number> = { value: 123 };
console.log(digit1);


function pair<T, U>(first: T, second: U): [T, U] {
    return [first, second];
}
const result = pair<string, number>('Rohan', 24);
console.log(result); 


//Union and Intersection Types

function printId(id: string | number): void {   //union
    console.log("Your ID is: " + id);
}
printId(101);
printId("RGK12");


type Roti = {
    shape : string;
    color: string;
}

type Naan = {
    size: number;
    price: number;
}

type lunch = Roti & Naan;  //intersection

const myLunch: lunch = {
    shape: 'round',
    color: 'brown',
    size: 10,
    price: 50
};
console.log(myLunch);