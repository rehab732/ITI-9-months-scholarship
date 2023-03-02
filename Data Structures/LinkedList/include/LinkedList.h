#ifndef LINKEDLIST_H
#define LINKEDLIST_H

#include<iostream>
#include "Node.h"
#include <stdexcept>
using namespace std;

class LinkedList
{

private:
    Node *head;
    Node *tail;
    int counter=0;
    Node *  GetNodebydata(int num)
    {
        Node *current=head;
        while(current!=NULL)
        {
            if(current->data==num)
            {
                return current;
            }
            else
            {
                current=current->Next;
            }
        }
        return NULL;
    }
public:

    LinkedList()
    {
        head=tail=NULL;

    }

    /*functions Need to implement
    1)Add data to linked list
    2)Remove data from linked list
    3)count elements in linked list
    4)display elements
    5)Get data by index
    6)insert after data
    7)Reverse linked list in same place
    8)Reverse in another list
    9)get node by data
    10)sort linkedlist by bubble sort
    11)search in the linkedlist using binary search
    */

    void push(int num)
    {
        Node *node=new Node(num);
        if(head==NULL)
        {
            head=tail=node;
        }
        else
        {
            tail->Next=node;
            node->Prev=tail;
            tail=node;
        }
        counter++;
    }


    void display()
    {
        Node *current=head;
        if(head==NULL)
            cout<<"The list is empty"<<endl;
        else
        {
            while(current!=NULL)
            {
                cout<<current->data<<endl;
                current=current->Next;
            }
        }
    }


    int getcounter()
    {
        return counter;
    }


    void Removedata(int num)
    {
        Node *node=GetNodebydata(num);//return pointer of node ع النود اللى بعتهابيشاور

        if(node==NULL)
            return;
        if(node==head)
        {
            if(node==tail)
            {
                head=tail=NULL;
            }
            else
            {
                node->Prev=NULL;
                head=node->Next;
            }
        }
        else if(node==tail)
        {
            tail=node->Prev;
            tail->Next=NULL;

        }
        else
        {
            node->Prev->Next=node->Next;
            node->Next->Prev=node->Prev;
        }
        delete node;
        if(counter!=0)
            counter--;

    }
    int getbyindex(int index)
    {
        int i=0;
        Node *current =head;

        while(current!=NULL)
        {
            if(i==index)
                return current->data;
            current=current->Next;
            i++;

        }
        throw(i);

    }

    void insertafter(int newdata,int after)
    {
        Node *node=GetNodebydata(after);
        Node *insertednode=new Node(newdata);
        if(node==NULL)

            return;

        if(node==head)
        {


            if(node==tail)
            {

                tail=insertednode;
                insertednode->Prev=head;
                head->Next=insertednode;
            }
            else
            {

                insertednode->Next=head->Next;
                head->Next=insertednode;
                insertednode->Next->Prev=insertednode;
                insertednode->Prev=head;


            }
        }
        else if(node==tail)
        {
            tail->Next=insertednode;
            insertednode->Prev=tail;
            tail=insertednode;
        }
        else
        {


            insertednode->Next=node->Next;
            insertednode->Prev=node;
            node->Next=insertednode;
            insertednode->Next->Prev=insertednode;

        }
        counter++;


    }

            LinkedList * Reverse()
        {
            LinkedList *myList=new LinkedList();
            Node *headReverse=tail, *tailReverse=head;
            Node *current=tail;

            while(true)
            {
                 if(head==NULL)
                {cout<<""<<endl;
                     return myList;
                }
                else

               {
                    myList->push(current->data);
                    current=current->Prev;
                  if(current==head)
                    {
                      myList->push(current->data);
                        return myList;

                    }
                }
    }}



       void InPlaceReverse()
        {
            Node *current=tail;

            while(true)
            {
                if(head==NULL)
                {cout<<""<<endl;
                     return;
                }

                else
                {
                    current->Next=current->Prev;
                    current->Prev=current;
                    current=current->Next;

                    if(current==head)
                    {

                        head=tail;
                        head->Prev=NULL;
                        //head->Next=tail->Prev;
                        tail=current;
                        tail->Next=NULL;

                        return;

                    }
                }

            }
        }



    void bubbleSort()
    {
        Node *current=head;
        int swapped, i;
        Node *ptr;
        Node *lptr=NULL;
        if(head==NULL)//empty list
        {
            return;
        }
        else
        {
            do
            {
                swapped=0;
                ptr=current;
                while(ptr->Next!=lptr)
                {
                    if(ptr->data >ptr->Next->data)
                    {
                        swap(ptr->data,ptr->Next->data);
                        swapped=1;
                    }
                    ptr=ptr->Next;
                }
                lptr=ptr;
            }
            while(swapped);
        }
    }


    int binarysearch(int num)
    {
        int size=getcounter();
        int minIndex = 0, maxIndex = size - 1, midIndex;

        while(minIndex <= maxIndex)
        {
            midIndex = (minIndex + maxIndex) / 2;

            if(num == getbyindex(midIndex))
                return midIndex;

            if(num > getbyindex(midIndex))
                minIndex = midIndex + 1;
            else
                maxIndex = midIndex - 1;
        }

        return -1;


    }




};































/*
class LinkedList
{


    Node *head;
    Node *tail;
    int Count=0;
public:

    LinkedList()
    {
        head=tail=NULL;

    }
    void Add(int num)
    {
        Node * node = new Node(num);//Next=Prev=Null
        if(head==NULL)//empty linkedlist
        {
            head=tail=node;

        }
        else //not empty
        {
            tail->Next=node;
            node->Prev=tail;
            tail=node;
        }
        Count++;
    }
    void display()
    {
        Node *current=head;
        while(current!=NULL)
        {
            cout<<current->data<<endl;
            current=current->Next;

        }
    }
    int GetCount()
    {
        return Count;
    }
    int Search(int num)
    {
        Node *node=GetNodeByData(num);
        return node!=NULL;
    }

    void Remove(int data)
    {

        Node *node=GetNodeByData(data);
        if(node==NULL)
            return;
        if(node==head)
        {
            if(node==tail)
            {
                head=tail=NULL;
            }
            else
            {
                head=node->Next;
                node->Prev=NULL;
            }
        }
        else if(node==tail)
        {
            tail=node->Prev;
            tail->Next=NULL;
        }
        else
        {
            node->Prev->Next=node->Next;
            node->Next->Prev=node->Prev;
        }
        delete node;
        if(Count!=0)
            Count--;
    }

    int GetDataByIndex(int index)
    {
        int idx=0;
        Node *current = head;
        try
        {

            while(current != NULL)
            {
                if(idx== index)
                    return current->data;

                current = current->Next;
                idx++;
            }
            throw(idx);
        }
        catch (int e)
        {
            cout<<"Access denied sorry ";
            cout<<e<<endl;
        }

    }

    void InsertAfter(int data, int afterData)
    {
        Node *node = GetNodeByData(afterData);
        Node *nodeToInsert = new Node(data);

        if(node == NULL)
            return;

        if(node == head)
        {
            if(node == tail)
            {
                tail = nodeToInsert;
            }
            else
            {
                head->Next->Prev=nodeToInsert;
                nodeToInsert->Next=head->Next;
                head->Next = nodeToInsert;
            }
        }
        else if(node == tail)
        {
            tail->Next = nodeToInsert;
            nodeToInsert->Prev = tail;
            tail = nodeToInsert;
        }
        else
        {
            nodeToInsert->Next = node->Next;
            nodeToInsert->Prev = node;
            node->Next=nodeToInsert;

        }



        Count++;
    }

    void InPlaceReverse()
    {
        Node *current=tail;

        while(true)
        {
            if(head==NULL)
            {
                cout<<""<<endl;
                return;
            }

            else
            {
                current->Next=current->Prev;
                current->Prev=current;
                current=current->Next;

                if(current==head)
                {

                    head=tail;
                    head->Prev=NULL;
                    tail=current;
                    tail->Next=NULL;

                    return;

                }
            }

        }
    }

    LinkedList * Reverse()
    {
        LinkedList *myList=new LinkedList();
        Node *headReverse=tail, *tailReverse=head;
        Node *current=tail;

        while(true)
        {
            if(head==NULL)
            {
                cout<<""<<endl;
                return myList;
            }
            else

            {
                myList->Add(current->data);
                current=current->Prev;
                if(current==head)
                {
                    myList->Add(current->data);
                    return myList;

                }
            }
        }
    }






private:
    Node * GetNodeByData(int data)
    {
        Node *current=head;
        while(current!=NULL)
        {
            if(current->data==data)
            {
                return current;
            }
            else
            {
                current=current->Next;
            }
        }
        return NULL;
    }
};
*/
#endif

