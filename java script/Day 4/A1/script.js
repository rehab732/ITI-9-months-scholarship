let x = location.search;
x = x.slice(1, x.length);
x = x.split("&"); 
console.log(x);
for(let i=0; i<x.length; i++){
    x[i] = x[i].split("=");
}
for(let i=0; i<x.length; i++){
     x[i][1] = x[i][1].replace(/\+/g, " ");
     x[i][1] = x[i][1].replace(/\%40/g, "@");
     console.log(x[i][1]);
}
console.log(x);
for(let i=0; i<x.length; i++){
    console.log(x[i][0] + " = " + x[i][1]);
    document.getElementById(x[i][0]).innerText = x[i][1];
}