#include <iostream>

using namespace std;
class Node
{
public:
    int data;
    Node * next;

    Node()
    {
        data=0;
        next=NULL;
    }
};
class Stack
{
private:
    Node *top;
    int counter=0;
public:
    Stack()
    {
        top=NULL;
    }
    bool isempty()
    {
        if(top==NULL)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    void push(int num)
    {
        Node *newnode=new Node();
        newnode->data=num;
        if(isempty())
        {
            newnode->next=NULL;
            top=newnode;
        }
        else
        {
            newnode->next=top;
            top=newnode;

        }
        counter++;

    }
    int pop()
    {
        int number;
        Node *deletedptr=top;
        number=top->data;
        top=top->next;
        delete deletedptr;
        if(counter!=0)
        {
            counter--;
        }
        return number;

    }
    void display()
    {
        Node *current=top;
        while(current!=NULL)
        {
            cout<<current->data<<endl;
            current=current->next;
        }
        cout<<"---------------"<<endl;
    }

    int peek()
    {
        return top->data;
    }
    int getcounter()
    {
        return counter;
    }
    bool isFound(int num)
    {
        bool found=false;
        Node *current=top;
        while(current!=NULL)
        {
            if(current->data==num)
            {
                found=true;
            }
            else
            {
                current=current->next;
            }
        }
        return found;
    }


};
int main()
{
    Stack s;
    s.push(4);
    s.push(45);
    s.push(6);
    s.push(8);
    s.display();
    cout<<s.getcounter()<<endl;
    cout<<"--------------"<<endl;
    cout<<s.pop()<<endl;
    cout<<"--------------"<<endl;
    s.display();
    cout<<s.peek()<<endl;
    cout<<"--------------"<<endl;
    s.display();
    cout<<s.getcounter()<<endl;

        cout<<"--------------"<<endl;
        cout<<"Enter number to search"<<endl;
        int n;
        cin>>n;
        if(s.isFound(n))
            cout<<"found"<<endl;
        cout<<"not found"<<endl;
    return 0;
}
