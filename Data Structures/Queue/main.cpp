#include <iostream>
using namespace std;
 class Node{
 public:
    int data;
    Node *next;
    Node()
    {
        data=0;
        next=NULL;
    }
 };
 class Queue{

 public:
    Node *front;
    Node *rear;
    int counter=0;
    Queue()
    {
        front=rear=NULL;
    }
    bool isempty()
    {
        if(front==NULL&&rear==NULL)
        {
            return true;
        }else{
            return false;
        }
    }
   void Enqueue(int num)
    {
        Node *newnode=new Node();
        newnode->data=num;
        if(isempty())
        {
            front=rear=newnode;
        }else{
            rear->next=newnode;
            rear=newnode;

        }
        counter++;

    }
    void display()
    {
        Node *current=front;
        if(front==NULL)
            return;
        while(current!=NULL)
        {
            cout<<current->data<<endl;
            current=current->next;
        }
        cout<<"-------------"<<endl;

    }
    int Dequeue()
    {
        int number=-1;
        if(isempty())
            cout<<"empty "<<endl;
       else if(front==rear)
       {
           delete front;
           counter--;
           front=rear=NULL;
       }
       else{
            Node *deletedeptr=front;
            front=front->next;
            number=deletedeptr->data;
            counter--;
            delete deletedeptr;

       }
       return number;
    }

    int getfirst()
    {
        return front->data;
    }
    int getlast()
    {
        return rear->data;
    }
    int getcounter()
    {
        return counter;
    }
    bool isFound(int num)
    {
        bool found=false;
        Node *current=front;
        while(current!=NULL)
        {
            if(current->data==num)
                found=true;
            current=current->next;
        }
        return found;
    }
    void Clear()
    {
        while(!isempty())
        {
            Dequeue();
        }
    }


 };
int main()
{
    Queue q;
    q.Enqueue(78);
    q.Enqueue(7);
    q.Enqueue(8);
    q.Enqueue(9);
    q.Enqueue(10);
    q.display();
    q.Dequeue();

     q.display();
cout<<q.getcounter();


    return 0;
}
