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
    Left = 72
    Top = 43
    Width = 19
    Height = 13
    Caption = 'MIN'
  end
  object Label2: TLabel
    Left = 72
    Top = 83
    Width = 21
    Height = 13
    Caption = 'MAX'
  end
  object Edit1: TEdit
    Left = 112
    Top = 40
    Width = 121
    Height = 21
    TabOrder = 0
    Text = '0'
  end
  object Edit2: TEdit
    Left = 112
    Top = 80
    Width = 121
    Height = 21
    TabOrder = 1
    Text = '6'
  end
  object Button1: TButton
    Left = 104
    Top = 144
    Width = 129
    Height = 65
    TabOrder = 2
    OnClick = Button1Click
  end
end
