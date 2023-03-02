#include <iostream>
using namespace std;
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
   virtual float calarea()=0;//pure virtual-->became an abstract class

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




    return 0;
}
/*
can not simply an object from it .
if not implemented the pure virtual function , the child class will be abstract class
*/
