object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 299
  ClientWidth = 635
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 80
    Top = 136
    Width = 3
    Height = 13
  end
  object Label2: TLabel
    Left = 72
    Top = 168
    Width = 3
    Height = 13
  end
  object Edit1: TEdit
    Left = 56
    Top = 40
    Width = 161
    Height = 21
    TabOrder = 0
  end
  object Edit2: TEdit
    Left = 56
    Top = 67
    Width = 161
    Height = 21
    TabOrder = 1
  end
  object Button1: TButton
    Left = 248
    Top = 40
    Width = 177
    Height = 25
    Caption = #1058#1077#1082#1091#1097#1077#1077' '#1074#1088#1077#1084#1103
    TabOrder = 2
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 248
    Top = 65
    Width = 177
    Height = 25
    Caption = #1058#1077#1082#1091#1097#1072#1103' '#1076#1072#1090#1072
    TabOrder = 3
    OnClick = Button2Click
  end
  object Timer1: TTimer
    OnTimer = Timer1Timer
    Left = 592
    Top = 64
  end
end
