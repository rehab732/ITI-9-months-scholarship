#include <iostream>

using namespace std;
struct Complex
{
    float real;
    float img;
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
int main()
{


    Complex c1;
    float n,m;
    cout<<"Enter the real number"<<endl;
    cin>>n;
    c1.real=n;

    cout<<"Enter the img number"<<endl;
    cin>>n;
    c1.img=n;
    // c1.setimg(n);
    cout<<"The complex number is :";
    c1.printcomp();

    return 0;
}
