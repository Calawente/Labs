unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls;

type
  TForm1 = class(TForm)
    Edit1: TEdit;
    Label1: TLabel;
    Edit2: TEdit;
    Button1: TButton;
    Edit3: TEdit;
    Button2: TButton;
    Edit4: TEdit;
    Edit5: TEdit;
    Button3: TButton;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  arr:array of Integer;
  k,i,min,max,ind:Integer;
  flag:boolean;


implementation

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
begin
Edit2.Text:='';
k:=StrToInt(Edit1.Text);
SetLength(arr,k);
for i := 0 to k-1 do
  begin
    arr[i]:=Random(20);
    Edit2.Text:=Edit2.Text+IntToStr(arr[i])+', ';
  end;
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
flag:=false;
ind:=StrToInt(Edit3.Text);
for i := 0 to k-1 do
  begin
    if ind=arr[i] then
    begin
      flag:=true;
      Edit4.Text:='Индекс числа '+IntToStr(ind)+': '+IntToStr(i);
      break;
    end;
  end;
  if flag=false then
  Edit4.Text:='Совпадений нет';
end;

procedure TForm1.Button3Click(Sender: TObject);
begin
max:=arr[0];
min:=arr[0];
for i := 0 to k-1 do
  begin
    if arr[i]>max then
    max:=arr[i];
    if arr[i]<min then
    min:=arr[i];
  end;
Edit5.Text:='min = '+IntToStr(min)+', max = '+IntToStr(max);
end;

end.
