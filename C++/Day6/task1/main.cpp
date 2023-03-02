#include <iostream>

using namespace std;
template <class T>
class sttack{

    int top;
    int sizee;
    T *ptr;
    static int counter;
public:
    sttack(){
        top=0;
        sizee=10;
        ptr=new T[sizee];
        counter++;
    }
    sttack(int n)
    {
        top=0;
        sizee=n;
        ptr=new T[sizee];
        counter++;
    }
    ~sttack(){
        delete []ptr;
        counter--;
    }
    static int getcounter(){
        return counter;

    }
    sttack (sttack &);
    void push(T);
    T pop();
    sttack & operator=(sttack&);
    friend void view(sttack);

};

template <class T>
sttack<T>::sttack(sttack<T>&mys)
{
    top=mys.top;
    sizee=mys.sizee;
    for(int i=0;i<top;i++)
    {
        ptr[i]=mys.ptr[i];
    }
    counter++;
}
template <class T>
void sttack<T>::push(T n)
{
    if(top==sizee)
    {
        cout<<"full"<<endl;
    }else{
        ptr[top]=n;
        top++;
    }
}
template <class T>
T sttack<T>::pop()
{
    T ret;
    if(top==0){cout<<"empty"<<endl;}
    else{
        top--;
        ret=ptr[top];
    }
    return ret;
}
template <class T>
sttack<T>& sttack<T>::operator= (sttack<T>&my)
{
    delete []ptr;
    top=my.top;
    sizee=my.sizee;
    ptr=new T[sizee];
    for(int i=0;i<top;i++)
    {
        ptr[i]=my.ptr[i];

    }
    return *this;
}
template <class T>
void view(sttack<T>mys)
{
    for(int i=0;i<mys.top;i++)
    {
        cout<<mys.ptr[i]<<endl;
    }
}
template <class T>
int sttack<T>::counter=0;
int main()
{
    sttack<int>s1(5),s2(2);
    s1.push(10);
    s1.push(20);
    s2.push(11);
    cout<<"integer counter :"<<sttack<int>::getcounter()<<endl;
    cout<<s1.pop()<<endl;
    cout<<s2.pop()<<endl;
sttack<char> mmm;
mmm.push('A');
mmm.push('R');
cout<<mmm.pop()<<endl;
    cout<<"char counter :"<<sttack<char>::getcounter()<<endl;


    return 0;
}
