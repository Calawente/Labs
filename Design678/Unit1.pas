unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls;

type
  TForm1 = class(TForm)
    Button1: TButton;
    Edit1: TEdit;
    Button2: TButton;
    Button3: TButton;
    ScrollBar1: TScrollBar;
    ScrollBar2: TScrollBar;
    ScrollBar3: TScrollBar;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    procedure Edit1Change(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure ScrollBar1Change(Sender: TObject);
    procedure ScrollBar2Change(Sender: TObject);
    procedure ScrollBar3Change(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  FormRgn:HRGN;
  Flag:Boolean=True;

implementation

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
begin
if Flag=true then
begin
  FormRgn:=CreateEllipticRgn(0,0,Width,Height);
  Flag:=False;
end
else
begin
   FormRgn:=CreateRectRgn(0,0,Width,Height);
   Flag:=True;
end;
  SetWindowRgn(Handle,FormRgn,True);
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
if Button1.Font.Size<18 then
Button1.Font.Size:=Button1.Font.Size+1;
end;

procedure TForm1.Button3Click(Sender: TObject);
begin
if Button1.Font.Size>4 then
Button1.Font.Size:=Button1.Font.Size-1;
end;

procedure TForm1.Edit1Change(Sender: TObject);
begin
 Form1.Caption:=Edit1.Text;
end;



procedure TForm1.ScrollBar1Change(Sender: TObject);
begin
Form1.Color:=RGB(ScrollBar1.Position, ScrollBar2.Position, ScrollBar3.Position);
end;

procedure TForm1.ScrollBar2Change(Sender: TObject);
begin
Form1.Color:=RGB(ScrollBar1.Position, ScrollBar2.Position, ScrollBar3.Position);
end;

procedure TForm1.ScrollBar3Change(Sender: TObject);
begin
Form1.Color:=RGB(ScrollBar1.Position, ScrollBar2.Position, ScrollBar3.Position);
end;

end.
