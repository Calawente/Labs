unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Math;

type
  TForm1 = class(TForm)
    Edit1: TEdit;
    Edit2: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    Button1: TButton;
    procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  a,b:Integer;

implementation

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
begin
a:= StrToInt(Edit1.Text);
b:= StrToInt(Edit2.Text);
Button1.Caption:=IntToStr(RandomRange(a,b));
end;

end.
