
// var EventEmmiter=require("events");
// // step 1 ==>create instance from event
// var e1=new EventEmmiter();

// // step 2 ==>do listener and emit the event (fire)
// e1.once("abc",()=>{console.log("Event Abc Fired")})
// e1.once("xyz",()=>{console.log("Event xyz Fired")})

// e1.emit("abc");
// e1.emit("xyz");
// e1.emit("xyz");
// e1.emit("xyz");
// e1.emit("xyz");



var EventEmmiter=require("events");

class myClassEvent extends EventEmmiter{
    //add your properties
}

module.exports={
    myClassEvent
}

var e1=new myClassEvent();
e11.on("s",()=>{});
e11.emit("s");
