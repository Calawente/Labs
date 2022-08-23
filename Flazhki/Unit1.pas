unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.CheckLst;

type
  TForm1 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Button3: TButton;
    Button4: TButton;
    Button5: TButton;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure Button4Click(Sender: TObject);
    procedure Button5Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  s:Boolean;
  i:Integer;
  arr:Array[1..5]of Boolean = (false,false,false,false,false);


implementation

{$R *.dfm}





procedure TForm1.Button1Click(Sender: TObject);
begin
s:=true;

if arr[2] then
begin
  arr[2]:=false;
  Label2.Caption:='-';
end
else
begin
  arr[2]:=true;
  Label2.Caption:='+';
end;

for i := 1 to 5 do
  if arr[i]=false then
    s:=false;
if s=true then
begin
  Button1.Enabled:=false;
  Button2.Enabled:=false;
  Button3.Enabled:=false;
  Button4.Enabled:=false;
  Button5.Enabled:=false;
  Label6.Caption:='WIN';
end;
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
s:=true;

if arr[1] then
begin
  arr[1]:=false;
  Label1.Caption:='-';
end
else
begin
  arr[1]:=true;
  Label1.Caption:='+';
end;

if arr[3] then
begin
  arr[3]:=false;
  Label3.Caption:='-';
end
else
begin
  arr[3]:=true;
  Label3.Caption:='+';
end;

for i := 1 to 5 do
  if arr[i]=false then
    s:=false;
if s=true then
begin
  Button1.Enabled:=false;
  Button2.Enabled:=false;
  Button3.Enabled:=false;
  Button4.Enabled:=false;
  Button5.Enabled:=false;
  Label6.Caption:='WIN';
end;
end;

procedure TForm1.Button3Click(Sender: TObject);
begin
s:=true;

if arr[2] then
begin
  arr[2]:=false;
  Label2.Caption:='-';
end
else
begin
  arr[2]:=true;
  Label2.Caption:='+';
end;

if arr[4] then
begin
  arr[4]:=false;
  Label4.Caption:='-';
end
else
begin
  arr[4]:=true;
  Label4.Caption:='+';
end;

for i := 1 to 5 do
  if arr[i]=false then
    s:=false;
if s=true then
begin
  Button1.Enabled:=false;
  Button2.Enabled:=false;
  Button3.Enabled:=false;
  Button4.Enabled:=false;
  Button5.Enabled:=false;
  Label6.Caption:='WIN';
end;
end;

procedure TForm1.Button4Click(Sender: TObject);
begin
s:=true;

if arr[3] then
begin
  arr[3]:=false;
  Label3.Caption:='-';
end
else
begin
  arr[3]:=true;
  Label3.Caption:='+';
end;

if arr[5] then
begin
  arr[5]:=false;
  Label5.Caption:='-';
end
else
begin
  arr[5]:=true;
  Label5.Caption:='+';
end;

for i := 1 to 5 do
  if arr[i]=false then
    s:=false;
if s=true then
begin
  Button1.Enabled:=false;
  Button2.Enabled:=false;
  Button3.Enabled:=false;
  Button4.Enabled:=false;
  Button5.Enabled:=false;
  Label6.Caption:='WIN';
end;
end;

procedure TForm1.Button5Click(Sender: TObject);
begin
s:=true;

if arr[4] then
begin
  arr[4]:=false;
  Label4.Caption:='-';
end
else
begin
  arr[4]:=true;
  Label4.Caption:='+';
end;

for i := 1 to 5 do
  if arr[i]=false then
    s:=false;
if s=true then
begin
  Button1.Enabled:=false;
  Button2.Enabled:=false;
  Button3.Enabled:=false;
  Button4.Enabled:=false;
  Button5.Enabled:=false;
  Label6.Caption:='WIN';
end;
end;

end.
