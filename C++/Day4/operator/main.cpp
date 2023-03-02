#include <bits/stdc++.h>
using namespace std;
class comp
{

    float real,img;
public:
    comp(float r,float i)
    {
        real=r;
        img=i;
    }
    comp(float n)
    {
        real=img=n;
    }
    comp()
    {
        real=img=0;
    }
    void printcomp()
    {
        if(real==0)
            cout<<img<<"i"<<endl;
        else if(img==0)
            cout<<real<<endl;
        else if (img<0)
            cout<<real<<img<<"i"<<endl;
        else if(img>0)
            cout<<real<<"+"<<img<<"i"<<endl;

    }
    //operator overloading
    //1) = operator
    comp operator=(comp);
    //2) + operator
    comp operator+(const comp) const;
    //3) - operator
    comp operator-(const comp) const;
    //4) == operator
    int operator==(comp);
    //5) ++ operator pre
    comp operator ++();
    //6) ++ operator post
    comp operator++(int);
    //7) -- operator pre
    comp operator--();
    //8) -- operator post
    comp operator--(int);
    //9) +=operator
    comp operator+=(comp);
    //10) -=operator
    comp operator-=(comp);
    //11)*operator
    comp operator*(const comp) const;
    //12)/operator
    comp operator/(const comp) const;
    //13) operator float
    operator float();
    //14) operator int
    operator int();
    //15) != operator
    int operator!=(comp);
    //16) > operator
    int operator>(comp);
    //17) < operator
    int operator<(comp);
    //18) cout operator
      void setVal(float r, float i)
    {
        real = r;
        img = i;
    }
  friend ostream& operator<<(ostream&,comp);
  //19)cin operator
   friend istream& operator>>(istream&,comp &);



};
comp comp::operator=(comp n)
{
    real=n.real;
    img=n.img;
    return *this;
}
comp comp::operator+(const comp n)const
{
    comp res;
    res.real=real+n.real;
    res.img=img+n.img;
    return res;
}
comp comp::operator-(const comp n)const
{
    comp res;
    res.real=real-n.real;
    res.img=img-n.img;
    return res;
}
int comp::operator==(comp m)
{
    return((real==m.real)&&(img=m.img));//return true if are equal
}
comp comp::operator++(int)//int-->postfix
{
    comp temp=*this;
    real++;
    return temp;

}
comp comp::operator++()
{
    real++;
    return *this;
}
comp comp::operator--(int)//int-->postfix
{
    comp temp=*this;
    real--;
    return temp;

}
comp comp::operator--()
{
    real--;
    return *this;
}
comp comp::operator+=(comp myy)
{
    real=real+myy.real;
    img=img+myy.img;
    return *this;
}
comp comp::operator-=(comp myy)
{
    real=real-myy.real;
    img=img-myy.img;
    return *this;
}
comp comp::operator*(const comp n)const
{
    comp res;
    res.real=real*n.real;
    res.img=img*n.img;
    return res;
}
comp comp::operator/(const comp n)const
{
    comp res;
    res.real=real/n.real;
    res.img=img/n.img;
    return res;
}
comp::operator float()
{
    return real;
}
comp::operator int()
{
    return real;
}
int comp::operator!=(comp m)
{
    return!((real==m.real)&&(img=m.img));
}
int comp::operator>(comp m)
{
    return((real>m.real));
}
int comp::operator<(comp m)
{
    return((real<m.real));
}
ostream& operator<<(ostream& mys,comp c)
{
    mys<<"("<<c.real<<"+i"<<c.img<<")"<<endl;
    return mys;
}

istream& operator>>(istream& m,comp &v)
{
    m>>v.real;
    m>>v.img;
    return m;

}/*
istream& operator>>(istream &ms, comp &c)
{
    float n1, n2;
    ms>>n1;
    ms>>n2;
    c.setVal(n1,n2);
    return ms;
}*/
int main()
{
    cout<<" = operator "<<endl;
    comp c1(2,5),c2(6,1);
    cout<<c1<<endl;

    comp n;
    cout<<"enter the comp number"<<endl;
    cin>>n;
    cout<<"df"<<endl;
    cout<<n;
    /*
    c1=c2;
    c1.printcomp();
    cout<<"\n + operator "<<endl;
    comp c(3,4),c3(7,8),res,ress;
    res= c+c3;
    res.printcomp();
    cout<<"\n - operator "<<endl;
    ress=c-c3;
    ress.printcomp();
    cout<<"\n == operator "<<endl;
    if(c==c3)
        cout<<"2 objects equal each other"<<endl;
    cout<<"not equal "<<endl;
    cout<<"\n ++pre operator "<<endl;
    ress=++c;
    ress.printcomp();
    cout<<"\n ++post operator "<<endl;
    res=c3++;
    res.printcomp();
    c3.printcomp();
    cout<<"\n --pre operator "<<endl;
    comp b(8,4),v(5,6),t;
    t=--b;
    t.printcomp();
    cout<<"\n --post operator "<<endl;
    t=b--;
    t.printcomp();
    b.printcomp();
    cout<<"\n +=operator "<<endl;
    comp cc(3,5),vv(9,7);
    cc+=vv;
    cc.printcomp();
    cout<<"\n -=operator "<<endl;
    comp x(8,5),a(9,8);
    a-=x;
    a.printcomp();
    cout<<"\n *operator "<<endl;
    comp n(3,5),m(5,2),y;
    y=n*m;
    y.printcomp();
    cout<<"\n /operator "<<endl;
    y=n/m;
    y.printcomp();
    cout<<"\n float operator"<<endl;
    float k;
    k=(float)n;
    cout<<k<<endl;
    cout<<"\n int operator"<<endl;
    int l;
    l=(int)m;
    cout<<l<<endl;
    cout<<"\n != operator"<<endl;
    if(n!=m)
        cout<<"yes they diff"<<endl;
    cout<<"\n > operator"<<endl;
    if(m>n)
        cout<<"m >n"<<endl;

    cout<<"\n <operator"<<endl;
    if(n<m)
        cout<<"n<m"<<endl;



*/

    return 0;
}
