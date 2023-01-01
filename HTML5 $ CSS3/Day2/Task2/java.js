var canvas = document.getElementById("can");
var ctx = canvas.getContext("2d");

ctx.beginPath();
ctx.moveTo(200,100);
ctx.lineTo(200,300);
ctx.lineTo(50,300);
ctx.font="10pt Georgia";
ctx.linewidth=3;
ctx.fillText("C",100,200);
ctx.fillText("B",210,200);
ctx.fillText("A",125,320);
ctx.fillStyle="red";
ctx.fill();