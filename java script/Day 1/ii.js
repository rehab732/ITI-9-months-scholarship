/*

function headers() {
    for (var num = 1; num <=6; num++) {
        document.write("<h" + num + ">" + "This is header number " + num + "</h" + num + ">");
    }
}



  <h1>Heading</h1>
    <hr>
    <p>
        <button type="button" onClick="headers()"> click on me</button>
    
    </p>
    */
   var sum=0;
  
   do{
    var m=prompt("Enter Number");
    if(isFinite(m))
    sum+=parseInt(m);
   }while(m!=0&&sum<100);
if(sum!=0)

   alert("sum is" +sum);