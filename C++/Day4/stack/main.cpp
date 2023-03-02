#include <iostream>
using namespace std;

class xx
{
public:
    int x ;
    int y;
};
class staack
{
private :
    int top ;
    int *ptrar;
    int sizee ;
    int static counter;
public:
    staack()
    {
        top = 0;
        sizee=10;
        counter++;
        ptrar = new int[sizee];
    }
    staack(int s)
    {
        top = 0;
        sizee=s;
        counter++;
        ptrar = new int[sizee];
    }

    staack(staack &s)
    {
        this->top = s.top;
        this->sizee = s.sizee;
        this->ptrar = new int[s.sizee];
        counter++;
        for(int i = 0 ; i<this->top ; i++)
        {
            this->ptrar[i] = s.ptrar[i];
        }
    }
    void push(int num)
    {
        if(top == this->sizee )
        {
            cout << "stack is full";
        }
        else
        {
            ptrar[top] = num;
            cout << endl << "added " << ptrar[top] << endl;

            top++;
        }
    }
    int pop ()
    {
        if(top == 0 )
        {
            cout << "stack is empty" ;
        }
        else
        {
            top--;

            return (ptrar[top]);

        }
    }
    int getTop()
    {
        return this->top;
    }

    friend void printStackFriend(staack &s);
    friend void printStackFriendValue(staack s);

    static int getObjcts()
    {
        return counter;
    }

    staack & operator = (staack &s )
    {
        delete this->ptrar;
        this->top = s.top;
        this->sizee = s.sizee;
        this->ptrar = new int[s.sizee];
        counter++;
        for(int i = 0 ; i<this->top ; i++)
        {
            this->ptrar[i] = s.ptrar[i];
        }
        return *this;
    }

    int & operator [](int x)
    {
        return ptrar[x];
    }

    ~staack()
    {
        delete ptrar;
        cout <<endl << "destructor work" << endl;
    }
} ;


void printStackFriend(staack &s)
{
    int n = s.getTop();
    for(int i = 0 ; i < s.getTop() ; i++)
    {
        cout << s.ptrar[i];
        cout << endl ;
    }
}

int staack::counter=0 ;


int main()
{

    staack s, s1  ;
    s.push(3);
    s.push(6);
    s.push(9);
    s1=s;
    s[0]=1;
    cout << "S elements" << endl;

    printStackFriend(s);
    cout << "S1 elements " << endl;

    printStackFriend(s1);



    cout << endl << "counter = " << staack::getObjcts();

    return 0;
}
