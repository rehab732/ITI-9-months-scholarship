#include <iostream>

using namespace std;

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
            //*ptrar++;
            //  cout << endl << "added " << ptrar++ << endl;
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
            //*ptrar--;
            //*ptrar--;
            //cout << "deleted " <<ptrar[top] << endl;
            return (ptrar[top]);

        }
    }
    int getTop()
    {
        return this->top;
    }
    /*void printStack()
    {
        for(int i = 0 ; i < top ; i++)
        {
            cout << ptrar[i];
                    cout << endl ;

        }
    }*/
    friend void printStackFriend(staack &s);
    friend void printStackFriendValue(staack s);
    staack& operator=(staack &s);


    static int getObjcts()
    {
        return counter;
    }
    //void printStackStand(staack &s);
    ~staack()
    {
        delete ptrar;
        cout <<endl << "destructor work" << endl;
    }
} ;

staack& staack::operator=(staack &s)
{
    delete this->ptrar;
    top=s.top;
    sizee=s.sizee;
    ptrar=new int[sizee];
    for(int i=0;i<top;i++)
    {
        ptrar[i]=s.ptrar[i];
    }
    return *this;

}
void printStackFriend(staack &s)
{
    int n = s.getTop();
    for(int i = 0 ; i < s.getTop() ; i++)
    {
        cout << s.ptrar[i];
        cout << endl ;
    }
}
void printStackFriendValue(staack s)
{
    int n = s.getTop();
    for(int i = 0 ; i < s.getTop() ; i++)
    {
        cout << s.ptrar[i];
        cout << endl ;
    }
}
int staack::counter=0 ;
void printStackStand(staack s)
{
    int n = s.getTop();
    for(int i = 0 ; i < n ; i++)
    {
        //cout << "stand" << endl;
        cout << s.pop();
        cout << endl ;
    }
}
/*static void getobjcts ()
{
    cout << "counter = "<<counter;
}*/
int main()
{

    staack s  ;
    s.push(3);
    s.push(6);
    s.push(9);
    cout << "by refrence " << endl;
    printStackFriend(s);
    cout << "by value " << endl;
    printStackFriendValue(s);
    cout << "by stand " << endl;
    printStackStand(s);
    s.pop();

    //s.pop();
    cout << "by value " << endl;

    printStackFriendValue(s);
    cout << "by refrence " << endl;
    printStackFriend(s);
    cout << "by stand " << endl;
    printStackStand(s);

    cout << "counter = " << staack::getObjcts();

    return 0;
}
