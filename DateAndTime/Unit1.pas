unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.ExtCtrls;

type
  TForm1 = class(TForm)
    Edit1: TEdit;
    Edit2: TEdit;
    Button1: TButton;
    Button2: TButton;
    Label1: TLabel;
    Label2: TLabel;
    Timer1: TTimer;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Timer1Timer(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  DateTime : TdateTime;
  Time: TDateTime;

implementation
const

stDay: array [1 .. 7] of string[11] = ('воскресенье',
'понедельник', 'вторник', 'среда', 'четверг', 'п€тница', 'суббота');

stMonth: array [1 .. 12] of string[8] = ('€нвар€', 'феврал€', 'марта', 'апрел€',
 'ма€', 'июн€', 'июл€', 'августа', 'сент€бр€', 'окт€бр€', 'но€бр€', 'декабр€');

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
begin
DateTime:=Time;
Edit1.Text:=TimeToStr(DateTime);
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
Edit2.Text := DateToStr(Date);
end;

procedure TForm1.FormCreate(Sender: TObject);
var
Present: TDateTime;
Year, Month, Day: Word;
begin
Present := Now;
DecodeDate(Present, Year, Month, Day);
Label2.Caption := '—егодн€ ' + IntToStr(Day) + ' ' + stMonth[Month] +
' ' + IntToStr(Year) + ' года, ' + stDay[DayOfWeek(Present)];
Timer1.Interval := 1000;
Timer1.Enabled:=true;
end;



procedure TForm1.Timer1Timer(Sender: TObject);
begin
Time:=Now();
Label1.Caption:=FormatDateTime('hh:mm:ss',Time);
end;

end.
