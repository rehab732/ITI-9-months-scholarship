#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
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
int main()
{
    int row=1;
   int num;
    printf("Enter an Odd Number: ");
    scanf("%d", &num);
    int col=(num+1)/2;
    if(num % 2 == 0)
        printf("%d Sorry that is invalid Number :", num);
    else
        {
            for (int i=1;i<=num*num;i++)
            {
                gotoxy(col*3,row*3);
                printf("%d",i);
                if(i%num==0)
                    row++;
                else{
                    row--;
                    col--;
                }
                if(col<=0)
                    col=num;
                if(row<=0)
                    row=num;
                if(row>num)
                    row=1;
                if(col>num)
                    col=1;
            }

        }
    return 0;
}
