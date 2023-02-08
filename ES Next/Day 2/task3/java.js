/**
 * Task 3
 */
var myobject = {
    [Symbol.replace]: function (str, index) {
      if(str.length > index)
      {
        return str.substring(0, index).concat("...");
      }
      else
      {
        return str;
      }
    },
  };
  

  /**
   * var myObj = {
  [Symbol.replace]: (str) => {
    return str.length > 15 ? str.substring(0, 15) + "..." : str;
  },
};

var result = "Rehab Mohamed Ahmed Zaki".replace(myObj);
console.log(result);

   */

  console.log("Rehab Mohamed Ahmed Zaki".replace(myobject, 15));
  console.log("Rehab".replace(myobject, 15));
  console.log("==========================");
  
