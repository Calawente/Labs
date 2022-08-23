unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls;

type
  TForm1 = class(TForm)
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
    Label9: TLabel;
    Label10: TLabel;
    Label11: TLabel;
    Label12: TLabel;
    Button1: TButton;
    Button2: TButton;
    Button3: TButton;
    Label13: TLabel;
    procedure FormCreate(Sender: TObject);
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
  flag:Boolean;
  zn1,zn2,zn3,v1,v2,v3,p:Integer;

implementation

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
begin
if zn1<>0 then
begin
  if flag then
  begin
    flag:=false;
    p:=zn1;
    if v1=1 then
    begin
      Label1.Caption:='0';
      zn1:=StrToInt(Label2.Caption);
    end;
    if v1=2 then
    begin
      Label2.Caption:='0';
      zn1:=StrToInt(Label3.Caption);
    end;
    if v1=3 then
    begin
      Label3.Caption:='0';
      zn1:=StrToInt(Label4.Caption);
    end;
    if v1=4 then
    begin
      Label4.Caption:='0';
      zn1:=5;
    end;
    v1:=v1+1;
  end
  else
  begin
    if p<zn1 then
    begin
      flag:=true;
      if v1=2 then
        Label1.Caption:=IntToStr(p);
      if v1=3 then
        Label2.Caption:=IntToStr(p);
      if v1=4 then
        Label3.Caption:=IntToStr(p);
      if v1=5 then
        Label4.Caption:=IntToStr(p);
      v1:=v1-1;
      zn1:=p;
    end;
  end;
  if (v2=1) or (v3=1) then
  begin
    Label13.Caption:='WIN';
  end;
end;
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
if zn2<>0 then
begin
  if flag then
  begin
    flag:=false;
    p:=zn2;
    if v2=1 then
    begin
      Label5.Caption:='0';
      zn2:=StrToInt(Label6.Caption);
    end;
    if v2=2 then
    begin
      Label6.Caption:='0';
      zn2:=StrToInt(Label7.Caption);
    end;
    if v2=3 then
    begin
      Label7.Caption:='0';
      zn2:=StrToInt(Label8.Caption);
    end;
    if v2=4 then
    begin
      Label8.Caption:='0';
      zn2:=5;
    end;
    v2:=v2+1;
  end
  else
  begin
    if p<zn2 then
    begin
      flag:=true;
      if v2=2 then
        Label5.Caption:=IntToStr(p);
      if v2=3 then
        Label6.Caption:=IntToStr(p);
      if v2=4 then
        Label7.Caption:=IntToStr(p);
      if v2=5 then
        Label8.Caption:=IntToStr(p);
      v2:=v2-1;
      zn2:=p;
    end;
  end;
  if (v2=1) or (v3=1) then
  begin
    Label13.Caption:='WIN';
  end;
end;
end;

procedure TForm1.Button3Click(Sender: TObject);
begin
if zn3<>0 then
begin
  if flag then
  begin
    flag:=false;
    p:=zn3;
    if v3=1 then
    begin
      Label9.Caption:='0';
      zn3:=StrToInt(Label10.Caption);
    end;
    if v3=2 then
    begin
      Label10.Caption:='0';
      zn3:=StrToInt(Label11.Caption);
    end;
    if v3=3 then
    begin
      Label11.Caption:='0';
      zn3:=StrToInt(Label12.Caption);
    end;
    if v3=4 then
    begin
      Label12.Caption:='0';
      zn3:=5;
    end;
    v3:=v3+1;
  end
  else
  begin
    if p<zn3 then
    begin
      flag:=true;
      if v3=2 then
        Label9.Caption:=IntToStr(p);
      if v3=3 then
        Label10.Caption:=IntToStr(p);
      if v3=4 then
        Label11.Caption:=IntToStr(p);
      if v3=5 then
        Label12.Caption:=IntToStr(p);
      v3:=v3-1;
      zn3:=p;
    end;
  end;
  if (v2=1) or (v3=1) then
  begin
    Label13.Caption:='WIN';
  end;
end;
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
  flag:=true;
  zn1:=1;
  zn2:=5;
  zn3:=5;
  v1:=1;
  v2:=5;
  v3:=5;
end;

end.
