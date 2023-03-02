#include <stdio.h>
#include <stdlib.h>
#include<conio.h>
#include <stdlib.h>
int main()
{
    char option;
    do{
        system("cls");
        printf("\n--------------------------");
        printf("\n Main Menue");
        printf("\n--------------------------\n");
        printf("N--> New \n");
        printf("D--> Display \n");
        printf("E--> Exit \n");
        scanf("%c",&option);

        switch(option)
        {
        case 'n':
        case 'N':
            system("cls");
            printf("Hello Rehab in New Menu");
            getch();

            break;
        case 'd':
        case 'D':

            system("cls");
            printf("Hello Rehab in Display Menu");
            getch();
            break;
        case 'e':
        case 'E':

            break;

        }


    }while(option!='e');

    return 0;
}
