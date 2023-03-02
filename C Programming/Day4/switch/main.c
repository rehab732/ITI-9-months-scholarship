#include <stdio.h>
#include <windows.h>

void textattr(int i)
{

    SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), i);

}

int main()
{
    char arr[3][11] = {"New", "Display", "Exit"}, key;
    int selected = 0;
    short isExit = 0;

    while(isExit == 0)
    {

        system("cls");
        printf("\t\t Draw Menu\n");

        for(int i=0; i<3; i++)
        {
            if(selected == i)
            {
                textattr(6);
            }
            else
            {
                textattr(0x07);
            }
            printf("%s\n", arr[i]);
            textattr(0x07);
        }

        key = getch();

        if(key == -32)
        {
            key = getche();

            switch(key)
            {
            case 72:      // press up
                selected--;

                if(selected>=3) selected = 0;
                else if(selected<0) selected=2;

                break;
            case 80:        // press down
                selected++;

                if(selected>=3) selected = 0;
                else if(selected<0) selected=3;

                break;

            case 71:        // press Home
                selected = 0;
                break;

            case 79:        // press End
                selected = 2;
                break;

            default:
                printf("wrong key");
                getch();
            }
        }
        else
        {


            switch(key)
            {
            case 104:
                selected=0;
                break;

            case 97:
                selected=2;
                break;


            case 13:

                switch(selected)
                {
                case 0:
                    printf("Hello Nada in New Menu\n");
                    getch();
                    system("cls");
                    break;
                case 1:
                    printf("Hello Nada in Display Menu\n");

                    getch();
                    system("cls");
                    break;
                case 2:
                    printf("Bye Bye **\n");
                    isExit = 1;
                    break;
                }

                break;

            case 27:
                isExit = 1;
                break;


            }
        }
    }


    return 0;
}
