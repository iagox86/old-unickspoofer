VERSION 5.00
Object = "{248DD890-BB45-11CF-9ABC-0080C7E7B78D}#1.0#0"; "MSWINSCK.OCX"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Begin VB.Form frmMain 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Universal Namespoofer - by iago[vL]"
   ClientHeight    =   2520
   ClientLeft      =   150
   ClientTop       =   720
   ClientWidth     =   7155
   Icon            =   "frmMain.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   2520
   ScaleWidth      =   7155
   StartUpPosition =   3  'Windows Default
   Begin VB.Timer tmrUpdate 
      Interval        =   1000
      Left            =   6840
      Top             =   0
   End
   Begin MSComDlg.CommonDialog CD 
      Left            =   6840
      Top             =   720
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Timer GetProcessHandles 
      Interval        =   5000
      Left            =   6840
      Top             =   360
   End
   Begin MSComctlLib.StatusBar SB 
      Align           =   2  'Align Bottom
      Height          =   375
      Left            =   0
      TabIndex        =   1
      Top             =   2145
      Width           =   7155
      _ExtentX        =   12621
      _ExtentY        =   661
      _Version        =   393216
      BeginProperty Panels {8E3867A5-8586-11D1-B16A-00C0F0283628} 
         NumPanels       =   5
         BeginProperty Panel1 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Bevel           =   2
            Enabled         =   0   'False
            Picture         =   "frmMain.frx":0ECA
            Text            =   "Offline"
            TextSave        =   "Offline"
            Object.ToolTipText     =   "Status of Starcraft"
         EndProperty
         BeginProperty Panel2 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            AutoSize        =   2
            Bevel           =   2
            Enabled         =   0   'False
            Picture         =   "frmMain.frx":14E4
            Text            =   "Offline"
            TextSave        =   "Offline"
            Object.ToolTipText     =   "Status of Brood War"
         EndProperty
         BeginProperty Panel3 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            AutoSize        =   2
            Bevel           =   2
            Enabled         =   0   'False
            Picture         =   "frmMain.frx":1AFE
            Text            =   "Offline"
            TextSave        =   "Offline"
            Object.ToolTipText     =   "Status of Warcraft II"
         EndProperty
         BeginProperty Panel4 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            AutoSize        =   2
            Bevel           =   2
            Enabled         =   0   'False
            Picture         =   "frmMain.frx":2118
            Text            =   "Offline"
            TextSave        =   "Offline"
            Object.ToolTipText     =   "Status of Warcraft III"
         EndProperty
         BeginProperty Panel5 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Style           =   5
            TextSave        =   "2:25 PM"
         EndProperty
      EndProperty
   End
   Begin VB.Frame Frame 
      Caption         =   "Starcraft"
      Height          =   2055
      Index           =   1
      Left            =   0
      TabIndex        =   2
      Top             =   0
      Visible         =   0   'False
      Width           =   7095
      Begin VB.PictureBox picSystemTray 
         Height          =   735
         Left            =   1800
         Picture         =   "frmMain.frx":2732
         ScaleHeight     =   675
         ScaleWidth      =   675
         TabIndex        =   79
         Top             =   600
         Visible         =   0   'False
         Width           =   735
      End
      Begin VB.Frame Frame5 
         Caption         =   "Previews:"
         Height          =   1695
         Left            =   5040
         TabIndex        =   13
         Top             =   240
         Width           =   1935
         Begin RichTextLib.RichTextBox scPregame 
            Height          =   375
            Left            =   120
            TabIndex        =   14
            TabStop         =   0   'False
            ToolTipText     =   "This is a preview of what your name will look like in Pregame chat."
            Top             =   480
            Width           =   1695
            _ExtentX        =   2990
            _ExtentY        =   661
            _Version        =   393217
            BackColor       =   0
            BorderStyle     =   0
            Enabled         =   -1  'True
            ReadOnly        =   -1  'True
            TextRTF         =   $"frmMain.frx":35FC
         End
         Begin RichTextLib.RichTextBox scIngame 
            Height          =   375
            Left            =   120
            TabIndex        =   15
            TabStop         =   0   'False
            ToolTipText     =   "This is a preview of what your name will look like during the game."
            Top             =   1080
            Width           =   1695
            _ExtentX        =   2990
            _ExtentY        =   661
            _Version        =   393217
            BackColor       =   0
            BorderStyle     =   0
            Enabled         =   -1  'True
            ReadOnly        =   -1  'True
            TextRTF         =   $"frmMain.frx":367E
         End
         Begin VB.Label Label2 
            Caption         =   "In game"
            Height          =   255
            Left            =   120
            TabIndex        =   17
            Top             =   840
            Width           =   1695
         End
         Begin VB.Label Label1 
            Caption         =   "Pregame"
            Height          =   255
            Left            =   120
            TabIndex        =   16
            Top             =   240
            Width           =   1695
         End
      End
      Begin VB.Frame Frame4 
         Caption         =   "Name"
         Height          =   855
         Left            =   120
         TabIndex        =   12
         Top             =   1080
         Width           =   1935
         Begin RichTextLib.RichTextBox scName 
            Height          =   375
            Left            =   120
            TabIndex        =   0
            ToolTipText     =   "Put the name you want to use here; pregame colors will show up"
            Top             =   240
            Width           =   1695
            _ExtentX        =   2990
            _ExtentY        =   661
            _Version        =   393217
            BackColor       =   0
            BorderStyle     =   0
            MultiLine       =   0   'False
            MaxLength       =   24
            AutoVerbMenu    =   -1  'True
            OLEDragMode     =   0
            OLEDropMode     =   0
            TextRTF         =   $"frmMain.frx":3700
            BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
         End
      End
      Begin VB.Frame Frame3 
         Caption         =   "Insert Color"
         Height          =   1695
         Left            =   2160
         TabIndex        =   5
         Top             =   240
         Width           =   2775
         Begin VB.CommandButton scClearColors 
            Caption         =   "Clear Colors"
            Height          =   255
            Left            =   120
            TabIndex        =   18
            Top             =   1320
            Width           =   2535
         End
         Begin VB.CommandButton scGreen 
            Caption         =   "Red/Green"
            Height          =   255
            Left            =   1440
            TabIndex        =   11
            TabStop         =   0   'False
            Top             =   960
            Width           =   1215
         End
         Begin VB.CommandButton scRed 
            Caption         =   "White/Red"
            Height          =   255
            Left            =   1440
            TabIndex        =   10
            TabStop         =   0   'False
            Top             =   600
            Width           =   1215
         End
         Begin VB.CommandButton scGrey 
            Caption         =   "Grey"
            Height          =   255
            Left            =   1440
            TabIndex        =   9
            TabStop         =   0   'False
            Top             =   240
            Width           =   1215
         End
         Begin VB.CommandButton scWhite 
            Caption         =   "LGreen/White"
            Height          =   255
            Left            =   120
            TabIndex        =   8
            TabStop         =   0   'False
            Top             =   960
            Width           =   1215
         End
         Begin VB.CommandButton scYellow 
            Caption         =   "Normal/Yellow"
            Height          =   255
            Left            =   120
            TabIndex        =   7
            TabStop         =   0   'False
            Top             =   600
            Width           =   1215
         End
         Begin VB.CommandButton scNormal 
            Caption         =   "LBlue/Normal"
            Height          =   255
            Left            =   120
            TabIndex        =   6
            TabStop         =   0   'False
            Top             =   240
            Width           =   1215
         End
      End
      Begin VB.Frame Frame2 
         Caption         =   "Alignment"
         Height          =   735
         Left            =   120
         TabIndex        =   3
         Top             =   240
         Width           =   1935
         Begin VB.ComboBox scAlignment 
            Height          =   315
            ItemData        =   "frmMain.frx":3784
            Left            =   120
            List            =   "frmMain.frx":3793
            TabIndex        =   4
            TabStop         =   0   'False
            Text            =   "Left"
            Top             =   240
            Width           =   1695
         End
      End
   End
   Begin VB.Frame Frame 
      Caption         =   "Warcraft III"
      Height          =   2055
      Index           =   4
      Left            =   0
      TabIndex        =   53
      Top             =   0
      Visible         =   0   'False
      Width           =   7095
      Begin VB.Frame frame14 
         Height          =   855
         Left            =   4440
         TabIndex        =   75
         Top             =   1080
         Width           =   2535
         Begin VB.CheckBox chkUseColors 
            Caption         =   "Use Colors? (shorter allowed name)"
            Height          =   375
            Left            =   120
            TabIndex        =   76
            Top             =   240
            Width           =   2295
         End
      End
      Begin VB.Frame frame13 
         Caption         =   "Name"
         Height          =   855
         Left            =   4440
         TabIndex        =   74
         Top             =   240
         Width           =   2535
         Begin VB.TextBox wc3Name 
            Height          =   285
            Left            =   120
            MaxLength       =   16
            TabIndex        =   77
            Top             =   240
            Width           =   2295
         End
      End
      Begin VB.Frame fraWC3Colors 
         Caption         =   "Colors"
         Enabled         =   0   'False
         Height          =   1695
         Left            =   120
         TabIndex        =   54
         Top             =   240
         Width           =   4215
         Begin VB.Timer tmrUsage 
            Interval        =   60000
            Left            =   120
            Top             =   0
         End
         Begin VB.CommandButton cmdCheat 
            Caption         =   "Cheat..."
            Enabled         =   0   'False
            Height          =   255
            Left            =   3360
            TabIndex        =   73
            TabStop         =   0   'False
            Top             =   1320
            Width           =   735
         End
         Begin VB.CommandButton cmdBrown 
            Caption         =   "Brown"
            Enabled         =   0   'False
            Height          =   255
            Left            =   3360
            TabIndex        =   72
            TabStop         =   0   'False
            Top             =   960
            Width           =   735
         End
         Begin VB.CommandButton cmdDGreen 
            Caption         =   "DGreen"
            Enabled         =   0   'False
            Height          =   255
            Left            =   3360
            TabIndex        =   71
            TabStop         =   0   'False
            Top             =   720
            Width           =   735
         End
         Begin VB.CommandButton cmdLBlue 
            Caption         =   "LBlue"
            Enabled         =   0   'False
            Height          =   255
            Left            =   3360
            TabIndex        =   70
            TabStop         =   0   'False
            Top             =   480
            Width           =   735
         End
         Begin VB.CommandButton cmdGrey 
            Caption         =   "Grey"
            Enabled         =   0   'False
            Height          =   255
            Left            =   3360
            TabIndex        =   69
            TabStop         =   0   'False
            Top             =   240
            Width           =   735
         End
         Begin VB.CommandButton cmdWhite 
            Caption         =   "White"
            Enabled         =   0   'False
            Height          =   255
            Left            =   2640
            TabIndex        =   68
            TabStop         =   0   'False
            Top             =   1320
            Width           =   735
         End
         Begin VB.CommandButton cmdPink 
            Caption         =   "Pink"
            Enabled         =   0   'False
            Height          =   255
            Left            =   2640
            TabIndex        =   67
            TabStop         =   0   'False
            Top             =   960
            Width           =   735
         End
         Begin VB.CommandButton cmdGreen 
            Caption         =   "Green"
            Enabled         =   0   'False
            Height          =   255
            Left            =   2640
            TabIndex        =   66
            TabStop         =   0   'False
            Top             =   720
            Width           =   735
         End
         Begin VB.CommandButton cmdOrange 
            Caption         =   "Orange"
            Enabled         =   0   'False
            Height          =   255
            Left            =   2640
            TabIndex        =   65
            TabStop         =   0   'False
            Top             =   480
            Width           =   735
         End
         Begin VB.CommandButton cmdYellow 
            Caption         =   "Yellow"
            Enabled         =   0   'False
            Height          =   255
            Left            =   2640
            TabIndex        =   64
            TabStop         =   0   'False
            Top             =   240
            Width           =   735
         End
         Begin VB.CommandButton cmdBlack 
            Caption         =   "Black"
            Enabled         =   0   'False
            Height          =   255
            Left            =   1920
            TabIndex        =   63
            TabStop         =   0   'False
            Top             =   1320
            Width           =   735
         End
         Begin VB.CommandButton cmdPurple 
            Caption         =   "Purple"
            Enabled         =   0   'False
            Height          =   255
            Left            =   1920
            TabIndex        =   62
            TabStop         =   0   'False
            Top             =   960
            Width           =   735
         End
         Begin VB.CommandButton cmdTeal 
            Caption         =   "Teal"
            Enabled         =   0   'False
            Height          =   255
            Left            =   1920
            TabIndex        =   61
            TabStop         =   0   'False
            Top             =   720
            Width           =   735
         End
         Begin VB.CommandButton cmdBlue 
            Caption         =   "Blue"
            Enabled         =   0   'False
            Height          =   255
            Left            =   1920
            TabIndex        =   60
            TabStop         =   0   'False
            Top             =   480
            Width           =   735
         End
         Begin VB.CommandButton cmdRed 
            Caption         =   "Red"
            Enabled         =   0   'False
            Height          =   255
            Left            =   1920
            TabIndex        =   59
            TabStop         =   0   'False
            Top             =   240
            Width           =   735
         End
         Begin VB.TextBox txtGreen 
            Alignment       =   2  'Center
            Enabled         =   0   'False
            Height          =   285
            Left            =   720
            MaxLength       =   3
            TabIndex        =   57
            Text            =   "00"
            Top             =   480
            Width           =   495
         End
         Begin VB.TextBox txtBlue 
            Alignment       =   2  'Center
            Enabled         =   0   'False
            Height          =   285
            Left            =   1200
            MaxLength       =   3
            TabIndex        =   58
            Text            =   "00"
            Top             =   480
            Width           =   495
         End
         Begin VB.TextBox txtRed 
            Alignment       =   2  'Center
            Enabled         =   0   'False
            Height          =   285
            Left            =   240
            MaxLength       =   3
            TabIndex        =   55
            Text            =   "00"
            Top             =   480
            Width           =   495
         End
         Begin MSWinsockLib.Winsock wsUsage 
            Left            =   600
            Top             =   0
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
            Protocol        =   1
            RemoteHost      =   "iago.no-ip.com"
            RemotePort      =   666
         End
         Begin VB.Line Line1 
            X1              =   1800
            X2              =   1800
            Y1              =   120
            Y2              =   1680
         End
         Begin VB.Shape wc3Preview 
            BackColor       =   &H00000000&
            BackStyle       =   1  'Opaque
            BorderStyle     =   3  'Dot
            FillColor       =   &H00FFFFFF&
            Height          =   615
            Left            =   240
            Shape           =   4  'Rounded Rectangle
            Top             =   840
            Width           =   1455
         End
         Begin VB.Label Label8 
            Caption         =   "Color Code (R G B):"
            Height          =   255
            Left            =   240
            TabIndex        =   56
            Top             =   240
            Width           =   1575
         End
      End
   End
   Begin VB.Frame Frame 
      Caption         =   "Warcraft II"
      Height          =   2055
      Index           =   3
      Left            =   0
      TabIndex        =   38
      Top             =   0
      Visible         =   0   'False
      Width           =   7095
      Begin VB.Frame Frame12 
         Caption         =   "Previews:"
         Height          =   1695
         Left            =   5040
         TabIndex        =   48
         Top             =   240
         Width           =   1935
         Begin RichTextLib.RichTextBox wc2Pregame 
            Height          =   375
            Left            =   120
            TabIndex        =   49
            TabStop         =   0   'False
            ToolTipText     =   "This is a preview of what your name will look like in Pregame chat."
            Top             =   480
            Width           =   1695
            _ExtentX        =   2990
            _ExtentY        =   661
            _Version        =   393217
            BackColor       =   0
            BorderStyle     =   0
            Enabled         =   -1  'True
            ReadOnly        =   -1  'True
            TextRTF         =   $"frmMain.frx":37AC
         End
         Begin RichTextLib.RichTextBox wc2Ingame 
            Height          =   375
            Left            =   120
            TabIndex        =   50
            TabStop         =   0   'False
            ToolTipText     =   "This is a preview of what your name will look like during the game."
            Top             =   1080
            Width           =   1695
            _ExtentX        =   2990
            _ExtentY        =   661
            _Version        =   393217
            BackColor       =   0
            BorderStyle     =   0
            Enabled         =   -1  'True
            ReadOnly        =   -1  'True
            TextRTF         =   $"frmMain.frx":382E
         End
         Begin VB.Label Label7 
            Caption         =   "In game"
            Height          =   255
            Left            =   120
            TabIndex        =   52
            Top             =   840
            Width           =   1695
         End
         Begin VB.Label Label6 
            Caption         =   "Pregame"
            Height          =   255
            Left            =   120
            TabIndex        =   51
            Top             =   240
            Width           =   1695
         End
      End
      Begin VB.Frame Frame11 
         Caption         =   "Name"
         Height          =   855
         Left            =   120
         TabIndex        =   46
         Top             =   240
         Width           =   1935
         Begin RichTextLib.RichTextBox wc2Name 
            Height          =   375
            Left            =   120
            TabIndex        =   47
            ToolTipText     =   "Put the name you want to use here; pregame colors will show up"
            Top             =   240
            Width           =   1695
            _ExtentX        =   2990
            _ExtentY        =   661
            _Version        =   393217
            BackColor       =   0
            BorderStyle     =   0
            MultiLine       =   0   'False
            MaxLength       =   24
            AutoVerbMenu    =   -1  'True
            OLEDragMode     =   0
            OLEDropMode     =   0
            TextRTF         =   $"frmMain.frx":38B0
            BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
         End
      End
      Begin VB.Frame Frame10 
         Caption         =   "Insert Color"
         Height          =   1695
         Left            =   2160
         TabIndex        =   39
         Top             =   240
         Width           =   2775
         Begin VB.CommandButton wc2ClearColors 
            Caption         =   "Clear Colors"
            Height          =   255
            Left            =   120
            TabIndex        =   45
            TabStop         =   0   'False
            Top             =   1320
            Width           =   2535
         End
         Begin VB.CommandButton wc2Grey 
            Caption         =   "Grey"
            Height          =   255
            Left            =   1440
            TabIndex        =   44
            TabStop         =   0   'False
            Top             =   240
            Width           =   1215
         End
         Begin VB.CommandButton wc2Black 
            Caption         =   "Black"
            Height          =   255
            Left            =   1440
            TabIndex        =   43
            TabStop         =   0   'False
            Top             =   600
            Width           =   1215
         End
         Begin VB.CommandButton wc2White 
            Caption         =   "White/Yellow"
            Height          =   255
            Left            =   120
            TabIndex        =   42
            TabStop         =   0   'False
            Top             =   960
            Width           =   1215
         End
         Begin VB.CommandButton wc2Red 
            Caption         =   "Red"
            Height          =   255
            Left            =   120
            TabIndex        =   41
            TabStop         =   0   'False
            Top             =   600
            Width           =   1215
         End
         Begin VB.CommandButton wc2Normal 
            Caption         =   "Normal"
            Height          =   255
            Left            =   120
            TabIndex        =   40
            TabStop         =   0   'False
            Top             =   240
            Width           =   1215
         End
      End
   End
   Begin VB.Frame Frame 
      Caption         =   "Brood War"
      Height          =   2055
      Index           =   2
      Left            =   0
      TabIndex        =   20
      Top             =   0
      Visible         =   0   'False
      Width           =   7095
      Begin VB.Frame Frame8 
         Caption         =   "Alignment"
         Height          =   735
         Left            =   120
         TabIndex        =   36
         Top             =   240
         Width           =   1935
         Begin VB.ComboBox bwAlignment 
            Height          =   315
            ItemData        =   "frmMain.frx":3934
            Left            =   120
            List            =   "frmMain.frx":3943
            TabIndex        =   37
            TabStop         =   0   'False
            Text            =   "Left"
            Top             =   240
            Width           =   1695
         End
      End
      Begin VB.Frame Frame7 
         Caption         =   "Insert Color"
         Height          =   1695
         Left            =   2160
         TabIndex        =   28
         Top             =   240
         Width           =   2775
         Begin VB.CommandButton bwNormal 
            Caption         =   "LBlue/Normal"
            Height          =   255
            Left            =   120
            TabIndex        =   35
            TabStop         =   0   'False
            Top             =   240
            Width           =   1215
         End
         Begin VB.CommandButton bwYellow 
            Caption         =   "Normal/Yellow"
            Height          =   255
            Left            =   120
            TabIndex        =   34
            TabStop         =   0   'False
            Top             =   600
            Width           =   1215
         End
         Begin VB.CommandButton bwWhite 
            Caption         =   "LGreen/White"
            Height          =   255
            Left            =   120
            TabIndex        =   33
            TabStop         =   0   'False
            Top             =   960
            Width           =   1215
         End
         Begin VB.CommandButton bwGrey 
            Caption         =   "Grey"
            Height          =   255
            Left            =   1440
            TabIndex        =   32
            TabStop         =   0   'False
            Top             =   240
            Width           =   1215
         End
         Begin VB.CommandButton bwRed 
            Caption         =   "White/Red"
            Height          =   255
            Left            =   1440
            TabIndex        =   31
            TabStop         =   0   'False
            Top             =   600
            Width           =   1215
         End
         Begin VB.CommandButton bwGreen 
            Caption         =   "Red/Green"
            Height          =   255
            Left            =   1440
            TabIndex        =   30
            TabStop         =   0   'False
            Top             =   960
            Width           =   1215
         End
         Begin VB.CommandButton bwClearColors 
            Caption         =   "Clear Colors"
            Height          =   255
            Left            =   120
            TabIndex        =   29
            Top             =   1320
            Width           =   2535
         End
      End
      Begin VB.Frame Frame6 
         Caption         =   "Name"
         Height          =   855
         Left            =   120
         TabIndex        =   26
         Top             =   1080
         Width           =   1935
         Begin RichTextLib.RichTextBox bwName 
            Height          =   375
            Left            =   120
            TabIndex        =   27
            ToolTipText     =   "Put the name you want to use here; pregame colors will show up"
            Top             =   240
            Width           =   1695
            _ExtentX        =   2990
            _ExtentY        =   661
            _Version        =   393217
            BackColor       =   0
            BorderStyle     =   0
            MultiLine       =   0   'False
            MaxLength       =   24
            AutoVerbMenu    =   -1  'True
            OLEDragMode     =   0
            OLEDropMode     =   0
            TextRTF         =   $"frmMain.frx":395C
            BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "Previews:"
         Height          =   1695
         Left            =   5040
         TabIndex        =   21
         Top             =   240
         Width           =   1935
         Begin RichTextLib.RichTextBox bwPregame 
            Height          =   375
            Left            =   120
            TabIndex        =   22
            TabStop         =   0   'False
            ToolTipText     =   "This is a preview of what your name will look like in Pregame chat."
            Top             =   480
            Width           =   1695
            _ExtentX        =   2990
            _ExtentY        =   661
            _Version        =   393217
            BackColor       =   0
            BorderStyle     =   0
            Enabled         =   -1  'True
            ReadOnly        =   -1  'True
            TextRTF         =   $"frmMain.frx":39E0
         End
         Begin RichTextLib.RichTextBox bwIngame 
            Height          =   375
            Left            =   120
            TabIndex        =   23
            TabStop         =   0   'False
            ToolTipText     =   "This is a preview of what your name will look like during the game."
            Top             =   1080
            Width           =   1695
            _ExtentX        =   2990
            _ExtentY        =   661
            _Version        =   393217
            BackColor       =   0
            BorderStyle     =   0
            Enabled         =   -1  'True
            ReadOnly        =   -1  'True
            TextRTF         =   $"frmMain.frx":3A62
         End
         Begin VB.Label Label5 
            Caption         =   "Pregame"
            Height          =   255
            Left            =   120
            TabIndex        =   25
            Top             =   240
            Width           =   1695
         End
         Begin VB.Label Label4 
            Caption         =   "In game"
            Height          =   255
            Left            =   120
            TabIndex        =   24
            Top             =   840
            Width           =   1695
         End
      End
   End
   Begin VB.Label Label9 
      Caption         =   $"frmMain.frx":3AE4
      Height          =   1215
      Left            =   720
      TabIndex        =   78
      Top             =   960
      Width           =   5895
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      Caption         =   "To continue, please launch one of the supported games."
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   840
      TabIndex        =   19
      Top             =   0
      Width           =   5655
   End
   Begin VB.Menu mnuFile 
      Caption         =   "&File"
      Begin VB.Menu mnuFileExit 
         Caption         =   "E&xit"
      End
   End
   Begin VB.Menu mnuHelp 
      Caption         =   "&Help"
      NegotiatePosition=   3  'Right
      Begin VB.Menu mnuHelpAbout 
         Caption         =   "&About"
      End
   End
   Begin VB.Menu mnuST 
      Caption         =   "ST"
      Visible         =   0   'False
      Begin VB.Menu mnuSTRestore 
         Caption         =   "&Restore"
      End
      Begin VB.Menu mnuSTExit 
         Caption         =   "E&xit"
      End
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim SC_DGREEN As Long
Dim SC_LGREEN As Long
Dim SC_BLUE As Long
Dim SC_YELLOW As Long
Dim SC_WHITE As Long
Dim SC_RED As Long
Dim SC_GAMEGREEN As Long
Dim SC_GREY As Long

Dim WC2_PreYELLOW As Long
Dim WC2_PreRED As Long
Dim WC2_PreWHITE As Long
Dim WC2_PreGREY As Long
Dim WC2_PreBLACK As Long
Dim WC2_InYELLOW As Long
Dim WC2_InRED As Long
Dim WC2_InWHITE As Long
Dim WC2_InGREY As Long
Dim WC2_InBLACK As Long

Const wcNormal = 2
Const wcRed = 3
Const wcWhite = 4
Const wcGrey = 5
Const wcBlack = 6

Const cLBlue = 2
Const cNormal = 3
Const cLGreen = 4
Const cGrey = 5
Const cWhite = 6
Const cRed = 7

Const SC_RIGHT = 18
Const SC_CENTER = 19


Private Sub chkUseColors_Click()
    If chkUseColors.Value = 1 Then
        fraWC3Colors.Enabled = True
        wc3Name.MaxLength = 6
        If Len(wc3Name.Text) > 6 Then
            wc3Name = Left(wc3Name.Text, 6)
        End If
        
        txtRed.Enabled = True
        txtGreen.Enabled = True
        txtBlue.Enabled = True
        cmdRed.Enabled = True
        cmdBlue.Enabled = True
        cmdTeal.Enabled = True
        cmdPurple.Enabled = True
        cmdYellow.Enabled = True
        cmdOrange.Enabled = True
        cmdGreen.Enabled = True
        cmdPink.Enabled = True
        cmdGrey.Enabled = True
        cmdLBlue.Enabled = True
        cmdDGreen.Enabled = True
        cmdBrown.Enabled = True
        cmdBlack.Enabled = True
        cmdWhite.Enabled = True
        cmdCheat.Enabled = True
    Else
        fraWC3Colors.Enabled = False
        wc3Name.MaxLength = 16
        txtRed.Enabled = False
        txtGreen.Enabled = False
        txtBlue.Enabled = False
        cmdRed.Enabled = False
        cmdBlue.Enabled = False
        cmdTeal.Enabled = False
        cmdPurple.Enabled = False
        cmdYellow.Enabled = False
        cmdOrange.Enabled = False
        cmdGreen.Enabled = False
        cmdPink.Enabled = False
        cmdGrey.Enabled = False
        cmdLBlue.Enabled = False
        cmdDGreen.Enabled = False
        cmdBrown.Enabled = False
        cmdBlack.Enabled = False
        cmdWhite.Enabled = False
        cmdCheat.Enabled = False
    End If
    
End Sub

Private Sub cmdBlack_Click()
    txtRed.Text = 0
    txtGreen.Text = 0
    txtBlue.Text = 0
End Sub

Private Sub cmdBlue_Click()
    txtRed.Text = 0
    txtGreen.Text = 66
    txtBlue.Text = 248

End Sub

Private Sub cmdBrown_Click()
    txtRed.Text = 76
    txtGreen.Text = 42
    txtBlue.Text = 4
End Sub

Private Sub cmdCheat_Click()
    Dim TheColor As Long
    CD.ShowColor
    TheColor = CD.Color
    
    txtRed.Text = (CD.Color) And &HFF
    txtGreen.Text = (CD.Color / 256) And &HFF
    txtBlue.Text = ((CD.Color / 256) / 256) And &HFF
    
End Sub

Private Sub cmdDGreen_Click()
    txtRed.Text = 16
    txtGreen.Text = 98
    txtBlue.Text = 78

End Sub

Private Sub cmdGreen_Click()
    txtRed.Text = 28
    txtGreen.Text = 190
    txtBlue.Text = 0

End Sub

Private Sub cmdLBlue_Click()
    txtRed.Text = 124
    txtGreen.Text = 190
    txtBlue.Text = 236

End Sub

Private Sub cmdOrange_Click()
    txtRed.Text = 248
    txtGreen.Text = 136
    txtBlue.Text = 12

End Sub

Private Sub cmdPink_Click()
    txtRed.Text = 220
    txtGreen.Text = 90
    txtBlue.Text = 172

End Sub

Private Sub cmdPurple_Click()
    txtRed.Text = 84
    txtGreen.Text = 0
    txtBlue.Text = 124

End Sub

Private Sub cmdRed_Click()
    txtRed.Text = 248
    txtGreen.Text = 2
    txtBlue.Text = 0

End Sub

Private Sub cmdTeal_Click()
    txtRed.Text = 28
    txtGreen.Text = 226
    txtBlue.Text = 180

End Sub

Private Sub cmdWhite_Click()
    txtRed.Text = 255
    txtGreen.Text = 255
    txtBlue.Text = 255

End Sub

Private Sub cmdYellow_Click()
    txtRed.Text = 248
    txtGreen.Text = 250
    txtBlue.Text = 0

End Sub

Private Sub cmdGrey_Click()
    txtRed.Text = 148
    txtGreen.Text = 148
    txtBlue.Text = 148

End Sub

Private Sub Form_Paint()
    tmrUsage.Interval = 60000
    tmrUsage.Enabled = True
End Sub

Private Sub mnuFileExit_Click()
    End
End Sub

Private Sub mnuHelpAbout_Click()
    frmAbout.Show vbModal
End Sub

Private Sub tmrUsage_Timer()
    ' send usage report every minute
    DoUsageReport
End Sub

Private Sub txtBlue_Change()
    If Val(txtBlue.Text) > 255 Then
        txtBlue.Text = "255"
    ElseIf Val(txtBlue.Text) < 0 Then
        txtBlue.Text = "0"
    End If
    If Val(txtRed.Text) > 255 Then
        txtRed.Text = "255"
    ElseIf Val(txtRed.Text) < 0 Then
        txtRed.Text = "0"
    End If
    If Val(txtGreen.Text) > 255 Then
        txtGreen.Text = "255"
    ElseIf Val(txtGreen.Text) < 0 Then
        txtGreen.Text = "0"
    End If
    
    wc3Preview.BackColor = GetWar3Color
End Sub

Private Sub txtGreen_Change()
    If Val(txtBlue.Text) > 255 Then
        txtBlue.Text = "255"
    ElseIf Val(txtBlue.Text) < 0 Then
        txtBlue.Text = "0"
    End If
    If Val(txtRed.Text) > 255 Then
        txtRed.Text = "255"
    ElseIf Val(txtRed.Text) < 0 Then
        txtRed.Text = "0"
    End If
    If Val(txtGreen.Text) > 255 Then
        txtGreen.Text = "255"
    ElseIf Val(txtGreen.Text) < 0 Then
        txtGreen.Text = "0"
    End If
    wc3Preview.BackColor = GetWar3Color
End Sub

Private Sub txtRed_Change()
    If Val(txtBlue.Text) > 255 Then
        txtBlue.Text = "255"
    ElseIf Val(txtBlue.Text) < 0 Then
        txtBlue.Text = "0"
    End If
    If Val(txtRed.Text) > 255 Then
        txtRed.Text = "255"
    ElseIf Val(txtRed.Text) < 0 Then
        txtRed.Text = "0"
    End If
    If Val(txtGreen.Text) > 255 Then
        txtGreen.Text = "255"
    ElseIf Val(txtGreen.Text) < 0 Then
        txtGreen.Text = "0"
    End If
    wc3Preview.BackColor = GetWar3Color
End Sub

Private Sub txtRed_GotFocus()
    txtRed.SelStart = 0
    txtRed.SelLength = Len(txtRed.Text)
    txtGreen.SelStart = 0
    txtGreen.SelLength = Len(txtGreen.Text)
    txtBlue.SelStart = 0
    txtBlue.SelLength = Len(txtBlue.Text)
End Sub

Private Sub txtgreen_GotFocus()
    txtRed.SelStart = 0
    txtRed.SelLength = Len(txtRed.Text)
    txtGreen.SelStart = 0
    txtGreen.SelLength = Len(txtGreen.Text)
    txtBlue.SelStart = 0
    txtBlue.SelLength = Len(txtBlue.Text)
End Sub
Private Sub txtblue_GotFocus()
    txtRed.SelStart = 0
    txtRed.SelLength = Len(txtRed.Text)
    txtGreen.SelStart = 0
    txtGreen.SelLength = Len(txtGreen.Text)
    txtBlue.SelStart = 0
    txtBlue.SelLength = Len(txtBlue.Text)
End Sub

Private Sub txtRed_KeyPress(KeyAscii As Integer)
    If KeyAscii < &H30 Or KeyAscii > &H39 Then
        KeyAscii = 0
    End If
End Sub
Private Sub txtGreen_KeyPress(KeyAscii As Integer)
    If KeyAscii < &H30 Or KeyAscii > &H39 Then
        KeyAscii = 0
    End If
End Sub
Private Sub txtBlue_KeyPress(KeyAscii As Integer)
    If KeyAscii < &H30 Or KeyAscii > &H39 Then
        KeyAscii = 0
    End If
End Sub

Private Sub wc2ClearColors_Click()
    Dim i As Integer
    
    For i = 0 To 24
        wc2Colors(i) = "0"
    Next
    
    Dowc2Change
    wc2Name.SelStart = 0
    wc2Name.SelLength = Len(wc2Name.Text)
    wc2Name.SelColor = WC2_PreYELLOW
    wc2Name.SelLength = 0
    wc2Name.SelStart = Len(wc2Name.Text)
    wc2Name.SetFocus
End Sub
Private Sub bwClearColors_Click()
    Dim i As Integer
    
    For i = 0 To 24
        bwColors(i) = "0"
    Next
    
    DobwChange
    bwName.SelStart = 0
    bwName.SelLength = Len(bwName.Text)
    bwName.SelColor = SC_DGREEN
    bwName.SelLength = 0
    bwName.SelStart = Len(bwName.Text)
    bwName.SetFocus
End Sub


Private Sub scClearColors_Click()
    Dim i As Integer
    
    For i = 0 To 24
        scColors(i) = "0"
    Next
    
    DoScChange
    scName.SelStart = 0
    scName.SelLength = Len(scName.Text)
    scName.SelColor = SC_DGREEN
    scName.SelLength = 0
    scName.SelStart = Len(scName.Text)
    scName.SetFocus
End Sub

Private Sub Form_Load()
    GetProcessHandles_Timer
    tmrUpdate_Timer
    wc3Address = 0
    SC_DGREEN = RGB(91, 204, 52)
    SC_LGREEN = RGB(189, 252, 130)
    SC_BLUE = RGB(175, 189, 249)
    SC_YELLOW = RGB(225, 225, 74)
    SC_WHITE = RGB(255, 255, 255)
    SC_RED = RGB(252, 0, 0)
    SC_GAMEGREEN = RGB(24, 252, 34)
    SC_GREY = RGB(103, 103, 103)

    WC2_PreYELLOW = RGB(211, 195, 31)
    WC2_PreRED = RGB(255, 0, 0)
    WC2_PreWHITE = RGB(255, 251, 243)
    WC2_PreBLACK = RGB(1, 1, 1)
    WC2_PreGREY = RGB(159, 159, 159)
    WC2_InYELLOW = RGB(208, 192, 28)
    WC2_InRED = RGB(252, 0, 0)
    WC2_InWHITE = RGB(252, 248, 240)
    WC2_InBLACK = RGB(1, 1, 1)
    WC2_InGREY = RGB(156, 156, 156)

    scName.SelColor = SC_DGREEN
    bwName.SelColor = SC_DGREEN
    wc2Name.SelColor = WC2_PreYELLOW


End Sub

Private Sub GetProcessHandles_Timer()
    ' Every 5 seconds we're going to try to get the process handles for
    ' our games (War2, Starcraft, War3)
    
    scHandle = GetGameHandle("Starcraft", STAR)
    wc2Handle = GetGameHandle("Warcraft II", W2BN)
    bwHandle = GetGameHandle("Brood War", SEXP)
    wc3Handle = GetGameHandle("Warcraft III", WAR3)
    d2Handle = GetGameHandle("Diablo II", vbNullString)
    
    If wc3Address = 0 And wc3Handle <> 0 Then
        GetWar3Address
    End If
    
    If wc3Handle = 0 Then
        wc3Address = 0
    End If
    
    If ReportCount = 0 Then
        ReportCount = 1
        DoUsageReport
    End If
    
End Sub

Function GetGameHandle(WindowName As String, GameCode) As Long
    Dim Window As Long
    Dim Pid As Long
    Dim Handle As Long
    
    Window = FindWindow(vbNullString, WindowName)
    GetWindowThreadProcessId Window, Pid
    Handle = OpenProcess(PROCESS_ALL_ACCESS, False, Pid)
    
    If GameCode <> vbNullString Then
        If Handle And SB.Panels.Item(GameCode).Enabled <> True Then
            SB.Panels.Item(GameCode).Enabled = True
            SB.Panels.Item(GameCode).Text = "Online"
        ElseIf Handle = 0 And SB.Panels.Item(GameCode).Enabled <> False Then
            SB.Panels.Item(GameCode).Enabled = False
            SB.Panels.Item(GameCode).Text = "Offline"
            SB.Panels(GameCode).Bevel = sbrRaised
        End If
    End If

    GetGameHandle = Handle
End Function

Private Sub SB_PanelClick(ByVal Panel As MSComctlLib.Panel)
    Dim iIndex As Integer
    If Panel.Style <> sbrTime Then
        If Panel.Enabled Then
            For iIndex = 1 To SB.Panels.Count - 1
                If SB.Panels(iIndex).Bevel = sbrInset Then
                    SB.Panels(iIndex).Bevel = sbrRaised
                    Frame(iIndex).Visible = False
                End If
            Next
            
            Panel.Bevel = sbrInset
            Frame(Panel.Index).Visible = True
        End If
    End If
End Sub

Private Sub scAlignment_Click()
    If scAlignment.ItemData(scAlignment.ListIndex) = 0 Then
        scName.SelAlignment = 0
    ElseIf scAlignment.ItemData(scAlignment.ListIndex) = 18 Then
        scName.SelAlignment = 1
    ElseIf scAlignment.ItemData(scAlignment.ListIndex) = 19 Then
        scName.SelAlignment = 2
    End If

    DoScChange
End Sub
Private Sub bwAlignment_Click()
    If bwAlignment.ItemData(bwAlignment.ListIndex) = 0 Then
        bwName.SelAlignment = 0
    ElseIf bwAlignment.ItemData(bwAlignment.ListIndex) = 18 Then
        bwName.SelAlignment = 1
    ElseIf bwAlignment.ItemData(bwAlignment.ListIndex) = 19 Then
        bwName.SelAlignment = 2
    End If

    DobwChange
End Sub

Private Sub scGreen_Click()
    scAddColor cRed, SC_RED
End Sub
Private Sub scGrey_Click()
    scAddColor cGrey, SC_GREY
End Sub
Private Sub scName_Change()
    DoScChange
End Sub
Private Sub scPregame_GotFocus()
    scName.SetFocus
End Sub
Private Sub scIngame_GotFocus()
    scName.SetFocus
End Sub
Private Sub scRed_Click()
    scAddColor cWhite, SC_WHITE
End Sub
Private Sub scWhite_Click()
    scAddColor cLGreen, SC_LGREEN
End Sub
Private Sub scYellow_Click()
    scAddColor cNormal, SC_DGREEN
End Sub
Private Sub scNormal_Click()
    scAddColor cLBlue, SC_BLUE
End Sub
Private Sub scAddColor(scColor As Integer, rgbColor As Long)
    Dim i As Integer
    
    scName.SelLength = Len(scName.Text)
    scName.SelColor = rgbColor
    
    For i = scName.SelStart To 24
        scColors(i) = "0"
    Next
    
    scColors(scName.SelStart) = scColor
    DoScChange
    scName.SelLength = 0
    scName.SetFocus
End Sub


Private Sub wc2Name_Change()
    Dowc2Change
End Sub

Private Sub wc2Normal_Click()
    wc2AddColor wcNormal, WC2_PreYELLOW
End Sub

Private Sub wc2Pregame_GotFocus()
    wc2Name.SetFocus
End Sub
Private Sub wc2Ingame_GotFocus()
    wc2Name.SetFocus
End Sub
Private Sub wc2AddColor(wc2Color As Integer, rgbColor As Long)
    Dim i As Integer
    
    wc2Name.SelLength = Len(wc2Name.Text)
    wc2Name.SelColor = rgbColor
    
    For i = wc2Name.SelStart To 24
        wc2Colors(i) = "0"
    Next
    
    wc2Colors(wc2Name.SelStart) = wc2Color
    Dowc2Change
    wc2Name.SelLength = 0
    wc2Name.SetFocus
End Sub
Private Sub bwGreen_Click()
    bwAddColor cRed, SC_RED
End Sub
Private Sub bwGrey_Click()
    bwAddColor cGrey, SC_GREY
End Sub
Private Sub bwName_Change()
    DobwChange
End Sub
Private Sub bwPregame_GotFocus()
    bwName.SetFocus
End Sub
Private Sub bwIngame_GotFocus()
    bwName.SetFocus
End Sub
Private Sub bwRed_Click()
    bwAddColor cWhite, SC_WHITE
End Sub
Private Sub bwWhite_Click()
    bwAddColor cLGreen, SC_LGREEN
End Sub
Private Sub bwYellow_Click()
    bwAddColor cNormal, SC_DGREEN
End Sub
Private Sub bwNormal_Click()
    bwAddColor cLBlue, SC_BLUE
End Sub
Private Sub bwAddColor(bwColor As Integer, rgbColor As Long)
    Dim i As Integer
    
    bwName.SelLength = Len(bwName.Text)
    bwName.SelColor = rgbColor
    
    For i = bwName.SelStart To 24
        bwColors(i) = "0"
    Next
    
    bwColors(bwName.SelStart) = bwColor
    DobwChange
    bwName.SelLength = 0
    bwName.SetFocus
End Sub

Private Sub tmrUpdate_Timer()
    ' Starcraft
    Dim strBuffer As String * 24
    Dim BytesWritten As Long
    DoScChange
    DobwChange
    Dowc2Change
    Dowc3Change
    
    ReadProcessMemory scHandle, scAddress, strBuffer, 24, BytesWritten
    scDecode strBuffer
    
    ReadProcessMemory bwHandle, bwAddress, strBuffer, 24, BytesWritten
    bwDecode strBuffer
    
    ReadProcessMemory wc2Handle, wc2Address, strBuffer, 24, BytesWritten
    wc2Decode strBuffer
    
    
    
End Sub


Private Sub scDecode(Buf As String)
    Dim Output As String
    Dim i As Integer
    Dim ColorsGoneOver As Integer
    Dim PGColor(0 To 24) As Long ' Pregame Color
    Dim IGColor(0 To 24) As Long ' Ingame Color
    i = 1
    scIngame.Text = ""
    scPregame.Text = ""
    While i < 24 And Asc(Mid(Buf, i, 1)) <> 0
        If Asc(Mid(Buf, i, 1)) < &H20 Then
            Select Case Asc(Mid(Buf, i, 1))
            Case 1
                PGColor(i - ColorsGoneOver) = SC_DGREEN
                IGColor(i - ColorsGoneOver) = SC_BLUE
                ColorsGoneOver = ColorsGoneOver + 1
            Case 2
                PGColor(i - ColorsGoneOver) = SC_BLUE
                IGColor(i - ColorsGoneOver) = SC_BLUE
                ColorsGoneOver = ColorsGoneOver + 1
            Case 3
                PGColor(i - ColorsGoneOver) = SC_DGREEN
                IGColor(i - ColorsGoneOver) = SC_YELLOW
                ColorsGoneOver = ColorsGoneOver + 1
            Case 4
                PGColor(i - ColorsGoneOver) = SC_LGREEN
                IGColor(i - ColorsGoneOver) = SC_WHITE
                ColorsGoneOver = ColorsGoneOver + 1
            Case 5
                PGColor(i - ColorsGoneOver) = SC_GREY
                IGColor(i - ColorsGoneOver) = SC_GREY
                ColorsGoneOver = ColorsGoneOver + 1
            Case 6
                PGColor(i - ColorsGoneOver) = SC_WHITE
                IGColor(i - ColorsGoneOver) = SC_RED
                ColorsGoneOver = ColorsGoneOver + 1
            Case 7
                PGColor(i - ColorsGoneOver) = SC_RED
                IGColor(i - ColorsGoneOver) = SC_GAMEGREEN
                ColorsGoneOver = ColorsGoneOver + 1
            Case &H12
                MsgBox "The previewed name is very dangerous, it will crash as soon as game starts.  I recomment not using it!", vbCritical, "Warning!!"
            Case 18
                scIngame.SelAlignment = 1
                scPregame.SelAlignment = 1
            Case 19
                scIngame.SelAlignment = 2
                scPregame.SelAlignment = 2
            End Select
        Else
            ' it was a normal character
            scIngame.Text = scIngame.Text & Mid(Buf, i, 1)
            scPregame.Text = scPregame.Text & Mid(Buf, i, 1)
        End If
            
        i = i + 1
    Wend
    
    scIngame.SelStart = 0
    scIngame.SelLength = Len(scIngame.Text)
    scIngame.SelColor = SC_BLUE
    
    scPregame.SelStart = 0
    scPregame.SelLength = Len(scPregame.Text)
    scPregame.SelColor = SC_DGREEN
    
    
    For i = 0 To 24
        If PGColor(i) <> 0 Then
            scPregame.SelStart = i - 1
            scPregame.SelLength = Len(scIngame.Text)
            scPregame.SelColor = PGColor(i)
            
            scIngame.SelStart = i - 1
            scIngame.SelLength = Len(scIngame.Text)
            scIngame.SelColor = IGColor(i)
        End If
    Next
End Sub
    
Private Sub bwDecode(Buf As String)
    Dim Output As String
    Dim i As Integer
    Dim ColorsGoneOver As Integer
    Dim PGColor(0 To 24) As Long ' Pregame Color
    Dim IGColor(0 To 24) As Long ' Ingame Color
    i = 1
    bwIngame.Text = ""
    bwPregame.Text = ""
    While i < 24 And Asc(Mid(Buf, i, 1)) <> 0
        If Asc(Mid(Buf, i, 1)) < &H20 Then
            Select Case Asc(Mid(Buf, i, 1))
            Case 1
                PGColor(i - ColorsGoneOver) = SC_DGREEN
                IGColor(i - ColorsGoneOver) = SC_BLUE
                ColorsGoneOver = ColorsGoneOver + 1
            Case 2
                PGColor(i - ColorsGoneOver) = SC_BLUE
                IGColor(i - ColorsGoneOver) = SC_BLUE
                ColorsGoneOver = ColorsGoneOver + 1
            Case 3
                PGColor(i - ColorsGoneOver) = SC_DGREEN
                IGColor(i - ColorsGoneOver) = SC_YELLOW
                ColorsGoneOver = ColorsGoneOver + 1
            Case 4
                PGColor(i - ColorsGoneOver) = SC_LGREEN
                IGColor(i - ColorsGoneOver) = SC_WHITE
                ColorsGoneOver = ColorsGoneOver + 1
            Case 5
                PGColor(i - ColorsGoneOver) = SC_GREY
                IGColor(i - ColorsGoneOver) = SC_GREY
                ColorsGoneOver = ColorsGoneOver + 1
            Case 6
                PGColor(i - ColorsGoneOver) = SC_WHITE
                IGColor(i - ColorsGoneOver) = SC_RED
                ColorsGoneOver = ColorsGoneOver + 1
            Case 7
                PGColor(i - ColorsGoneOver) = SC_RED
                IGColor(i - ColorsGoneOver) = SC_GAMEGREEN
                ColorsGoneOver = ColorsGoneOver + 1
            Case &H12
                MsgBox "The previewed name is very dangerous, it will crash as soon as game starts.  I recomment not using it!", vbCritical, "Warning!!"
            Case 18
                bwIngame.SelAlignment = 1
                bwPregame.SelAlignment = 1
            Case 19
                bwIngame.SelAlignment = 2
                bwPregame.SelAlignment = 2
            End Select
        Else
            ' it was a normal character
            bwIngame.Text = bwIngame.Text & Mid(Buf, i, 1)
            bwPregame.Text = bwPregame.Text & Mid(Buf, i, 1)
        End If
            
        i = i + 1
    Wend
    
    bwIngame.SelStart = 0
    bwIngame.SelLength = Len(bwIngame.Text)
    bwIngame.SelColor = SC_BLUE
    
    bwPregame.SelStart = 0
    bwPregame.SelLength = Len(bwPregame.Text)
    bwPregame.SelColor = SC_DGREEN
    
    
    For i = 0 To 24
        If PGColor(i) <> 0 Then
            bwPregame.SelStart = i - 1
            bwPregame.SelLength = Len(bwIngame.Text)
            bwPregame.SelColor = PGColor(i)
            
            bwIngame.SelStart = i - 1
            bwIngame.SelLength = Len(bwIngame.Text)
            bwIngame.SelColor = IGColor(i)
        End If
    Next
End Sub
    
Private Sub wc2Decode(Buf As String)
    Dim Output As String
    Dim i As Integer
    Dim ColorsGoneOver As Integer
    Dim PGColor(0 To 24) As Long ' Pregame Color
    Dim IGColor(0 To 24) As Long ' Ingame Color
    i = 1
    wc2Ingame.Text = ""
    wc2Pregame.Text = ""
    
    While i < 24 And Asc(Mid(Buf, i, 1)) <> 0
        If Asc(Mid(Buf, i, 1)) < &H20 Then
            Select Case Asc(Mid(Buf, i, 1))
            Case 1
                PGColor(i - ColorsGoneOver) = WC2_PreYELLOW
                IGColor(i - ColorsGoneOver) = WC2_InWHITE
                ColorsGoneOver = ColorsGoneOver + 1
            Case 2
                PGColor(i - ColorsGoneOver) = WC2_PreYELLOW
                IGColor(i - ColorsGoneOver) = WC2_InWHITE
                ColorsGoneOver = ColorsGoneOver + 1
            Case 3
                PGColor(i - ColorsGoneOver) = WC2_PreRED
                IGColor(i - ColorsGoneOver) = WC2_InRED
                ColorsGoneOver = ColorsGoneOver + 1
            Case 4
                PGColor(i - ColorsGoneOver) = WC2_PreWHITE
                IGColor(i - ColorsGoneOver) = WC2_InYELLOW
                ColorsGoneOver = ColorsGoneOver + 1
            Case 5
                PGColor(i - ColorsGoneOver) = WC2_PreGREY
                IGColor(i - ColorsGoneOver) = WC2_InGREY
                ColorsGoneOver = ColorsGoneOver + 1
            Case 6
                PGColor(i - ColorsGoneOver) = WC2_PreBLACK
                IGColor(i - ColorsGoneOver) = WC2_InBLACK
                ColorsGoneOver = ColorsGoneOver + 1
            End Select
        Else
            ' it was a normal character
            wc2Ingame.Text = wc2Ingame.Text & Mid(Buf, i, 1)
            wc2Pregame.Text = wc2Pregame.Text & Mid(Buf, i, 1)
        End If
            
        i = i + 1
    Wend
    
    wc2Ingame.SelStart = 0
    wc2Ingame.SelLength = Len(wc2Ingame.Text)
    wc2Ingame.SelColor = WC2_InWHITE
    
    wc2Pregame.SelStart = 0
    wc2Pregame.SelLength = Len(wc2Pregame.Text)
    wc2Pregame.SelColor = WC2_PreYELLOW
    
    
    For i = 0 To 24
        If PGColor(i) <> 0 Then
            wc2Pregame.SelStart = i - 1
            wc2Pregame.SelLength = Len(wc2Ingame.Text)
            wc2Pregame.SelColor = PGColor(i)
            
            wc2Ingame.SelStart = i - 1
            wc2Ingame.SelLength = Len(wc2Ingame.Text)
            wc2Ingame.SelColor = IGColor(i)
        End If
    Next
End Sub

Private Sub wc2Red_Click()
    wc2AddColor wcRed, WC2_PreRED
End Sub

Private Sub wc2White_Click()
    wc2AddColor wcWhite, WC2_PreWHITE
End Sub
Private Sub wc2Black_Click()
    wc2AddColor wcBlack, WC2_PreBLACK
End Sub
Private Sub wc2Grey_Click()
    wc2AddColor wcGrey, WC2_PreGREY
End Sub

Private Function GetWar3Color() As Long
    GetWar3Color = RGB(Val(txtRed.Text), Val(txtGreen.Text), Val(txtBlue.Text))
End Function

Private Sub Form_Resize()
    If frmMain.WindowState = 1 And Restoring <> True Then
        App.TaskVisible = False
        Me.Hide
        CreateIcon
    ElseIf frmMain.WindowState = 0 Then
        Me.Show
        App.TaskVisible = True
        Restoring = False
        DeleteIcon
    End If
End Sub

Private Sub picSystemTray_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    X = X / Screen.TwipsPerPixelX
    Select Case X
        Case WM_LBUTTONDOWN
            Me.PopupMenu mnuST
        Case WM_RBUTTONDOWN
            Me.PopupMenu mnuST
        Case WM_LBUTTONDBLCLK
            Restoring = True
            App.TaskVisible = True
            Me.Show
            Me.WindowState = 0
            DeleteIcon
    End Select
End Sub

Private Sub mnuSTExit_Click()
    DeleteIcon
    Unload Me
    End
End Sub

Private Sub mnuSTRestore_Click()
    Restoring = True
    App.TaskVisible = True
    Me.Show
    Me.WindowState = 0
    DeleteIcon
End Sub
