#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

void swap(int* xp, int* yp)
{
    int temp = *xp;
    *xp = *yp;
    *yp = temp;
}

void Sortarray(int arr[], int n)
{
    int i, j, min_idx;


    for (i = 0; i < n - 1; i++) {


        min_idx = i;
        for (j = i + 1; j < n; j++)
            if (arr[j] < arr[min_idx])
                min_idx = j;


        swap(&arr[min_idx], &arr[i]);
    }
}

void printArray(int arr[], int size)
{
    int i;
    for (i = 0; i < size; i++)
        printf("%d ", arr[i]);
    printf("\n");
}
void printrev(int arr[],int size)
{

    int i;
    for(i=size-1;i>=0;i--)
        printf("%d ",arr[i]);
    printf("\n");
}
void fill_array(int *array, int n)
{
    int i,element;
    for (i = 0; i < n; i++)
    {
        printf("Enter element %d :",i+1);
        scanf("%d",&element);
        array[i] = element;
    }

   // return array;
}
void getmin(int arr[],int n)
{
    Sortarray(arr,n);
    printf("the min element is %d ",arr[0]);


}
void getmax(int arr[],int n)
{
    Sortarray(arr,n);
    printf("the Max element is %d ",arr[n-1]);


}
void sumavg(int arr[],int n)
{
    int sum=0;
    for(int i=0;i<n;i++)
    {
        sum+=arr[i];

    }
    printf("the sum of numbers = %d \n",sum);
    printf("the avg of numbers = %d ",(sum/n));

}

int main()
{


     int size_arr;
      printf("Enter the size of array : \n");
    scanf("%d",&size_arr);
    int arr[size_arr];


    int option;
    do{
            system("cls");
    printf("\n************************");
    printf("\n Arrays Menu Must start with 1");
    printf("\n************************\n");
    printf("1:Fill The array \n");
    printf("2:Sort The array \n");
    printf("3:print The array Reversed \n");
    printf("4:Sum and Avg of the array\n");
    printf("5:Get the Min of the array\n");
    printf("6:Get the Max The array \n");
    printf("0:Exit the Program \n");
    scanf("%d",&option);
    switch(option)
    {

    case 1:
        system("cls");
        printf("fill the array :\n");
        fill_array(arr,size_arr);
        printf("You filled the array successfully and the values you entered  :)\n");
        printArray(arr,size_arr);
        getch();
        break;
    case 2:
         system("cls");
        printf("sorted the array will be :\n");
        Sortarray(arr,size_arr);
        printArray(arr,size_arr);
        getch();
        break;
    case 3:
         system("cls");
         printf("The original array :\n");
         printArray(arr,size_arr);

        printf("Reversed Array :\n");
        printrev(arr,size_arr);
        getch();
        break;
    case 4:
         system("cls");
         printf("Remember your elements :\n");
         printArray(arr,size_arr);
        printf("Tha sum and avg of the elements in the array :\n");
        sumavg(arr,size_arr);

        getch();
        break;
    case 5:
         system("cls");
         printf("the value you entered :\n");
         printArray(arr,size_arr);
        getmin(arr,size_arr);
        getch();
        break;
    case 6:
         system("cls");
       printf("the value you entered :\n");
         printArray(arr,size_arr);
        getmax(arr,size_arr);
        getch();
        break;
    case 0:

        break;

    }
    }while(option!=0);




    return 0;
}
