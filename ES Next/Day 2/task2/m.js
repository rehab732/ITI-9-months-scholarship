/**
 * Task 2=====>Generators 
 * iterable object
 */

//way one
function * FibonanciSeries_number(num) {
    var arr = [0, 1];
    for (var i = 2; i < num; i++) {
        //sum prev 2 numbers 
        arr.push(arr[i - 1] + arr[i - 2]);
    }
    for (var i in arr) {
        yield arr[i];//return from function
    }
}


//just 5 numbers 0 1 1 2 3 
var result = FibonanciSeries_number(5);
console.log(result.next());
console.log(result.next());
console.log(result.next());
console.log(result.next());
console.log(result.next());
console.log(result.next());
console.log(result.next());


console.log("==========================");

//way Two

//12---> 0 1 1 2 3 5 8 

function * FibonanciSeries_Max(maxNum) {
    var arr = [0, 1];
    for (var i = 2; i < maxNum; i++) {
        arr.push(arr[i - 1] + arr[i - 2]);
        if (arr[i] > maxNum) {
            arr.pop();
            break;
        }
    }
    for (var i in arr) {
        yield arr[i];
    }
}
var result1 = FibonanciSeries_Max(12);
for(var elem of FibonanciSeries_Max(12))
{
    console.log(elem);
}
/*
console.log(result1.next());
console.log(result1.next());
console.log(result1.next());
console.log(result1.next());
console.log(result1.next());
console.log(result1.next());
console.log(result1.next());
console.log(result1.next());
console.log(result1.next());
console.log(result1.next());*/