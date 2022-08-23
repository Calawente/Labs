#pragma once
#include "Form6_1.h"

namespace BlinovaCpp {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для Form6
	/// </summary>
	public ref class Form6 : public System::Windows::Forms::Form
	{
	public:
		Form6(void)
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
		~Form6()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TextBox^ textBox1;
	protected:
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Button^ button1;
	private: System::Windows::Forms::Timer^ timer1;
	private: System::Windows::Forms::Label^ label2;
	private: System::ComponentModel::IContainer^ components;

	private:
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>


#pragma region Windows Form Designer generated code
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->components = (gcnew System::ComponentModel::Container());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->timer1 = (gcnew System::Windows::Forms::Timer(this->components));
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(112, 137);
			this->textBox1->MaxLength = 10;
			this->textBox1->Name = L"textBox1";
			this->textBox1->PasswordChar = '*';
			this->textBox1->Size = System::Drawing::Size(100, 20);
			this->textBox1->TabIndex = 5;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(109, 104);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(71, 13);
			this->label1->TabIndex = 4;
			this->label1->Text = L"Ввод пароля";
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(309, 228);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(75, 41);
			this->button1->TabIndex = 3;
			this->button1->Text = L"ОК";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Form6::button1_Click);
			// 
			// timer1
			// 
			this->timer1->Tick += gcnew System::EventHandler(this, &Form6::timer1_Tick);
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(497, 401);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(43, 13);
			this->label2->TabIndex = 6;
			this->label2->Text = L"abc123";
			// 
			// Form6
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(540, 332);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->button1);
			this->Name = L"Form6";
			this->Text = L"Form6";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {
		if (textBox1->Text == "abc123") {
			Form6_1^ f61 = gcnew Form6_1;
			f61->Show();
			this->Close();
		}
		else {
			MessageBox::Show("Вы ввели неправильный пароль", "Тест", MessageBoxButtons::OK, MessageBoxIcon::Information);
			textBox1->Text = "";

		}
	}
	private: System::Void timer1_Tick(System::Object^ sender, System::EventArgs^ e) {
		MessageBox::Show("Время истекло", "Тест", MessageBoxButtons::OK, MessageBoxIcon::Information);
		textBox1->Text = "";
	}
	};
}
