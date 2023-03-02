/*
let arr = [];
let reqNum;

function write(info, msg) {
  document.write(
    "<h1 style='color: red;'>" +
      msg +
      " " +
      "<span style='color: black; font-weight:bolder;'>" +
      info +
      "</span>" +
      "</h1>"
  );
}


for (let i = 0; i < 5; i++) {
  reqNum = prompt("Please Enter No. " + (i + 1));
  arr.push(reqNum);
}

write(arr, "You have entered the values of");

write(
  arr.sort(function (a, b) {
    return b - a;
  }),
  "Your values after being sorted descending"
);
write(
  arr.sort(function (a, b) {
    return a - b;
  }),
  "Your values after being sorted ascending"
);*/
/*
var rad=prompt("Enter the value of circle raduis");
var area = (parseInt(rad) * parseInt(rad) * Math.PI);
alert("Total area of the circle is :"+area);



const num=prompt("Enter the value you want to calculate its squere root");
alert("The squer root of "+num+" is "+Math.sqrt(num));




let angle=prompt("Enter the angle you want to calc its cos valus");
let raa=Math.PI*angle/180;
document.write("Cos "+angle+"is :"+Math.cos(raa).toFixed(2));
*/



var time;
var win;
function openmove()
    {
        win=window.open("child.html","","width=150,height=150");
       var y=100;
       var x=100;
       time= setInterval(function () {
        win.moveBy(x,y);
        if(win.screenY>540||win.screenY<1) {
            y*=-1;
           

        }
        if(win.screenX>1300||win.screenX<1)
        {
            x*=-1;

        }

        
       }, 300);
    
    }
    function closewind()
    {
        clearInterval(time);
        win.focus();

    }
    function typingMessage()
    {
        var str="welcome to my assignment !";
       var win=window.open("blankw.html","","width=300,height=300");
        win.focus();
       
        var i=0;
        var timeid=setInterval(() => {
           
            if(i==str.length-1)
            {
                win.close();
                clearInterval(timeid);
            }
            var x="";
            
            win.document.write (str[i]);
            i++;
        }, 300);
        
    }
    function ScrollDpage()
    {
       var win=window.open("scroll.html","","width=200,height=200");
        win.focus();
        var i=0;
        var timeid=setInterval(() => {
           
           if(i>=win.document.body.offsetHeight-win.innerHeight)
           {
               win.close();
               clearInterval(timeid);
           }
           win.scrollBy(0,50)
           i+=50;
       }, 1000);
        
    }
    

    
   


