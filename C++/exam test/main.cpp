#include <iostream>
#include<cstring>
using namespace std;
class parent
{
public:
    int x;
    parent(int m){x=m;}
};
class child:protected parent{
public:
    int y ;
    child(int m , int n):parent(m){y=n;}
};
class grand: public child{
    int z;
public:
    grand(int a,int b,int c):child(a,b){z=c;}
};

int main()
{


    grand c(3,4,5);
    cout<<c.x<endl;

    return 0;
}
