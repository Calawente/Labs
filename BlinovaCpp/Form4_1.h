#pragma once
#include "Form4_2.h"

namespace BlinovaCpp {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для Form4_1
	/// </summary>
	public ref class Form4_1 : public System::Windows::Forms::Form
	{
	public:
		Form4_1(void)
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
		~Form4_1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TextBox^ textBox1;
	private: System::Windows::Forms::TextBox^ textBox2;
	private: System::Windows::Forms::Button^ button1;
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
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(41, 76);
			this->textBox1->Multiline = true;
			this->textBox1->Name = L"textBox1";
			this->textBox1->ReadOnly = true;
			this->textBox1->Size = System::Drawing::Size(338, 59);
			this->textBox1->TabIndex = 0;
			this->textBox1->Text = L"Совокупность дисциплин, изучающих свойства инфор-мации, а также способы представл"
				L"ения, накопления, обработки и передачи ин-формации с помощью технических средств"
				L" это";
			this->textBox1->TextChanged += gcnew System::EventHandler(this, &Form4_1::textBox1_TextChanged);
			// 
			// textBox2
			// 
			this->textBox2->Location = System::Drawing::Point(41, 171);
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(124, 20);
			this->textBox2->TabIndex = 1;
			this->textBox2->TextChanged += gcnew System::EventHandler(this, &Form4_1::textBox2_TextChanged);
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(41, 241);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(222, 55);
			this->button1->TabIndex = 2;
			this->button1->Text = L"ОК";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Form4_1::button1_Click);
			// 
			// Form4_1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(641, 362);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->textBox2);
			this->Controls->Add(this->textBox1);
			this->Name = L"Form4_1";
			this->Text = L"Form4_1";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	public: int c = 0;
		

	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {
		if (textBox2->Text == "") {
			MessageBox::Show("Введите текст", "Тест", MessageBoxButtons::OK, MessageBoxIcon::Information);
		}
		else {
			if (textBox2->Text == "информатика" || textBox2->Text == "Информатика") {
				MessageBox::Show("Верно", "Тест", MessageBoxButtons::OK, MessageBoxIcon::Information);
				c++;
			}
			else {
				MessageBox::Show("Неверно", "Тест", MessageBoxButtons::OK, MessageBoxIcon::Information);
			}
			Form4_2^ f42 = gcnew Form4_2;
			f42->c = c;
			f42->Show();
			this->Close();
		}
	}
	private: System::Void textBox2_TextChanged(System::Object^ sender, System::EventArgs^ e) {
	}
private: System::Void textBox1_TextChanged(System::Object^ sender, System::EventArgs^ e) {
	}
};
}
