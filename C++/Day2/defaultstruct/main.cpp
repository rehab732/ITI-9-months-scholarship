#include <iostream>

using namespace std;
class Stack
{

    int st[10];
    int top;
public:
    void settop()
    {
        top=0;
    }
    void push(int num)
    {
        if(top<=9)
        {
            st[top]=num;
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
            value=st[top];
        }
        return value;
    }
};
int main()
{
    Stack s1;
    s1.settop();
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
