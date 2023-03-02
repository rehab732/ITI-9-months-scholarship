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
public:
    Circle()
    {
        rad=0;
    }
    Circle(int x,int y,int r):center(x,y)
    {
        rad=r;
    }
    void draw()
    {

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
public:
    rec() {}
    rec(int x1,int y1,int x2,int y2):UL(x1,y1),LR(x2,y2)
    {}
    void draw()
    {
        rectangle(UL.getx(),UL.gety(),LR.getx(),LR.gety());
    }
};
class lin
{
    Point startP,endP;
public:
    lin() {}
    lin(int x1,int y1,int x2,int y2):startP(x1,y1),endP(x2,y2)
    {}
    void draw()
    {
        setcolor(RED);

        line(startP.getx(),startP.gety(),endP.getx(),endP.gety());


    }
};
//one to many relatinon
class pic
{
    Circle *pcr;
    rec *prec;
    lin *pli;
    int cn;//circle number
    int rn;//rec number
    int ln;//line number
public:
    pic()
    {
        cn=0;
        rn=0;
        ln=0;
        pcr=NULL;
        prec=NULL;
        pli=NULL;
    };
    pic(Circle *pc,rec *pr,lin *pl,int cnn,int rnn,int lnn)
    {
        cn=cnn;
        rn=rnn;
        ln=lnn;
        prec=pr;
        pcr=pc;
        pli=pl;

    };
    void setcirr(Circle *pc,int cnn)
    {
        pcr=pc;
        cn=cn;
    };
    void  setrecc(rec *pr,int rnn)
    {
        prec=pr;
        rn=rnn;
    };
    void setlinn(lin *pl,int lnn)
    {
        pli=pl;
        ln=lnn;
    };
    void paint();
};
void pic::paint()
{
    int i;
    for(i=0; i<cn; i++)
    {
        pcr[i].draw();
    }
    for(i=0; i<ln; i++)
    {
        pli[i].draw();
    }
    for(i=0; i<rn; i++)
    {
        prec[i].draw();
    }
}
int main()
{

    initwindow(500,500);
    setcolor(YELLOW);
    setcolor(RED);
    rectangle(40,70,410,290);
    setfillstyle(SOLID_FILL,YELLOW);
    //floodfill(200,200,YELLOW);
    circle(50,80,60);
    floodfill(200,200,RED);

   /* int gd=DETECT,gm;

    initgraph(&gd,&gm,"");
     lin s(100,100,200,200);
     setcolor(yellow);
     s.draw();

     lin s1(200,100,100,200);
     s1.draw();

     Circle c;
     c.setCenter(150,150);
     c.setRad(50);
     c.draw();

     rec r(100,100,200,200);
     r.draw();*/
     /*


    pic mypic;
    Circle cArr[3]= {Circle(100,200,150),Circle(420,50,200)};
    rec rArr[2]= {rec(350,300,300,150),rec(350,500,300,350)};
    lin lArr[2]= {lin(400,200,450,350),lin(600,200,650,350)};

    mypic.setcirr(cArr,3);
    mypic.setlinn(lArr,2);
    mypic.setrecc(rArr,2);
    mypic.paint();
*/

    getch();

    return 0;
}

