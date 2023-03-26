/*const os=require("os");
console.log(os.hostname);


const fs=require("fs");
fs.readFile("Hamada.txt","utf-8",(err,data)=>{
       if(err)
       {
        console.log(err);
       }else{
        console.log(data);
       }
})*/


const fs = require("fs");
const http = require("http");


const Server= http.createServer((req,res)=>{
    
    if(req.url !== "/favicon.ico"){
        //step 1 need to split url
         //step 2  know operator
        let  inputs=req.url.split('/');
        let operator=inputs[1];
        let nums=inputs.slice(2);
        let result=0;
        switch(operator)
        {
            case 'add':
                result=add(...nums)
                break;
            case 'sub':
                result=sub(...nums)

                break;
            case 'mult':
                result=mult(...nums)

                break;
            case 'divid':
                result=divid(...nums)

                break;
            default:
                result="Sorry Can't detect this operation";
                break;

        }
        fs.writeFileSync("Hamada.txt","Your Result = "+result.toString()+"\n")

       
    }
    res.end()
}).listen(7000,()=>{console.log("lise")})

let add=(...inputs)=>{
    let resu=0
    inputs.forEach((input)=>{
        resu+=Number.parseInt(input)
    })
    return resu;
}

let sub=(...inputs)=>{
    let resu=0
    inputs.forEach((input)=>{
        resu-=Number.parseInt(input)
    })
    return resu;
}
let mult=(...inputs)=>{
    let resu=0
    inputs.forEach((input)=>{
        resu*=Number.parseInt(input)
    })
    return resu;
}
let divid=(...inputs)=>{
    let resu=0
    inputs.forEach((input)=>{
        resu/=Number.parseInt(input)
    })
    return resu;
}