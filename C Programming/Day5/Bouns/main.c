#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <stdlib.h>
#include <windows.h>

int power(int base, int a)
{
    if (a != 0)
        return (base * power(base, a - 1));
    else
        return 1;
}
int find_decimal(int decimal_number)
{
    if (decimal_number == 0)
        return 0;
    else
        return (decimal_number % 2 + 10 *
                find_decimal(decimal_number / 2));
}

int main()
{


    printf("Choose which operation that want to apply \n");
    int option;
    do
    {
        system("cls");

        printf("\n************************");
        printf("\n Program Menu");
        printf("\n************************\n");
        printf("1:Get the power \n");
        printf("2:Convert to decimal \n");
        scanf("%d",&option);
        int base, a, result;
        int dec;
        switch(option)
        {
        case 1:
            system("cls");
            printf("Enter base number: ");
            scanf("%d", &base);
            printf("Enter power number(positive integer): ");
            scanf("%d", &a);
            result = power(base, a);
            printf("%d^%d = %d", base, a, result);
            getch();
            break;
        case 2:
            system("cls");
            printf("Enter a decimal Number \n");
            scanf("%d",&dec);
            printf("The binary number is :");
            printf("%d", find_decimal(dec));
            getch();
            break;
        default:
            printf("Wrong chooice\n");

        }
    }
    while(option!=0);





    return 0;
}


