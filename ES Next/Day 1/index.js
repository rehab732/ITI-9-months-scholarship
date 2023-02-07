//Swap the values of x and y using destructuring
var x = 5,y=3;

console.log(x, y);

[x, y] = [y, x];
console.log(x, y);



/**
 * Using rest parameter and spread operator
 *  return min and max value from any array passed to function calland display
 *  each of them separately after function callnote: a
 * rray length is not fixed
 */

//way one
function Min_MAx(...args) {
    let minimum = Math.min(...args);
    let maximum = Math.max(...args);
    return [minimum, maximum];//return array contains 2 numbers
  }
  
  let [min, max] = Min_MAx(1, 2, 3, 4, 5);
 
  console.log(`Maximum Number is: ${max}`);
  console.log(`Minimum Number is: ${min}`);
console.log("====================================");
//way two
function MAx_MIN(...args)
{
    console.log("maximum Number is: " + Math.max(...args));
    console.log("Minimum Number is: " + Math.min(...args));
   
}

MAx_MIN(1, 2, 3, 4, 5);

console.log("====================================");

/**
 * Study new array api methods
 *  then create the following methods and apply it 
 * on this array var fruits = ["apple", "strawberry", "banana", "orange", "mango"];
 */

//a)test that every element in the given array is a string
//by arrow function 
var fruits = ["apple", "strawberry", "banana", "orange", "mango"];
var StringOrNt = fruits.every((element) => typeof element === "string");
console.log(StringOrNt);
//way 2

var test = ["apple", "strawberry", 2, "orange", "mango"];
var StringOrNttest = test.every(function(element){
    if(typeof(element)==="string")
    return true;
    else 
    return false;
})
console.log(StringOrNttest);
console.log("====================================");

//b.test that some of array elements starts with "a"

var startsWithletterA = fruits.some((element) => element.startsWith("a"));
console.log(startsWithletterA);

console.log("====================================");

//c)generate new array filtered from the given array with only elements that starts with "b" or "s"
var filteredArray = fruits.filter( function(element) {
    if(element.startsWith("b") || element.startsWith("s"))
    return true;
    else 
    return false;
}) 
console.log(filteredArray);

console.log("====================================");

//d)generate new array, each element of the new array contains a string declaring that you like the give fruit element

var NewArray = fruits.map(function(element) {
  return "I Like "+element
} )

console.log(NewArray);
console.log("====================================");

//use forEach to display all elements of the new array from previouse point

NewArray.forEach(function(element){
    console.log(element)
} );