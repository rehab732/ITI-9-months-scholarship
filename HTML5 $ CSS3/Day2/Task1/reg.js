/*
here need to save all data we get from the user and save it
*/
function setallcookies()
{
    
    AllData=document.getElementsByTagName('input');
    for(i=0; i<AllData.length;i++)
    {
        if(AllData[i].type!='radio' || (AllData[i].type=='radio' && AllData[i].checked))
        {
            var name=AllData[i].name;
            var value=AllData[i].value;
            setCookie(name,value,14);
        }
    }
    selectinput=document.getElementsByTagName('select');
    var name=selectinput[0].name;
    var value=selectinput[0][selectinput[0].selectedIndex].innerText;
    setCookie(name,value,14);

   
     setCookie('visitcounter','0',14);
     location.assign("./welcom.html");
}