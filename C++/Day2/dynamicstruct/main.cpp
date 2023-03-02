#include <iostream>

using namespace std;
class Stackk
{
    int *stptr;
    int top;
    int sizee;
public:
    Stackk()
    {
        top=0;
        sizee=10;
        stptr=new int[sizee];
    }
    void push(int num)
    {
        if(top<=9)
        {
            stptr[top]=num;
            top++;

        }
        else
        {
            cout<<"Stack is full"<<endl;
        }
    }
    int pop()
    {
        int value=0;
        if(top==0)
        {
            cout<<"Stack is empty"<<endl;
        }
        else
        {
            top--;
            value=stptr[top];

        }
        return value;

    }
};
int main()
{
    Stackk s1;

    s1.push(5);
    s1.push(8);
    s1.push(10);
    s1.push(7);
    cout<< s1.pop()<<endl;
    cout<< s1.pop()<<endl;
    cout<< s1.pop()<<endl;
    cout<< s1.pop()<<endl;
    cout<< s1.pop()<<endl;

    return 0;
}
