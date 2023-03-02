/*let Linked = {
  data: [], 

  Enqueue: function () {
    try {
      let temp = {};
      if (this.data.length == 0) {
        temp["val"] = arguments[0];
        this.data.push(temp);
        console.log("First value added");
      } else {
        if (this.data[this.data.length - 1].val < arguments[0]) {
          temp["val"] = arguments[0];
          this.data.push(temp);
          console.log(" value added");
        } else {
          throw "the value is not in the sequence";
        }
      }
    } catch (e) {
      console.log(e);
    }
  },
//insert at spacific place
  InsertIN: function () {
    try {
      let temp = {};
      console.log(this.data[arguments[0] - 1]);
      if (
        this.data[arguments[0] - 1].val < arguments[1] &&
        arguments[1] < this.data[arguments[0]].val
      ) {
        temp["val"] = arguments[1];
        this.data.splice(arguments[0], 0, temp);
      } else throw "Not in sequence";
    } catch (e) {
      console.log(e);
    }
  },
//Pop a value (remove an item from the end of the list).
  PoP: function () {
    try {
      if (this.data.length == 0) throw "the linked list is empty ";
      return this.data.pop();
    } catch (e) {
      console.log(e);
    }
  },
  //Remove an item from a specific place
  RemoveFrom: function () {
    try {
      if (
        arguments[0] <= this.data.length - 1 &&//index
        arguments[0] >= 0 &&
        this.data[arguments[0]].val == arguments[1]//val
      )
        this.data.splice(arguments[0], 1);//method adds and/or removes array elements.
      else throw "Data not found";
    } catch (e) {
      console.log(e);
    }
  },
 // (remove an item from the beginning of the list 
  Dequeue: function () {
    try {
      if (this.data.length == 0) throw "Linked list is empty";
      this.data.shift();
    } catch (e) {
      console.log(e);
    }
  },
  //print all elements
  Display: function () {
    for (i in this.data) {
      console.log(this.data[i]);
    }
  },


};
*/
/*Linked.Enqueue(3);
Linked.Enqueue(8);
Linked.Enqueue(9);
console.log("if i pushed 1:");
Linked.Enqueue(1);
console.log("insert in 1 value 7:");
Linked.InsertIN(1, 7);
console.log("after pop :");
Linked.PoP();
Linked.log("Display :");
Linked.Display();
Linked.RemoveFrom(1, 7);
Linked.Dequeue();
Linked.Enqueue(8);
*/

// Two ways to take any number of parameter and revers it


var wayone=function(...arr){
     return arr.reverse();
}


var waytwo=function(){
  let arr=[...arguments];
  return arr.reverse();
}

var waythree=function(){
  return [].reverse.call(arguments);
}

//Create a function that accepts only 2 parameters
  var onlyTow=function(){
    try{
      if(arguments.length!=2)
      throw("Must Enter only 2 parameter")
      else
      {
        console.log("correct parameter");
      }
    }
    catch(e)
    {
      console.log(e);
    }
  }



  //Add only Numbers


var addnumbers=function(){
  try{
    let sum=0;
    if(arguments.length==0)
    throw("please Enter Numbers");
  for(i in arguments)
  {
    if(typeof(arguments[i])!='number')
    {
      throw("Sorry we add Numbers only :)")
    }
    sum+=arguments[i];
  }
  return sum;
  }catch(e)
  {
    console.log(e);
  }
}