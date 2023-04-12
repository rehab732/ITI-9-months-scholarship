const http = require("http");
const fs=require("fs");
let mainhtml=fs.readFileSync("../Client/main.html").toString();
let stylecss=fs.readFileSync("../Client/style.css").toString();
let scriptjs=fs.readFileSync("../Client/script.js").toString();
let image=fs.readFileSync("../Client/Images/mask.png");
let favicons=fs.readFileSync("../Client/Icons/mask.ico");

http.createServer((req,res)=>{
  if(req.url!='/favicon.icon')
  {
   if(req.method=="GET")
   {
    switch(req.url)
    {
        case '/':
        case '/main.html':
        case '/Client/main.html':
            // res.writeHead(200,"OK",{"content-type":"text/html"})
            // res.writeHead(200,"OK",{"set-cookie":"name=Rehab"})
            // res.writeHead(200,"OK",{"Access-Control-Allow-Origin":"*"})

            // res.setHeader("content-type","text/html");
            // res.setHeader("set-cookie","name=Mahmoud");
            res.write(mainhtml);
            break;

        case '/style.css':
        case '/Client/style.css':

            res.write(stylecss);
            break;

        case '/script.js':
        case '/Client/script.js':
          res.write(scriptjs);
            break;
        case '/mask.png':
        case '/Images/mask.png':
        case '/Client/mask.png':
        case '/Client/Images/mask.png':

            res.write(image);
            break;

        case '/mask.ico':
        case '/Client/mask.ico':
        case '/Client/Icons/mask.ico':
            res.write(favicons);
            break;
        default:
            if(req.url.includes("?username"))
            {
                res.write(mainhtml);
            }
            break;
    }
    res.end();


   }else if(req.method=="POST")
   {
        
   }
   else if(req.method=="DELETE")
   {

   }else if(req.method=="PUT")
   {

   }else if(req.method=="PATCH")
   {

   }
   else{
   // res.end("please do common method");
   }
  }
}).listen(7007,()=>{
    {console.log("port 7007")}
})