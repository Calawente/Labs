#pragma once
#include "Form1.h"
#include "Form2.h"
#include "Form3.h"
#include "Form4.h"
#include "Form5.h"
#include "Form6.h"
#include "Form7.h"
#include "Form8.h"

namespace BlinovaCpp {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	

	/// <summary>
	/// Сводка для MainForm
	/// </summary>
	public ref class MainForm : public System::Windows::Forms::Form
	{
	public:
		MainForm(void)
		{
			InitializeComponent();
			//
			//TODO: добавьте код конструктора
			//
		}

	protected:
		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		~MainForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ button1;
	private: System::Windows::Forms::Button^ button2;
	private: System::Windows::Forms::Button^ button3;
	private: System::Windows::Forms::Button^ button4;
	private: System::Windows::Forms::Button^ button5;
	private: System::Windows::Forms::Button^ button6;
	private: System::Windows::Forms::Button^ button7;
	private: System::Windows::Forms::Button^ button8;
	private: System::Windows::Forms::Button^ button9;
	private: System::Windows::Forms::Button^ button10;
	private: System::Windows::Forms::Button^ button11;
	protected:

	protected:





	private:
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->button3 = (gcnew System::Windows::Forms::Button());
			this->button4 = (gcnew System::Windows::Forms::Button());
			this->button5 = (gcnew System::Windows::Forms::Button());
			this->button6 = (gcnew System::Windows::Forms::Button());
			this->button7 = (gcnew System::Windows::Forms::Button());
			this->button8 = (gcnew System::Windows::Forms::Button());
			this->button9 = (gcnew System::Windows::Forms::Button());
			this->button10 = (gcnew System::Windows::Forms::Button());
			this->button11 = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(53, 64);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(176, 23);
			this->button1->TabIndex = 0;
			this->button1->Text = L"Лабораторная 1";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MainForm::button1_Click);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(339, 64);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(176, 23);
			this->button2->TabIndex = 1;
			this->button2->Text = L"Лабораторная 2";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &MainForm::button2_Click);
			// 
			// button3
			// 
			this->button3->Location = System::Drawing::Point(339, 93);
			this->button3->Name = L"button3";
			this->button3->Size = System::Drawing::Size(176, 23);
			this->button3->TabIndex = 2;
			this->button3->Text = L"Лабораторная 3";
			this->button3->UseVisualStyleBackColor = true;
			this->button3->Click += gcnew System::EventHandler(this, &MainForm::button3_Click);
			// 
			// button4
			// 
			this->button4->Location = System::Drawing::Point(339, 122);
			this->button4->Name = L"button4";
			this->button4->Size = System::Drawing::Size(176, 23);
			this->button4->TabIndex = 3;
			this->button4->Text = L"Лабораторная 4";
			this->button4->UseVisualStyleBackColor = true;
			this->button4->Click += gcnew System::EventHandler(this, &MainForm::button4_Click);
			// 
			// button5
			// 
			this->button5->Location = System::Drawing::Point(53, 122);
			this->button5->Name = L"button5";
			this->button5->Size = System::Drawing::Size(176, 23);
			this->button5->TabIndex = 4;
			this->button5->Text = L"Лабораторная 3";
			this->button5->UseVisualStyleBackColor = true;
			this->button5->Click += gcnew System::EventHandler(this, &MainForm::button5_Click);
			// 
			// button6
			// 
			this->button6->Location = System::Drawing::Point(53, 93);
			this->button6->Name = L"button6";
			this->button6->Size = System::Drawing::Size(176, 23);
			this->button6->TabIndex = 5;
			this->button6->Text = L"Лабораторная 2";
			this->button6->UseVisualStyleBackColor = true;
			this->button6->Click += gcnew System::EventHandler(this, &MainForm::button6_Click);
			// 
			// button7
			// 
			this->button7->Location = System::Drawing::Point(53, 151);
			this->button7->Name = L"button7";
			this->button7->Size = System::Drawing::Size(176, 23);
			this->button7->TabIndex = 6;
			this->button7->Text = L"Лабораторная 4";
			this->button7->UseVisualStyleBackColor = true;
			this->button7->Click += gcnew System::EventHandler(this, &MainForm::button7_Click);
			// 
			// button8
			// 
			this->button8->Location = System::Drawing::Point(339, 151);
			this->button8->Name = L"button8";
			this->button8->Size = System::Drawing::Size(176, 23);
			this->button8->TabIndex = 7;
			this->button8->Text = L"Лабораторная 5";
			this->button8->UseVisualStyleBackColor = true;
			this->button8->Click += gcnew System::EventHandler(this, &MainForm::button8_Click);
			// 
			// button9
			// 
			this->button9->Location = System::Drawing::Point(53, 180);
			this->button9->Name = L"button9";
			this->button9->Size = System::Drawing::Size(176, 23);
			this->button9->TabIndex = 8;
			this->button9->Text = L"Лабораторная 5";
			this->button9->UseVisualStyleBackColor = true;
			this->button9->Click += gcnew System::EventHandler(this, &MainForm::button9_Click);
			// 
			// button10
			// 
			this->button10->Location = System::Drawing::Point(53, 209);
			this->button10->Name = L"button10";
			this->button10->Size = System::Drawing::Size(176, 23);
			this->button10->TabIndex = 9;
			this->button10->Text = L"Лабораторная 6";
			this->button10->UseVisualStyleBackColor = true;
			this->button10->Click += gcnew System::EventHandler(this, &MainForm::button10_Click);
			// 
			// button11
			// 
			this->button11->Location = System::Drawing::Point(53, 238);
			this->button11->Name = L"button11";
			this->button11->Size = System::Drawing::Size(176, 23);
			this->button11->TabIndex = 10;
			this->button11->Text = L"Лабораторная 7";
			this->button11->UseVisualStyleBackColor = true;
			this->button11->Click += gcnew System::EventHandler(this, &MainForm::button11_Click);
			// 
			// MainForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::ActiveBorder;
			this->ClientSize = System::Drawing::Size(726, 340);
			this->Controls->Add(this->button11);
			this->Controls->Add(this->button10);
			this->Controls->Add(this->button9);
			this->Controls->Add(this->button8);
			this->Controls->Add(this->button7);
			this->Controls->Add(this->button6);
			this->Controls->Add(this->button5);
			this->Controls->Add(this->button4);
			this->Controls->Add(this->button3);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->button1);
			this->Name = L"MainForm";
			this->Text = L"MainForm";
			this->WindowState = System::Windows::Forms::FormWindowState::Maximized;
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {
		Form1^ f1 = gcnew Form1;
		f1->Show();

	}
	private: System::Void button2_Click(System::Object^ sender, System::EventArgs^ e) {
		Form2^ f2 = gcnew Form2;
		f2->Show();
	}
	private: System::Void button3_Click(System::Object^ sender, System::EventArgs^ e) {
		Form3^ f3 = gcnew Form3;
		f3->Show();
	}
private: System::Void button4_Click(System::Object^ sender, System::EventArgs^ e) {
	Form4^ f4 = gcnew Form4;
	f4->Show();
}
private: System::Void button5_Click(System::Object^ sender, System::EventArgs^ e) {
	Form5^ f5 = gcnew Form5;
	f5->Show();
}
private: System::Void button6_Click(System::Object^ sender, System::EventArgs^ e) {
	Form6^ f6 = gcnew Form6;
	f6->Show();
}
private: System::Void button7_Click(System::Object^ sender, System::EventArgs^ e) {
	Form7^ f7 = gcnew Form7;
	f7->Show();
}
private: System::Void button8_Click(System::Object^ sender, System::EventArgs^ e) {
	Form8^ f8 = gcnew Form8;
	f8->Show();
}
private: System::Void button9_Click(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void button10_Click(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void button11_Click(System::Object^ sender, System::EventArgs^ e) {
}
};
}
