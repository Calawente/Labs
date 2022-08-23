#pragma once
#include "Form6_4.h"

namespace BlinovaCpp {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для Form6_3
	/// </summary>
	public ref class Form6_3 : public System::Windows::Forms::Form
	{
	public:
		Form6_3(void)
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
		~Form6_3()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::GroupBox^ groupBox1;
	protected:
	private: System::Windows::Forms::RadioButton^ radioButton4;
	private: System::Windows::Forms::RadioButton^ radioButton3;
	private: System::Windows::Forms::RadioButton^ radioButton2;
	private: System::Windows::Forms::RadioButton^ radioButton1;
	private: System::Windows::Forms::TextBox^ textBox1;
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
			this->groupBox1 = (gcnew System::Windows::Forms::GroupBox());
			this->radioButton4 = (gcnew System::Windows::Forms::RadioButton());
			this->radioButton3 = (gcnew System::Windows::Forms::RadioButton());
			this->radioButton2 = (gcnew System::Windows::Forms::RadioButton());
			this->radioButton1 = (gcnew System::Windows::Forms::RadioButton());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->groupBox1->SuspendLayout();
			this->SuspendLayout();
			// 
			// groupBox1
			// 
			this->groupBox1->Controls->Add(this->radioButton4);
			this->groupBox1->Controls->Add(this->radioButton3);
			this->groupBox1->Controls->Add(this->radioButton2);
			this->groupBox1->Controls->Add(this->radioButton1);
			this->groupBox1->Location = System::Drawing::Point(465, 102);
			this->groupBox1->Name = L"groupBox1";
			this->groupBox1->Size = System::Drawing::Size(228, 163);
			this->groupBox1->TabIndex = 5;
			this->groupBox1->TabStop = false;
			this->groupBox1->Text = L"Выберите вариант ответа";
			// 
			// radioButton4
			// 
			this->radioButton4->AutoSize = true;
			this->radioButton4->Location = System::Drawing::Point(7, 92);
			this->radioButton4->Name = L"radioButton4";
			this->radioButton4->Size = System::Drawing::Size(49, 17);
			this->radioButton4->TabIndex = 3;
			this->radioButton4->TabStop = true;
			this->radioButton4->Text = L"1790";
			this->radioButton4->UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this->radioButton3->AutoSize = true;
			this->radioButton3->Location = System::Drawing::Point(7, 68);
			this->radioButton3->Name = L"radioButton3";
			this->radioButton3->Size = System::Drawing::Size(49, 17);
			this->radioButton3->TabIndex = 2;
			this->radioButton3->TabStop = true;
			this->radioButton3->Text = L"1858";
			this->radioButton3->UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this->radioButton2->AutoSize = true;
			this->radioButton2->Location = System::Drawing::Point(7, 44);
			this->radioButton2->Name = L"radioButton2";
			this->radioButton2->Size = System::Drawing::Size(49, 17);
			this->radioButton2->TabIndex = 1;
			this->radioButton2->TabStop = true;
			this->radioButton2->Text = L"1642";
			this->radioButton2->UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this->radioButton1->AutoSize = true;
			this->radioButton1->Location = System::Drawing::Point(7, 20);
			this->radioButton1->Name = L"radioButton1";
			this->radioButton1->Size = System::Drawing::Size(49, 17);
			this->radioButton1->TabIndex = 0;
			this->radioButton1->TabStop = true;
			this->radioButton1->Text = L"1617";
			this->radioButton1->UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(74, 102);
			this->textBox1->Multiline = true;
			this->textBox1->Name = L"textBox1";
			this->textBox1->ReadOnly = true;
			this->textBox1->Size = System::Drawing::Size(241, 86);
			this->textBox1->TabIndex = 4;
			this->textBox1->Text = L"В какои году Блез Паскаль изобрел устрой-ство, механически выполняющее сложение ч"
				L"исел\? ";
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(74, 194);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(75, 45);
			this->button1->TabIndex = 3;
			this->button1->Text = L"OK";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Form6_3::button1_Click_1);
			// 
			// Form6_3
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(767, 367);
			this->Controls->Add(this->groupBox1);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->button1);
			this->Name = L"Form6_3";
			this->Text = L"Form6_3";
			this->groupBox1->ResumeLayout(false);
			this->groupBox1->PerformLayout();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	

private: System::Void button1_Click_1(System::Object^ sender, System::EventArgs^ e) {
	bool f = MyDll1::Class2::Vopros3(radioButton1, radioButton2, radioButton3, radioButton4);
	if (f == true) {
		Form6_4^ f64 = gcnew Form6_4();
		f64->Show();
		this->Close();
	}
}
};
}
