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
  Menu = MainMenu1
  OldCreateOrder = False
  PopupMenu = PopupMenu1
  PixelsPerInch = 96
  TextHeight = 13
  object Image1: TImage
    Left = 8
    Top = 24
    Width = 593
    Height = 267
    Proportional = True
  end
  object MainMenu1: TMainMenu
    Left = 8
    object N1: TMenuItem
      Caption = #1052#1077#1085#1102
      object N2: TMenuItem
        Caption = #1055#1091#1089#1090#1099#1085#1103
        OnClick = N2Click
      end
      object N3: TMenuItem
        Caption = #1052#1072#1103#1082
        OnClick = N3Click
      end
    end
  end
  object PopupMenu1: TPopupMenu
    Left = 608
    Top = 160
    object N4: TMenuItem
      Caption = #1055#1091#1089#1090#1099#1085#1103
      OnClick = N4Click
    end
    object N5: TMenuItem
      Caption = #1052#1072#1103#1082
      OnClick = N5Click
    end
  end
end
