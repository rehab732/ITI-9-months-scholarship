//to declare var
//datatype =initialization
// var x:number=20; 
// x=45;//valid
//x="Rehab";//error


// var y:string;
// console.log(y);//error

// var c=10; //type inferance
//c="hdg";//error


// //Way 1
// var v:any;
// v=10;
// v="rehab";
// v=true;
// v={};
// v=[];

// //Way 2
// var b;
// b=10;
// b="Mahmoud";
// b=true;
// b={};
// b=[];

//take only one numer
// var arr:[number];
// arr=[10];

//take 2 numbers
// var arr2:[number,number];
// arr2=[1,2];

// //take any numbers
// var arr3:number[];
// arr3=[1,2,3,45];


// var numstring: number|string;
// numstring=45;
// numstring="Rehab";

// var arr4:string|number[];
// arr4=[1];
// arr4=[1,2];
// arr4=[1,33,45];
// arr4=[""];//error --> accept array of numbrs or string
// arr4="rehab";//de tamam


// var obj:{};
// obj={};
// obj={name:"Rehab",age:56};


// var obj1:{name,age};//just declaration
// obj1={name:"cskn",age:45};//initializaton


// var obj2:{name:string,age:number,address:string};
// obj2={name:"Rehab",age:45,address:"Helwan"};


// //Can Make optional property
// var obj3:{name:string,age:number,address?:string};
// obj3={name:"Rehab",age:45};

// var arrbj:{name:string,age:number,address?:string}[];
// arrbj=[{name:"Reem",age:20,address:"cairo"},{name:"Rehab",age:45}]



// function xyz():number{
//     return 0;
// }
// //smart enugh to know return type
// function abc(){

//     return "abc";
// }

// class Person{
//     private address="132 street";
//     static counter=0;
//     constructor(public name="person name",public age=0){
//         if(this.constructor==Person)
//         Person.counter++;}
//     getName(){
//         return this.name;
//     }
//     //geter property
//     //call-->p.Address
//     get Address(){
//         return this.address;
//     }
//     set Name(value)
//     {
//         this.name=value;
//     }
//     get Counter()
//     {
//         return Person.counter;
//     }
// }
// var p=new Person();//name=Person Name,age=45
// var p1=new Person("rehab",4);//name=rehab,age=4

// class Employee extends Person{
//     static counter=0;
//     constructor(name="Emp Name",age=45,public salary=4545){
//         Employee.counter++;
//         super(name,age);
//     }

// }
// var emp1= new Employee();

// abstract class Aperson{
//     name:string;
//     age:number;
//     getName(){
//         return this.name;
//     }
//     abstract getAge();
    
// }
// class Emp extends Aperson{
//     name: string;
//     age: number;
   
//     getAge() {
//         //throw new Error("Method not implemented.");
//     }
// }

// interface Iperson{
//     name: string;
//     age: number;
//     getName();
//     getAge();
// }

// class Emppp implements Iperson{
//     name: string;
//     age: number;
//     getName() {
//         throw new Error("Method not implemented.");
//     }
//     getAge() {
//         throw new Error("Method not implemented.");
//     }

// }

class Account{
   constructor(public Acc_no=1,public Balance=1){}
   debitAmount(){
    return "debitAmount fun";
   }
   creditAmoun(){
    return "creditAmoun fun";
   }
    getBalance(){
    return "getBalance fun";
   }

}

interface IAccount{
    Date_of_opening:number;
    addCustomer();
    removeCustomer();
}

class SavingAccount extends Account,implements IAccount{
    constructor(public Acc_no=1,public Balance=1,public MinBalance=4545)
    {
                super(Acc_no,Balance);
    }
    Date_of_opening: number;
    addCustomer() {
        throw new Error("Method not implemented.");
    }
    removeCustomer() {
        throw new Error("Method not implemented.");
    }
}
class CurrentAccount extends Account,implements IAccount{
    constructor(public Acc_no=1,public Balance=1,public interstrate=4545)
    {
                super(Acc_no,Balance);
    }
    Date_of_opening: number;
    addCustomer() {
        throw new Error("Method not implemented.");
    }
    removeCustomer() {
        throw new Error("Method not implemented.");
    }
}
