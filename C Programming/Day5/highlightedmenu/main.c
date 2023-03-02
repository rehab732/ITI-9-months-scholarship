#include <stdio.h>
#include <stdlib.h>
#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <conio.h>
#include <stdlib.h>
struct fullname
{

    char fname[10];
    char lname[10];
};
struct net
{

    int bonus;
    int sal;
    int tax;
};
struct employee
{
    int code;
    struct fullname fulln;
    int age;
    struct net netsalary ;


};

void enterEmployees(int arr2[],struct employee e[])
{
    int n=1;
    printf("Enter indexes of employees ,0 to end:");
    while(n!=0)
    {
        scanf("%d",&n);
        if(n!=0)arr2[n-1]=1;

    }
    for(int l=0; l<100; l++)
    {
        if(arr2[l]==1)
        {
            system("cls");
            gotoxy(10,0);
            printf("Employee number %d Form \n",l+1);
            gotoxy(0,2);
            printf("code :\n");
            gotoxy(29,2);
            printf("age :\n");
            gotoxy(0,4);
            printf("Fname :\n");
            gotoxy(29,4);
            printf("Lname :\n");
            gotoxy(0,6);
            printf("salary :\n");
            gotoxy(29,6);
            printf("bonus :\n");
            gotoxy(0,8);
            printf("Tax :\n");
            gotoxy(0,10);
            printf("To print enter any key>>\n");
            gotoxy(6,2);
            scanf("%d",&e[l].code);
            gotoxy(35,2);
            scanf("%d",&e[l].age);

            gotoxy(7,4);
            scanf("%s",&e[l].fulln.fname);
            gotoxy(38,4);
            scanf("%s",&e[l].fulln.lname);

            gotoxy(8,6);
            scanf("%d",&e[l].netsalary.sal);
            gotoxy(37,6);
            scanf("%d",&e[l].netsalary.bonus);


            gotoxy(8,8);
            scanf("%d",&e[l].netsalary.tax);
            arr2[l]=2;
        }
    }
}
void displayall(int arr2[],struct employee e[])
{
    int counter=0;
    system("cls");
    for(int v=0; v<100; v++)
    {

        if(arr2[v]!=0)
        {
            gotoxy(0,counter++);
            printf("------Employee number %d -------\n",v+1);
            gotoxy(0,counter++);
            printf("Code :%d", e[v].code);
            gotoxy(0,counter++);
            printf("Full name :%s %s", e[v].fulln.fname,e[v].fulln.lname);
            gotoxy(0,counter++);
            printf("age :%d", e[v].age);
            gotoxy(0,counter++);
            int nett=(e[v].netsalary.bonus+e[v].netsalary.sal)-e[v].netsalary.tax;
            printf("Netsalary :%d", nett);
            gotoxy(0,counter++);


        }

    }
}
void searchbysalary(int arr2[],struct employee e[])
{
    int counter=0;
    system("cls");
    for(int r=0; r<100; r++)
    {

        if(arr2[r]!=0)
        {
            int nett=(e[r].netsalary.bonus+e[r].netsalary.sal)-e[r].netsalary.tax;
            if(nett>=3000)
            {
                gotoxy(0,counter++);
                printf("------Employee number %d -------\n",r+1);
                gotoxy(0,counter++);
                printf("Code :%d", e[r].code);
                gotoxy(0,counter++);
                printf("Full name :%s %s", e[r].fulln.fname,e[r].fulln.lname);
                gotoxy(0,counter++);
                printf("age :%d", e[r].age);
                gotoxy(0,counter++);

                printf("Netsalary :%d", nett);
                gotoxy(0,counter++);
            }
        }

    }
}
void searchbyidx(int arr2[],struct employee e[])
{
    int n;
    int counter=0;

    printf("Enter the employee number :");
    scanf("%d",&n);
    for(int v=0; v<100; v++)
    {

        if(arr2[v]!=0&&n-1==v)
        {
            gotoxy(0,counter++);
            printf("------Employee number %d -------\n",v+1);
            gotoxy(0,counter++);
            printf("Code :%d", e[v].code);
            gotoxy(0,counter++);
            printf("Full name :%s %s", e[v].fulln.fname,e[v].fulln.lname);
            gotoxy(0,counter++);
            printf("age :%d", e[v].age);
            gotoxy(0,counter++);
            int nett=(e[v].netsalary.bonus+e[v].netsalary.sal)-e[v].netsalary.tax;
            printf("Netsalary :%d", nett);
            gotoxy(0,counter++);


        }
    }
}
void textattr(int i)
{
    SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), i);

}
void gotoxy( int column, int line )
{
    COORD coord;
    coord.X = column;
    coord.Y = line;
    SetConsoleCursorPosition(
        GetStdHandle( STD_OUTPUT_HANDLE ),
        coord
    );
}
void mainmenue()
{
    char arr[5][50] = { {"1:Add New employees by index"}, {"2:Display All employees"}, {"3:Display specific employee"},{"4:search for employees have salary >3000"},{"5:Exit the program"} };
    int selected = 0 ;
    char key ;
    int flag=0;
    struct employee e[100];
    int arr2[100]= {0};
    while(flag==0)
    {

        system("cls");
        printf("\t\t Our Program Menu \n");
        for(int i=0; i<5; i++)
        {
            if(selected == i)
            {
                textattr(6);
            }
            else
            {
                textattr(0x07);
            }

            printf("%s\n", arr[i]);
            textattr(0x07);
        }
        key = getch();
        if(key == -32)
        {
            key = getche();

            switch(key)
            {
            case 72:      // press up
                selected--;

                if(selected>=5) selected = 0;
                else if(selected<0) selected=4;

                break;
            case 80:        // press down
                selected++;

                if(selected>=5) selected = 0;
                else if(selected<0) selected=5;

                break;

            case 71:        // press Home
                selected = 0;
                break;

            case 79:        // press End
                selected = 4;
                break;

            default:
                printf("wrong key");
                getch();
            }
        }
        else
        {


            switch(key)
            {
            case 104:
                selected=0;
                break;

            case 97:
                selected=4;
                break;


            case 13:

                switch(selected)
                {
                case 0:
                    system("cls");
                    enterEmployees(arr2,e);
                    printf("\n if you want to continue please press 1 else press 0 \n");
                    getch();
                    system("cls");
                    break;
                case 1:
                    system("cls");
                    displayall(arr2,e);
                    printf("\n if you want to continue please press 1 else press 0 \n");
                    getch();
                    system("cls");
                    break;
                case 2:
                    system("cls");
                    searchbyidx(arr2,e);

                    printf("\n if you want to continue please press 1 else press 0 \n");
                    getch();
                    system("cls");

                    break;
                case 3:
                    system("cls");
                    searchbysalary(arr2,e);
                    printf("\n if you want to continue please press 1 else press 0 \n");
                    getch();
                    system("cls");

                    break;
                case 4:
                    system("cls");
                    printf("Bye Bye **\n");
                    flag = 1;
                    break;

                }

                break;

            case 27:
                flag = 1;
                break;


            }
        }

    }

}
int main()
{

    mainmenue();
    return 0;
}
/*
#include <stdio.h>
#include <stdlib.h>
#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <conio.h>
#include <stdlib.h>



void textattr(int i)
{
    SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), i);

}

void gotoxy( int column, int line )
  {
  COORD coord;
  coord.X = column;
  coord.Y = line;
  SetConsoleCursorPosition(
    GetStdHandle( STD_OUTPUT_HANDLE ),
    coord
    );
  }
  struct fullname
  {

      char fname[10];
      char lname[10];
  };
  struct net
  {

    int bonus;
    int sal;
    int tax;
  };
  struct employee{
  int code;
  struct fullname fulln;
  int age;
  struct net netsalary ;


  };
  void enterEmployees(int arr2[],struct employee e[])
  {
                   int n=1;
                   printf("Enter employees numbers :");
                    while(n!=0)
                    {
                        scanf("%d",&n);
                        if(n!=0)arr2[n-1]=1;

                    }
                  for(int l=0;l<100;l++)
                 {
                    if(arr2[l]==1)
                    {
                     system("cls");
                            gotoxy(10,0);
                            printf("Employee number %d Form \n" ,l+1);
                            gotoxy(0,2);
                            printf("code :\n");
                             gotoxy(29,2);
                            printf("age :\n");
                             gotoxy(0,4);
                            printf("Fname :\n");
                             gotoxy(29,4);
                            printf("Lname :\n");
                              gotoxy(0,6);
                            printf("salary :\n");
                             gotoxy(29,6);
                            printf("bonus :\n");
                             gotoxy(0,8);
                            printf("Tax :\n");
                             gotoxy(0,10);
                            printf("To print enter any key>>\n");
                             gotoxy(6,2);
                            scanf("%d",&e[l].code);
                             gotoxy(35,2);
                            scanf("%d",&e[l].age);

                              gotoxy(7,4);
                              scanf("%s",&e[l].fulln.fname);
                              gotoxy(38,4);
                              scanf("%s",&e[l].fulln.lname);

                                gotoxy(8,6);
                                 scanf("%d",&e[l].netsalary.sal);
                                  gotoxy(37,6);
                                scanf("%d",&e[l].netsalary.bonus);


                             gotoxy(8,8);
                            scanf("%d",&e[l].netsalary.tax);
                            arr2[l]=2;
                 }}
  }
  void displayall(int arr2[],struct employee e[])
  {
        int counter=0;
             system("cls");
             for(int v=0;v<100;v++)
             {

               if(arr2[v]!=0)
             {
             gotoxy(0,counter++);
            printf("------Employee number %d -------\n" ,v+1);
            gotoxy(0,counter++);
             printf("Code :%d", e[v].code);
              gotoxy(0,counter++);
             printf("Full name :%s %s", e[v].fulln.fname,e[v].fulln.lname);
              gotoxy(0,counter++);
             printf("age :%d", e[v].age);
              gotoxy(0,counter++);
              int nett=(e[v].netsalary.bonus+e[v].netsalary.sal)-e[v].netsalary.tax;
             printf("Netsalary :%d", nett);
              gotoxy(0,counter++);


 }

    }
  }
  void searchbysalary(int arr2[],struct employee e[])
  {
        int counter=0;
             system("cls");
             for(int r=0;r<100;r++)
             {

               if(arr2[r]!=0)
             {
            int nett=(e[r].netsalary.bonus+e[r].netsalary.sal)-e[r].netsalary.tax;
            if(nett>=3000)
            {
                gotoxy(0,counter++);
            printf("------Employee number %d -------\n" ,r+1);
            gotoxy(0,counter++);
             printf("Code :%d", e[r].code);
              gotoxy(0,counter++);
             printf("Full name :%s %s", e[r].fulln.fname,e[r].fulln.lname);
              gotoxy(0,counter++);
             printf("age :%d", e[r].age);
              gotoxy(0,counter++);

             printf("Netsalary :%d", nett);
              gotoxy(0,counter++);
            }
 }

    }
  }
  void searchbyidx(int arr2[],struct employee e[])
  {
       int n;
             int counter=0;
             system("cls");
              printf("Enter the employee number :");
              scanf("%d",&n);
             for(int v=0;v<100;v++)
             {

               if(arr2[v]!=0&&n-1==v)
             {
             gotoxy(0,counter++);
            printf("------Employee number %d -------\n" ,v+1);
            gotoxy(0,counter++);
             printf("Code :%d", e[v].code);
              gotoxy(0,counter++);
             printf("Full name :%s %s", e[v].fulln.fname,e[v].fulln.lname);
              gotoxy(0,counter++);
             printf("age :%d", e[v].age);
              gotoxy(0,counter++);
              int nett=(e[v].netsalary.bonus+e[v].netsalary.sal)-e[v].netsalary.tax;
             printf("Netsalary :%d", nett);
              gotoxy(0,counter++);


 }
  }}
void menue()
{
    int selected = 0 ;
    char key ;
    int flag=1;
    struct employee e[100];
    int arr2[100]={0};
   while(flag!=0)
    {
        char arr[5][16] = { {"new"}, {"display all"},{"search"},{"display"}, {"exit"} };
           system("cls");
                if(selected>4)
                {
                    selected=0;

                }
                else if(selected<0)
                    {
                      selected=4;

                     }
        for(int i = 0 ; i<5 ; i++)
        {
            if(i==selected)
            {
                textattr(5);
                puts(arr[i]);
            }
            else
            {
                textattr(7);
                puts(arr[i]);
            }
        }
        key = getch();

        if(key == -32)
        {

            key = getch();

            if (key == 80 || key == 9)
            {
                selected++;

            }
            else if (key == 72)
            {
                selected--;


            }
        }
             if (key == 13)
            {

                system("cls");
                if(selected == 0)
                {
                  enterEmployees(arr2,e);
                 printf("\n if you want to continue please press 1 else press 0 \n");
                  flag=getch();
                  system("cls");
                }
                else if (selected == 1)
                {
                   displayall(arr2,e);
                  printf("\n if you want to continue please press 1 else press 0 \n");
                  flag=getch();

                }
      else if (selected == 2)
        {
                  searchbysalary(arr2,e);
                  printf("\n if you want to continue please press 1 else press 0 \n");
                  flag=getch();
                  system("cls");

                }
                 else if (selected == 3)
                {
                    searchbyidx(arr2,e);
                  printf("\n if you want to continue please press 1 else press 0 \n");
                  flag=getch();
                  }

                  else if (selected == 4)
                {
                     printf("exit");
                     flag=0;

                }
 }


            else if (key == 27)
            {
                 system("cls");
                printf("escape");
                flag=0;

            }



    }
}
void main()
{

    menue();
}
*/
