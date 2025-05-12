﻿'Justin Bell
'RCET3371
'Spring 2025
Imports System.IO.Ports
Imports System.Security.Cryptography
Imports System.Text

Public Class BasicQY

    Public Shared Sub RecieveData(serialport As SerialPort, incoming As Queue(Of Byte))
        'defualt handling of Rx moving data into a predefined queue to be used
        Dim numberofbytes = serialport.BytesToRead
        Dim _bytes(numberofbytes) As Byte

        serialport.Read(_bytes, 0, numberofbytes)

        For Each thingy In _bytes
            incoming.Enqueue(thingy)
        Next
    End Sub

    Public Shared Sub VerifyQ(serialport As SerialPort, pullfrom As ToolStripComboBox)
        serialport.PortName = pullfrom.SelectedItem.ToString
        serialport.Open()

        Dim _bytes(0) As Byte
        _bytes(0) = &B11110000

        serialport.Write(_bytes, 0, 1)
    End Sub

    Shared vQ As Integer
    Public Shared Function QYCheck(_byte As Byte) As Boolean
        'verifies the connected device is the quiet boad
        'the value of vQ will need to be updated if/when QY@3.0 is implemented
        Dim _continue As Boolean = False
        If vQ < 873 Then
            vQ = CInt(_byte) + vQ
        ElseIf vQ = 873 Then
            _continue = True
        Else
            vQ = 0
        End If
        Return _continue
    End Function

    Public Shared Function GetAnalog(incoming As Queue(Of Byte)) As Integer(,)
        '| AN1 DEC | AN1 MSB | AN1 LSB |
        '| AN2 DEC | AN2 MSB | AN2 LSB |
        Dim adcValues(1, 2) As Integer '0 is analog 1, 1 is analog 2 on the QY@ Board
        Dim msb1 As Byte
        Dim lsb1 As Byte
        Dim msb2 As Byte
        Dim lsb2 As Byte

        If incoming.Count > 3 Then
            msb1 = incoming.Dequeue
            adcValues(0, 1) = CStr(msb1)
            lsb1 = incoming.Dequeue
            adcValues(0, 2) = CStr(lsb1)
            adcValues(0, 0) = (CInt(msb1) * 4) + CInt(lsb1 >> 6)

            msb2 = incoming.Dequeue
            adcValues(1, 1) = CStr(msb2)
            lsb2 = incoming.Dequeue
            adcValues(1, 2) = CStr(lsb1)
            adcValues(1, 0) = (CInt(msb2) * 4) + CInt(lsb2 >> 6)

        End If

        Return adcValues
    End Function

    Public Shared Function GetDigital(incoming As Queue(Of Byte)) As Integer
        Dim DI(0, 7) As Boolean
        Dim value As Integer

        If incoming.Count > 0 Then
            value = incoming.Dequeue
        End If

        Return value
    End Function

End Class
