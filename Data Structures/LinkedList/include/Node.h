#ifndef NODE_H
#define NODE_H
class Node{
public:

    int data;
    Node * Next;
    Node * Prev;
    Node(int d)
    {
        data=d;
        Next=Prev=NULL;
    }
};
#endif
