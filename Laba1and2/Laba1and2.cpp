// Laba1and2.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>  
#include <fstream>  
#include <string>  
#include <stdio.h>  

#define _CRT_SECURE_NO_WARNINGS 
#define LINE "\n|______________________________________________________________________________________________________________|" 
#define SHAPKA "\n|     City      |     DepSt     |TraNum|Time | costK  |NTK| RCostK |ChRCostK| costP  |NTP| RCostP |ChRCostP|Co|" 
using namespace std;

struct Tickets
{
    char city[15];
    char depSt[15];
    char trainNum[7];
    char time[6];
    float costK;
    int numTK;
    float costP;
    int numTP;
    float realCostK;
    float realCostP;
    float realCostKCh;
    float realCostPCh;
    friend istream& operator >>(istream& is, Tickets& dan);
    friend ostream& operator <<(ostream& os, Tickets& dan);
    friend ofstream& operator <<(ofstream& ofs, Tickets& dan);
} dan;

istream& operator >>(istream& is, Tickets& dan)
{
    cout << "\n Tickets\n";
    cout << " City: ";
    cin >> dan.city;
    cout << " DepSt: ";
    cin >> dan.depSt;
    cout << " TrainNum: ";
    cin >> dan.trainNum;
    cout << " Time: ";
    cin >> dan.time;
    cout << " CostK: ";
    cin >> dan.costK;
    cout << " NumTK: ";
    cin >> dan.numTK;
    cout << " CostP: ";
    cin >> dan.costP;
    cout << " NumTP: ";
    cin >> dan.numTP;
    dan.realCostK = dan.costK + 30;
    dan.realCostP = dan.costP + 30;
    dan.realCostKCh = dan.costK * 0.5 + 30;
    dan.realCostPCh = dan.costP * 0.5 + 30;
    return is;
}

ostream& operator <<(ostream& os, Tickets& dan)
{
    char str[120];
    sprintf_s(str, "\n|%-15s|%-15s|%7s|%6s|%8.2f|%3i|%8.2f|%8.2f|%8.2f|%3i|%8.2f|%8.2f|30|", dan.city, dan.depSt, dan.trainNum, dan.time, dan.costK, dan.numTK, dan.realCostK, dan.realCostKCh, dan.costP, dan.numTP, dan.realCostP, dan.realCostPCh);
    str[119] = '\0';
    os << str;
    return os;
}

ofstream& operator<<(ofstream& ofs, Tickets& dan)
{
    char str[120];
    sprintf_s(str, "\n|%-15s|%-15s|%7s|%6s|%8.2f|%3i|%8.2f|%8.2f|%8.2f|%3i|%8.2f|%8.2f|30|", dan.city, dan.depSt, dan.trainNum, dan.time, dan.costK, dan.numTK, dan.realCostK, dan.realCostKCh, dan.costP, dan.numTP, dan.realCostP, dan.realCostPCh);
    str[119] = '\0';
    ofs << str;
    return ofs;
}

void vvod()
{
    char c;
    ofstream fout;
    fout.open("base.txt", ios::app);
    if (!fout)
    {
        cerr << "\n File base.bd ne otkrit";
        return;
    }
    do {
        cin >> dan;
        fout.write((char*)&dan, sizeof(Tickets));
        cout << "\n vvesti echo? ";
        cin >> c;
    } while (c == 'y'); fout.close();
}

void vivod()
{
    ifstream fin;
    fin.open("base.txt", ios::in);
    if (!fin)
    {
        cout << "file base.bd ne otkrit";
        return;
    }
    ofstream fout;
    fout.open("print.txt", ios::out);
    if (!fout)
    {
        cout << "file print.txt ne otkrit";
        return;
    }
    cout << LINE << SHAPKA << LINE; fout << LINE << SHAPKA << LINE;
    do {
        fin.read((char*)&dan, sizeof(struct Tickets));
        if (!fin.eof())
        {
            cout << dan << LINE; fout << dan << LINE;
        }
    } while (!fin.eof());
    fin.close();
    fout.close();
}

struct List
{
    Tickets t;
    List* next;
};

List* head = 0, * Ref = 0, * last = 0;
Tickets z;
char dbFileName[16] = "FBase.txt";
char printFileName[16] = "Print.txt";

void del()
{
    if (head != 0)
    {
        while (head->next != 0)
        {
            Ref = head->next;
            free((struct List*)head);
            head = Ref;
        }
        free((List*)head);
        head = 0; last = 0; Ref = 0;
    } return;
}

void use()
{
    del();
    char c;
    cout << "\n Ispol'zovat standartnii file FBase.txt? y/n";
    cin >> c;
    if (c == 'n')
    {
        cout << "\n Vvedite svoe imya dlya BD: ";
        cin >> dbFileName;
    }
    else
        strcpy_s(dbFileName, "FBase.txt");
    return;
}

void savetofile()
{
    ofstream fout;
    fout.open(dbFileName, ios::out);
    if (!fout)
    {
        cerr << "\n File ne otkrit!";
        return;
    }
    for (Ref = head; Ref != 0; Ref = Ref->next)
        fout.write((char*)&(Ref->t), sizeof(Tickets));
    fout.close(); return;
}

int add()
{
    Ref = last;
    last = (List*)calloc(1, sizeof(List));
    if (last == 0)
    {
        cerr << "\n Net pamyaty!";
        return 0;
    }
    else
        last->next = 0;
    if (head != 0)
    {
        Ref->next = last; Ref = last;
    }
    else
    {
        head = last; Ref = last;
    }
    return 1;
}

void append()
{
    char c;
    do
    {
        if (add() == 0) return;
        cin >> Ref->t;
        cout << "\n Prodolzhit' vvod? y/n ";
        cin >> c;
    } while (c == 'y');
    savetofile(); return;
}

void create()
{
    char c;
    use();
    cout << "\n Vvesti dannie? y/n ";
    cin >> c;
    if (c == 'y')
        append();
    return;
}

void readfromfile()
{
    del();
    ifstream fin;
    fin.open(dbFileName, ios::in);
    if (!fin)
    {
        cerr << "\n File ne otkrit!"; return;
    }
    else
        while (!fin.read((char*)&z, sizeof(Tickets)).eof())
        {
            if (add() == 0) return;
            else
                Ref->t = z;
        }
    fin.close(); return;
}

void printab()
{
    ofstream fout;
    fout.open(printFileName, ios::out);
    if (!fout)
    {
        cerr << "\n File ne otkrit!"; return;
    }
    cout << LINE << SHAPKA << LINE; fout << LINE << SHAPKA << LINE;
    for (Ref = head; Ref != 0; Ref = Ref->next)
    {
        cout << Ref->t << LINE; fout << Ref->t << LINE;
    }
    fout.close(); return;
}

void otbor1()
{
    ofstream fout;
    fout.open("printO1.txt", ios::out);
    if (!fout)
    {
        cerr << "\n File ne otkrit!"; return;
    }
    cout << LINE << SHAPKA << LINE; fout << LINE << SHAPKA << LINE;
    for (Ref = head; Ref != 0; Ref = Ref->next)
    {
        if (Ref->t.numTK > 0)
        {
            cout << Ref->t << LINE; fout << Ref->t << LINE;
        }
    }
    fout.close(); return;
}

void otbor2()
{
    ofstream fout;
    fout.open("printO1.txt", ios::out);
    if (!fout)
    {
        cerr << "\n File ne otkrit!"; return;
    }
    cout << LINE << SHAPKA << LINE; fout << LINE << SHAPKA << LINE;
    for (Ref = head; Ref != 0; Ref = Ref->next)
    {
        if (Ref->t.numTK + Ref->t.numTP > 4)
        {
            cout << Ref->t << LINE; fout << Ref->t << LINE;
        }
    }
    fout.close(); return;
}

int main()
{
    int key = 0;
    do
    {
        cout << "\n MENU" << "\n l-create" << "\n 2-use" << "\n 3-append" << "\n 4-printtab" << "\n 5-otbor1" << "\n 6-otbor2" << "\n 10-EXIT" << endl;
        cout << "\n Vvedite nomer: ";
        cin >> key;
        switch (key)
        {
        case 1:
            create();
            break;
        case 2:
            use();
            readfromfile();
            break;
        case 3:
            append();
            break;
        case 4:
            printab();
            break;
        case 5:
            otbor1();
            break;
            case 6:
                otbor2();
                break;
        case 10:
            break;
        default: cerr << "\n Wrong number!\n";
        }
    } while (key != 10);
    cout << "\nEnd of program";
}
