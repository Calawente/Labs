unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls;

type
  TForm1 = class(TForm)
    Edit1: TEdit;
    ComboBox1: TComboBox;
    ComboBox2: TComboBox;
    ComboBox3: TComboBox;
    Button1: TButton;
    procedure Button1Click(Sender: TObject);
    procedure ComboBox1Change(Sender: TObject);
    procedure ComboBox2Change(Sender: TObject);
    procedure ComboBox3Change(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
begin
ComboBox1.ItemIndex:=Random(3);
ComboBox2.ItemIndex:=Random(3);
ComboBox3.ItemIndex:=Random(3);
Edit1.Text:=ComboBox1.Items[ComboBox1.ItemIndex]+' '+ComboBox2.Items[ComboBox2.ItemIndex]+' '+ComboBox3.Items[ComboBox3.ItemIndex];
end;

procedure TForm1.ComboBox1Change(Sender: TObject);
begin
Edit1.Text:=ComboBox1.Items[ComboBox1.ItemIndex]+' '+ComboBox2.Items[ComboBox2.ItemIndex]+' '+ComboBox3.Items[ComboBox3.ItemIndex];
end;

procedure TForm1.ComboBox2Change(Sender: TObject);
begin
Edit1.Text:=ComboBox1.Items[ComboBox1.ItemIndex]+' '+ComboBox2.Items[ComboBox2.ItemIndex]+' '+ComboBox3.Items[ComboBox3.ItemIndex];
end;

procedure TForm1.ComboBox3Change(Sender: TObject);
begin
Edit1.Text:=ComboBox1.Items[ComboBox1.ItemIndex]+' '+ComboBox2.Items[ComboBox2.ItemIndex]+' '+ComboBox3.Items[ComboBox3.ItemIndex];
end;

end.
