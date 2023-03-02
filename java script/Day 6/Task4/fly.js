


let  i1=10,i2=480,ii=10,setInt,coun=0;
let container = window.getComputedStyle(document.getElementById("div1"))
let width = container.getPropertyValue("width");
let height = container.getPropertyValue("height");
height = parseInt(height);
width = parseInt(width)

let image1 = document.getElementById("icon1")
image1.style.top=(height/2)+"px"
image1.style.left=10+"px"


let image2 = document.getElementById("icon2")
tor=window.getComputedStyle(image2)
//console.log(tor);
image2width = parseInt(tor.getPropertyValue("width"));
console.log(image2width);//30
image2.style.top = ((height / 2)) + "px"
image2.style.left=(width-image2width)+"px"

topimage = document.getElementById("top")
topimage.style.left = width/2 +"px"



let button = document.getElementById("btn")
button.addEventListener("click", () => {
    console.log(typeof button.value);
    if (button.value == "go") {
        gofly();
        button.value="stop"
    }
    else {
        stopfly()
        button.value="go"
    }
})


function gofly() {
    image1.style.left = (i1 + "px");
    image2.style.left = (i2 + "px");
    topimage.style.top = (i1 + "px");
    i1 += ii;
    i2+=(ii*-1)
      
    coun += 10
    if (coun == 460) {
        ii *= -1
        coun=0
    }
    setInt = setTimeout(gofly, 50);
    
}

function stopfly() {
    clearTimeout(setInt)
}



function resetimage() {
    clearTimeout(setInt)
    button.value = "go"
    
    image1.style.left="0px"
    image2.style.left = (width - image2width) + "px"
    topimage.style.top = "0px"
    i1 = 10
    i2 = 480
    coun = 0
    ii=10
    
}



