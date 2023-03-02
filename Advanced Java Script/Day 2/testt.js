

//problem 1
var object={
    address:"Alex",
    getSetGen:function()
    {
        for(var i in this)
        {
            if(typeof(this[i])!='function')
            {
                var propertyGetersName="get"+i;
                this[propertyGetersName]=function()
                {
                    return this[i];
                }
                var propertySetersName="set"+i;
                this[propertySetersName]=function(val)
                {
                    this[i]=val;
                }

            }
        
        }

    }
        


}
/*
let obj2={};
obj2.id=9;
obj.id=3;
obj.getSetGen();
console.log(obj.getid());
obj.getSetGen.call(obj2);
console.log(obj2.getid());
*/

//problem 2
function Rec(height,width)
{
    this.height=height;
    this.width=width;
    this.RecArea=function (){
        return this.height*this.width;

    }
    this.Recperim=function(){
        return 2*(this.height+this.width);
    }

    this.print=function(){
        console.log(`Height is ${this.height} Width is ${this.width} Area is ${this.RecArea()} Premiter is ${this.Recperim()}`)
    }
}