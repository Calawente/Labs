#pragma once
#include <cmath>

namespace BlinovaCpp {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для Form5
	/// </summary>
	public ref class Form5 : public System::Windows::Forms::Form
	{
	public:
		Form5(void)
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
		~Form5()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::ListBox^ listBox1;
	protected:
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::TextBox^ textBox1;
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::TextBox^ textBox2;
	private: System::Windows::Forms::Label^ label4;
	private: System::Windows::Forms::Label^ label5;
	private: System::Windows::Forms::TextBox^ textBox3;
	private: System::Windows::Forms::Label^ label6;
	private: System::Windows::Forms::Label^ label7;
	private: System::Windows::Forms::Label^ label8;
	private: System::Windows::Forms::Label^ label9;
	private: System::Windows::Forms::Label^ label10;
	private: System::Windows::Forms::Label^ label11;
	private: System::Windows::Forms::TextBox^ textBox4;
	private: System::Windows::Forms::TextBox^ textBox5;
	private: System::Windows::Forms::TextBox^ textBox6;
	private: System::Windows::Forms::TextBox^ textBox7;
	private: System::Windows::Forms::TextBox^ textBox8;
	private: System::Windows::Forms::Button^ button1;
	private: System::Windows::Forms::DataGridView^ dataGridView1;

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
			this->listBox1 = (gcnew System::Windows::Forms::ListBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->textBox3 = (gcnew System::Windows::Forms::TextBox());
			this->label6 = (gcnew System::Windows::Forms::Label());
			this->label7 = (gcnew System::Windows::Forms::Label());
			this->label8 = (gcnew System::Windows::Forms::Label());
			this->label9 = (gcnew System::Windows::Forms::Label());
			this->label10 = (gcnew System::Windows::Forms::Label());
			this->label11 = (gcnew System::Windows::Forms::Label());
			this->textBox4 = (gcnew System::Windows::Forms::TextBox());
			this->textBox5 = (gcnew System::Windows::Forms::TextBox());
			this->textBox6 = (gcnew System::Windows::Forms::TextBox());
			this->textBox7 = (gcnew System::Windows::Forms::TextBox());
			this->textBox8 = (gcnew System::Windows::Forms::TextBox());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->dataGridView1 = (gcnew System::Windows::Forms::DataGridView());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->BeginInit();
			this->SuspendLayout();
			// 
			// listBox1
			// 
			this->listBox1->FormattingEnabled = true;
			this->listBox1->Location = System::Drawing::Point(326, 27);
			this->listBox1->Name = L"listBox1";
			this->listBox1->Size = System::Drawing::Size(142, 381);
			this->listBox1->TabIndex = 0;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 8.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label1->Location = System::Drawing::Point(42, 41);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(108, 13);
			this->label1->TabIndex = 1;
			this->label1->Text = L"f(x)=3cos^2(2x+1)";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(42, 78);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(56, 13);
			this->label2->TabIndex = 2;
			this->label2->Text = L"Отрезок: ";
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(105, 78);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(45, 20);
			this->textBox1->TabIndex = 3;
			this->textBox1->Text = L"-1";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(156, 78);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(18, 13);
			this->label3->TabIndex = 4;
			this->label3->Text = L"pi,";
			// 
			// textBox2
			// 
			this->textBox2->Location = System::Drawing::Point(180, 78);
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(45, 20);
			this->textBox2->TabIndex = 5;
			this->textBox2->Text = L"1";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(231, 78);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(18, 13);
			this->label4->TabIndex = 6;
			this->label4->Text = L"pi.";
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(42, 121);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(33, 13);
			this->label5->TabIndex = 7;
			this->label5->Text = L"Шаг: ";
			// 
			// textBox3
			// 
			this->textBox3->Location = System::Drawing::Point(129, 118);
			this->textBox3->Name = L"textBox3";
			this->textBox3->Size = System::Drawing::Size(45, 20);
			this->textBox3->TabIndex = 8;
			this->textBox3->Text = L"8";
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->Location = System::Drawing::Point(102, 121);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(20, 13);
			this->label6->TabIndex = 9;
			this->label6->Text = L"pi/";
			// 
			// label7
			// 
			this->label7->AutoSize = true;
			this->label7->Location = System::Drawing::Point(42, 227);
			this->label7->Name = L"label7";
			this->label7->Size = System::Drawing::Size(41, 13);
			this->label7->TabIndex = 10;
			this->label7->Text = L"Сумма";
			// 
			// label8
			// 
			this->label8->AutoSize = true;
			this->label8->Location = System::Drawing::Point(42, 202);
			this->label8->Name = L"label8";
			this->label8->Size = System::Drawing::Size(116, 13);
			this->label8->TabIndex = 11;
			this->label8->Text = L"Количество значений";
			// 
			// label9
			// 
			this->label9->AutoSize = true;
			this->label9->Location = System::Drawing::Point(42, 251);
			this->label9->Name = L"label9";
			this->label9->Size = System::Drawing::Size(81, 13);
			this->label9->TabIndex = 12;
			this->label9->Text = L"Произведение";
			// 
			// label10
			// 
			this->label10->AutoSize = true;
			this->label10->Location = System::Drawing::Point(42, 276);
			this->label10->Name = L"label10";
			this->label10->Size = System::Drawing::Size(78, 13);
			this->label10->TabIndex = 13;
			this->label10->Text = L"Минимальное";
			// 
			// label11
			// 
			this->label11->AutoSize = true;
			this->label11->Location = System::Drawing::Point(42, 300);
			this->label11->Name = L"label11";
			this->label11->Size = System::Drawing::Size(84, 13);
			this->label11->TabIndex = 14;
			this->label11->Text = L"Максимальное";
			// 
			// textBox4
			// 
			this->textBox4->Location = System::Drawing::Point(189, 199);
			this->textBox4->Name = L"textBox4";
			this->textBox4->Size = System::Drawing::Size(60, 20);
			this->textBox4->TabIndex = 15;
			// 
			// textBox5
			// 
			this->textBox5->Location = System::Drawing::Point(189, 224);
			this->textBox5->Name = L"textBox5";
			this->textBox5->Size = System::Drawing::Size(60, 20);
			this->textBox5->TabIndex = 16;
			// 
			// textBox6
			// 
			this->textBox6->Location = System::Drawing::Point(189, 248);
			this->textBox6->Name = L"textBox6";
			this->textBox6->Size = System::Drawing::Size(60, 20);
			this->textBox6->TabIndex = 17;
			// 
			// textBox7
			// 
			this->textBox7->Location = System::Drawing::Point(189, 273);
			this->textBox7->Name = L"textBox7";
			this->textBox7->Size = System::Drawing::Size(60, 20);
			this->textBox7->TabIndex = 18;
			// 
			// textBox8
			// 
			this->textBox8->Location = System::Drawing::Point(189, 299);
			this->textBox8->Name = L"textBox8";
			this->textBox8->Size = System::Drawing::Size(60, 20);
			this->textBox8->TabIndex = 19;
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(45, 353);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(217, 36);
			this->button1->TabIndex = 20;
			this->button1->Text = L"Выполнить";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Form5::button1_Click);
			// 
			// dataGridView1
			// 
			this->dataGridView1->AutoSizeColumnsMode = System::Windows::Forms::DataGridViewAutoSizeColumnsMode::AllCells;
			this->dataGridView1->AutoSizeRowsMode = System::Windows::Forms::DataGridViewAutoSizeRowsMode::AllCells;
			this->dataGridView1->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView1->ColumnHeadersVisible = false;
			this->dataGridView1->Location = System::Drawing::Point(531, 27);
			this->dataGridView1->Name = L"dataGridView1";
			this->dataGridView1->RowHeadersVisible = false;
			this->dataGridView1->Size = System::Drawing::Size(240, 381);
			this->dataGridView1->TabIndex = 21;
			// 
			// Form5
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::ControlLight;
			this->ClientSize = System::Drawing::Size(802, 420);
			this->Controls->Add(this->dataGridView1);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->textBox8);
			this->Controls->Add(this->textBox7);
			this->Controls->Add(this->textBox6);
			this->Controls->Add(this->textBox5);
			this->Controls->Add(this->textBox4);
			this->Controls->Add(this->label11);
			this->Controls->Add(this->label10);
			this->Controls->Add(this->label9);
			this->Controls->Add(this->label8);
			this->Controls->Add(this->label7);
			this->Controls->Add(this->label6);
			this->Controls->Add(this->textBox3);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->textBox2);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->listBox1);
			this->Name = L"Form5";
			this->Text = L"Form5";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {
		double omin = MyDll1::Class1::VvodD(textBox1);
		double omax = MyDll1::Class1::VvodD(textBox2);
		double shag = MyDll1::Class1::VvodD(textBox3);
		int kz = 0;
		double sum = 0, pr = 1, min = 1000, max = -1000, znach;
		listBox1->Items->Clear();
		dataGridView1->Rows->Clear();
		dataGridView1->ColumnCount = 2;
		MyDll1::Class1::Vyr5(omin, omax, shag, kz, sum, pr, min, max, listBox1, dataGridView1);
		MyDll1::Class1::Vivod(kz, textBox4);
		MyDll1::Class1::Vivod(sum, textBox5);
		MyDll1::Class1::Vivod(pr, textBox6);
		MyDll1::Class1::Vivod(min, textBox7);
		MyDll1::Class1::Vivod(max, textBox8);
	}
};
}
