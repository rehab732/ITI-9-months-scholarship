#include <stdio.h>
#include <stdlib.h>
#define MAX 3
int main()
{   int st_numbers[2]={1,2};
    int arr[2][4];
    int total[4]={0,0,0,0};
    int gba,temp;
    int avg[4]={0,0,0,0};
    char courses [4][20]={"operating System","database","programming","data structure"};

    printf("*******************************************\n");
    printf("       Enter Data of all students    \n");
    printf("*******************************************\n");
    int i=0;

    do{
            getch();
            system("cls");

        printf("For the student number %d  \n",i+1);
     for(int k=0;k<4;k++)
     {
         printf("Enter the grade of course  %s  :\n",courses[k]);
         scanf("%d",&arr[i][k]);
         total[i]+=arr[i][k];
         avg[k]+=arr[i][k];
    }
     printf("*******************************************\n");
      printf("The total number of grade is %d",total[i]);
      gba=(total[i]/100)*100;
      if(gba>=85)
      {
          printf("\n The grade is A\n");
      }
      else if(gba>=75&&gba<=85)
      {
          printf("\nThe grade is B\n");
      }
       else if(gba>=65&&gba<=75)
      {
          printf("\nThe grade is C\n");
      }
      else{
         printf("\nThe grade is D\n");
      }
        printf("*******************************************\n");

      i++;


    }while(i!=MAX);

   /* for(int i=0;i<2;i++)
    {
        printf("For the student number %d  \n",i+1);
     for(int k=0;k<4;k++)
     {
         printf("Enter the grade of course  %s  :\n",courses[k]);
         scanf("%d",&arr[i][k]);
         total[i]+=arr[i][k];
         avg[k]+=arr[i][k];
    }
      printf("The total number of grade is %d",total[i]);
      gba=(total[i]/100)*100;
      if(gba>=85)
      {
          printf("\n And The grade is A\n");
      }
      else if(gba>=75&&gba<=85)
      {
          printf("The grade is B\n");
      }
       else if(gba>=65&&gba<=75)
      {
          printf("The grade is C\n");
      }
      else{
         printf("The grade is D\n");
      }

    }*/
       printf("*******************************************\n");
       printf("The avg of each course is :\n");
          printf("*******************************************\n");
     for(int k=0;k<4;k++)
     { int t=avg[k]/4;
       printf("for course %s",courses[k]);
       printf(" %d",t);
       printf("\n");
     }
     printf("\nThe sorted total of courses for each student is :\n");
      for(int i=0;i<2;i++)
        for(int k=0;k<2;k++)
     {

         if(total[i]>total[k])
         {

             temp=total[i];
             total[i]=total[k];
             total[k]=temp;

             temp=st_numbers[i];
             st_numbers[i]=st_numbers[k];
             st_numbers[k]=temp;
         }
     }
     for(int i=0;i<2;i++)
     {
          printf("Student number %d has a total %d ",st_numbers[i],total[i]);
          printf("\n");

     }

    return 0;
}
