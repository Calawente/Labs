#include "pch.h"

#include "MyDll1.h"
#include <cmath>
#include <cstdlib>
#include <ctime>

using namespace System;
using namespace System::Windows::Forms;
using namespace Microsoft::VisualBasic;

namespace MyDll1 {
	double Class1::VvodD(TextBox^ t) {
		return Convert::ToDouble(t->Text);
	}

	int Class1::VvodI(TextBox^ t) {
		return Convert::ToInt32(t->Text);
	}

	void Class1::Vivod(double x, TextBox^ t) {
		t->Text = Convert::ToString(x);
	}

	double Class1::Stor(double r, int n) {
		return 2 * r * sin(3.141592653589793 / n);
	}

	double Class1::Perim(double r, int n) {
		return Stor(r, n) * n;
	}

	double Class1::Ugol(double a, double b, double c) {
		return acos((c * c + b * b - a * a) / (2 * b * c) ) * 180.0 / 3.141592653589793;
	}
	
	double Class1::Max(double a, double b) {
		if (a > b) {
			return a;
		}
		else {
			return b;
		}
	}

	double Class1::Min(double a, double b) {
		if (a < b) {
			return a;
		}
		else
		{
			return b;
		}
	}

	double Class1::Vyr31(double x, double y, double c, double d) {
		double a = x * x * x;
		double b = std::pow(std::log(x * y), c * d);
		return Max(a, b);
	}

	double Class1::Vyr32(double x, double y, double c, double d) {
		double a = c * x;
		double b = d * y;
		double t = Max(a, b);
		t = Min(x, t);
		t = Min(y, t);
		return t * 3;
	}

	double Class1::Vyr33(double x, double c, double d) {
		return std::pow(2, c * d) - x;
	}

	double Class1::Vyr3(double x, double y, double c, double d) {
		double t;
		if (x * y > 3) {
			t = Vyr31(x, y, c, d);
		}
		else {
			if (x * y >= 0) {
				t = Vyr32(x, y, c, d);
			}
			else
			{
				t = Vyr33(x, c, d);
			}
		}
		return t;
	}

	void Class1::VivodList(double a, double b, ListBox^ l) {
		l->Items->Add(a.ToString("0.00") + "pi      " + b.ToString("0.00"));
	}

	double Class1::Vyr51(double x) {
		return 3 * std::cos(2 * x * 3.1415926535 + 1) * std::cos(2 * x * 3.1415926535 + 1);
	}

	void Class1::Vyr5(double omin, double omax, double shag, int& kz, double& sum, double& pr, double& min, double& max, ListBox^ l, DataGridView^ dgv) {
		kz = 0; sum = 0; pr = 1; min = 1000; max = -1000;
		double znach;
		for (double i = omin; i <= omax; i += 1 / shag) {
			kz++;
			znach = Vyr51(i);
			sum += znach;
			pr *= znach;
			min = Min(min, znach);
			max = Max(max, znach);
			VivodList(i, znach, l);
			VivodDGV(i, znach, dgv);
		}
	}

	void Class1::VivodDGV(double x, double y, DataGridView^ dgv) {
		dgv->Rows->Add(x.ToString("0.00") + "pi", y);
	}





	bool Class2::Vopros1(TextBox^ t) {
		if (t->Text == "") {
			MessageBox::Show("Введите текст", "Тест", MessageBoxButtons::OK, MessageBoxIcon::Information);
			return false;
		}
		else {
			if (t->Text == "информатика" || t->Text == "Информатика") {
				MessageBox::Show("Верно", "Тест", MessageBoxButtons::OK, MessageBoxIcon::Information);
				mas[0] = 1;
				n++;
			}
			else {
				MessageBox::Show("Неверно", "Тест", MessageBoxButtons::OK, MessageBoxIcon::Information);
				mas[0] = 0;
			}
			return true;
		}
	}
	
	bool Class2::Vopros2(CheckBox^ chb1, CheckBox^ chb2, CheckBox^ chb3, CheckBox^ chb4) {
		if (!chb1->Checked && !chb2->Checked && !chb3->Checked && !chb4->Checked) {
			MessageBox::Show("Введите ответ", "Тест", MessageBoxButtons::OK, MessageBoxIcon::Information);
			return false;
		}
		else {
			if (chb2->Checked && chb4->Checked && !chb1->Checked && !chb3->Checked) {
				mas[1] = 1;
				n++;
				MessageBox::Show("Верно", "Тест", MessageBoxButtons::OK, MessageBoxIcon::Information);
			}
			else {
				mas[1] = 0;
				MessageBox::Show("Неверно", "Тест", MessageBoxButtons::OK, MessageBoxIcon::Information);
			}
			return true;
		}
	}

	bool Class2::Vopros3(RadioButton^ rb1, RadioButton^ rb2, RadioButton^ rb3, RadioButton^ rb4) {
		if (!rb1->Checked && !rb2->Checked && !rb3->Checked && !rb4->Checked) {
			MessageBox::Show("Введите ответ", "Тест", MessageBoxButtons::OK, MessageBoxIcon::Information);
			return false;
		}
		else {
			if (rb2->Checked) {
				mas[2] = 1;
				n++;
				MessageBox::Show("Верно", "Тест", MessageBoxButtons::OK, MessageBoxIcon::Information);
			}
			else {
				mas[2] = 0;
				MessageBox::Show("Неверно", "Тест", MessageBoxButtons::OK, MessageBoxIcon::Information);
			}
			return true;
		}
	}

	void Class2::OutputMas( int len, DataGridView^ grid) {
		grid->ColumnCount = len;
		grid->RowCount = 2;
		for (int i = 0; i < len; i++) {
			grid->Rows[0]->Cells[i]->Value = "[" + (i + 1) + "]";
			grid->Rows[1]->Cells[i]->Value = mas[i];
		}
		int width = 0;
		for (int i = 0; i < grid->ColumnCount; i++) {
			width += grid->Columns[i]->Width;
		}
		if (width > 1080) {
			grid->Width = 1080;
		}
		else {
			grid->Width = width;
		}
	}

	void Class2::ZapTxt(DataGridView^ grid, TextBox^ t) {
		String^ filename = t->Text + ".txt";
		try {
			auto fk = System::Text::Encoding::GetEncoding(1251);
			auto Z = gcnew IO::StreamWriter(filename, false, fk);
			String^ row = nullptr;
			Z->WriteLine("Баллы полученные за тест!");
			for (int i = 0; i < grid->ColumnCount; i++) {
				Z->WriteLine(Convert::ToString(grid->Rows[1]->Cells[i]->Value));
			}
			Z->Close();
			MessageBox::Show("Запись в файл произошла успешно!", "Запись", MessageBoxButtons::OK, MessageBoxIcon::Information);
		}
		catch (System::Exception^ E) {
			MessageBox::Show(E->Message + "\nОшибка", "Ошибка");
		}
	}

	void Class3::EnterMas(double* mas, int n) {
		srand(time(0));
		for (int i = 0; i < n; i++) {
			mas[i] = (int)(rand() % 900) / 20 - 20;
		}
	}

	void Class3::EnterMas(int* mas, int n) {
		srand(time(0));
		for (int i = 0; i < n; i++) {
			mas[i] = rand() % 2000 - 1000;
		}
	}

	void Class3::OutputMas(double* mas, int len, DataGridView^ grid) {
		grid->ColumnCount = len;
		grid->RowCount = 2;
		for (int i = 0; i < len; i++) {
			grid->Rows[0]->Cells[i]->Value = "[" + i + "]";
			grid->Rows[1]->Cells[i]->Value = mas[i];
		}
	}

	void Class3::OutputMas(int* mas, int len, DataGridView^ grid) {
		grid->ColumnCount = len;
		grid->RowCount = 2;
		for (int i = 0; i < len; i++) {
			grid->Rows[0]->Cells[i]->Value = "[" + i + "]";
			grid->Rows[1]->Cells[i]->Value = mas[i];
		}
	}

	double Class3::SredA5(int* mas, int n) {
		int a = 0;
		int sum = 0;
		for (int i = 0; i < n; i++) {
			if (mas[i] % 5 == 0) {
				a++;
				sum += mas[i];
			}
		}
		double rez = -1000000;
		if (a > 0) {
			rez = sum / a;
		}
		return rez;
	}

	int Class3::Sravn(int* mas1, int* mas2, int n, double a) {
		int b = 0;
		for (int i = 0; i < n; i++) {
			if (mas1[i] < a) {
				mas2[b] = mas1[i];
				b++;
			}
		}
		return b;
	}

	int Class3::UdalEl(int* mas, int len, int n) {
		if (len > n) {
			for (int i = n; i < len - 1; i++) {
				mas[i] = mas[i + 1];
			}
			len--;
		}
		return len;
	}

	void Class3::CopyMas(int* mas1, int* mas2, int n) {
		for (int i = 0; i < n; i++) {
			mas2[i] = mas1[i];
		}
	}

	void Class3::SortMasUbyv(int* mas, int n) {
		int max;
		for (int i = 0; i < n - 1; i++) {
			max = mas[i];
			for (int j = i + 1; j < n; j++) {
				if (mas[j] > max) {
					mas[i] = mas[j];
					mas[j] = max;
					max = mas[i];
				}
			}
		}
	}

	bool Class3::MonUbyv(int* mas, int n) {
		bool flag = true;
		for (int i = 0; i < n - 1; i++) {
			if (mas[i] < mas[i + 1]) {
				flag = false;
				break;
			}
		}
		return flag;
	}

	void Class4::EnterMass(double** mas, int n, int m) {
		srand(unsigned(time(NULL)));
		for (int i = 0; i < n; i++) {
			mas[i] = new double[m];
			for (int j = 0; j < m; j++) {
				mas[i][j] = (double)(rand() % 100) - 20;
			}
		}
	}

	void Class4::EnterMass(int** mas, int n, int m) {
		srand(unsigned(time(NULL)));
		for (int i = 0; i < n; i++) {
			mas[i] = new int[m];
			for (int j = 0; j < m; j++) {
				mas[i][j] = rand() % 2000 - 1000;
			}
		}
	}

	void Class4::OutputMas(double** mas, int n, int m, DataGridView^ grid1) {
		grid1->ColumnCount = m + 1;
		grid1->RowCount = n + 1;
		grid1->Rows[0]->Cells[0]->Value = "[" + n + "][" + m + "]";
		for (int i = 0; i < n; i++) {
			grid1->Rows[i + 1]->Cells[0]->Value = "[" + i + "]";
		}
		for (int j = 0; j < m; j++) {
			grid1->Rows[0]->Cells[j + 1]->Value = "[" + j + "]";
		}
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				grid1->Rows[i + 1]->Cells[j + 1]->Value = mas[i][j];
			}
		}
	}

	void Class4::OutputMas(int** mas, int n, int m, DataGridView^ grid1) {
		grid1->ColumnCount = m + 1;
		grid1->RowCount = n + 1;
		grid1->Rows[0]->Cells[0]->Value = "[" + n + "][" + m + "]";
		for (int i = 0; i < n; i++) {
			grid1->Rows[i + 1]->Cells[0]->Value = "[" + i + "]";
		}
		for (int j = 0; j < m; j++) {
			grid1->Rows[0]->Cells[j + 1]->Value = "[" + j + "]";
		}
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				grid1->Rows[i + 1]->Cells[j + 1]->Value = mas[i][j];
			}
		}
	}

	void Class4::SortMasUbyv(int** mas, int n, int m) {
		int* arr = new int[n * m];
		int a = 0;
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				arr[a] = mas[i][j];
				a++;
			}
		}
		int max;
		for (int i = 0; i < n*m - 1; i++) {
			max = arr[i];
			for (int j = i + 1; j < n*m; j++) {
				if (arr[j] > max) {
					arr[i] = arr[j];
					arr[j] = max;
					max = arr[i];
				}
			}
		}
		a = 0;
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				mas[i][j] = arr[a];
				a++;
			}
		}
		delete[] arr;
	}

	bool Class4::MonUbyv(int** mas, int n, int m) {
		int* arr = new int[n * m];
		int a = 0;
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				arr[a] = mas[i][j];
				a++;
			}
		}
		bool flag = true;
		for (int i = 0; i < n*m - 1; i++) {
			if (arr[i] < arr[i + 1]) {
				flag = false;
				break;
			}
		}
		delete[] arr;
		return flag;
	}

	double Class4::SredA5(int** mas, int n, int m) {
		int* arr = new int[n * m];
		int a = 0;
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				arr[a] = mas[i][j];
				a++;
			}
		}
		a = 0;
		int sum = 0;
		for (int i = 0; i < n; i++) {
			if (arr[i] % 5 == 0) {
				a++;
				sum += arr[i];
			}
		}
		double rez = -1000000;
		if (a > 0) {
			rez = sum / a;
		}
		return rez;
	}

	int Class4::Sravn(int** mas1, int* mas2, int n, int m, double a) {
		int* arr = new int[n * m];
		int ch = 0;
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				arr[ch] = mas1[i][j];
				a++;
			}
		}
		int b = 0;
		for (int i = 0; i < n; i++) {
			if (arr[i] < a) {
				mas2[b] = arr[i];
				b++;
			}
		}
		return b;
	}

	void Class4::InsertOolumn(int** mas, int n, int m, int insool, int insval) {
		for (int i = 0; i < n; i++) {
			for (int j = insool - 1; j < m; j++) {
				mas[i][j + 1] = mas[i][j];
			}
		}
		for (int i = 0; i < n; i++) {
			mas[i][insool] = insval;
		}
	}
}
