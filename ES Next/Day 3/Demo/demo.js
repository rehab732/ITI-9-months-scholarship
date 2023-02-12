//////constructor functions////////////////////////////////////////////////////////////////////////////////

/*var Emp=function(name,id)
{
    Person.call(this,salary,des)
    this.empname=name;
    this.empid=id;
}
var emp1=new Emp(" Rehab Zaki ",2000);


var Person =function(salary,des)
{
    this.presal=salary;
    this.perdes=des;
}
Person.prototype.add="Cairo"
Person.prototype.setAdd=function(val)
{
    this.add=val;
}

Emp.prototype=Person.prototype 
 
Emp.prototype.dispalyInfo=function(){
    return `
            Your Name is ${this.empname} 
            your Id is ${this.empid}`
}

*/
//constructor function
/*
var Employee=function(name,id,salary,dep)
{
    Person.call(name,id)
    /*this.empname=name
    this.empid=id*/
/* this.epmsalary=salary
 this.empdep=dep}


var Person=function(name,id)
{
 //abstract
 if(this.constructor==Person)
 {
     throw "Abstract"
 }
 this.pername=name
 this.perid=id
}
 
Person.prototype.add="Cairo"
Person.prototype.setAdd=function(value)
{
 this.add=value;
}
Employee.prototype=Object.create(Person.prototype)
Employee.prototype.constructor=Employee

//add function
Employee.prototype.display=function()
{
 return `
 Your name is ${this.empname}
 Your id is ${this.empid}
 Your department is ${this.empdep}
 Your salary is ${this.salary}`
}

var emp1 =new Employee("rehab",100,200,"IS");

var p =new Person("rehab",100);
*/
/*
//////classes////////////////////////////////////////////////////////////////////////////////

class User
{
    constt=2018
    id
    #userName//private

    constructor(id,name)
    {
        if(this.constructor==User)
        {
            throw "dnck"
        }
        this.id=id
        this.#userName=name
    }
    get UserName()
    {
        return this.#userName

    }
    set UserName(val)
    {
        this.#userName=val
    }

    display()
    {
        return ` 
            Your Name is ${this.UserName} 
            Your id is ${this.id}`
    }    
    static fun()
    {
        return 'Hello World'
    }
    toString()
    {
        return "user class"
    }
}


class Employee extends User{
    constructor(name,id,salary)
    {
        super(name,id)
        this.empsal=salary
    }
    toString()
    {
        return "emp class"
    }
}

var user1=new User(20000,"Rehab");
console.log(user1.id)
var n=new Employee("ali",13,12)*/
//////Math lib module////////////////////////////////////////////////////////////////////////////////
/*import * as mymodel from './Mathlib.js'
console.log(mymodel.add(11,2));*/

//////Proxy///////////////////////////////////////////////////////////////////////////////
/*
var obj = {
    x: 10,
    y: 20
}

var handler = {

    set(target, prop, value) {
        if (target.hasOwnProperty(prop)) {


            if (value > 0 && value < 100) {
                target[prop] = value
            } else {
                throw 'limited'
            }
        }else{
            throw "not prpo"
        }
    },
    get(target,prop){
        if(target.hasOwnProperty(prop))
        {
            return target[prop]

        }else
        throw 'invalid prop'

    }

     
}

var myproxy = new Proxy(obj, handler)

*/
//////Promises///////////////////////////////////////////////////////////////////////////////

var myprom=new Promise(function(success,faluier){
   


})
