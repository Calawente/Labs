// LabaFiles.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>

#define line  printf("\n----------------------------------------------------------------------------------------------------------------");
#define lineFile(x) fprintf(x, "\n----------------------------------------------------------------------------------------------------------------");
#define Tickets  printf("\n--------------------------------------------------Tickets----------------------------------------------------");
#define TicketsFile(x) fprintf(x, "\n--------------------------------------------------Tickets----------------------------------------------------");
#define Header printf("\n|....City....|..Time.|PriceKupe|..Kupe+tax.|.ChildKupe..|...qtTKupe..|");
#define HeaderFile(x) fprintf(x, "\n|....City....|..Time.|PriceKupe|..Kupe+tax.|.ChildKupe..|...qtTKupe..|");
#define str printf("\n|%-12s|%2i : %-2i|%9i|%11i|%12.2f|%12.2i|", A.City, A.time.chas, A.time.min, A.TPKupe, A.RealTPKupe, A.ChildTPKupe, A.qtTKupe);
#define str1(x) fprintf(x, "\n|%-12s|%2i : %-2i|%9i|%11i|%12.2f|%12.2i|", A.City, A.time.chas, A.time.min, A.TPKupe, A.RealTPKupe, A.ChildTPKupe, A.qtTKupe);

struct vr
{
    int chas;
    int min;
};

struct TicketSales
{
    const float Tax = 30.0;
    char City[20];
    vr time;
    int TPKupe;
    float ChildTPKupe;
    int RealTPKupe;
    int qtTKupe;
};
struct TicketSales A;

void Input(int n);

void Output();

void Otbor(int n);

int main()
{
    int key, n = 1;
    do {
        printf("\n MENU");
        printf("\n 1-Vvod");
        printf("\n 2-Vivod");
        printf("\n 3-Otbor");
        printf("\n 4-Exit");
        printf("\n Vvedite nomer:");
        scanf_s("%d", &key);
        switch (key)
        {
        case 1: 
            Input(n);
            break;
        case 2: 
            Output();
            break;
        case 3: 
            Otbor(n);
        case 4:
            return 0; 
            break;
        default: printf("\n ERROR num");
        }
    } while (key != 4);
}

void Input(int n)
{
    FILE* pin;
    if ((pin = fopen("Base.txt", "w")) == 0)
    {
        printf("ERROR");
        return;
    }
    for (int i = 0; i < n; i++)
    {
        printf("\n City:");
        scanf("%s", &A.City);
        printf("\n vr ch: ");
        scanf("%i", &A.time.chas);
        printf("\n vr min: ");
        scanf("%i", &A.time.min);
        printf("\n Price kupe:");
        scanf("%i", &A.TPKupe);
        printf("\n qtTKupe: ");
        scanf("%i", &A.qtTKupe);
        A.RealTPKupe = A.TPKupe + A.Tax;
        A.ChildTPKupe = A.TPKupe * 0.5 + A.Tax;
        fwrite(&A, sizeof(struct TicketSales), 1, pin);
    }
    fclose(pin);
    return;
}

void Output()
{
    FILE* pin, * pout;

    if ((pin = fopen("Base.txt", "r")) == 0 || (pout = fopen("PrintBase.txt", "w")) == 0)
    {
        printf("ERROR");
        return;
    }
    Tickets;
    line;
    Header;
    line;
    TicketsFile(pout);
    lineFile(pout);
    HeaderFile(pout);
    lineFile(pout);

    while (!feof(pin))
    {
        fread(&A, sizeof(struct TicketSales), 1, pin);
        if (!feof(pin))
        {
            str;
            str1(pout);
        }
    }
    printf("\n");
    fclose(pout);
    fclose(pin);
    return;
}

void Otbor(int n)
{
    int i;
    printf("\n ------------bilety----------");
    printf("\n -------------------------------");
    printf("\n|....City....|..Time.|PriceKupe|..Kupe+tax.|.ChildKupe..|...qtTKupe..|");
    for (i = 0; i < n; i++)
    {
        if (A.TPKupe > 0)
        {
            printf("\n|%-12s|%2i : %-2i|%9i|%11i|%12.2f|%12.2i|", A.City, A.time.chas, A.time.min, A.TPKupe, A.RealTPKupe, A.ChildTPKupe, A.qtTKupe);
        }
    }
}