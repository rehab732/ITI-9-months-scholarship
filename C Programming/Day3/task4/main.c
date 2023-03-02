#include <stdio.h>
#include <stdlib.h>

int main()
{
    char arr[21];
    printf("Enter char :\n");
    for(int i=0;i<20;i++)
    {

        arr[i]=getche();
        if(arr[i]==13)
            break;
    }
    printf("\n%s",arr);

    return 0;
}
