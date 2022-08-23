unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls;

type
  TForm1 = class(TForm)
    Edit1: TEdit;
    Label1: TLabel;
    procedure Edit1Change(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  ch:Char;
  x,y:Real;
  dey:Integer;
  s:String;

implementation

{$R *.dfm}

procedure TForm1.Edit1Change(Sender: TObject);
begin
if AnsiCompareStr(Edit1.Text,'')<>0 then
begin
  ch:=Edit1.Text[Length(Edit1.Text)];
  case ch of
  '+':
  begin
    if AnsiCompareStr(Label1.Caption,'')=0 then
    begin
      s:=Edit1.Text;
      Delete(s,Length(s),1);
      x:=StrToFloat(s);
      dey:=1;
      Label1.Caption:=Edit1.Text;
      Edit1.Text:='';
    end
    else
    begin
      s:=Edit1.Text;
      Delete(s,Length(s),1);
      y:=StrToFloat(s);
      case dey of
        1: x:=x+y;
        2: x:=x-y;
        3: x:=x*y;
        4: x:=x/y;
      end;
      dey:=1;
      Label1.Caption:=FloatToStr(x)+'+';
      Edit1.Text:='';
    end;
  end;
  '-':
  begin
    if AnsiCompareStr(Label1.Caption,'')=0 then
    begin
      s:=Edit1.Text;
      Delete(s,Length(s),1);
      x:=StrToFloat(s);
      dey:=2;
      Label1.Caption:=Edit1.Text;
      Edit1.Text:='';
    end
    else
    begin
      s:=Edit1.Text;
      Delete(s,Length(s),1);
      y:=StrToFloat(s);
      case dey of
        1: x:=x+y;
        2: x:=x-y;
        3: x:=x*y;
        4: x:=x/y;
      end;
      dey:=2;
      Label1.Caption:=FloatToStr(x)+'-';
      Edit1.Text:='';
    end;
  end;
  '*':
  begin
    if AnsiCompareStr(Label1.Caption,'')=0 then
    begin
      s:=Edit1.Text;
      Delete(s,Length(s),1);
      x:=StrToFloat(s);
      dey:=3;
      Label1.Caption:=Edit1.Text;
      Edit1.Text:='';
    end
    else
    begin
      s:=Edit1.Text;
      Delete(s,Length(s),1);
      y:=StrToFloat(s);
      case dey of
        1: x:=x+y;
        2: x:=x-y;
        3: x:=x*y;
        4: x:=x/y;
      end;
      dey:=3;
      Label1.Caption:=FloatToStr(x)+'*';
      Edit1.Text:='';
    end;
  end;
  '/':
  begin
    if AnsiCompareStr(Label1.Caption,'')=0 then
    begin
      s:=Edit1.Text;
      Delete(s,Length(s),1);
      x:=StrToFloat(s);
      dey:=4;
      Label1.Caption:=Edit1.Text;
      Edit1.Text:='';
    end
    else
    begin
      s:=Edit1.Text;
      Delete(s,Length(s),1);
      y:=StrToFloat(s);
      case dey of
        1: x:=x+y;
        2: x:=x-y;
        3: x:=x*y;
        4: x:=x/y;
      end;
      dey:=4;
      Label1.Caption:=FloatToStr(x)+'/';
      Edit1.Text:='';
    end;
  end;
  '=':
  begin
    s:=Edit1.Text;
    Delete(s,Length(s),1);
    y:=StrToFloat(s);
      case dey of
        1: x:=x+y;
        2: x:=x-y;
        3: x:=x*y;
        4: x:=x/y;
      end;
    Label1.Caption:='';
    Edit1.Text:=FloatToStr(x);
  end;
  end;
end;
end;

end.
