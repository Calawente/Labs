#pragma once
#include "Form6_3.h"

namespace BlinovaCpp {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для Form6_2
	/// </summary>
	public ref class Form6_2 : public System::Windows::Forms::Form
	{
	public:
		Form6_2(void)
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
		~Form6_2()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::GroupBox^ groupBox1;
	protected:
	private: System::Windows::Forms::CheckBox^ checkBox4;
	private: System::Windows::Forms::CheckBox^ checkBox3;
	private: System::Windows::Forms::CheckBox^ checkBox2;
	private: System::Windows::Forms::CheckBox^ checkBox1;
	private: System::Windows::Forms::TextBox^ textBox1;
	private: System::Windows::Forms::Button^ button1;

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
			this->groupBox1 = (gcnew System::Windows::Forms::GroupBox());
			this->checkBox4 = (gcnew System::Windows::Forms::CheckBox());
			this->checkBox3 = (gcnew System::Windows::Forms::CheckBox());
			this->checkBox2 = (gcnew System::Windows::Forms::CheckBox());
			this->checkBox1 = (gcnew System::Windows::Forms::CheckBox());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->groupBox1->SuspendLayout();
			this->SuspendLayout();
			// 
			// groupBox1
			// 
			this->groupBox1->Controls->Add(this->checkBox4);
			this->groupBox1->Controls->Add(this->checkBox3);
			this->groupBox1->Controls->Add(this->checkBox2);
			this->groupBox1->Controls->Add(this->checkBox1);
			this->groupBox1->Location = System::Drawing::Point(398, 68);
			this->groupBox1->Name = L"groupBox1";
			this->groupBox1->Size = System::Drawing::Size(200, 182);
			this->groupBox1->TabIndex = 8;
			this->groupBox1->TabStop = false;
			this->groupBox1->Text = L"Выберите варианты ответа";
			// 
			// checkBox4
			// 
			this->checkBox4->AutoSize = true;
			this->checkBox4->Location = System::Drawing::Point(7, 98);
			this->checkBox4->Name = L"checkBox4";
			this->checkBox4->Size = System::Drawing::Size(88, 17);
			this->checkBox4->TabIndex = 3;
			this->checkBox4->Text = L"Базовое ПО";
			this->checkBox4->UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this->checkBox3->AutoSize = true;
			this->checkBox3->Location = System::Drawing::Point(7, 74);
			this->checkBox3->Name = L"checkBox3";
			this->checkBox3->Size = System::Drawing::Size(153, 17);
			this->checkBox3->TabIndex = 2;
			this->checkBox3->Text = L"Интерфейсные оболочки";
			this->checkBox3->UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this->checkBox2->AutoSize = true;
			this->checkBox2->Location = System::Drawing::Point(7, 50);
			this->checkBox2->Name = L"checkBox2";
			this->checkBox2->Size = System::Drawing::Size(70, 17);
			this->checkBox2->TabIndex = 1;
			this->checkBox2->Text = L"Утилиты";
			this->checkBox2->UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this->checkBox1->AutoSize = true;
			this->checkBox1->Location = System::Drawing::Point(7, 26);
			this->checkBox1->Name = L"checkBox1";
			this->checkBox1->Size = System::Drawing::Size(150, 17);
			this->checkBox1->TabIndex = 0;
			this->checkBox1->Text = L"Операционные системы";
			this->checkBox1->UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(54, 68);
			this->textBox1->Multiline = true;
			this->textBox1->Name = L"textBox1";
			this->textBox1->ReadOnly = true;
			this->textBox1->Size = System::Drawing::Size(152, 44);
			this->textBox1->TabIndex = 7;
			this->textBox1->Text = L"Системное ПО делится на: ";
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(54, 247);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(179, 60);
			this->button1->TabIndex = 6;
			this->button1->Text = L"OK";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Form6_2::button1_Click);
			// 
			// Form6_2
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(676, 370);
			this->Controls->Add(this->groupBox1);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->button1);
			this->Name = L"Form6_2";
			this->Text = L"Form6_2";
			this->groupBox1->ResumeLayout(false);
			this->groupBox1->PerformLayout();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {
		bool f = MyDll1::Class2::Vopros2(checkBox1, checkBox2, checkBox3, checkBox4);
		if (f == true) {
			Form6_3^ f63 = gcnew Form6_3();
			f63->Show();
			this->Close();
		}
	}
};
}
