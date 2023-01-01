var canvas=document.getElementById("can");
var context=canvas.getContext("2d");
canvas.style.border="3px solid red"

context.lineWidth=3
context.beginPath();
context.moveTo(0,0);
var x=0,y=0;
interval=setInterval(function(){

    context.lineTo(x++,y++);
    context.stroke();
    if(x>=canvas.width&&y>=canvas.height)
    {
        clearInterval(interval);
        alert("Time Out for Animation");
    }
},10)

