#include <iostream>
#include "LinkedList.h"
using namespace std;
int main()
{
    LinkedList l;
    l.push(2);
    l.push(7);
    l.push(8);
    l.push(1);
    l.push(5);
    l.display();
   cout<<"---------------"<<endl;
   l.bubbleSort();
   l.display();

   cout<<"the number in index :"<<l.binarysearch(8)<<endl;






    return 0;
}


