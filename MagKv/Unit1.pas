unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls;

type
  TForm1 = class(TForm)
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Edit5: TEdit;
    Edit6: TEdit;
    Edit7: TEdit;
    Edit8: TEdit;
    Edit9: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    procedure FormCreate(Sender: TObject);
    procedure Edit1Change(Sender: TObject);
    procedure Edit2Change(Sender: TObject);
    procedure Edit3Change(Sender: TObject);
    procedure Edit4Change(Sender: TObject);
    procedure Edit5Change(Sender: TObject);
    procedure Edit6Change(Sender: TObject);
    procedure Edit7Change(Sender: TObject);
    procedure Edit8Change(Sender: TObject);
    procedure Edit9Change(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  arr:Array[0..2,0..2]of Integer;
  sum:Array[0..5]of Integer;
  i,j:Integer;
  flag:Boolean;

implementation

{$R *.dfm}

procedure TForm1.Edit1Change(Sender: TObject);
begin
if (AnsiCompareStr(Edit1.Text,'')<>0 )and(StrToInt(Edit1.Text)>0)and(StrToInt(Edit1.Text)<9) then
begin
  arr[0,0]:=StrToInt(Edit1.Text);
  sum[0] := arr[0, 0] + arr[1, 0] + arr[2, 0];
  Label1.Caption:=IntToStr(sum[0]);
  sum[3] := arr[0, 0] + arr[0, 1] + arr[0, 2];
  Label4.Caption:=IntToStr(sum[3]);
end
else
Edit1.Text:='1';
flag:=true;
for i := 0 to 5 do
  if sum[i]<>10 then
  flag:=false;
if flag then
  Label7.Caption:='WIN';
end;

procedure TForm1.Edit2Change(Sender: TObject);
begin
if (AnsiCompareStr(Edit2.Text,'')<>0 )and(StrToInt(Edit2.Text)>0)and(StrToInt(Edit2.Text)<9) then
begin
  arr[0,1]:=StrToInt(Edit2.Text);
  sum[1] := arr[0, 1] + arr[1, 1] + arr[2, 1];
  Label2.Caption:=IntToStr(sum[1]);
  sum[3] := arr[0, 0] + arr[0, 1] + arr[0, 2];
  Label4.Caption:=IntToStr(sum[3]);
end
else
Edit2.Text:='1';
flag:=true;
for i := 0 to 5 do
  if sum[i]<>10 then
  flag:=false;
if flag then
  Label7.Caption:='WIN';
end;

procedure TForm1.Edit3Change(Sender: TObject);
begin
if (AnsiCompareStr(Edit3.Text,'')<>0 )and(StrToInt(Edit3.Text)>0)and(StrToInt(Edit3.Text)<9) then
begin
  arr[0,2]:=StrToInt(Edit3.Text);
  sum[2] := arr[0, 2] + arr[1, 2] + arr[2, 2];
  Label3.Caption:=IntToStr(sum[2]);
  sum[3] := arr[0, 0] + arr[0, 1] + arr[0, 2];
  Label4.Caption:=IntToStr(sum[3]);
end
else
Edit3.Text:='1';
flag:=true;
for i := 0 to 5 do
  if sum[i]<>10 then
  flag:=false;
if flag then
  Label7.Caption:='WIN';
end;

procedure TForm1.Edit4Change(Sender: TObject);
begin
if (AnsiCompareStr(Edit4.Text,'')<>0 )and(StrToInt(Edit4.Text)>0)and(StrToInt(Edit4.Text)<9) then
begin
  arr[1,0]:=StrToInt(Edit4.Text);
  sum[0] := arr[0, 0] + arr[1, 0] + arr[2, 0];
  Label1.Caption:=IntToStr(sum[0]);
  sum[4] := arr[1, 0] + arr[1, 1] + arr[1, 2];
  Label5.Caption:=IntToStr(sum[4]);
end
else
Edit4.Text:='1';
flag:=true;
for i := 0 to 5 do
  if sum[i]<>10 then
  flag:=false;
if flag then
  Label7.Caption:='WIN';
end;

procedure TForm1.Edit5Change(Sender: TObject);
begin
if (AnsiCompareStr(Edit5.Text,'')<>0 )and(StrToInt(Edit5.Text)>0)and(StrToInt(Edit5.Text)<9) then
begin
  arr[1,1]:=StrToInt(Edit5.Text);
  sum[1] := arr[0, 1] + arr[1, 1] + arr[2, 1];
  Label2.Caption:=IntToStr(sum[1]);
  sum[4] := arr[1, 0] + arr[1, 1] + arr[1, 2];
  Label5.Caption:=IntToStr(sum[4]);
end
else
Edit5.Text:='1';
flag:=true;
for i := 0 to 5 do
  if sum[i]<>10 then
  flag:=false;
if flag then
  Label7.Caption:='WIN';
end;

procedure TForm1.Edit6Change(Sender: TObject);
begin
if (AnsiCompareStr(Edit6.Text,'')<>0 )and(StrToInt(Edit6.Text)>0)and(StrToInt(Edit6.Text)<9) then
begin
  arr[1,2]:=StrToInt(Edit6.Text);
  sum[2] := arr[0, 2] + arr[1, 2] + arr[2, 2];
  Label3.Caption:=IntToStr(sum[2]);
  sum[4] := arr[1, 0] + arr[1, 1] + arr[1, 2];
  Label5.Caption:=IntToStr(sum[4]);
end
else
Edit6.Text:='1';
flag:=true;
for i := 0 to 5 do
  if sum[i]<>10 then
  flag:=false;
if flag then
  Label7.Caption:='WIN';
end;

procedure TForm1.Edit7Change(Sender: TObject);
begin
if (AnsiCompareStr(Edit7.Text,'')<>0 )and(StrToInt(Edit7.Text)>0)and(StrToInt(Edit7.Text)<9) then
begin
  arr[2,0]:=StrToInt(Edit7.Text);
  sum[0] := arr[0, 0] + arr[1, 0] + arr[2, 0];
  Label1.Caption:=IntToStr(sum[0]);
  sum[5] := arr[2, 0] + arr[2, 1] + arr[2, 2];
  Label6.Caption:=IntToStr(sum[5]);
end
else
Edit7.Text:='1';
flag:=true;
for i := 0 to 5 do
  if sum[i]<>10 then
  flag:=false;
if flag then
  Label7.Caption:='WIN';
end;

procedure TForm1.Edit8Change(Sender: TObject);
begin
if (AnsiCompareStr(Edit8.Text,'')<>0 )and(StrToInt(Edit8.Text)>0)and(StrToInt(Edit8.Text)<9) then
begin
  arr[2,1]:=StrToInt(Edit8.Text);
  sum[1] := arr[0, 1] + arr[1, 1] + arr[2, 1];
  Label2.Caption:=IntToStr(sum[1]);
  sum[5] := arr[2, 0] + arr[2, 1] + arr[2, 2];
  Label6.Caption:=IntToStr(sum[5]);
end
else
Edit8.Text:='1';
flag:=true;
for i := 0 to 5 do
  if sum[i]<>10 then
  flag:=false;
if flag then
  Label7.Caption:='WIN';
end;

procedure TForm1.Edit9Change(Sender: TObject);
begin
if (AnsiCompareStr(Edit9.Text,'')<>0 )and(StrToInt(Edit9.Text)>0)and(StrToInt(Edit9.Text)<9) then
begin
  arr[2,2]:=StrToInt(Edit9.Text);
  sum[2] := arr[0, 2] + arr[1, 2] + arr[2, 2];
  Label3.Caption:=IntToStr(sum[2]);
  sum[5] := arr[2, 0] + arr[2, 1] + arr[2, 2];
  Label6.Caption:=IntToStr(sum[5]);
end
else
Edit9.Text:='1';
flag:=true;
for i := 0 to 5 do
  if sum[i]<>10 then
  flag:=false;
if flag then
  Label7.Caption:='WIN';
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
for i := 0 to 2 do
  for j := 0 to 2 do
    arr[i,j]:=1;
for i := 0 to 5 do
  sum[i]:=3;
end;

end.
