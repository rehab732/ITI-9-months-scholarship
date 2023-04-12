function sum(x,y){
    if(isFinite(x) && isFinite(y)){

        return x+y;
    }else{
        throw new TypeError("nums only")
    }
}
function convertToArray(x,y,z){
    return [x,y,z]
}
function checkPositivity(x){
    if(x>0){
        return true
    }else{
        return false
    }
}

const capitalizeText = (input) => {
    if (typeof input !== "string"){
      throw new TypeError("parameter should be string")
    };
    return input.toUpperCase();
  };


  const createArray = (number) => {
    const myArray = Array.from(Array(number).keys());
    return myArray;
  };
  
  
module.exports = {sum,convertToArray,checkPositivity,capitalizeText,createArray}