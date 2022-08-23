// Laba1_2.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include<stdio.h>	
#include<string.h>	
#include<iostream> 
#include<fstream>
#define LINE "\n|________________________________________________|"
#define SHAPKA "\n|      familia       |gruppa|srednii bal|stipenia|"

using namespace std;

struct Tickets
{
    string city;
    string depSt;
    string trainNum;
    string time;
    float costK;
    int numTK;
    float costP;
    int numTP;
    float commis = 30.0;
    float realCostK;
    float realCostP;
    float realCostKCh;
    float realCostPCh;
    float stipendia;
    friend istream& operator >> (istream& is, Tickets& dan);
    friend ostream& operator << (ostream& os, Tickets& dan);
    friend ofstream& operator << (ofstream& ofs, Tickets& dan);
} dan;

istream& operator >>(istream& is, Tickets& dan)
{
    cout << "\n Ticket enter\n";
    cout << " City: "; is >> dan.city;
    cout << " DepSt: "; is >> dan.depSt;
    cout << " TrainNum: "; is >> dan.trainNum;
    cout << " Time: "; is >> dan.time;
    cout << " CostK: "; is >> dan.costK;
    cout << " NumTK: "; is >> dan.numTK;
    cout << " CostP: "; is >> dan.costP;
    cout << " NumTP: "; is >> dan.numTP;
    dan.realCostK = dan.costK + dan.commis;
    dan.realCostP = dan.costP + dan.commis;
    dan.realCostKCh = dan.costK * 0.5 + dan.commis;
    dan.realCostPCh = dan.costP * 0.5 + dan.commis;
    return is;
}
ostream& operator <<(ostream& os, Tickets& dan)
{
    char str[80];
    sprintf_s(str, "\n | % -15s | % -5s | % 6s | % 5s | % 8.2f | % 3i | % 8.2f | % 8.2f | % 8.2f | % 3i | % 8.2f | % 8.2f | ", dan.city.c_str(), dan.depSt.c_str(), dan.trainNum.c_str(), dan.time.c_str(), dan.costK, dan.numTK, dan.realCostK, dan.realCostKCh, dan.costP, dan.numTP, dan.realCostP, dan.realCostPCh);
    str[79] = '\0';
    os << str; return os;
}
ofstream& operator <<(ofstream& ofs, Tickets& dan)
{
    char str[80];
    sprintf_s(str, "\n | % -15s | % -5s | % 6s | % 5s | % 8.2f | % 3i | % 8.2f | % 8.2f | % 8.2f | % 3i | % 8.2f | % 8.2f | ", dan.city.c_str(), dan.depSt.c_str(), dan.trainNum.c_str(), dan.time.c_str(), dan.costK, dan.numTK, dan.realCostK, dan.realCostKCh, dan.costP, dan.numTP, dan.realCostP, dan.realCostPCh);
    str[79] = '\0';
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
        cout << "file base.bd ne otkrit"; return;
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
        fin.read((char*)&dan, sizeof(Tickets));
        if (!fin.eof())
        {
            cout << dan << LINE; fout << dan << LINE;
        }
    } while (!fin.eof());
    fin.close(); fout.close();
}

int main()
{
    int key = 0;
    do
    {
        cout << "\n MENU" << "\n l-vvod" << "\n 2-vivod" << "\n 3-EXIT";
        cout << "\n Vvedite nomer: ";
        cin >> key;
        switch (key)
        {
        case 1: vvod(); break;
        case 2: vivod(); break;
        case 3: break;
        default: cout << "\n Neverno\n";
        }
    } while (key != 4);
    cout << "\nKonec programmi";
}
