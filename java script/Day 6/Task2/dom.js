let img=document.getElementById("header");
img.style.textAlign="right";
  document.getElementById("nav").style.listStyleType="circle";
  //document.getElementById("nav").style.alignItems="right";

  let newimg=img.cloneNode(true);
  newimg.style.textAlign="left";
  document.body.appendChild(newimg);