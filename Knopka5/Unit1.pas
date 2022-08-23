unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.ExtCtrls;

type
  TForm1 = class(TForm)
    Timer1: TTimer;
    Button1: TButton;
    procedure Button1Click(Sender: TObject);
    procedure Timer1Timer(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  x,y:Integer;

implementation

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
begin
if Timer1.Enabled=false then
begin
  Button1.Caption:='Поймай меня';
  Timer1.Enabled:=true;
end
 else
 begin
   Button1.Caption:='Продолжить';
   Timer1.Enabled:=false;
 end;
end;

procedure TForm1.Timer1Timer(Sender: TObject);
begin
 x:=1+Random(500);
 y:=1+Random(200);
 Button1.Left:=x;
 Button1.Top:=y;
end;

end.
