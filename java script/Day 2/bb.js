
/*task 1
var input=prompt("Enter String");
var letter=prompt("Enter char");
var casee=prompt("Enter 0 if care with lettre cases or enter 1 if not");
function countstring(input,letter)
{
    var countletter=0;
    for(var pos=0; pos< input.length;pos++)
    {
        
        if(parseInt(casee)==0)
        {


            if(input.charAt(pos).toUpperCase()===letter.toUpperCase())
            {
                countletter+=1;
            }

        }else if(parseInt(casee)==1)
        {
            if(input.charAt(pos)===letter)
            {
                countletter+=1;
            }
        }
        
    }
    return countletter;
}
document.write(countstring(input,letter));
*/

/*task 2
var word=prompt("Enter word");
var casee=prompt("Enter 0 if care with lettre cases or enter 1 if not");
let palindrom = function(word)
{
    let l = word.length;
    let start;
    let end;
    let fliping;

    if(parseInt(casee)==0)
    {
         start=word.substring(0,Math.floor(l/2));
     end = word.substring(l-Math.floor(l/2));
     fliping=end.split('').reverse().join('');

    }else if(parseInt(casee)==1)
    {
         start=word.substring(0,Math.floor(l/2)).toLowerCase();
         end = word.substring(l-Math.floor(l/2)).toLowerCase();
         fliping=end.split('').reverse().join('');

    }
   
    return (start===fliping);
}

document.write(palindrom(word));

*/


/* task 3
function findLongestWord(str) {
    var strSplit = str.split(' ');
    var longestWord = 0;
    var result="";
    for(var i = 0; i < strSplit.length; i++){
      if(strSplit[i].length > longestWord){
      longestWord = strSplit[i].length;
      result=strSplit[i];
       }
    }
    return result;
  }
  var str=prompt("Enter long sentence");
  document.write(findLongestWord(str));
  
*/

 
 
  
/*task 4
var namm=prompt("Enter your name");
var phone= prompt("Enter your phone number");
var mobile=prompt("Enter your mobile number");
var email= prompt("Enter your email");
  function validname(username)
  {
   var letters = /^[A-Za-z]+$/;
   if(username.match(letters))
     {
      return username;
     }
   else
     {
    
     return "False";
     }
  }
function validphone(ph)
{
     var numbers = /^[0-9]+$/;
     if(ph.match(numbers)&&ph.length==8)
     {
        return ph;
     }else{
        return "False";
     }
} function mailvalid(ma)
{
    var mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    if(ma.match(mailformat))
    {
        return ma;
    }else{
        return "False";
    }
}
function mobvaild(mm)
{
    var mobileformat=/^(010|011|012)[0-9]{8}$/;
    if(mm.match(mobileformat))
    {
        return mm;
    }else{
        return "False";
    }
}

document.write('<span style="color: red;">Your Name=</span>'+validname(namm)+'<br>');
document.write('<br>'+'<span style="color: red;">Your phone=</span>'+validphone(phone)+'<br>');
document.write('<br>'+'<span style="color: red;">Your Mobile=</span>'+mobvaild(mobile)+'<br>');
document.write('<br>'+'<span style="color: red;">Your Email=</span>'+mailvalid(email)+'<br>');

  */