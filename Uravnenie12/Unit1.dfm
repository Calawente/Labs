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
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 79
    Top = 58
    Width = 52
    Height = 19
    Caption = 'X^2 + '
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -16
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object Label2: TLabel
    Left = 175
    Top = 58
    Width = 31
    Height = 19
    Caption = 'X + '
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -16
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object Label3: TLabel
    Left = 255
    Top = 58
    Width = 31
    Height = 19
    Caption = ' = 0'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -16
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object Label4: TLabel
    Left = 40
    Top = 112
    Width = 36
    Height = 13
    Caption = #1054#1090#1074#1077#1090':'
  end
  object Edit1: TEdit
    Left = 32
    Top = 56
    Width = 41
    Height = 21
    TabOrder = 0
    Text = '1'
  end
  object Edit2: TEdit
    Left = 128
    Top = 56
    Width = 41
    Height = 21
    TabOrder = 1
    Text = '0'
  end
  object Edit3: TEdit
    Left = 208
    Top = 56
    Width = 41
    Height = 21
    TabOrder = 2
    Text = '-4'
  end
  object Button1: TButton
    Left = 32
    Top = 152
    Width = 241
    Height = 57
    Caption = #1042#1099#1087#1086#1083#1085#1080#1090#1100
    TabOrder = 3
    OnClick = Button1Click
  end
end
