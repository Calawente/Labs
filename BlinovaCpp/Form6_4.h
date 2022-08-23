#pragma once

namespace BlinovaCpp {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для Form6_4
	/// </summary>
	public ref class Form6_4 : public System::Windows::Forms::Form
	{
	public:
		Form6_4(void)
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
		~Form6_4()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ button1;
	protected:
	private: System::Windows::Forms::Button^ button2;
	private: System::Windows::Forms::DataGridView^ dataGridView1;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::TextBox^ textBox1;

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
			this->dataGridView1 = (gcnew System::Windows::Forms::DataGridView());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->BeginInit();
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(39, 43);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(139, 48);
			this->button1->TabIndex = 0;
			this->button1->Text = L"Узнать результаты";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Form6_4::button1_Click);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(39, 189);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(139, 48);
			this->button2->TabIndex = 1;
			this->button2->Text = L"Запись в файл";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &Form6_4::button2_Click);
			// 
			// dataGridView1
			// 
			this->dataGridView1->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView1->Location = System::Drawing::Point(342, 54);
			this->dataGridView1->Name = L"dataGridView1";
			this->dataGridView1->Size = System::Drawing::Size(175, 336);
			this->dataGridView1->TabIndex = 2;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 11.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label1->Location = System::Drawing::Point(251, 23);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(0, 18);
			this->label1->TabIndex = 3;
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(39, 146);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(212, 20);
			this->textBox1->TabIndex = 4;
			// 
			// Form6_4
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(613, 416);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->dataGridView1);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->button1);
			this->Name = L"Form6_4";
			this->Text = L"Form6_4";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {
		dataGridView1->Visible = true;
		label1->Text = "Вы ответили правильно на " + Convert::ToString(Math::Round(Convert::ToDouble(MyDll1::Class2::n) / 3 * 100)) + "% вопросов!";
		MessageBox::Show("Количество правильных ответов = " + Convert::ToString(MyDll1::Class2::n), "Правильные ответы", MessageBoxButtons::OK, MessageBoxIcon::Information);
		MyDll1::Class2::OutputMas(3, dataGridView1);
	}
	private: System::Void button2_Click(System::Object^ sender, System::EventArgs^ e) {
		MyDll1::Class2::ZapTxt(dataGridView1, textBox1);
	}
};
}
