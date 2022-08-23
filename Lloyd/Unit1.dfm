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
    Left = 264
    Top = 212
    Width = 35
    Height = 13
    Caption = #1057#1091#1084#1084#1072':'
  end
  object CheckListBox1: TCheckListBox
    Left = 72
    Top = 48
    Width = 121
    Height = 177
    OnClickCheck = CheckListBox1ClickCheck
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -13
    Font.Name = 'Tahoma'
    Font.Style = []
    Items.Strings = (
      '25'
      '27'
      '3'
      '12'
      '6'
      '15'
      '9'
      '30'
      '21'
      '19')
    ParentFont = False
    TabOrder = 0
  end
  object ListBox1: TListBox
    Left = 264
    Top = 48
    Width = 121
    Height = 158
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -13
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 1
  end
end
