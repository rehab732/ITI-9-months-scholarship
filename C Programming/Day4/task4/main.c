#include <stdio.h>
#include <stdlib.h>

int main()
{
    char key;
    int op=0;
    do{
            system("cls");

        printf("Enter char \n");
    key=getche();
    printf("\n");
    if(key==-32)
    {
        printf("The char you entered is Expanded \n");
        key=getch();
        printf("And the ASCII for this char is  %d",key);
         printf("\n");

    }
    else{
        printf("The char you entered is Normal \n");
        printf("And The ASCII for this char is %d",key);
         printf("\n");
    }
    printf("If you want to try another char press 1\n");
    scanf("%d",&op);


    }while(op==1);
    return 0;
}
