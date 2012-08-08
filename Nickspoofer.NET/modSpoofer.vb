Option Strict Off
Option Explicit On
Module modSpoofer
	
	'for retrieving the game process handle
	Declare Function FindWindow Lib "user32"  Alias "FindWindowA"(ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
	'get processID from hwnd returned above
	Declare Function GetWindowThreadProcessId Lib "user32" (ByVal hwnd As Integer, ByRef lpdwProcessId As Integer) As Integer
	'return handle to target process
	Declare Function OpenProcess Lib "kernel32" (ByVal dwDesiredAccess As Integer, ByVal bInheritHandle As Integer, ByVal dwProcessId As Integer) As Integer
	'for writing game memory
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1016"'
	Declare Function WriteProcessMemory Lib "kernel32" (ByVal hProcess As Integer, ByVal lpBaseAddress As Any, ByVal lpBuffer As Any, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer
	'for reading game memory
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1016"'
	Declare Function ReadProcessMemory Lib "kernel32" (ByVal hProcess As Integer, ByVal lpBaseAddress As Any, ByVal lpBuffer As Any, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer
	'close each open handle
	Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Integer) As Integer
	'for determining OS version
	'UPGRADE_WARNING: Structure OSVERSIONINFO may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1050"'
	Declare Function GetVersionExA Lib "kernel32" (ByRef lpVersionInformation As OSVERSIONINFO) As Short
	'User defined type for OSVERSIONINFO
	Public Structure OSVERSIONINFO
		Dim dwOSVersionInfoSize As Integer
		Dim dwMajorVersion As Integer
		Dim dwMinorVersion As Integer
		Dim dwBuildNumber As Integer
		Dim dwPlatformId As Integer '1 = Windows 95.
		'2 = Windows NT
		<VBFixedString(128),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=128)> Public szCSDVersion As String
	End Structure
	'Necessary flags for NT
	Public Const STANDARD_RIGHTS_REQUIRED As Integer = &HF0000
	Public Const SYNCHRONIZE As Integer = &H100000
	Public Const PROCESS_ALL_ACCESS As Boolean = (STANDARD_RIGHTS_REQUIRED Or SYNCHRONIZE Or &HFFFs)
	
	
	Public scHandle As Integer
	Public bwHandle As Integer
	Public wc2Handle As Integer
	Public wc3Handle As Integer
	Public d2Handle As Integer
	
	Public scColors(24) As String
	Public bwColors(24) As String
	Public wc2Colors(24) As String
	Public Const scAddress As Integer = &H190350A0
	Public Const bwAddress As Integer = &H190350A0
	Public Const wc2Address As Integer = &H190314E8
	Public Const scReal As Integer = &H19035338
	Public Const bwReal As Integer = &H19035338
	Public Const wc2Real As Integer = &H19031714
	
	Public Const D2XP As Short = 0
	Public Const STAR As Short = 1
	Public Const SEXP As Short = 2
	Public Const W2BN As Short = 3
	Public Const WAR3 As Short = 4
	Public Const D2DV As Short = 5
	
	
	
	
	Public wc3Address As Integer
	
	Public Sub DoScChange()
		' we already have the process handle, all we have to do is put the name in the box
		
		'UPGRADE_NOTE: Str was upgraded to Str_Renamed. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim Str_Renamed As String ' the string that ill be sent
		Dim DefaultStr As New VB6.FixedLengthString(24)
		Dim i As Integer ' location in str
		Dim j As Integer ' location in scName.text
		
		If frmMain.DefInstance.scName.Text = "" Then
			ReadProcessMemory(scHandle, scReal, DefaultStr.Value, 24, i)
			WriteProcessMemory(scHandle, scAddress, DefaultStr.Value, 24, i)
			Exit Sub
		End If
		
		If scColors(0) <> "0" And scColors(0) <> "" Then
			Str_Renamed = Str_Renamed & Chr(CInt(scColors(0)))
		End If
		
		
		For j = 1 To Len(frmMain.DefInstance.scName.Text)
			Str_Renamed = Str_Renamed & Mid(frmMain.DefInstance.scName.Text, j, 1)
			
			If scColors(j) <> "0" And scColors(j) <> "" Then
				Str_Renamed = Str_Renamed & Chr(CInt(scColors(j)))
			End If
		Next 
		
		If frmMain.DefInstance.scAlignment.Text = "Right" Then
			Str_Renamed = Chr(18) & Str_Renamed
		ElseIf frmMain.DefInstance.scAlignment.Text = "Center" Then 
			Str_Renamed = Chr(19) & Str_Renamed
		End If
		
		
		WriteProcessMemory(scHandle, scAddress, Str_Renamed, Len(Str_Renamed) + 1, i)
		
	End Sub
	Public Sub DobwChange()
		' we already have the process handle, all we have to do is put the name in the box
		
		'UPGRADE_NOTE: Str was upgraded to Str_Renamed. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim Str_Renamed As String ' the string that ill be sent
		Dim DefaultStr As New VB6.FixedLengthString(24)
		Dim i As Integer ' location in str
		Dim j As Integer ' location in bwName.text
		
		If frmMain.DefInstance.bwName.Text = "" Then
			ReadProcessMemory(bwHandle, bwReal, DefaultStr.Value, 24, i)
			WriteProcessMemory(bwHandle, bwAddress, DefaultStr.Value, 24, i)
			Exit Sub
		End If
		
		If bwColors(0) <> "0" And bwColors(0) <> "" Then
			Str_Renamed = Str_Renamed & Chr(CInt(bwColors(0)))
		End If
		
		
		For j = 1 To Len(frmMain.DefInstance.bwName.Text)
			Str_Renamed = Str_Renamed & Mid(frmMain.DefInstance.bwName.Text, j, 1)
			
			If bwColors(j) <> "0" And bwColors(j) <> "" Then
				Str_Renamed = Str_Renamed & Chr(CInt(bwColors(j)))
			End If
		Next 
		
		If frmMain.DefInstance.bwAlignment.Text = "Right" Then
			Str_Renamed = Chr(18) & Str_Renamed
		ElseIf frmMain.DefInstance.bwAlignment.Text = "Center" Then 
			Str_Renamed = Chr(19) & Str_Renamed
		End If
		
		
		WriteProcessMemory(bwHandle, bwAddress, Str_Renamed, Len(Str_Renamed) + 1, i)
		
	End Sub
	
	Public Sub Dowc2Change()
		' we already have the process handle, all we have to do is put the name in the box
		
		'UPGRADE_NOTE: Str was upgraded to Str_Renamed. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim Str_Renamed As String ' the string that ill be sent
		Dim DefaultStr As New VB6.FixedLengthString(24)
		Dim i As Integer ' location in str
		Dim j As Integer ' location in wc2Name.text
		
		If frmMain.DefInstance.wc2Name.Text = "" Then
			ReadProcessMemory(wc2Handle, wc2Real, DefaultStr.Value, 24, i)
			WriteProcessMemory(wc2Handle, wc2Address, DefaultStr.Value, 24, i)
			Exit Sub
		End If
		
		If wc2Colors(0) <> "0" And wc2Colors(0) <> "" Then
			Str_Renamed = Str_Renamed & Chr(CInt(wc2Colors(0)))
		End If
		
		
		For j = 1 To Len(frmMain.DefInstance.wc2Name.Text)
			Str_Renamed = Str_Renamed & Mid(frmMain.DefInstance.wc2Name.Text, j, 1)
			
			If wc2Colors(j) <> "0" And wc2Colors(j) <> "" Then
				Str_Renamed = Str_Renamed & Chr(CInt(wc2Colors(j)))
			End If
		Next 
		
		WriteProcessMemory(wc2Handle, wc2Address, Str_Renamed, Len(Str_Renamed) + 1, i)
		
	End Sub
	
	
	Public Sub GetWar3Address()
		Dim i As Integer
		Dim Read As Integer
		Dim TestString As New VB6.FixedLengthString(9)
		Dim StandardString As New VB6.FixedLengthString(9)
		StandardString.Value = Chr(0) & Chr(0) & Chr(0) & Chr(0) & Chr(&H21s) & Chr(&HCBs) & Chr(&HEAs) & Chr(&H6Cs) & Chr(&H21s)
		For i = &H0s To &H10000000 Step &H10000
			System.Windows.Forms.Application.DoEvents()
			ReadProcessMemory(wc3Handle, i, TestString.Value, 9, Read)
			If TestString.Value = StandardString.Value Then
				wc3Address = i + &H2CCs
				Exit Sub
			End If
		Next 
		
		'MsgBox "Error, could not determine address of Warcraft III name; check version (newest version can be found at www.backstab.ca)", vbCritical, "Could not find address!"
		
	End Sub
	
	
	Public Sub Dowc3Change()
		Dim BR As Integer
		Dim Buf As New VB6.FixedLengthString(16)
		Dim RED As String
		Dim GREEN As String
		Dim BLUE As String
		
		If frmMain.DefInstance.wc3Name.Text = "" Then
			ReadProcessMemory(wc3Handle, wc3Address + 16, Buf.Value, 16, BR)
			frmMain.DefInstance.wc3Name.Text = Buf.Value
		End If
		
		If frmMain.DefInstance.chkUseColors.CheckState = 0 Then
			WriteProcessMemory(wc3Handle, wc3Address, frmMain.DefInstance.wc3Name.Text, 16, BR)
		Else
			If CDbl(frmMain.DefInstance.txtRed.Text) < 16 Then
				RED = 0 & Hex(CInt(frmMain.DefInstance.txtRed.Text))
			Else
				RED = Hex(CInt(frmMain.DefInstance.txtRed.Text))
			End If
			If CDbl(frmMain.DefInstance.txtGreen.Text) < 16 Then
				GREEN = 0 & Hex(CInt(frmMain.DefInstance.txtGreen.Text))
			Else
				GREEN = Hex(CInt(frmMain.DefInstance.txtGreen.Text))
			End If
			If CDbl(frmMain.DefInstance.txtBlue.Text) < 16 Then
				BLUE = 0 & Hex(CInt(frmMain.DefInstance.txtBlue.Text))
			Else
				BLUE = Hex(CInt(frmMain.DefInstance.txtBlue.Text))
			End If
			
			Buf.Value = "|c00" & RED & GREEN & BLUE & frmMain.DefInstance.wc3Name.Text
			WriteProcessMemory(wc3Handle, wc3Address, Buf.Value, 16, BR)
		End If
	End Sub
End Module