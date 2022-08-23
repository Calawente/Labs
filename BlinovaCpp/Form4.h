#pragma once
#include "Form4_1.h"

namespace BlinovaCpp {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для Form4
	/// </summary>
	public ref class Form4 : public System::Windows::Forms::Form
	{
	public:
		Form4(void)
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
		~Form4()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ button1;
	protected:
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::TextBox^ textBox1;
	private: System::Windows::Forms::Timer^ timer1;
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
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->timer1 = (gcnew System::Windows::Forms::Timer(this->components));
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(277, 199);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(75, 41);
			this->button1->TabIndex = 0;
			this->button1->Text = L"ОК";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Form4::button1_Click);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(77, 75);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(71, 13);
			this->label1->TabIndex = 1;
			this->label1->Text = L"Ввод пароля";
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(80, 108);
			this->textBox1->MaxLength = 10;
			this->textBox1->Name = L"textBox1";
			this->textBox1->PasswordChar = '*';
			this->textBox1->Size = System::Drawing::Size(100, 20);
			this->textBox1->TabIndex = 2;
			// 
			// timer1
			// 
			this->timer1->Enabled = true;
			this->timer1->Interval = 30000;
			this->timer1->Tick += gcnew System::EventHandler(this, &Form4::timer1_Tick);
			// 
			// Form4
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(709, 346);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->button1);
			this->Name = L"Form4";
			this->Text = L"Form4";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void timer1_Tick(System::Object^ sender, System::EventArgs^ e) {
		MessageBox::Show("Время истекло", "Тест", MessageBoxButtons::OK, MessageBoxIcon::Information);
		textBox1->Text = "";
	}
	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {
		if (textBox1->Text == "abc123") {
			Form4_1^ f41 = gcnew Form4_1;
			f41->Show();
			this->Close();
		}
		else {
			MessageBox::Show("Вы ввели неправильный пароль", "Тест", MessageBoxButtons::OK, MessageBoxIcon::Information);
			textBox1->Text = "";

		}
	}
	};
}
