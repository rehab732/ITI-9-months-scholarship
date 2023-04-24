// console.log(window);


(function(callingname,environment,myFun){
    if(typeof module !='undefined')//true and will work on server
    {
        //server side
        module.exports={myUMD:myFun}
    }else{
        //client side 
        // window.UMD=myFun//as refrence
        environment[callingname]=myFun//subscript notation ==>to not call property by callingname
    }
})("myUMD",this,()=>{return "hello in umd"})//this (client or server)


// console.log(module);