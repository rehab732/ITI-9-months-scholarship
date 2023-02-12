var myobj={
    name:"Rehab",
    address:"Helwan",
    age:23
}
var handler={
    set(target, prop, value) {
       if(prop==="name")
       {
        if(typeof value !=="string")
        {
            throw "name Must be String"
        }
        if(value.length<7)
        {
            throw "Your Name too short"
        }else{
            target[prop]=value;
        }
       }
       if(prop==="address")
       {
        if(typeof value !=="string")
        {
            throw "Enter string only"
        }else
        {
            target[prop]=value;

        }
        
       }
       if(prop==="age")
       {
        if(value>60 || value<25)
        {
            throw "Your Age not allowed"
        }else{
            target[prop]=value;
        }
       }
    },
    get(target,prop){
        if(target.hasOwnProperty(prop))
        {
            return target[prop]
        }else{
            throw "Enter valid property name"
        }
    }

}

var pro=new Proxy(myobj,handler)