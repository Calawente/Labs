object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 361
  ClientWidth = 384
  Color = clBlack
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 280
    Top = 167
    Width = 20
    Height = 13
    Caption = 'RED'
    Color = clWhite
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWhite
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentColor = False
    ParentFont = False
  end
  object Label2: TLabel
    Left = 280
    Top = 198
    Width = 33
    Height = 13
    Caption = 'GREEN'
    Color = clWhite
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWhite
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentColor = False
    ParentFont = False
  end
  object Label3: TLabel
    Left = 280
    Top = 229
    Width = 24
    Height = 13
    Caption = 'BLUE'
    Color = clWhite
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWhite
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentColor = False
    ParentFont = False
  end
  object Button1: TButton
    Left = 8
    Top = 48
    Width = 250
    Height = 73
    Caption = #1048#1079#1084#1077#1085#1080#1090#1100' '#1092#1086#1088#1084#1091
    TabOrder = 0
    OnClick = Button1Click
  end
  object Edit1: TEdit
    Left = 8
    Top = 136
    Width = 250
    Height = 21
    TabOrder = 1
    OnChange = Edit1Change
  end
  object Button2: TButton
    Left = 264
    Top = 48
    Width = 25
    Height = 25
    Caption = '+'
    TabOrder = 2
    OnClick = Button2Click
  end
  object Button3: TButton
    Left = 264
    Top = 79
    Width = 25
    Height = 25
    Caption = '-'
    TabOrder = 3
    OnClick = Button3Click
  end
  object ScrollBar1: TScrollBar
    Left = 8
    Top = 163
    Width = 250
    Height = 17
    Max = 255
    PageSize = 0
    TabOrder = 4
    OnChange = ScrollBar1Change
  end
  object ScrollBar2: TScrollBar
    Left = 8
    Top = 194
    Width = 250
    Height = 17
    Max = 255
    PageSize = 0
    TabOrder = 5
    OnChange = ScrollBar2Change
  end
  object ScrollBar3: TScrollBar
    Left = 8
    Top = 225
    Width = 250
    Height = 17
    Max = 255
    PageSize = 0
    TabOrder = 6
    OnChange = ScrollBar3Change
  end
end
