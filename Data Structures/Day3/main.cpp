#include <iostream>
using namespace std;

void Swap(int &first, int &second)
{
    int temp = first;
    first = second;
    second = temp;
}

void BubbleSort(int *items, int size)
{
    int iterations = 0;
    int sorted = 0;

    for(int counter = 0; counter < size - 1 && sorted == 0; counter++)
    {
        sorted = 1;

        for(int index = 0; index < size - 1 - counter; index++)
        {
            if(items[index] > items[index + 1])
            {
                Swap(items[index], items[index + 1]);
                sorted = 0;
            }

            iterations++;
        }
    }

    cout << "Iterations: " << iterations << endl;
}

void SelectionSort(int *items, int size)
{
    for(int counter = 0; counter < size; counter++)
    {
        int minIndex = counter;

        for(int index = minIndex + 1; index < size; index++)
        {
            if(items[index] < items[minIndex])
                minIndex = index;
        }

        Swap(items[counter], items[minIndex]);
    }
}

void InsertionSort(int *items, int size)
{
    for(int counter = 1; counter < size; counter++)
    {
        int key = items[counter];
        int index = counter - 1;

        while(index >= 0 && items[index] > key)
        {
            items[index + 1] = items[index];
            index--;
        }

        items[index + 1] = key;
    }
}

void Display(int *items, int size)
{
    for(int index = 0; index < size; index++)
    {
        cout << items[index] << "   ";
    }
}

int BinarySearch(int data, int *items, int size)
{
    int minIndex = 0, maxIndex = size - 1, midIndex;

    while(minIndex <= maxIndex)
    {
        midIndex = (minIndex + maxIndex) / 2;

        if(data == items[midIndex])
            return midIndex;

        if(data > items[midIndex])
            minIndex = midIndex + 1;
        else
            maxIndex = midIndex - 1;
    }

    return -1;
}

int main()
{
    int arr[] = {5, 4, 7, 3, 2, 1};

    SelectionSort(arr, 6);

    Display(arr, 6);

    return 0;
}
