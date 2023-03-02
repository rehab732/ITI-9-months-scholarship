#include <bits/stdc++.h>
#include "graphics.h"
using namespace std;

class Point
{
    int x,y;
public:
    Point()
    {
        x=y=0;
    }
    Point(int m,int n)
    {
        x=m;
        y=n;
    }
    Point(int v)
    {
        x=y=v;
    }

    void setx(int m)
    {
        x=m;
    }
    void sety(int n)
    {
        y=n;
    }
    int getx()
    {
        return x;
    }
    int gety()
    {
        return y;
    }

};
//circle
class Circle
{
    Point center;
    int rad;
    int color;
public:
    Circle()
    {
        rad=0;
        color=0;
    }
    Circle(int x,int y,int r,int c):center(x,y)
    {
        rad=r;
        color=c;
    }
    void draw()
    {
        setcolor(color);
        circle(center.getx(),center.gety(),rad);


    }
    void setCenter(int x1,int y1)
    {
        center.setx(x1);
        center.sety(y1);
    }
    void setRad(int r)
    {
        rad=r;
    }

};
class rec
{
    Point UL,LR;
    int color;
public:
    rec() {color=0;}
    rec(int x1,int y1,int x2,int y2,int b):UL(x1,y1),LR(x2,y2)
    {
        color=b;
    }
    void draw()
    {
        setcolor(color);
        rectangle(UL.getx(),UL.gety(),LR.getx(),LR.gety());
    }
};
class lin
{
    Point startP,endP;
    int color;
public:
    lin() {color=0;}
    lin(int x1,int y1,int x2,int y2,int n):startP(x1,y1),endP(x2,y2)
    {color=n;}
    void draw()
    {
        setcolor(color);

        line(startP.getx(),startP.gety(),endP.getx(),endP.gety());


    }
};

int main()
{

    int gd=DETECT,gm;

    initgraph(&gd,&gm,"");
    lin s(100,100,200,200,1);

     s.draw();

     lin s1(200,100,100,200,2);
     s1.draw();
     Circle c(150,150,50,4);
     c.draw();


     rec r(100,100,200,200,6);
     r.draw();

    getch();

    return 0;
}

