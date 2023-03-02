#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#define MAX 2
int main()
{
   char fname[MAX][11],lname[MAX][11],fullname[MAX][21];

  /* for(int i=0 ;i<MAX ;i++ )
    {
        printf("Enter First Name  : %d \n",i+1);
        scanf("%s",&fname[i][0]);
        printf("Enter Last Name :%d \n",i+1);
        scanf("%s",&lname[i][0]);
    }*/
    int i=0;
while(i<MAX)
{
    system("cls");
    printf("Enter First Name  : %d \n",i+1);
        scanf("%s",fname[i]);
        printf("Enter Last Name :%d \n",i+1);
        scanf("%s",lname[i]);
    i++;
}

for(int j=0;j<MAX;j++)
{
    strcpy(fullname[j],fname[j]);
    strcat(fullname[j]," ");
    strcat(fullname[j], lname[j]);

}
system("cls");

int minindex=0;
int maxindex=0;
int min=strlen(fullname[0]);
int max=strlen(fullname[0]);
for(int v=0; v<MAX;v++)
{
    if(strlen(fullname[v])<min)
    {
        minindex=v;
        min=strlen(fullname[v]);
    }
     if(strlen(fullname[v])>max)
    {
        maxindex=v;
        max=strlen(fullname[v]);
    }

}
printf("shortest and longest name \n");
printf("*********************\n");
printf("shortest Name : \n");
printf(fullname[minindex]);
printf("\n");

printf("longest Name : \n");
printf(fullname[maxindex]);
printf("\n");
getch();
system("cls");
printf("ALL FULL NAMES IN UPPER CASE \n");
printf("***************************\n");
for(int m=0;m<MAX;m++)
{
   // system("cls");
    printf("the full name of student  %d : \n",m+1);
   puts(strupr(fullname[m]));



}

    return 0;
}
