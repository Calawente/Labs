// Laba4and5.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы. 
// 

#define _CRT_SECURE_NO_WARNINGS
#define LINE "\n|______________________________________________________________________________________________________________|"  
#define SHAPKA "\n|     City      |     DepSt     |TraNum |Time | costK  |NTK| RCostK |ChRCostK| costP  |NTP| RCostP |ChRCostP|Co|" 

#include <iostream>   
#include <fstream>   
#include <string>   
#include <stdio.h>   

using namespace std;

struct Tickets
{
    char city[15];
    char depSt[15];
    int trainNum;
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
    sprintf_s(str, "\n|%-15s|%-15s|%7i|%6s|%8.2f|%3i|%8.2f|%8.2f|%8.2f|%3i|%8.2f|%8.2f|30|", dan.city, dan.depSt, dan.trainNum, dan.time, dan.costK, dan.numTK, dan.realCostK, dan.realCostKCh, dan.costP, dan.numTP, dan.realCostP, dan.realCostPCh);
    str[119] = '\0';
    os << str;
    return os;
}

ofstream& operator<<(ofstream& ofs, Tickets& dan)
{
    char str[120];
    sprintf_s(str, "\n|%-15s|%-15s|%7i|%6s|%8.2f|%3i|%8.2f|%8.2f|%8.2f|%3i|%8.2f|%8.2f|30|", dan.city, dan.depSt, dan.trainNum, dan.time, dan.costK, dan.numTK, dan.realCostK, dan.realCostKCh, dan.costP, dan.numTP, dan.realCostP, dan.realCostPCh);
    str[119] = '\0';
    ofs << str;
    return ofs;
}

struct List
{
    Tickets t;
    List* next, * nextP, * nextK;
};

class Base
{
private:
    List* head, * Ref, * last, * reft, * refk, * headP, * headK;
    Tickets z;
    char dbFileName[16];
    char printFileName[16];
    char otborFileName[16];
public:
    Base()
    {
        head = 0; last = 0; Ref = 0;
        strcpy(dbFileName, "FBase.bd");
        strcpy(printFileName, "Print.bd");
        strcpy(otborFileName, "Otborprint.bd");
    }
    ~Base()
    {
        del();
    }
    void create();
    void use();
    void append();
    void savetofile();
    void readfromfile();
    void printab();
    int add();
    void del();
    void otbor();
};

void Base::create()
{
    char c;
    use();
    cout << "\n Vvesti dannie? y/n ";
    cin >> c;
    if (c == 'y')
        append();
    return;
}

void Base::use()
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

void Base::append()
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

void Base::savetofile()
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

void Base::readfromfile()
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

void Base::printab()
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

int Base::add()
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

void Base::del()
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

int strabc(char a[], char b[])//0=; 1 правильный порядок; -1 поменять
{
    int flag = 0;
    for (int i = 0; i < 15; i++)
    {
        if (a[i] != b[i])
        {
            if (a[i] < b[i])
            {
                flag = 1;
                break;
            }
            else
            {
                flag = -1;
                break;
            }
        }
    }
    return flag;
}

void Base::otbor()
{
    int key = 0, x, key1 = 0;
    char c[15];
    char d[15] = "";
    do {
        ofstream fout;
        cout << "\n Menu" << "\n 1-Bilety v kupe" << "\n 2-Bol'she 4-h biletov do goroda" << "\n 3-Spisok gorodov s vokzala\n" << "4-Sortirovka\n" << "Vvedite nomer\n";
        cin >> key;
        switch (key)
        {
        case 1:
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
            fout.close();
            break;
        case 2:
            cout << "Vvedite gorog:\n";
            cin >> c;
            fout.open("printO1.txt", ios::out);
            if (!fout)
            {
                cerr << "\n File ne otkrit!"; return;
            }
            cout << LINE << SHAPKA << LINE; fout << LINE << SHAPKA << LINE;
            for (Ref = head; Ref != 0; Ref = Ref->next)
            {
                if (Ref->t.numTK + Ref->t.numTP > 4 && strcmp(Ref->t.city, c) == 0)
                {
                    cout << Ref->t << LINE; fout << Ref->t << LINE;
                }
            }
            fout.close();
            break;
        case 3:
            for (Ref = head; Ref != 0; Ref = Ref->next)
                for (reft = Ref->next; reft != 0; reft = reft->next)
                {
                    int fl = strabc(Ref->t.city, reft->t.city);
                    if (fl == -1)
                    {
                        dan = Ref->t;
                        Ref->t = reft->t; 
                        reft->t = dan;
                    }
                }
            cout << "Vvedite vikzal:\n";
            cin >> c;
            cout << "Goroda:\n";
            for (Ref = head; Ref != 0; Ref = Ref->next)
            {
                if (strcmp(Ref->t.depSt, c) == 0)
                {
                    if (strcmp(Ref->t.city, d) != 0)
                    {
                        cout << Ref->t.city << "\n";
                        strcpy(d, Ref->t.city);
                    }
                }
            }
            break;
        case 4:
            for (Ref = head; Ref != 0; Ref = Ref->next)
                for (reft = Ref->next; reft != 0; reft = reft->next)
                {
                    if (Ref->t.trainNum > reft->t.trainNum)
                    {
                        dan = Ref->t;
                        Ref->t = reft->t;
                        reft->t = dan;
                    }
                }
            headK = 0;
            headP = 0;
            refk = 0;
            reft = 0;
            for (Ref = head; Ref != 0; Ref = Ref->next)
            {
                if (Ref->t.numTK > 0)
                {
                    if (headK == 0)
                    {
                        headK = Ref; 
                    }
                    else
                    {
                        refk->nextK = Ref;
                    }
                    refk = Ref;
                }
                if (Ref->t.numTP > 0)
                {
                    if (headP == 0)
                    {
                        headP = Ref;
                    }
                    else
                    {
                        reft->nextP = Ref;
                    }
                    reft = Ref;
                }
            }
            do
            {
                cout << "Menu:\n" << "1 - Vyvesti bilety v kupe\n" << "2 - Vyvesti Bilety v platskart\n" << "3 - Prodat' bilety v kupe\n" << "4 - Prodat' bilety v platskart\n" << "10 - Vyhod\n";
                cin >> key1;
                switch (key1)
                {
                case 1:
                    fout.open("printO1.txt", ios::out);
                    if (!fout)
                    {
                        cerr << "\n File ne otkrit!"; return;
                    }
                    cout << LINE << SHAPKA << LINE; fout << LINE << SHAPKA << LINE;
                    for (Ref = headK; Ref != 0; Ref = Ref->nextK)
                    {
                        cout << Ref->t << LINE; fout << Ref->t << LINE;
                    }
                    fout.close();
                    break;
                case 2:
                    fout.open("printO1.txt", ios::out);
                    if (!fout)
                    {
                        cerr << "\n File ne otkrit!"; return;
                    }
                    cout << LINE << SHAPKA << LINE; fout << LINE << SHAPKA << LINE;
                    for (Ref = headP; Ref != 0; Ref = Ref->nextP)
                    {
                        cout << Ref->t << LINE; fout << Ref->t << LINE;
                    }
                    fout.close();
                    break;
                case 3:
                    for (Ref = headK; Ref != 0; Ref = Ref->nextK)
                    {
                        cout << Ref->t << LINE;
                        cout << "Prodap' x biletov\n";
                        cin >> x;
                        if (x > Ref->t.numTK)
                        {
                            cerr << "Ne hvataet biletov!";
                        }
                        else
                        {
                            Ref->t.numTK -= x;
                        }
                    }
                    break;
                case 4:
                    for (Ref = headP; Ref != 0; Ref = Ref->nextP)
                    {
                        cout << Ref->t << LINE;
                        cout << "Prodap' x biletov\n";
                        cin >> x;
                        if (x > Ref->t.numTP)
                        {
                            cerr << "Ne hvataet biletov!";
                        }
                        else
                        {
                            Ref->t.numTP -= x;
                        }
                    }
                    break;
                default: cerr << "\n Wrong number!";
                    break;
                }
            } while (key1 != 10);
            break;
        default: cerr << "\n Wrong number!";
        }      
    } while (key != 10);
}


int main()
{
    int key = 0;
    Base Bd;
    do
    {
        cout << "\n MENU" << "\n 1-create" << "\n 2-use"
            << "\n 3-append" << "\n 4-printab" << "\n 5-otbor i prodazha biletov" << "\n 10-EXIT" << endl;
        cout << "\n Vvedite nomer:";
        cin >> key;
        switch (key)
        {
        case    1: Bd.create(); break;
        case    2: Bd.use(); Bd.readfromfile(); break;
        case    3: Bd.append(); break;
        case    4: Bd.printab(); break;
        case    5: Bd.otbor();break;  
        default: cerr << "\n Wrong number!";
        }
    } while (key != 10);
    cout << "\n END OF PROGRAM";
}

/*Задание к лабораторной работе №2
•    Вывести список городов, в которые имеются билеты в купе.
•    Вывести список поездов, в которых есть более 4 купейных или плацкартных билетов до заданного города.
Задание к лабораторной работе №5
•    Вывести список городов, в которые можно выехать с заданного вокзала(например, с Курского).Список упорядочить по названию города назначения в алфавитном порядке.
Задание к лабораторной работе №6
•    Из общего списка билетов создать два списка :
1.    билетов в купейные вагоны, упорядоченные по номеру вагона.
2.    билетов в плацкартные вагоны, упорядоченные по номеру вагона.
•    Продать 2, 3, 4, 10 билетов в один вагон.*/