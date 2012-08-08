Attribute VB_Name = "modMinimize"
Option Explicit

Declare Function Shell_NotifyIcon Lib "shell32.dll" Alias _
"Shell_NotifyIconA" (ByVal dwMessage As Long, lpData As _
NOTIFYICONDATA) As Long

Public Type NOTIFYICONDATA
    cbSize As Long
    hwnd As Long
    uID As Long
    uFlags As Long
    uCallbackMessage As Long
    hIcon As Long
    szTip As String * 64
End Type

Public Const NIM_ADD = &H0
Public Const NIM_MODIFY = &H1
Public Const NIM_DELETE = &H2
Public Const NIF_MESSAGE = &H1
Public Const NIF_ICON = &H2
Public Const NIF_TIP = &H4

'Make your own constant, e.g.:
Public Const NIF_DOALL = NIF_MESSAGE Or NIF_ICON Or NIF_TIP

Public Const WM_MOUSEMOVE = &H200
Public Const WM_LBUTTONDBLCLK = &H203
Public Const WM_LBUTTONDOWN = &H201
Public Const WM_RBUTTONDOWN = &H204

Public Restoring As Boolean

Public Sub CreateIcon()
    Dim Tic As NOTIFYICONDATA
    Tic.cbSize = Len(Tic)
    Tic.hwnd = frmMain.picSystemTray.hwnd
    Tic.uID = 1&
    Tic.uFlags = NIF_DOALL
    Tic.uCallbackMessage = WM_MOUSEMOVE
    Tic.hIcon = frmMain.picSystemTray.Picture
    Tic.szTip = App.Title & Chr$(0)
    Shell_NotifyIcon NIM_ADD, Tic
End Sub

Public Sub DeleteIcon()
    Dim Tic As NOTIFYICONDATA
    Tic.cbSize = Len(Tic)
    Tic.hwnd = frmMain.picSystemTray.hwnd
    Tic.uID = 1&
    Shell_NotifyIcon NIM_DELETE, Tic
End Sub



