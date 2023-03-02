#include <iostream>

using namespace std;
class Complex{
    float real;
    float img;
public:
    void setreal(float r){
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

};
Complex Add(Complex n,Complex j)
{
    Complex res;
    res.setreal(n.getreal()+j.getreal());
    res.setimg(n.getimg()+j.getimg());
    return res;

};
int main()
{
    while(true){
        system("cls");
    int d;
    Complex n,s,result;
    float c;
    cout<<"Enter real 1:"<<endl;
    cin>>c;
    n.setreal(c);
    cout<<"Enter img 1:"<<endl;
    cin>>c;
    n.setimg(c);
     cout<<"Enter real 2:"<<endl;
    cin>>c;
    s.setreal(c);
    cout<<"Enter img 2:"<<endl;
    cin>>c;
    s.setimg(c);
    result=Add(n,s);
    cout<<"the sum is :";
    result.printcomp();
    cin>>d;

    }



    return 0;
}
