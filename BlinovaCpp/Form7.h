#pragma once

namespace BlinovaCpp {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для Form7
	/// </summary>
	public ref class Form7 : public System::Windows::Forms::Form
	{
	public:
		Form7(void)
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
		~Form7()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ button1;
	protected:
	private: System::Windows::Forms::TextBox^ textBox1;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::DataGridView^ dataGridView1;
	private: System::Windows::Forms::DataGridView^ dataGridView2;



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
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->dataGridView1 = (gcnew System::Windows::Forms::DataGridView());
			this->dataGridView2 = (gcnew System::Windows::Forms::DataGridView());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView2))->BeginInit();
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(41, 108);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(75, 56);
			this->button1->TabIndex = 0;
			this->button1->Text = L"Выполнить";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Form7::button1_Click);
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(41, 50);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(60, 20);
			this->textBox1->TabIndex = 1;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(38, 34);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(171, 13);
			this->label1->TabIndex = 2;
			this->label1->Text = L"Количество элементов массива";
			// 
			// dataGridView1
			// 
			this->dataGridView1->AutoSizeColumnsMode = System::Windows::Forms::DataGridViewAutoSizeColumnsMode::AllCells;
			this->dataGridView1->AutoSizeRowsMode = System::Windows::Forms::DataGridViewAutoSizeRowsMode::AllCells;
			this->dataGridView1->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView1->Location = System::Drawing::Point(266, 32);
			this->dataGridView1->Name = L"dataGridView1";
			this->dataGridView1->Size = System::Drawing::Size(487, 95);
			this->dataGridView1->TabIndex = 3;
			// 
			// dataGridView2
			// 
			this->dataGridView2->AutoSizeColumnsMode = System::Windows::Forms::DataGridViewAutoSizeColumnsMode::AllCells;
			this->dataGridView2->AutoSizeRowsMode = System::Windows::Forms::DataGridViewAutoSizeRowsMode::AllCells;
			this->dataGridView2->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView2->Location = System::Drawing::Point(266, 157);
			this->dataGridView2->Name = L"dataGridView2";
			this->dataGridView2->Size = System::Drawing::Size(487, 95);
			this->dataGridView2->TabIndex = 4;
			// 
			// Form7
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(792, 434);
			this->Controls->Add(this->dataGridView2);
			this->Controls->Add(this->dataGridView1);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->button1);
			this->Name = L"Form7";
			this->Text = L"Form7";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView2))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {
		int n = MyDll1::Class1::VvodI(textBox1);
		int* mas = new int[n];
		MyDll1::Class3::EnterMas(mas, n);
		MyDll1::Class3::OutputMas(mas, n, dataGridView1);
		double rez = MyDll1::Class3::SredA5(mas, n);
		int* rezmas = new int[n];
		int k = MyDll1::Class3::Sravn(mas, rezmas, n, rez);
		MyDll1::Class3::OutputMas(rezmas, k, dataGridView2);
		MessageBox::Show("Найденное число равно: " + Convert::ToString(rez)+ ". Количество элементов результируюшего массива равно" + Convert::ToString(k), "Результат", MessageBoxButtons::OK, MessageBoxIcon::Information);
		delete[]mas;
		delete[]rezmas;
	}

};
}
