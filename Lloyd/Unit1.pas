unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.CheckLst;

type
  TForm1 = class(TForm)
    CheckListBox1: TCheckListBox;
    Label1: TLabel;
    ListBox1: TListBox;
    procedure CheckListBox1ClickCheck(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  i,s:Integer;

implementation

{$R *.dfm}

procedure TForm1.CheckListBox1ClickCheck(Sender: TObject);
begin
  ListBox1.Clear;
  for i := 0 to CheckListBox1.Items.Count-1 do
    if CheckListBox1.Checked[i] then
      ListBox1.Items.Add(CheckListBox1.Items[i]);
  s:=0;
  for i := 0 to ListBox1.Items.Count-1 do
    s:=s+StrToInt(ListBox1.Items[i]);
  Label1.Caption:='Сумма: '+IntToStr(s);
  if s=50 then
  begin
    Label1.Caption:='Победа!';
    CheckListBox1.Enabled:=False;
    ListBox1.Enabled:=False;
  end;
end;

end.
