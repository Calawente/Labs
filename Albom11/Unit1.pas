unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.Menus, Vcl.ExtCtrls;

type
  TForm1 = class(TForm)
    Image1: TImage;
    MainMenu1: TMainMenu;
    N1: TMenuItem;
    N2: TMenuItem;
    N3: TMenuItem;
    PopupMenu1: TPopupMenu;
    N4: TMenuItem;
    N5: TMenuItem;
    procedure N2Click(Sender: TObject);
    procedure N3Click(Sender: TObject);
    procedure N4Click(Sender: TObject);
    procedure N5Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.N2Click(Sender: TObject);
begin
Image1.Picture.LoadFromFile('pustynya.bmp');
end;

procedure TForm1.N3Click(Sender: TObject);
begin
Image1.Picture.LoadFromFile('mayak.bmp');
end;

procedure TForm1.N4Click(Sender: TObject);
begin
 Image1.Picture.LoadFromFile('pustynya.bmp');
end;

procedure TForm1.N5Click(Sender: TObject);
begin
Image1.Picture.LoadFromFile('mayak.bmp');
end;

end.
