'Justin Bell
'RCET 3371
'Spring 2025
' https://github.com/ju8t1n203/QuietThermostat
Option Explicit On
Option Strict On

Imports System.IO.Ports
Imports System.Text
Imports System.ComponentModel
Imports System.Globalization
Imports System.Media
Imports System.Windows.Forms.Design
Public Class QuietThermostat
    Dim incoming As New Queue(Of Byte)

    Private Sub QuietThermostat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        COMMTimer.Enabled = True
    End Sub

    Private Sub COMMTimer_Tick(sender As Object, e As EventArgs) Handles COMMTimer.Tick
        'updates combo box in top menu strip with COMM ports availble
        Dim comPorts As String() = SerialPort.GetPortNames()

        If comPorts.Length > 0 Then
            For Each port As String In comPorts
                COMMComboBox.Items.Add(port)
            Next
            COMMTimer.Enabled = False
            VerificationTimer.Enabled = True    'once a comm port is selected verify the connected device is a Quiet Board (specifically a verision 2.0)
        End If
    End Sub

    Private Sub COMMComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMMComboBox.SelectedIndexChanged
        BasicQY.VerifyQ(SerialPort, COMMComboBox)
    End Sub

    Private Sub VerificationTimer_Tick(sender As Object, e As EventArgs) Handles VerificationTimer.Tick
        Static iterration As Boolean = False
        Dim working As Byte = &H0
        Static countinue As Boolean = False
        'puts the incoming information from the COMM port into a queue
        If countinue = False Then
            Try
                working = incoming.Dequeue
            Catch ex As Exception
                working = &H0
            End Try
            'verifies the connected device is the quiet boad
            countinue = BasicQY.QYCheck(working)
        Else
            Connection.Text = "Quiet Board is Connected"
            VerificationTimer.Enabled = False
            countinue = False
            UpdateTimer.Enabled = True
        End If
    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        BasicQY.RecieveData(SerialPort, incoming)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UpdateTimer_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        Dim _bytes(2) As Byte
        _bytes(0) = &H51
        _bytes(1) = &H52
        _bytes(2) = &H30
        ListBox1.Items.Clear()
        SerialPort.Write(_bytes, 0, 3)
        'If incoming.Count > 0 Then
        '    For i = 0 To incoming.Count - 1
        '        ListBox1.Items.Add(incoming.Dequeue)
        '    Next
        'End If

        TimenDateStatusLabel.Text = DateTime.Now.ToString("yyyy MMMM d, h:mm")

        Dim ADC(1, 2) As Integer
        ADC = BasicQY.GetAnalog(incoming)

        If ADC(0, 0) > 1 Then
            Dim cT As Integer
            cT = CInt(50 + ((ADC(0, 0) - 11) * (80 - 50) / (1023 - 11)))
            CurrentTempLabel.Text = $"Current Temperature: {cT}°F"
        End If

        If ADC(1, 0) > 1 Then
            Dim sT As Integer
            sT = CInt(50 + ((ADC(1, 0) - 11) * (80 - 50) / (1023 - 11)))
            SetTempLabel.Text = $"Set Temperature: {sT}°F"
            TargetTempMeter.Value = sT
        End If

        Dim DI(7) As Boolean
        Dim value As Integer

        value = BasicQY.GetDigital(incoming)

        If value > 0 Then
            Dim found As Boolean = False
            DILabel.Text = $"Digital In: {value}"

            Do      'this loop cheacks the digital inputs and fires teh corrolated action

                If (value And 2) = 0 Then
                    PictureBox1.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("Heat"), Image)
                    Exit Do
                Else
                    PictureBox1.BackgroundImage = Nothing
                End If

                If (value And 4) = 0 Then
                    FanLabel.Text = "Fan is ON"
                    Exit Do
                Else
                    FanLabel.Text = "Fan is OFF"
                End If

                If (value And 16) = 0 Then
                    PictureBox1.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("AC"), Image)
                    Exit Do
                Else
                    PictureBox1.BackgroundImage = Nothing
                End If

                If (value And 1) = 0 Then
                    FanLabel.Text = "saftey has tripped call technitian"
                    Exit Do
                End If

                Exit Do
            Loop

            ' Check the bits directly
        End If

        incoming.Clear()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        AboutForm.Show()
    End Sub
End Class