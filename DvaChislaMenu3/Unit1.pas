unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls;

type
  TForm1 = class(TForm)
    ComboBox1: TComboBox;
    Edit1: TEdit;
    Edit2: TEdit;
    Button1: TButton;
    Edit3: TEdit;
    procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  a,b,c : Integer;

implementation

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
begin
   a:=StrToInt(Edit1.Text);
  b:=StrToInt(Edit2.Text);
  case ComboBox1.Itemindex of
     0: c:=a+b;
     1: c:=a-b;
     2: c:=a*b;
     3: c:=a div b;
  end;
  Edit3.Text:=IntToStr(c);
end;

end.
