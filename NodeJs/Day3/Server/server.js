// let myMod=require("../Modules/umdModule");
// // console.log(myMod);
// console.log(myMod.myUMD());


// const express=require("express");
// const app=express();
// const path=require("path");
// const bodyParser=require("body-parser");

// app.use(bodyParser.urlencoded())
// app.use(bodyParser.json())


// let PORT=process.env.PORT ||7008
// app.all('/',(req,res,hamada)=>{
//     console.log("Middleware called");
//     // res.send("Hello Ra7oba");
//     hamada();
// })

// app.get('/',(req,res)=>{
//     console.log("on / get")
//     res.send("Hello Ra7oba");
// })
// app.get('/main.html',(req,res)=>{
//     // res.sendFile("E:/ITI/ITI-9-months-scholarship/NodeJs/Day3/Client/main.html")
//     res.sendFile(path.join(__dirname,"../Client/main.html"))
// })

// app.get('/:op/:num1/:num2',
// //first middelware
// (req,res,next)=>{
//     console.log(req.params.num1);
//     req.params.num1=10;
//     next();
// },//second middelware
// (req,res,next)=>{
//     console.log(req.params.num1);
//     req.params.num1=10;
//     next();
// },(req,res)=>{
//     console.log(req.params);//{ op: 'add', num1: '7', num2: '8' }
//     res.send("Operation Ended")
// })

// app.post("/",(req,res)=>{
//     console.log(req.body);
//     res.send("post called")
// })
// console.log(PORT);
// app.listen(PORT,()=>{console.log("http://www.localhost:"+PORT)});
////////////task///////////////////////

let name = "";
let email = "";
let address = "";
let mobile = "";
let obj={}
const express=require("express");
const app=express();
const path=require("path");
const bodyParser=require("body-parser");



app.use(bodyParser.urlencoded({extended:false}))
app.use(bodyParser.json())
let PORT=process.env.PORT ||7008

//console.log(PORT);


app.get('/',(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/main.html"))

})
app.get('/main.html',(req,res,hamada)=>{
    res.sendFile(path.join(__dirname,"../Client/main.html"));
   
})

app.post("/",(req,res)=>{
    // console.log(req.body);
    // const formData = req.body;
    // res.render('persondata', { formData });
    name = req.body.name
    email = req.body.email
    address = req.body.add
    mobile = req.body.phone
    obj={name,email,address,mobile}
    
   res.send("post called")
})

app.post("/main.html",(req,res)=>{
    // console.log(req.body);
    const formData = req.body;
    res.render('persondata', { formData });
    res.send("post called")
 })

app.listen(PORT,()=>{console.log("http://www.localhost:"+PORT)});
