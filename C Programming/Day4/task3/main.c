#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <string.h>
#define NUM 5
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
  struct fullname{
      char fname[20];
      char lname[20];
  };
struct employee{
    int code;
    struct fullname name;
    int age;
    int bouns;
    int salary;
};
int main()
{
    struct employee emp[NUM];
    int arr[NUM]={0};
    int i=0;
    int key;
       do{

            system("cls");
             printf("Enter details of Employee %d\n", i+1);
                gotoxy(0,2);
                printf("Code :");
                gotoxy(20,2);
                printf("Age :");
                gotoxy(0,3);
                printf("Fname :");
                gotoxy(20,3);
                printf("Lname :");
                gotoxy(0,4);
                printf("Salary :");
                gotoxy(20,4);
                printf("Bouns :");
                gotoxy(6,2);
                scanf("%d",&emp[i].code);
                gotoxy(26,2);
                scanf("%d",&emp[i].age);
                gotoxy(8,3);
                scanf("%s",&emp[i].name.fname);
                gotoxy(28,3);
                scanf("%s",&emp[i].name.lname);
                gotoxy(8,4);
                scanf("%d",&emp[i].salary);
                gotoxy(28,4);
                scanf("%d",&emp[i].bouns);
                arr[i]=1;
                printf("\n");
              printf("press 0 to break \n");
              scanf("%d",&key);

             i++;

    }while((key!=0)&&(i<NUM));


     getch();
    system("cls");
    printf("********************************\n");
    printf("    Data of All employees just entered     \n");
    printf("********************************\n");
    int x=0;
    int c=5;
while(x<NUM)
{
    if(arr[x]==1)
    {
      gotoxy(0,c);
    c++;
    printf("     Data for employee %d ",x+1);
    gotoxy(0,c);
    printf("code : %d",emp[x].code);
    gotoxy(10,c);
    strcat(emp[x].name.fname," ");
    printf("Full Name : %s",strcat(emp[x].name.fname,emp[x].name.lname));
    c++;
    gotoxy(0,c);
    printf("Age :%d",emp[x].age);
    gotoxy(10,c);
    printf("Net Salary :%d",emp[x].salary*emp[x].bouns);
    printf("\n");
    x++;
    c++;

}
    else{
        break;
    }
}


    return 0;
}
