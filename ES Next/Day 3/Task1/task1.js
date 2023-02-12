class polygon
{
    constructor(height,width)
    {
        this.name="polygon";
        this.height=height;
        this.width=width;
    }
    toString()
    {
        return `
        Shape Name is : ${this.name}
        Area is : ${this.area()} 
        Premieter is :${this.preimeter()}
        `;
    }
}
class rectangle extends polygon{
   constructor(height,width)
   {
    super(height,width);
    this.name="Rectangle";
   }
 
   calcArea(){
    return (this.height +this.width);
   }
   get area()
   {
    return this.calcArea;
   }
   calcpremiter(){
    return (this.height +this.width)*2;
   }
   get preimeter()
   {
    return this.calcpremiter;
   }


 draw() {
    const canvas = document.getElementById("mycan");
    const ctx = canvas.getContext("2d");
    ctx.beginPath();
    ctx.rect(20, 20, this.width, this.height);
    ctx.stroke();
    ctx.fillStyle = "pink";
    ctx.fill();
    ctx.closePath();
  }
}

class circle extends polygon{
    constructor(raduis)
    {
     super(raduis,raduis);
     this.name="Circle";
    }
  
    calcArea(){
     return (Math.PI*this.height*this.height);
    }
    get area()
    {
     return this.calcArea;
    }
    calcpremiter(){
     return (Math.PI*this.height)*2;
    }
    get preimeter()
    {
     return this.calcpremiter;
    }

  draw() {
        const canvas = document.getElementById("mycan");
        const ctx = canvas.getContext("2d");
        ctx.beginPath();
        ctx.arc(95,200,this.height,0,2*Math.PI);
        ctx.stroke();
   } 
}
class square extends polygon{
   constructor(height,width)
   {
    super(height,width);
    this.name="square";
   } 
 
   calcArea(){
    return (this.height *this.width);
   }
   get area()
   {
    return this.calcArea;
   }
   calcpremiter(){
    return (this.height +this.width)*2;
   }
   get preimeter()
   {
    return this.calcpremiter;
   }

   draw() {
    const canvas = document.getElementById("mycan");
    const ctx = canvas.getContext("2d");
    ctx.beginPath();
    ctx.rect(350, 20, this.height, this.width);
    ctx.stroke();
    ctx.fillStyle = "red";
    ctx.fill();
    ctx.closePath();
  }
}

class triangle extends polygon{
    constructor(height,width)
    {
     super(height,width);
     this.name="Triangle";
    } 
  
    calcArea(){
     return (this.height *this.width)*0.5;
    }
    get area()
    {
     return this.calcArea;
    }
    calcpremiter(){
     return (this.height +this.width);
    }
    get preimeter()
    {
     return this.calcpremiter;
    }
 
    draw() {
     const canvas = document.getElementById("mycan");
     const ctx = canvas.getContext("2d");
     ctx.beginPath();
     ctx.moveTo(this.height,this.height);
     ctx.lineTo(this.height,this.width);
     ctx.lineTo(this.width,this.width);
     ctx.closePath();
     ctx.fillStyle="black";
     ctx.fill();
     ctx.strokeStyle="green";
     ctx.stroke();

   }
    
}

var rec=new rectangle(100,200);
var cir=new circle(50);
var tri=new triangle(200,350);
var squ=new square(100,100);

rec.draw();
cir.draw();
tri.draw();
squ.draw();
