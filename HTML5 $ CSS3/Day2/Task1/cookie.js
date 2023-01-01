/*
document.cookie("name=value; expires=DAte; path=")
 */

function setCookie(cookiename,cookievalue,exdate)
{
   try{
    if(arguments.length==0)
    throw ("must enter the name ,value and Exdate of the cookie");
    if(arguments.length!=3)
    throw("Not Valid Parameter");
    if(typeof(arguments[2])!='number')
    throw("Must Enter number to calc exdate");
    if(typeof(arguments[0])!='string')
    throw("Cookie name must be string");
    let date=new Date();
    date.setDate(date.getDate()+exdate);
    document.cookie = cookiename + "=" + cookievalue  +";expires="+date + ";path=/";
   }catch(e)
   {
    console.log(e);
   }
}
function getCookie(cookiename)
{
    try{
        if(arguments.length==0)
        throw("must enter cookie name");
        if(arguments.length!=1)
        throw("Just Enter cooki name only");
    var cookieArray=document.cookie.split(";");//have associative array contain key and value

    for(var i=0;i<cookieArray.length;i++)
    {
        var cookiepair=cookieArray[i].split("=");//index 0 have name ; index 1 have value
        if(cookiename==cookiepair[0].trim()){//remove whitespace at the beginning of the cookie name& compaire with the given string 
            return decodeURIComponent(cookiepair[1]);
        }
    }
    return null;
}catch(e)
{
    console.log(e);
}
}

function getallCookies(){
    var cookiesArray=document.cookie.split("; ");
    return cookiesArray;
}

function deleteCookie(cookiename)
{
    let olddate=new Date();
    setCookie(cookiename,'',olddate);
}