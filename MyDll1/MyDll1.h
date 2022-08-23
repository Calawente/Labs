#pragma once

using namespace System;
using namespace System::Windows::Forms;

namespace MyDll1 {
	public ref class Class1
	{
	public: static double VvodD(TextBox^ t);

	public: static int VvodI(TextBox^ t);

	public: static void Vivod(double x, TextBox^ t);

	public: static double Stor(double r, int n);

	public: static double Perim(double r, int n);
		  
	public: static double Ugol(double a, double b, double c);

	public: static double Min(double a, double b);

	public: static double Max(double a, double b);

	public: static double Vyr31(double x, double y, double c, double d);

	public: static double Vyr32(double x, double y, double c, double d);

	public: static double Vyr33(double x, double c, double d);

	public: static double Vyr3(double x, double y, double c, double d);

	public: static void VivodList(double a, double b, ListBox^ l);

	public: static double Vyr51(double x);

	public: static void Vyr5(double omin, double omax, double shag, int& kz, double& sum, double& pr, double& min, double& max, ListBox^ l, DataGridView^ dgv);

	public: static void VivodDGV(double x, double y, DataGridView^ dgv);
	};

	public ref class Class2 {
	public: static int n = 0;
	public: static int* mas = new int[3];
	public: static bool Vopros1(TextBox^ t);
	public: static bool Vopros2(CheckBox^ chb1, CheckBox^ chb2, CheckBox^ chb3, CheckBox^ chb4);
	public: static bool Vopros3(RadioButton ^rb1, RadioButton^ rb2, RadioButton^ rb3, RadioButton^ rb4);
	public: static void OutputMas(int len, DataGridView^ grid);
	public: static void ZapTxt(DataGridView^ grid, TextBox^ t);
	};

	public ref class Class3 {
	public: static void EnterMas(double* mas, int n);
	public: static void EnterMas(int* mas, int n);
	public:static void SortMasUbyv(int* mas, int n);
	public: static bool MonUbyv(int* mas, int n);
	public: static void OutputMas(double* mas, int len, DataGridView^ grid);
	public: static void OutputMas(int* mas, int len, DataGridView^ grid);
	public: static double SredA5(int* mas, int n);
	public: static int Sravn(int* mas1, int* mas2, int n, double a);
	public: static int UdalEl(int* mas, int len, int n);
	public:static void CopyMas(int* mas1, int* mas2, int n);
	};

	public ref class Class4 {
	public: static void EnterMass(double** mas, int n, int m);
	public: static void EnterMass(int** mas, int n, int m);
	public: static void OutputMas(double** mas, int n, int m, DataGridView^ grid1);
	public: static void OutputMas(int** mas, int n, int m, DataGridView^ grid1);
	public: static void SortMasUbyv(int** mas, int n, int m);
	public: static bool MonUbyv(int** mas, int n, int m);
	public: static double SredA5(int** mas, int n, int m);
	public: static int Sravn(int** mas1, int* mas2, int n, int m, double a);
	public: static void InsertOolumn(int** mas, int n, int m, int insool, int insval);
	//public:static int PolEl()
	};
}
