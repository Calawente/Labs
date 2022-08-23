#pragma once

namespace BlinovaCpp {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для Form8
	/// </summary>
	public ref class Form8 : public System::Windows::Forms::Form
	{
	public:
		Form8(void)
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
		~Form8()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ button1;
	protected:
	private: System::Windows::Forms::Button^ button2;
	private: System::Windows::Forms::TextBox^ textBox1;
	private: System::Windows::Forms::DataGridView^ dataGridView1;

	private: System::Windows::Forms::TextBox^ textBox2;
	private: System::Windows::Forms::Button^ button3;
	private: System::Windows::Forms::Button^ button4;

	private:
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		System::ComponentModel::Container^ components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->dataGridView1 = (gcnew System::Windows::Forms::DataGridView());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->button3 = (gcnew System::Windows::Forms::Button());
			this->button4 = (gcnew System::Windows::Forms::Button());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->BeginInit();
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(45, 77);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(116, 50);
			this->button1->TabIndex = 0;
			this->button1->Text = L"Создать массив";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Form8::button1_Click);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(45, 199);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(116, 50);
			this->button2->TabIndex = 1;
			this->button2->Text = L"Удалить элемент";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &Form8::button2_Click);
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(45, 39);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(116, 20);
			this->textBox1->TabIndex = 2;
			// 
			// dataGridView1
			// 
			this->dataGridView1->AutoSizeColumnsMode = System::Windows::Forms::DataGridViewAutoSizeColumnsMode::AllCells;
			this->dataGridView1->AutoSizeRowsMode = System::Windows::Forms::DataGridViewAutoSizeRowsMode::AllCells;
			this->dataGridView1->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView1->Location = System::Drawing::Point(292, 54);
			this->dataGridView1->Name = L"dataGridView1";
			this->dataGridView1->Size = System::Drawing::Size(361, 82);
			this->dataGridView1->TabIndex = 3;
			// 
			// textBox2
			// 
			this->textBox2->Location = System::Drawing::Point(45, 156);
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(116, 20);
			this->textBox2->TabIndex = 5;
			// 
			// button3
			// 
			this->button3->Location = System::Drawing::Point(45, 255);
			this->button3->Name = L"button3";
			this->button3->Size = System::Drawing::Size(116, 50);
			this->button3->TabIndex = 6;
			this->button3->Text = L"Сортировка";
			this->button3->UseVisualStyleBackColor = true;
			this->button3->Click += gcnew System::EventHandler(this, &Form8::button3_Click);
			// 
			// button4
			// 
			this->button4->Location = System::Drawing::Point(45, 311);
			this->button4->Name = L"button4";
			this->button4->Size = System::Drawing::Size(116, 50);
			this->button4->TabIndex = 7;
			this->button4->Text = L"Монотонно убывающая";
			this->button4->UseVisualStyleBackColor = true;
			this->button4->Click += gcnew System::EventHandler(this, &Form8::button4_Click);
			// 
			// Form8
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(698, 407);
			this->Controls->Add(this->button4);
			this->Controls->Add(this->button3);
			this->Controls->Add(this->textBox2);
			this->Controls->Add(this->dataGridView1);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->button1);
			this->Name = L"Form8";
			this->Text = L"Form8";
			this->FormClosed += gcnew System::Windows::Forms::FormClosedEventHandler(this, &Form8::Form8_FormClosed);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}

		int* mas;
		int n;
#pragma endregion
	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {
		n = MyDll1::Class1::VvodI(textBox1);
		mas = new int[n];
		MyDll1::Class3::EnterMas(mas, n);
		MyDll1::Class3::OutputMas(mas, n, dataGridView1);

	}
	private: System::Void button2_Click(System::Object^ sender, System::EventArgs^ e) {
		n = MyDll1::Class3::UdalEl(mas, n, MyDll1::Class1::VvodI(textBox2));
		MyDll1::Class3::OutputMas(mas, n, dataGridView1);
		int* a = new int[n];
		MyDll1::Class3::CopyMas(mas, a, n);
		mas = new int[n];
		MyDll1::Class3::CopyMas(a, mas, n);
		delete[]a;
	}
	private: System::Void Form8_FormClosed(System::Object^ sender, System::Windows::Forms::FormClosedEventArgs^ e) {
		delete[] mas;
	}
	private: System::Void button3_Click(System::Object^ sender, System::EventArgs^ e) {
		MyDll1::Class3::SortMasUbyv(mas, n);
		MyDll1::Class3::OutputMas(mas, n, dataGridView1);
	}
	private: System::Void button4_Click(System::Object^ sender, System::EventArgs^ e) {
		bool flag = MyDll1::Class3::MonUbyv(mas, n);
		if (flag == true) {
			MessageBox::Show("Массив монотонно убывающий!", "Массив", MessageBoxButtons::OK, MessageBoxIcon::Information);
		}
		else {
			MessageBox::Show("Массив не является монотонно убывающим!", "Массив", MessageBoxButtons::OK, MessageBoxIcon::Information);
		}
	}
};
}
