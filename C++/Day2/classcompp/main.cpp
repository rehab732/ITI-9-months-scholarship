#include <iostream>

using namespace std;
class Complex
{
    float real;
    float img;
public:

    Complex()
    {
        real=0;
        img=0;

    }

   Complex(float r,float i)
    {
        real=r;
        img=i;
    }
    Complex(float n)
    {
        real=n;
        img=n;
    }
    void setreal(float r)
    {
        real=r;
    }
    void setimg(float i)
    {
        img=i;
    }
    float getreal()
    {
        return real;
    }
    float getimg()
    {
        return img;
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
    /*~Complex()
    {
        cout<<"iam a destructor"<<endl;
    }*/

};
Complex Add(Complex n,Complex j)
{
    Complex res;
    res.setreal(n.getreal()+j.getreal());
    res.setimg(n.getimg()+j.getimg());
    return res;

};
Complex Add(Complex n,float j)
{
    Complex res;
    res.setreal(n.getreal()+j);
    res.setimg(n.getimg());
               return res;

};
Complex Add(float n,Complex j)
{
    Complex res;
    res.setreal(n+j.getreal());
    res.setimg(j.getimg());
    return res;

};
Complex Add(Complex n,Complex j,Complex x)
{
    Complex res;
    res.setreal(n.getreal()+j.getreal()+x.getreal());
    res.setimg(n.getimg()+j.getimg()+x.getimg());
    return res;

};
int main()
{
    Complex res;
    Complex c1;
   Complex C2(12.0,13.0);
    Complex c3(5);
     cout<<"c1 is:";
    c1.printcomp();
    cout<<"C2 is:";
    C2.printcomp();
    cout<<"C3 is:";
    c3.printcomp();
   cout<<"**********************"<<endl;
   res=Add(C2,c3);
   cout<<"sum result :";
   res.printcomp();
   cout<<"**********"<<endl;
   res=Add(5.2,C2);
   cout<<"sum result :";
   res.printcomp();
     cout<<"**********"<<endl;
   res=Add(C2,3.6);
   cout<<"sum result :";
   res.printcomp();




    return 0;
}
