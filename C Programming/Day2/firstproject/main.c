#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>

int main()
{
   int num, sum=0;
   while(sum<=100)
   {

       printf("Enter Number \n");
       scanf("%d",&num);
       sum+=num;
   }
   printf("the sum of all numbers you entered = %d",sum);




}


