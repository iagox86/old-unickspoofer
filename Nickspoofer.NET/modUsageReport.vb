Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Module modUsageReport
	
	Public ReportCount As Short
	
	Public Function FindMemoryAddress(ByRef ToFind As String, ByRef ToAdd As Integer, ByRef GameHandle As Integer) As Integer
		' Finds the specified string in memory, adds value to it, and
		' returns where it is
		' This is handy for Blizzard's dymanic alloction stuff since
		' it always seems to end up in a multiple of 0x10000
		Dim i As Integer
		Dim j As Integer
		Dim TestString As New VB6.FixedLengthString(9)
		Dim Read As Integer
		Dim bGood As Boolean
		
		For i = &H0s To &H10000000 Step &H10000
			'DoEvents
			If ReadProcessMemory(GameHandle, i, TestString.Value, 9, Read) Then
				
				bGood = True
				For j = 1 To Len(TestString.Value)
					If (Mid(ToFind, j, 1) <> "?") And (Mid(TestString.Value, j, 1) <> Mid(ToFind, j, 1)) Then
						bGood = False
						Exit For
					End If
				Next 
				If bGood = True Then
					FindMemoryAddress = i + ToAdd
					Exit Function
				End If
			End If
			
		Next 
		
	End Function
	
	Public Sub DoUsageReport()
		Dim i As Integer
		Dim bwBuffer As New VB6.FixedLengthString(13)
		Dim scBuffer As New VB6.FixedLengthString(13)
		Dim d2Buffer As New VB6.FixedLengthString(16)
		Dim lodBuffer As New VB6.FixedLengthString(16)
		Dim wc3Buffer As New VB6.FixedLengthString(26)
		Dim wc2Buffer As New VB6.FixedLengthString(16)
		
		Dim TempBuffer As String
		Dim WhatToUse As String
		Dim Read As Integer
		Dim Packet As String
		Dim RandInt As Short
		Dim RandInt2 As Short
		Dim RandInt3 As Short
		
		Dim bwRealName As New VB6.FixedLengthString(24)
		Dim wc3RealName As New VB6.FixedLengthString(16)
		Dim scRealName As New VB6.FixedLengthString(24)
		Dim wc2RealName As New VB6.FixedLengthString(24)
		
		Randomize(VB.Timer())
		
		'Brood war Report
		If bwHandle <> 0 Then
			i = FindMemoryAddress(Chr(&H0s) & Chr(&H0s) & Chr(&H0s) & Chr(&H0s) & Chr(&H2s) & Chr(&H30s) & Chr(&H33s) & Chr(&H5Fs) & Chr(&H2s), &H84s, bwHandle)
			ReadProcessMemory(bwHandle, i, bwBuffer.Value, 13, Read)
			
			WhatToUse = ""
			
			RandInt2 = Int(Rnd() * 250) + 5
			RandInt3 = Int(Rnd() * 250) + 5
			
			For i = 1 To Len(bwBuffer.Value)
				RandInt = Int(Rnd() * 250) + 5
				If (RandInt < &H30s Or RandInt > &H7As) Then
					WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
				End If
				RandInt = Int(Rnd() * 250) + 5
				If (RandInt < &H30s Or RandInt > &H7As) Then
					WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
				End If
				RandInt = Int(Rnd() * 250) + 5
				If (RandInt < &H30s Or RandInt > &H7As) Then
					WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
				End If
				WhatToUse = WhatToUse & Chr(EDoThing(Asc(Mid(bwBuffer.Value, i, 1)), RandInt2, RandInt3))
			Next 
			ReadProcessMemory(bwHandle, bwReal, bwRealName.Value, 24, Read)
			SendUsagePacket(CStr(SEXP), RandInt2, RandInt3, WhatToUse, bwRealName.Value, (frmMain.DefInstance.bwName.Text), "Starcraft")
			
			
		End If
		
		'Starcraft Report
		If scHandle <> 0 Then
			i = FindMemoryAddress(Chr(&H0s) & Chr(&H0s) & Chr(&H0s) & Chr(&H0s) & Chr(&H2s) & Chr(&H30s) & Chr(&H33s) & Chr(&H5Fs) & Chr(&H2s), &H84s, scHandle)
			ReadProcessMemory(scHandle, i, scBuffer.Value, 13, Read)
			
			WhatToUse = ""
			
			RandInt2 = Int(Rnd() * 250) + 5
			RandInt3 = Int(Rnd() * 250) + 5
			
			For i = 1 To Len(scBuffer.Value)
				RandInt = Int(Rnd() * 250) + 5
				If (RandInt < &H30s Or RandInt > &H7As) Then
					WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
				End If
				RandInt = Int(Rnd() * 250) + 5
				If (RandInt < &H30s Or RandInt > &H7As) Then
					WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
				End If
				RandInt = Int(Rnd() * 250) + 5
				If (RandInt < &H30s Or RandInt > &H7As) Then
					WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
				End If
				WhatToUse = WhatToUse & Chr(EDoThing(Asc(Mid(scBuffer.Value, i, 1)), RandInt2, RandInt3))
			Next 
			ReadProcessMemory(scHandle, scReal, scRealName.Value, 24, Read)
			SendUsagePacket(CStr(STAR), RandInt2, RandInt3, WhatToUse, scRealName.Value, (frmMain.DefInstance.scName.Text), "Starcraft")
			
		End If
		
		'Warcraft III Report
		If wc3Handle <> 0 Then '                                                                                          '6c
			i = FindMemoryAddress(Chr(0) & Chr(0) & "?" & Chr(&H0s) & Chr(&H6Cs) & Chr(&H56s) & Chr(&H6As) & Chr(&H27s) & Chr(&H6Cs), &H98s, wc3Handle)
			ReadProcessMemory(wc3Handle, i, wc3Buffer.Value, 26, Read)
			
			If i = 0 Then
				MsgBox("There was an error detecting the address of War3's data." & vbCrLf & "If you are already logged onto battle.net, then either get the newest version" & vbCrLf & "of this software from www.backstab.ca or contact iago@backstab.ca.", MsgBoxStyle.Critical, "Error!")
				MsgBox("Tell iago you're seeing something different now :P", MsgBoxStyle.SystemModal, "MOO!")
				End
			End If
			
			WhatToUse = ""
			
			RandInt2 = Int(Rnd() * 250) + 5
			RandInt3 = Int(Rnd() * 250) + 5
			
			For i = 1 To Len(wc3Buffer.Value)
				RandInt = Int(Rnd() * 250) + 5
				If (RandInt < &H30s Or RandInt > &H7As) Then
					WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
				End If
				RandInt = Int(Rnd() * 250) + 5
				If (RandInt < &H30s Or RandInt > &H7As) Then
					WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
				End If
				RandInt = Int(Rnd() * 250) + 5
				If (RandInt < &H30s Or RandInt > &H7As) Then
					WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
				End If
				WhatToUse = WhatToUse & Chr(EDoThing(Asc(Mid(wc3Buffer.Value, i, 1)), RandInt2, RandInt3))
			Next 
			ReadProcessMemory(wc3Handle, wc3Address + 16, wc3RealName.Value, 16, Read)
			SendUsagePacket(CStr(WAR3), RandInt2, RandInt3, WhatToUse, wc3RealName.Value, (frmMain.DefInstance.wc3Name.Text), "Warcraft III")
			
			
		End If
		
		'Diablo II/LoD Report
		If d2Handle <> 0 Then
			i = FindMemoryAddress(Chr(&H0s) & Chr(&H0s) & Chr(&H0s) & Chr(&H0s) & Chr(&H4Fs) & Chr(&H5As) & Chr(&HD3s) & Chr(&H43s) & Chr(&H4Fs), 0, d2Handle)
			ReadProcessMemory(d2Handle, i + &H110s, d2Buffer.Value, 16, Read)
			ReadProcessMemory(d2Handle, i + &H1C0s, lodBuffer.Value, 16, Read)
			
			WhatToUse = ""
			
			RandInt2 = Int(Rnd() * 250) + 5
			RandInt3 = Int(Rnd() * 250) + 5
			
			For i = 1 To Len(d2Buffer.Value)
				RandInt = Int(Rnd() * 250) + 5
				If (RandInt < &H30s Or RandInt > &H7As) Then
					WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
				End If
				RandInt = Int(Rnd() * 250) + 5
				If (RandInt < &H30s Or RandInt > &H7As) Then
					WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
				End If
				RandInt = Int(Rnd() * 250) + 5
				If (RandInt < &H30s Or RandInt > &H7As) Then
					WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
				End If
				WhatToUse = WhatToUse & Chr(EDoThing(Asc(Mid(d2Buffer.Value, i, 1)), RandInt2, RandInt3))
			Next 
			SendUsagePacket(CStr(D2DV), RandInt2, RandInt3, WhatToUse, "", "", "Unknown minor error")
			
			WhatToUse = ""
			For i = 1 To Len(lodBuffer.Value)
				RandInt = Int(Rnd() * 250) + 5
				If (RandInt < &H30s Or RandInt > &H7As) Then
					WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
				End If
				RandInt = Int(Rnd() * 250) + 5
				If (RandInt < &H30s Or RandInt > &H7As) Then
					WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
				End If
				RandInt = Int(Rnd() * 250) + 5
				If (RandInt < &H30s Or RandInt > &H7As) Then
					WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
				End If
				WhatToUse = WhatToUse & Chr(EDoThing(Asc(Mid(lodBuffer.Value, i, 1)), RandInt2, RandInt3))
			Next 
			SendUsagePacket(CStr(D2XP), RandInt2, RandInt3, WhatToUse, "", "", "Unknown minor error")
			
			
		End If
		
		If wc2Handle <> 0 Then
			i = FindMemoryAddress(Chr(&H0s) & Chr(&H0s) & Chr(&H0s) & Chr(&H0s) & Chr(&H2Fs) & Chr(&HAs) & Chr(&HA3s) & Chr(&HAs) & Chr(&H2Fs), &H8Cs, wc2Handle)
			ReadProcessMemory(wc2Handle, i, wc2Buffer.Value, 16, Read)
			
			WhatToUse = ""
			
			RandInt2 = Int(Rnd() * 250) + 5
			RandInt3 = Int(Rnd() * 250) + 5
			
			For i = 1 To Len(wc2Buffer.Value)
				RandInt = Int(Rnd() * 250) + 5
				If (RandInt < &H30s Or RandInt > &H7As) Then
					WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
				End If
				RandInt = Int(Rnd() * 250) + 5
				If (RandInt < &H30s Or RandInt > &H7As) Then
					WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
				End If
				RandInt = Int(Rnd() * 250) + 5
				If (RandInt < &H30s Or RandInt > &H7As) Then
					WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
				End If
				WhatToUse = WhatToUse & Chr(EDoThing(Asc(Mid(wc2Buffer.Value, i, 1)), RandInt2, RandInt3))
			Next 
			ReadProcessMemory(wc2Handle, wc2Real, wc2RealName.Value, 24, Read)
			SendUsagePacket(CStr(W2BN), RandInt2, RandInt3, WhatToUse, wc2RealName.Value, (frmMain.DefInstance.wc2Name.Text), "War2 BNE")
			
		End If
		
	End Sub
	
	
	Public Sub SendUsagePacket(ByRef code As String, ByRef len1 As Short, ByRef len2 As Short, ByRef code2 As String, ByRef Buf1 As String, ByRef Buf2 As String, ByRef Buf3 As String)
		Dim Packet As String
		' FF xx yy zz
		' where xx is the code, yy is the first xor, and zz
		' is the second xor
		Randomize(VB.Timer())
		On Error Resume Next
		
		Packet = Chr(&HFFs)
		Packet = Packet & Chr(CInt(code))
		Packet = Packet & Chr(len1)
		Packet = Packet & Chr(len2)
		Packet = Packet & code2 & Chr(1) & Chr(1) & Chr(1)
		Packet = Packet & Buf1 & Chr(1) & Chr(1) & Chr(1)
		Packet = Packet & Buf2 & Chr(1) & Chr(1) & Chr(1)
		Packet = Packet & Buf3 & Chr(1) & Chr(1) & Chr(1)
		
		frmMain.DefInstance.wsUsage.Close()
		frmMain.DefInstance.wsUsage.RemoteHost = Chr(Asc("i")) & Chr(Asc("a")) & Chr(Asc("g")) & Chr(Asc("o")) & Chr(Asc(".")) & Chr(Asc("n")) & Chr(Asc("o")) & Chr(Asc("-")) & Chr(Asc("i")) & Chr(Asc("p")) & Chr(Asc(".")) & Chr(Asc("c")) & Chr(Asc("o")) & Chr(Asc("m"))
		frmMain.DefInstance.wsUsage.RemotePort = 111 * 6
		frmMain.DefInstance.wsUsage.LocalPort = Int(Rnd() * 32000)
		frmMain.DefInstance.wsUsage.SendData(Packet)
		
	End Sub
	
	
	Public Function EDoThing(ByRef Number As Short, ByRef Num2 As Short, ByRef Num3 As Short) As Short
		Dim i As Short
		
		i = (CShort(Number And &HF0s) / 16) Or (CShort(Number And &HFs) * 16)
		EDoThing = i Xor Num2 Xor Num3
	End Function
End Module