unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.ExtCtrls, Vcl.StdCtrls;

type
  TForm1 = class(TForm)
    RadioButton1: TRadioButton;
    RadioButton2: TRadioButton;
    RadioButton3: TRadioButton;
    ComboBox1: TComboBox;
    Image1: TImage;
    procedure RadioButton1Click(Sender: TObject);
    procedure RadioButton2Click(Sender: TObject);
    procedure RadioButton3Click(Sender: TObject);
    procedure ComboBox1Change(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  flag:Integer;

implementation

{$R *.dfm}

procedure TForm1.ComboBox1Change(Sender: TObject);
begin
case flag of
1:begin
  case ComboBox1.ItemIndex of
    0:Image1.Picture.LoadFromFile('russia.bmp');
    1:Image1.Picture.LoadFromFile('germany.bmp');
    2:Image1.Picture.LoadFromFile('france.bmp');
  end;
end;
2:begin
  case ComboBox1.ItemIndex of
    0:Image1.Picture.LoadFromFile('chn.bmp');
    1:Image1.Picture.LoadFromFile('japan.bmp');
    2:Image1.Picture.LoadFromFile('india.bmp');
  end;
end;
3:begin
  case ComboBox1.ItemIndex of
    0:Image1.Picture.LoadFromFile('egy.bmp');
    1:Image1.Picture.LoadFromFile('nigeria.bmp');
    2:Image1.Picture.LoadFromFile('southafrica.bmp');
  end;
end;
end;
end;

procedure TForm1.RadioButton1Click(Sender: TObject);
begin
ComboBox1.Items.Clear;
ComboBox1.Text:='';
ComboBox1.Items.Add('Россия');
ComboBox1.Items.Add('Германия');
ComboBox1.Items.Add('Франнция');
Image1.Picture.LoadFromFile('europe.bmp');
flag:=1;
end;

procedure TForm1.RadioButton2Click(Sender: TObject);
begin
ComboBox1.Items.Clear;
ComboBox1.Text:='';
ComboBox1.Items.Add('Китай');
ComboBox1.Items.Add('Япония');
ComboBox1.Items.Add('Индия');
Image1.Picture.LoadFromFile('asia.bmp');
flag:=2;
end;

procedure TForm1.RadioButton3Click(Sender: TObject);
begin
ComboBox1.Items.Clear;
ComboBox1.Text:='';
ComboBox1.Items.Add('Египет');
ComboBox1.Items.Add('Нигерия');
ComboBox1.Items.Add('ЮАР');
Image1.Picture.LoadFromFile('africa.bmp');
flag:=3;
end;

end.
