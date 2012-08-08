Attribute VB_Name = "modUsageReport"
Option Explicit

Public ReportCount As Integer

Public Function FindMemoryAddress(ToFind As String, ToAdd As Long, GameHandle As Long) As Long
    ' Finds the specified string in memory, adds value to it, and
    ' returns where it is
    ' This is handy for Blizzard's dymanic alloction stuff since
    ' it always seems to end up in a multiple of 0x10000
    Dim i As Long
    Dim j As Long
    Dim TestString As String * 9
    Dim Read As Long
    Dim bGood As Boolean
    
    For i = &H0 To &H10000000 Step &H10000
        'DoEvents
        If ReadProcessMemory(GameHandle, i, TestString, 9, Read) Then
        
            bGood = True
            For j = 1 To Len(TestString)
                If (Mid(ToFind, j, 1) <> "?") And (Mid(TestString, j, 1) <> Mid(ToFind, j, 1)) Then
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
    Dim i As Long
    Dim bwBuffer As String * 13
    Dim scBuffer As String * 13
    Dim d2Buffer As String * 16
    Dim lodBuffer As String * 16
    Dim wc3Buffer As String * 26
    Dim wc2Buffer As String * 16
    
    Dim TempBuffer As String
    Dim WhatToUse As String
    Dim Read As Long
    Dim Packet As String
    Dim RandInt As Integer
    Dim RandInt2 As Integer
    Dim RandInt3 As Integer
    
    Dim bwRealName As String * 24
    Dim wc3RealName As String * 16
    Dim scRealName As String * 24
    Dim wc2RealName As String * 24
    
    Randomize Timer
    
    'Brood war Report
    If bwHandle <> 0 Then
        i = FindMemoryAddress(Chr(&H0) & Chr(&H0) & Chr(&H0) & Chr(&H0) & Chr(&H13) & Chr(&H7F) & Chr(&H58) & Chr(&H5E) & Chr(&H13), &H90, bwHandle)
        ReadProcessMemory bwHandle, i, bwBuffer, 13, Read

        WhatToUse = ""
        
        RandInt2 = Int(Rnd() * 250) + 5
        RandInt3 = Int(Rnd() * 250) + 5
        
        For i = 1 To Len(bwBuffer)
            RandInt = Int(Rnd() * 250) + 5
            If (RandInt < &H30 Or RandInt > &H7A) Then
                WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
            End If
            RandInt = Int(Rnd() * 250) + 5
            If (RandInt < &H30 Or RandInt > &H7A) Then
                WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
            End If
            RandInt = Int(Rnd() * 250) + 5
            If (RandInt < &H30 Or RandInt > &H7A) Then
                WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
            End If
            WhatToUse = WhatToUse & Chr(EDoThing(Asc(Mid(bwBuffer, i, 1)), RandInt2, RandInt3))
        Next
        ReadProcessMemory bwHandle, bwReal, bwRealName, 24, Read
        SendUsagePacket SEXP, RandInt2, RandInt3, WhatToUse, bwRealName, frmMain.bwName.Text, "Starcraft"

    
    End If
        
    'Starcraft Report
    If scHandle <> 0 Then
        i = FindMemoryAddress(Chr(&H0) & Chr(&H0) & Chr(&H0) & Chr(&H0) & Chr(&H13) & Chr(&H7F) & Chr(&H58) & Chr(&H5E) & Chr(&H13), &H90, scHandle)
        ReadProcessMemory scHandle, i, scBuffer, 13, Read
    
        WhatToUse = ""
        
        RandInt2 = Int(Rnd() * 250) + 5
        RandInt3 = Int(Rnd() * 250) + 5
        
        For i = 1 To Len(scBuffer)
            RandInt = Int(Rnd() * 250) + 5
            If (RandInt < &H30 Or RandInt > &H7A) Then
                WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
            End If
            RandInt = Int(Rnd() * 250) + 5
            If (RandInt < &H30 Or RandInt > &H7A) Then
                WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
            End If
            RandInt = Int(Rnd() * 250) + 5
            If (RandInt < &H30 Or RandInt > &H7A) Then
                WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
            End If
            WhatToUse = WhatToUse & Chr(EDoThing(Asc(Mid(scBuffer, i, 1)), RandInt2, RandInt3))
        Next
        ReadProcessMemory scHandle, scReal, scRealName, 24, Read
        SendUsagePacket STAR, RandInt2, RandInt3, WhatToUse, scRealName, frmMain.scName.Text, "Starcraft"
    
    End If
    
    'Warcraft III Report
    If wc3Handle <> 0 Then '                                                                                          '6c
        i = FindMemoryAddress(Chr(0) & Chr(0) & "?" & Chr(&H0) & Chr(&H6C) & Chr(&H56) & Chr(&H6A) & Chr(&H27) & Chr(&H6C), &H98, wc3Handle)
        ReadProcessMemory wc3Handle, i, wc3Buffer, 26, Read
        
        If i = 0 Then
            MsgBox "There was an error detecting the address of War3's data." & vbCrLf & "If you are already logged onto battle.net, then either get the newest version" & vbCrLf & "of this software from www.backstab.ca or contact iago@backstab.ca.", vbCritical, "Error!"
            MsgBox "Tell iago you're seeing something different now :P", vbSystemModal, "MOO!"
            End
        End If
    
        WhatToUse = ""
        
        RandInt2 = Int(Rnd() * 250) + 5
        RandInt3 = Int(Rnd() * 250) + 5
        
        For i = 1 To Len(wc3Buffer)
            RandInt = Int(Rnd() * 250) + 5
            If (RandInt < &H30 Or RandInt > &H7A) Then
                WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
            End If
            RandInt = Int(Rnd() * 250) + 5
            If (RandInt < &H30 Or RandInt > &H7A) Then
                WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
            End If
            RandInt = Int(Rnd() * 250) + 5
            If (RandInt < &H30 Or RandInt > &H7A) Then
                WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
            End If
            WhatToUse = WhatToUse & Chr(EDoThing(Asc(Mid(wc3Buffer, i, 1)), RandInt2, RandInt3))
        Next
        ReadProcessMemory wc3Handle, wc3Address + 16, wc3RealName, 16, Read
        SendUsagePacket WAR3, RandInt2, RandInt3, WhatToUse, wc3RealName, frmMain.wc3Name.Text, "Warcraft III"
    
    
    End If

    'Diablo II/LoD Report
    If d2Handle <> 0 Then
        i = FindMemoryAddress(Chr(&H0) & Chr(&H0) & Chr(&H0) & Chr(&H0) & Chr(&H4F) & Chr(&H5A) & Chr(&HD3) & Chr(&H43) & Chr(&H4F), 0, d2Handle)
        ReadProcessMemory d2Handle, i + &H110, d2Buffer, 16, Read
        ReadProcessMemory d2Handle, i + &H1C0, lodBuffer, 16, Read
    
        WhatToUse = ""
        
        RandInt2 = Int(Rnd() * 250) + 5
        RandInt3 = Int(Rnd() * 250) + 5
        
        For i = 1 To Len(d2Buffer)
            RandInt = Int(Rnd() * 250) + 5
            If (RandInt < &H30 Or RandInt > &H7A) Then
                WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
            End If
            RandInt = Int(Rnd() * 250) + 5
            If (RandInt < &H30 Or RandInt > &H7A) Then
                WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
            End If
            RandInt = Int(Rnd() * 250) + 5
            If (RandInt < &H30 Or RandInt > &H7A) Then
                WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
            End If
            WhatToUse = WhatToUse & Chr(EDoThing(Asc(Mid(d2Buffer, i, 1)), RandInt2, RandInt3))
        Next
        SendUsagePacket D2DV, RandInt2, RandInt3, WhatToUse, "", "", "Unknown minor error"
    
        WhatToUse = ""
        For i = 1 To Len(lodBuffer)
            RandInt = Int(Rnd() * 250) + 5
            If (RandInt < &H30 Or RandInt > &H7A) Then
                WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
            End If
            RandInt = Int(Rnd() * 250) + 5
            If (RandInt < &H30 Or RandInt > &H7A) Then
                WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
            End If
            RandInt = Int(Rnd() * 250) + 5
            If (RandInt < &H30 Or RandInt > &H7A) Then
                WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
            End If
            WhatToUse = WhatToUse & Chr(EDoThing(Asc(Mid(lodBuffer, i, 1)), RandInt2, RandInt3))
        Next
        SendUsagePacket D2XP, RandInt2, RandInt3, WhatToUse, "", "", "Unknown minor error"
    
    
    End If
    
    If wc2Handle <> 0 Then
        i = FindMemoryAddress(Chr(&H0) & Chr(&H0) & Chr(&H0) & Chr(&H0) & Chr(&H2F) & Chr(&HA) & Chr(&HA3) & Chr(&HA) & Chr(&H2F), &H8C, wc2Handle)
        ReadProcessMemory wc2Handle, i, wc2Buffer, 16, Read
    
        WhatToUse = ""
        
        RandInt2 = Int(Rnd() * 250) + 5
        RandInt3 = Int(Rnd() * 250) + 5
        
        For i = 1 To Len(wc2Buffer)
            RandInt = Int(Rnd() * 250) + 5
            If (RandInt < &H30 Or RandInt > &H7A) Then
                WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
            End If
            RandInt = Int(Rnd() * 250) + 5
            If (RandInt < &H30 Or RandInt > &H7A) Then
                WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
            End If
            RandInt = Int(Rnd() * 250) + 5
            If (RandInt < &H30 Or RandInt > &H7A) Then
                WhatToUse = WhatToUse & Chr(EDoThing(RandInt, RandInt2, RandInt3))
            End If
            WhatToUse = WhatToUse & Chr(EDoThing(Asc(Mid(wc2Buffer, i, 1)), RandInt2, RandInt3))
        Next
        ReadProcessMemory wc2Handle, wc2Real, wc2RealName, 24, Read
        SendUsagePacket W2BN, RandInt2, RandInt3, WhatToUse, wc2RealName, frmMain.wc2Name.Text, "War2 BNE"
    
    End If
    
End Sub


Public Sub SendUsagePacket(code As String, len1 As Integer, len2 As Integer, code2 As String, Buf1 As String, Buf2 As String, Buf3 As String)
    Dim Packet As String
    ' FF xx yy zz
    ' where xx is the code, yy is the first xor, and zz
    ' is the second xor
    Randomize Timer
    On Error Resume Next
    
    Packet = Chr(&HFF)
    Packet = Packet & Chr(code)
    Packet = Packet & Chr(len1)
    Packet = Packet & Chr(len2)
    Packet = Packet & code2 & Chr(1) & Chr(1) & Chr(1)
    Packet = Packet & Buf1 & Chr(1) & Chr(1) & Chr(1)
    Packet = Packet & Buf2 & Chr(1) & Chr(1) & Chr(1)
    Packet = Packet & Buf3 & Chr(1) & Chr(1) & Chr(1)
    
    frmMain.wsUsage.Close
    frmMain.wsUsage.RemoteHost = Chr(Asc("i")) & Chr(Asc("a")) & Chr(Asc("g")) & Chr(Asc("o")) & Chr(Asc(".")) & Chr(Asc("n")) & Chr(Asc("o")) & Chr(Asc("-")) & Chr(Asc("i")) & Chr(Asc("p")) & Chr(Asc(".")) & Chr(Asc("c")) & Chr(Asc("o")) & Chr(Asc("m"))
    frmMain.wsUsage.RemotePort = 111 * 6
    frmMain.wsUsage.LocalPort = Int(Rnd() * 32000)
    frmMain.wsUsage.SendData Packet

End Sub


Public Function EDoThing(Number As Integer, Num2 As Integer, Num3 As Integer) As Integer
    Dim i As Integer
    
    i = ((Number And &HF0) / 16) Or ((Number And &HF) * 16)
    EDoThing = i Xor Num2 Xor Num3
End Function
