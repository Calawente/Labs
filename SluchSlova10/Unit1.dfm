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
  object Edit1: TEdit
    Left = 40
    Top = 136
    Width = 561
    Height = 21
    TabOrder = 0
  end
  object ComboBox1: TComboBox
    Left = 80
    Top = 40
    Width = 145
    Height = 21
    TabOrder = 1
    OnChange = ComboBox1Change
    Items.Strings = (
      #1051#1086#1089#1100
      #1047#1072#1103#1094
      #1051#1080#1089#1072)
  end
  object ComboBox2: TComboBox
    Left = 240
    Top = 40
    Width = 145
    Height = 21
    TabOrder = 2
    OnChange = ComboBox2Change
    Items.Strings = (
      #1077#1089#1090
      #1073#1077#1078#1080#1090
      #1080#1076#1077#1090)
  end
  object ComboBox3: TComboBox
    Left = 400
    Top = 40
    Width = 145
    Height = 21
    TabOrder = 3
    OnChange = ComboBox3Change
    Items.Strings = (
      #1073#1099#1089#1090#1088#1086
      #1084#1077#1076#1083#1077#1085#1085#1086
      #1083#1077#1085#1080#1074#1086)
  end
  object Button1: TButton
    Left = 136
    Top = 176
    Width = 289
    Height = 73
    Caption = #1042#1099#1087#1086#1083#1085#1080#1090#1100
    TabOrder = 4
    OnClick = Button1Click
  end
end
