Attribute VB_Name = "modSpoofer"
Option Explicit

'for retrieving the game process handle
Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Long
'get processID from hwnd returned above
Declare Function GetWindowThreadProcessId Lib "user32" (ByVal hwnd As Long, lpdwProcessId As Long) As Long
'return handle to target process
Declare Function OpenProcess Lib "kernel32" (ByVal dwDesiredAccess As Long, ByVal bInheritHandle As Long, ByVal dwProcessId As Long) As Long
'for writing game memory
Declare Function WriteProcessMemory Lib "kernel32" (ByVal hProcess As Long, ByVal lpBaseAddress As Any, ByVal lpBuffer As Any, ByVal nSize As Long, lpNumberOfBytesWritten As Long) As Long
'for reading game memory
Declare Function ReadProcessMemory Lib "kernel32" (ByVal hProcess As Long, ByVal lpBaseAddress As Any, ByVal lpBuffer As Any, ByVal nSize As Long, lpNumberOfBytesWritten As Long) As Long
'close each open handle
Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Long) As Long
'for determining OS version
Declare Function GetVersionExA Lib "kernel32" (lpVersionInformation As OSVERSIONINFO) As Integer
'User defined type for OSVERSIONINFO
    Public Type OSVERSIONINFO
       dwOSVersionInfoSize As Long
       dwMajorVersion As Long
       dwMinorVersion As Long
       dwBuildNumber As Long
       dwPlatformId As Long           '1 = Windows 95.
                                      '2 = Windows NT

       szCSDVersion As String * 128
    End Type
'Necessary flags for NT
Public Const STANDARD_RIGHTS_REQUIRED = &HF0000
Public Const SYNCHRONIZE = &H100000
Public Const PROCESS_ALL_ACCESS = (STANDARD_RIGHTS_REQUIRED Or SYNCHRONIZE Or &HFFF)


Public scHandle As Long
Public bwHandle As Long
Public wc2Handle As Long
Public wc3Handle As Long
Public d2Handle As Long

Public scColors(0 To 24) As String
Public bwColors(0 To 24) As String
Public wc2Colors(0 To 24) As String
Public Const scAddress As Long = &H19033310
Public Const bwAddress As Long = &H19033310
Public Const wc2Address As Long = &H190314E8
Public Const scReal As Long = &H190335A8
Public Const bwReal As Long = &H190335A8
Public Const wc2Real As Long = &H19031714

Public Const D2XP = 0
Public Const STAR = 1
Public Const SEXP = 2
Public Const W2BN = 3
Public Const WAR3 = 4
Public Const D2DV = 5




Public wc3Address As Long

Public Sub DoScChange()
    ' we already have the process handle, all we have to do is put the name in the box
    
    Dim Str As String ' the string that ill be sent
    Dim DefaultStr As String * 24
    Dim i As Long ' location in str
    Dim j As Long ' location in scName.text
    
    If frmMain.scName.Text = "" Then
        ReadProcessMemory scHandle, scReal, DefaultStr, 24, i
        WriteProcessMemory scHandle, scAddress, DefaultStr, 24, i
        Exit Sub
    End If
    
    If scColors(0) <> "0" And scColors(0) <> "" Then
        Str = Str & Chr(scColors(0))
    End If
    
    
    For j = 1 To Len(frmMain.scName.Text)
        Str = Str & Mid(frmMain.scName.Text, j, 1)
        
        If scColors(j) <> "0" And scColors(j) <> "" Then
            Str = Str & Chr(scColors(j))
        End If
    Next
    
    If frmMain.scAlignment.Text = "Right" Then
        Str = Chr(18) & Str
    ElseIf frmMain.scAlignment.Text = "Center" Then
        Str = Chr(19) & Str
    End If
    
    
    WriteProcessMemory scHandle, scAddress, Str, Len(Str) + 1, i
    
End Sub
Public Sub DobwChange()
    ' we already have the process handle, all we have to do is put the name in the box
    
    Dim Str As String ' the string that ill be sent
    Dim DefaultStr As String * 24
    Dim i As Long ' location in str
    Dim j As Long ' location in bwName.text
    
    If frmMain.bwName.Text = "" Then
        ReadProcessMemory bwHandle, bwReal, DefaultStr, 24, i
        WriteProcessMemory bwHandle, bwAddress, DefaultStr, 24, i
        Exit Sub
    End If
    
    If bwColors(0) <> "0" And bwColors(0) <> "" Then
        Str = Str & Chr(bwColors(0))
    End If
    
    
    For j = 1 To Len(frmMain.bwName.Text)
        Str = Str & Mid(frmMain.bwName.Text, j, 1)
        
        If bwColors(j) <> "0" And bwColors(j) <> "" Then
            Str = Str & Chr(bwColors(j))
        End If
    Next
    
    If frmMain.bwAlignment.Text = "Right" Then
        Str = Chr(18) & Str
    ElseIf frmMain.bwAlignment.Text = "Center" Then
        Str = Chr(19) & Str
    End If
    
    
    WriteProcessMemory bwHandle, bwAddress, Str, Len(Str) + 1, i
    
End Sub

Public Sub Dowc2Change()
    ' we already have the process handle, all we have to do is put the name in the box
    
    Dim Str As String ' the string that ill be sent
    Dim DefaultStr As String * 24
    Dim i As Long ' location in str
    Dim j As Long ' location in wc2Name.text
    
    If frmMain.wc2Name.Text = "" Then
        ReadProcessMemory wc2Handle, wc2Real, DefaultStr, 24, i
        WriteProcessMemory wc2Handle, wc2Address, DefaultStr, 24, i
        Exit Sub
    End If
    
    If wc2Colors(0) <> "0" And wc2Colors(0) <> "" Then
        Str = Str & Chr(wc2Colors(0))
    End If
    
    
    For j = 1 To Len(frmMain.wc2Name.Text)
        Str = Str & Mid(frmMain.wc2Name.Text, j, 1)
        
        If wc2Colors(j) <> "0" And wc2Colors(j) <> "" Then
            Str = Str & Chr(wc2Colors(j))
        End If
    Next
    
    WriteProcessMemory wc2Handle, wc2Address, Str, Len(Str) + 1, i
    
End Sub


Public Sub GetWar3Address()
    Dim i As Long
    Dim Read As Long
    Dim TestString As String * 9
    Dim StandardString As String * 9
    StandardString = Chr(0) & Chr(0) & Chr(0) & Chr(0) & Chr(&H21) & Chr(&HCB) & Chr(&HEA) & Chr(&H6C) & Chr(&H21)
    For i = &H0 To &H10000000 Step &H10000
        DoEvents
        ReadProcessMemory wc3Handle, i, TestString, 9, Read
        If TestString = StandardString Then
            wc3Address = i + &H2CC
            Exit Sub
        End If
    Next
    
    'MsgBox "Error, could not determine address of Warcraft III name; check version (newest version can be found at www.backstab.ca)", vbCritical, "Could not find address!"
    
End Sub


Public Sub Dowc3Change()
    Dim BR As Long
    Dim Buf As String * 16
    Dim RED As String
    Dim GREEN As String
    Dim BLUE As String
    
    If frmMain.wc3Name.Text = "" Then
        ReadProcessMemory wc3Handle, wc3Address + 16, Buf, 16, BR
        frmMain.wc3Name.Text = Buf
    End If
    
    If frmMain.chkUseColors.Value = 0 Then
        WriteProcessMemory wc3Handle, wc3Address, frmMain.wc3Name.Text, 16, BR
    Else
        If frmMain.txtRed.Text < 16 Then
            RED = 0 & Hex(frmMain.txtRed.Text)
        Else
            RED = Hex(frmMain.txtRed.Text)
        End If
        If frmMain.txtGreen.Text < 16 Then
            GREEN = 0 & Hex(frmMain.txtGreen.Text)
        Else
            GREEN = Hex(frmMain.txtGreen.Text)
        End If
        If frmMain.txtBlue.Text < 16 Then
            BLUE = 0 & Hex(frmMain.txtBlue.Text)
        Else
            BLUE = Hex(frmMain.txtBlue.Text)
        End If
        
        Buf = "|c00" & RED & GREEN & BLUE & frmMain.wc3Name.Text
        WriteProcessMemory wc3Handle, wc3Address, Buf, 16, BR
    End If
End Sub


