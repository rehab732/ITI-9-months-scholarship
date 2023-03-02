#include <stdio.h>
#include <stdlib.h>
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
    char fname[20];
    char lname[20];
};
struct emploee
{
    struct fullname name;
    int age;
    int code;
    int salary;
    int tax;
    int bonus;
};
void addemp(int arrayy[],struct emploee empp[])
{
    int n=1;
    int i=1;
    printf("Enter indexes of employees\n");
    //saved indexes
    while(n!=0)
    {
        printf("Enter index of employee %d:",i);
        scanf("%d",&n);
        if(n!=0)
            arrayy[n-1]=1;
        i++;
    }
    for(int x=0; x<100; x++)
    {
        if(arrayy[x]==1)
        {
            system("cls");
            gotoxy(10,0);
            printf("Enter data of employee number : %d",x+1);

            printf("\nEnter code : ");
            scanf("%d",&empp[x].code);
            printf("\n");
            printf("Enter age : ");
            scanf("%d",&empp[x].age);

            printf("\nEnter first name : ");
            scanf("%s",&empp[x].name.fname);
            printf("\nEnter last name : ");
            scanf("%s",&empp[x].name.lname);

            printf("\nEnter salary : ");
            scanf("%d",&empp[x].salary);
            printf("\nEnter bouns :");
            scanf("%d",&empp[x].bonus);


            printf("\nEnter taxes : ");
            scanf("%d",&empp[x].tax);
            arrayy[x]=5;


        }
    }
    printf("Employees added successfully\n");

};


void printallemp(int arrayy[],struct emploee empp[])
{

    for (int y=0; y<100; y++)
    {
        // system("cls");
        if(arrayy[y]!=0)
        {
            system("cls");
            gotoxy(10,0);
            printf("Data for employee number :%d",y+1);
            printf("\nCode :");
            printf("%d",empp[y].code);
            printf("\nAge :");
            printf("%d",empp[y].age);
            printf("\nFull Name :");
            printf("%s %s",empp[y].name.fname,empp[y].name.lname);
            printf("\nNetSalary :");
            int nett=(empp[y].bonus+empp[y].salary)-empp[y].tax;
            printf("%d",nett);
            getch();

        }
    }
    printf("\nThis is All employees in the struct");

};

void printbyindex(int arrayy[],struct emploee empp[])
{
    printf("Enter index of employee\n");
    int num;
    scanf("%d",&num);
    if(arrayy[num-1]==0)
        printf("No Employee in this index\n");
    else
    {
        system("cls");
        gotoxy(10,0);
        printf("Data for employee %d :",num);
        printf("\nCode :");
        printf("%d",empp[num-1].code);
        printf("\nAge :");
        printf("%d",empp[num-1].age);
        printf("\nFull Name :");
        printf("%s %s",empp[num-1].name.fname,empp[num-1].name.lname);
        printf("\nNetSalary :");
        int nett=(empp[num-1].bonus+empp[num-1].salary)-empp[num-1].tax;
        printf("%d",nett);
        getch();

    }

};

void searchbysalary(int arrayy[],struct emploee empp[])
{
    system("cls");
    printf("All Employees that there salary >3000");
    for(int i=0; i<100; i++)
    {


        if(arrayy[i]!=0)
        {
             int nett=(empp[i].bonus+empp[i].salary)-empp[i].tax;
            system("cls");
            if(nett>=3000){
                    printf("Employee number %d",i+1);
            printf("\nCode :");
            printf("%d",empp[i].code);
            printf("\nAge :");
            printf("%d",empp[i].age);
            printf("\nFull Name :");
            printf("%s %s",empp[i].name.fname,empp[i].name.lname);
            printf("\nNetSalary :");
            printf("%d",nett);

            }else{
                printf("There is no employees have salary >3000");
            }
             getch();

        }

    }





};


void programmenu()
{

    char arr[5][50]= {"1:Add new employee by index","2:Display all employees","3:Display spacific employee","4:search for employee by index","5:Exit the program"};
    char key;
    int index[100]= {0};
    struct emploee emp[100];
    int selected=0;
    int flag=0;
    while(flag==0)
    {
        system("cls");
        gotoxy(50,0);
        printf("Our program menu\n");
        for(int i=0; i<5; i++)
        {
            if(selected==i)
            {
                textattr(4);//red color
            }
            else
            {
                textattr(0x07);//white color
            }

            printf("%s\n", arr[i]);
            textattr(0x07);


        }
        key=getch();
        if(key==-32)
        {
            key=getch();
            switch(key)
            {
            //press up
            case 72:
                selected--;
                if(selected>5)
                {
                    selected=0;
                }
                else if (selected<0)
                {
                    selected=4;
                }
                break;
            //press down
            case 80:
                selected++;
                if(selected>=5)
                    selected=0;
                break;

            default:
                printf("Error key");

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
                    addemp(index,emp);
                    getch();
                    break;
                case 1:
                    system("cls");
                    printallemp(index,emp);
                    getch();
                    break;
                case 2:
                    system("cls");
                    printbyindex(index,emp);
                    getch();
                    break;
                case 3:
                    system("cls");
                    searchbysalary(index,emp);
                    getch();
                    break;
                case 4:
                    system("cls");
                    printf("\n\nBay Bay Rehab :)\n\n");
                    flag=1;
                    /*    break;
                    case 27:
                        flag = 1;
                        break;*/





                }


            }


        }

    }


}
int main()
{
    programmenu();
    return 0;
}
