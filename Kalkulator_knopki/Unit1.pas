unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls;

type
  TForm1 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Button3: TButton;
    Button4: TButton;
    Button5: TButton;
    Button6: TButton;
    Button7: TButton;
    Button8: TButton;
    Button9: TButton;
    Button10: TButton;
    Button11: TButton;
    Button12: TButton;
    Button13: TButton;
    Button14: TButton;
    Button15: TButton;
    Button16: TButton;
    Button17: TButton;
    Button18: TButton;
    Button19: TButton;
    Button20: TButton;
    Edit1: TEdit;
    Label1: TLabel;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure Button4Click(Sender: TObject);
    procedure Button5Click(Sender: TObject);
    procedure Button6Click(Sender: TObject);
    procedure Button7Click(Sender: TObject);
    procedure Button8Click(Sender: TObject);
    procedure Button9Click(Sender: TObject);
    procedure Button10Click(Sender: TObject);
    procedure Button11Click(Sender: TObject);
    procedure Button12Click(Sender: TObject);
    procedure Button18Click(Sender: TObject);
    procedure Button19Click(Sender: TObject);
    procedure Button20Click(Sender: TObject);
    procedure Button13Click(Sender: TObject);
    procedure Button14Click(Sender: TObject);
    procedure Button15Click(Sender: TObject);
    procedure Button16Click(Sender: TObject);
    procedure Button17Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  x,y:Real;
  flag:Boolean=true;
  dey:Integer;
  s:String;

implementation

{$R *.dfm}

procedure vych();
begin
case dey of
1: y:=x+y;
2: y:=y-x;
3: y:=x*y;
4: y:=y/x;
else
y:=0;
end;
end;

procedure TForm1.Button10Click(Sender: TObject);
begin
Edit1.Text:=Edit1.Text+'0';
end;

procedure TForm1.Button11Click(Sender: TObject);
begin
Edit1.Text:=Edit1.Text+',';
end;

procedure TForm1.Button12Click(Sender: TObject);
begin
Edit1.Text:=FloatToStr(StrToFloat(Edit1.Text)*(-1));
end;

procedure TForm1.Button13Click(Sender: TObject);
begin
if flag=true then
begin
  dey:=1;
  y:=StrToFloat(Edit1.Text);
  Label1.Caption:=Edit1.Text+'+';
  Edit1.Text:='';
  flag:=false;
end
else
begin
  if AnsiCompareStr(Edit1.Text,'')=0 then
  begin
    dey:=1;
    Label1.Caption:=FloatToStr(y)+'+';
  end
  else
  begin
    x:=StrToFloat(Edit1.Text);
    vych();
    dey:=1;
    Label1.Caption:=FloatToStr(y)+'+';
    Edit1.Text:='';
  end;
end;
end;

procedure TForm1.Button14Click(Sender: TObject);
begin
if flag=true then
begin
  dey:=2;
  y:=StrToFloat(Edit1.Text);
  Label1.Caption:=Edit1.Text+'-';
  Edit1.Text:='';
  flag:=false;
end
else
begin
  if AnsiCompareStr(Edit1.Text,'')=0 then
  begin
    dey:=2;
    Label1.Caption:=FloatToStr(y)+'-';
  end
  else
  begin
    x:=StrToFloat(Edit1.Text);
    vych();
    dey:=2;
    Label1.Caption:=FloatToStr(y)+'-';
    Edit1.Text:='';
  end;
end;
end;

procedure TForm1.Button15Click(Sender: TObject);
begin
if flag=true then
begin
  dey:=3;
  y:=StrToFloat(Edit1.Text);
  Label1.Caption:=Edit1.Text+'*';
  Edit1.Text:='';
  flag:=false;
end
else
begin
  if AnsiCompareStr(Edit1.Text,'')=0 then
  begin
    dey:=3;
    Label1.Caption:=FloatToStr(y)+'*';
  end
  else
  begin
    x:=StrToFloat(Edit1.Text);
    vych();
    dey:=3;
    Label1.Caption:=FloatToStr(y)+'*';
    Edit1.Text:='';
  end;
end;
end;

procedure TForm1.Button16Click(Sender: TObject);
begin
if flag=true then
begin
  dey:=4;
  y:=StrToFloat(Edit1.Text);
  Label1.Caption:=Edit1.Text+'/';
  Edit1.Text:='';
  flag:=false;
end
else
begin
  if AnsiCompareStr(Edit1.Text,'')=0 then
  begin
    dey:=4;
    Label1.Caption:=FloatToStr(y)+'/';
  end
  else
  begin
    x:=StrToFloat(Edit1.Text);
    vych();
    dey:=4;
    Label1.Caption:=FloatToStr(y)+'/';
    Edit1.Text:='';
  end;
end;
end;

procedure TForm1.Button17Click(Sender: TObject);
begin
if flag=false then
begin
  x:=StrToFloat(Edit1.Text);
  vych();
  Edit1.Text:=FloatToStr(y);
  Label1.Caption:='';
  flag:=true;
end;
end;

procedure TForm1.Button18Click(Sender: TObject);
begin
s:=Edit1.Text;
Delete(s,Length(s),1);
Edit1.Text:=s;
end;

procedure TForm1.Button19Click(Sender: TObject);
begin
flag:=true;
Edit1.Text:='';
Label1.Caption:='';
end;

procedure TForm1.Button1Click(Sender: TObject);
begin
Edit1.Text:=Edit1.Text+'1';
end;

procedure TForm1.Button20Click(Sender: TObject);
begin
Edit1.Text:='';
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
Edit1.Text:=Edit1.Text+'2';
end;

procedure TForm1.Button3Click(Sender: TObject);
begin
Edit1.Text:=Edit1.Text+'3';
end;

procedure TForm1.Button4Click(Sender: TObject);
begin
Edit1.Text:=Edit1.Text+'4';
end;

procedure TForm1.Button5Click(Sender: TObject);
begin
Edit1.Text:=Edit1.Text+'5';
end;

procedure TForm1.Button6Click(Sender: TObject);
begin
Edit1.Text:=Edit1.Text+'6';
end;

procedure TForm1.Button7Click(Sender: TObject);
begin
Edit1.Text:=Edit1.Text+'7';
end;

procedure TForm1.Button8Click(Sender: TObject);
begin
Edit1.Text:=Edit1.Text+'8';
end;

procedure TForm1.Button9Click(Sender: TObject);
begin
Edit1.Text:=Edit1.Text+'9';
end;

end.
