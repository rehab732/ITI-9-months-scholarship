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


int main()
{
    char arr[3][10] = { {"new"}, {"display"}, {"exit"} };
    int selected = 0 ;
    char key ;
int flag=1;
    while(flag==1)
    {
        for(int i = 0 ; i<3 ; i++)
        {
            if(i==selected)
            {
                textattr(6);
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
            if (key == 80)
            {
                selected++;
                system("cls");
            }
            else if (key == 72)
            {
                selected--;
                system("cls");
            }
            else if (key == 71)
            {
                selected = 0;
                system("cls");
            }
            else if (key == 79)
            {
                selected = 2;
                system("cls");
            }

        }
        else
        {
            if (key == 9)
            {
                selected++;
                system("cls");
            }
            else if (key == 27)
            {
                printf("escape");
                flag=0;
            }
            else if (key == 13)
            {
                if(selected == 0)
                {
                    system("cls");
                    printf(" new \n");
                }
                else if (selected == 1)
                {
                    system("cls");
                    printf(" display \n");
                }
                else if (selected == 2)
                {
                    printf("exit");
                    flag=0 ;
                }
            }
        }
        if(selected >2)
        {
            selected=0;
        }
        if(selected <0)
        {
            selected=2;
        }

    }

    return 0;
}
