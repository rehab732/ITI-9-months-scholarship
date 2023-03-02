#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <string.h>
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
    struct employee emp1;
    printf("               Employee                \n");
    printf("\n");
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
    scanf("%d",&emp1.code);
    gotoxy(26,2);
    scanf("%d",&emp1.age);
    gotoxy(8,3);
    scanf("%s",&emp1.name.fname);
    gotoxy(28,3);
    scanf("%s",&emp1.name.lname);
    gotoxy(8,4);
    scanf("%d",&emp1.salary);
    gotoxy(28,4);
    scanf("%d",&emp1.bouns);

system("cls");
     printf("***************************************\n");
     printf("    Data of employee you entered       \n");
     printf("***************************************\n");
     gotoxy(0,3);
     printf("Code : %d",emp1.code);
     gotoxy(20,3);
     strcat(emp1.name.fname," ");
     printf("Full Name : %s", strcat(emp1.name.fname,emp1.name.lname));
     gotoxy(0,4);
     printf("Age : %d",emp1.age);
     gotoxy(20,4);
     printf("Net Salary : %d",(emp1.salary*emp1.bouns));




    return 0;
}
