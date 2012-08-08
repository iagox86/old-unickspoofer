Option Strict Off
Option Explicit On
Module modMinimize
	
	'UPGRADE_WARNING: Structure NOTIFYICONDATA may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1050"'
	Declare Function Shell_NotifyIcon Lib "shell32.dll"  Alias "Shell_NotifyIconA"(ByVal dwMessage As Integer, ByRef lpData As NOTIFYICONDATA) As Integer
	
	Public Structure NOTIFYICONDATA
		Dim cbSize As Integer
		Dim hwnd As Integer
		Dim uID As Integer
		Dim uFlags As Integer
		Dim uCallbackMessage As Integer
		Dim hIcon As Integer
		<VBFixedString(64),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=64)> Public szTip As String
	End Structure
	
	Public Const NIM_ADD As Short = &H0s
	Public Const NIM_MODIFY As Short = &H1s
	Public Const NIM_DELETE As Short = &H2s
	Public Const NIF_MESSAGE As Short = &H1s
	Public Const NIF_ICON As Short = &H2s
	Public Const NIF_TIP As Short = &H4s
	
	'Make your own constant, e.g.:
	Public Const NIF_DOALL As Boolean = NIF_MESSAGE Or NIF_ICON Or NIF_TIP
	
	Public Const WM_MOUSEMOVE As Short = &H200s
	Public Const WM_LBUTTONDBLCLK As Short = &H203s
	Public Const WM_LBUTTONDOWN As Short = &H201s
	Public Const WM_RBUTTONDOWN As Short = &H204s
	
	Public Restoring As Boolean
	
	Public Sub CreateIcon()
		Dim Tic As NOTIFYICONDATA
		Tic.cbSize = Len(Tic)
		Tic.hwnd = frmMain.DefInstance.picSystemTray.Handle.ToInt32
		Tic.uID = 1
		Tic.uFlags = NIF_DOALL
		Tic.uCallbackMessage = WM_MOUSEMOVE
		Tic.hIcon = CInt(CObj(frmMain.DefInstance.picSystemTray.Image))
		Tic.szTip = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & Chr(0)
		Shell_NotifyIcon(NIM_ADD, Tic)
	End Sub
	
	Public Sub DeleteIcon()
		Dim Tic As NOTIFYICONDATA
		Tic.cbSize = Len(Tic)
		Tic.hwnd = frmMain.DefInstance.picSystemTray.Handle.ToInt32
		Tic.uID = 1
		Shell_NotifyIcon(NIM_DELETE, Tic)
	End Sub
End Module