#include <iostream>
#include <cassert>
using namespace std;
const int MAXL=50;
class circularQ
{
    int rear;
    int front;
    int Count;
    int arr[MAXL];
public:

    circularQ()
    {
        front=0;
        rear=MAXL-1;
        Count=0;
    }
    bool isempty()
    {
        return Count==0;
    }
    bool isFull()
    {
        return Count==MAXL;
    }

    void Add(int num)
    {
        if(isFull())
        {
            cout<<"Queue is Full"<<endl;
        }
        else
        {
            rear=(rear+1)%MAXL;
            arr[rear]=num;
            Count++;
        }

    }

    void Remove()
    {
        if(isempty())
            cout<<"queue is empty"<<endl;
        else
        {
            front=(front+1)%MAXL;
            --Count;
        }
    }
    int getcounter()
    {
        return Count;
    }
    int frontQ()
    {
        assert(!isempty());
        return arr[front];
    }
    int rearQ()
    {
        assert(!isempty());
        return arr[rear];
    }
    void display()
    {
        for(size_t i=front; i!=rear; i=(i+1)%MAXL)
        {
            cout<<arr[i]<<endl;
        }
        cout<<arr[rear]<<endl;
        cout<<"--------------"<<endl;
    }

};
int main()
{
    circularQ n;
    n.Add(4);
    n.Add(8);
    n.Add(9);
    n.Add(3);
    n.Add(1);
    n.display();
    n.Remove();
    n.display();
    cout<<n.frontQ()<<endl;

    return 0;
}
