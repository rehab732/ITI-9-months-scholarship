var canvas = document.getElementById("can");
canvas.style.border = "3px solid pink"


var ctx = canvas.getContext('2d');

var flag = true, count=0, circleInterval;

circleInterval = setInterval(function(){
    if(count<=10){
        count++;
        drawCircle(flag, Math.PI)
        flag = !flag;
    }else{
        clearInterval(circleInterval);
        drawCircle(flag, 2*Math.PI)
    }
}, 500)



function drawCircle(flag, angle){ 
    ctx.clearRect(0, 0, canvas.width, canvas.height);
    ctx.beginPath();
    ctx.font="60px Arial"
    ctx.strokeStyle="green"
    ctx.strokeText("Circle",100,50);
    ctx.arc(200,200,100,0, angle,flag)
    ctx.fillStyle="green";
    ctx.fill();
    ctx.stroke();
    ctx.closePath();
}