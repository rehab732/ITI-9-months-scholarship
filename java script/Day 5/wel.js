/*function welcompart(){
   var space=document.getElementById("welcom");
   var color=getCookie("color");
   if(color=='red')
   {
    space.innerHTML="Welcom " + "<h1 style = 'color:red;'>" +getCookie("name")
   }
    
}*/

setCookie("visitcounter",parseInt(getCookie("visitcounter"))+1 ,14);
var image=document.getElementById("image");
var gender=getCookie("gender");
console.log(image);

if(gender=='female')
{
    image.src="assets/female.png";
}else
{
    image.src="assets/male.png";
}
var ele=document.getElementById("welcom");
var color=getCookie("color");
ele.innerHTML= "<h1 >Welcom " + "<span style='color:"+getCookie("color")+";'> "+getCookie("name")+"</span>"+ " you have visited this site "+ "<span style='color:"+getCookie("color")+";'> "+getCookie("visitcounter")+"</span>"+"</h1>";

