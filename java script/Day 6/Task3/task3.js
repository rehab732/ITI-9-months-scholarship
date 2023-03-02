
var arr = document.getElementsByName("inp") 
var imgID


function checked() {
    
for (var i = 0; i < arr.length; i++){
        if (arr[i].checked) {
            document.getElementById(arr[i].id).style.border = "thick solid orange"
            imgID=arr[i].id
        }
        else {
            document.getElementById(arr[i].id).style.border = "0px solid orange"
        }
    }
}


function setCoockie(cname,cvalue,months) {
    const d = new Date();
    d.setMonth(d.getMonth()+months);
    let expires = "expires="+ d.toUTCString();
    document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/";
}


function getCookie(cname) {
    let name = cname + "=";
    let ca = document.cookie.split(';');
    for (let i = 0; i < ca.length; i++) {
        let c = ca[i];
        
      if (c.indexOf(name) == 1) {
        return c.substring(name.length+1, c.length);
      }
    }
    return '';
}
  


function newPage() {
    var msg = document.getElementById("message").value;
    setCoockie("msg", msg, 1);
    var img = "assets/"+imgID+".jpg"
    setCoockie("img",img,1)
    win= window.open("msg.html","","width=500,height=500")
    

}

function loading() {
    const contain = document.createElement("div")
    const im = document.createElement("img")
    const txt = document.createElement("h1");
    const btn = document.createElement("input")
    msg=getCookie("msg")
    img = getCookie("img")
    im.src=img
    txt.innerHTML = msg;

    contain.setAttribute("id","container")
    btn.setAttribute("type", "button")
    btn.setAttribute("value","close")
    txt.setAttribute("id", "msg");
    im.setAttribute("id", "img");
    btn.setAttribute("id", "btn");
    btn.setAttribute("onclick","closee()")

    
    document.body.append(contain)
    document.getElementById("container").append(im)
    document.getElementById("container").append(txt)
    document.getElementById("container").append(btn)
    
}

function closee() {
    console.log('closedd');
    window.close()
}
