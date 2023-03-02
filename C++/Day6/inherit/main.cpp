#include <iostream>
using namespace std;
/*class base{
protected:
    int a,b;
public:
    base(){a=b=0;}
    base(int n)
    {
        a=b=n;
    }
    base(int x,int m )
    {
        a=x;
        b=m;
    }
    void setA(int n)
    {
        a=n;
    }
    void setB(int m)
    {
        b=m;
    }
    int getA(){
        return a;
    }
    int getB()
    {
        return b;
    }
    int sum()
    {
        return a+b;
    }
};
class derived :public base{
    int c;
public:
    derived(){c=0;}//call default base constructor
    derived(int n):base(n)//call parameter base constructor
    {
        c=n;
    }
    derived(int y,int f,int k):base(y,f)
    {
        c=k;
    }
    void setC(int g)
    {
        c=g;
    }
    int getC()
    {
        return c;
    }
    int sum()
    {
       return a+b+c;
       //return base::sum()+c;
    }
};*/

class Geoshape{

protected:
    float dim1,dim2;
public:
    Geoshape(){dim1=dim2=0;}
    Geoshape(float b)
    {
        dim1=dim2=b;
    }
    Geoshape(float a,float c)
    {
        dim1=a;
        dim2=c;
    }
    void set1(float f)
    {
        dim1=f;
    }
       void set2(float f)
    {
        dim2=f;
    }
    float get1()
    {
        return dim1;
    }
     float get2()
    {
        return dim2;
    }
   virtual float calarea()
    {
        return 0;
    }
};

class circle:public Geoshape{

public:
    circle(){};
    circle(float r):Geoshape(r){};
     void setr(float r)
    {
        dim1=dim2=r;
    }
    float calarea(){
        return 3.14*dim1*dim2;
    }

};
class rec:public Geoshape
{
public:
    rec(){};
    rec(float l,float w):Geoshape(l,w){};
    float calarea()
    {
        return dim1*dim2;
    }

};
class squ:public rec
{
public:
    squ(){};
    squ(float l):rec(l,l){};
    float calarea()
    {
        return dim1*dim2;
    }


};
class tre:public Geoshape
{
public:
    tre(){};
    tre(float l,float w):Geoshape(l,w){};
    float calarea()
    {
        return 0.5*dim1*dim2;
    }

};

//standalone function
float sumofareas(Geoshape *g1,Geoshape *g2,Geoshape *g3)
{
    return g1->calarea()+g2->calarea()+g3->calarea();
}

int main()
{

////virtual function rule 1
    Geoshape *p;
    circle myc(10);
    rec myr(3,5);
    p=&myc;
    cout<<p->calarea()<<endl;
    p=&myr;
    cout<<p->calarea()<<endl;

//dynamic binding rule 2
    Geoshape *b;
    circle myyc(10);
    rec myyr(3,5);
    squ myys(7);
    tre myyt(10,20);
    cout<<"sum of areas : "<<sumofareas(&myyc,&myyr,&myys);



    /*
    tre t(20,10);
    cout<<t.calarea()<<endl;
    circle c(7);
    cout<<c.calarea()<<endl;
    rec r(2,5);
    cout<<r.calarea()<<endl;
    squ s(5);
    cout<<s.calarea()<<endl;
    */




    //logical error
    /*squ ss;
    ss.set1(4);
    ss.set2(8);
 cout<<ss.calarea();//convert squere to rectangle*/


    /*

   derived q(7,1,2);
  int b= q.sum();//by default search on derived class first
  cout<<b<<endl;*/





    return 0;
}
/*
   1) virtual function ->allows us to decide which function to call during runtime not during compile time
   2) implemented in base class only----apply in all child classes until override it
   3) not work with private and protected inhiretince

*/
