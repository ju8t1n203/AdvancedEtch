'Justin Bell
'RCET3371
'Spring 2025
'https://github.com/ju8t1n203/AdvancedEtch

Option Explicit On
Option Strict On
Imports System.IO.Ports
Imports System.Xml
Imports System.Threading
Imports Microsoft.VisualBasic.Devices
Imports System.CodeDom

Public Class MainForm
    Dim incoming As New Queue(Of Byte)
    Dim countinue As Boolean = False
    Dim ADC(1) As Integer
    Dim _store(1) As Integer
    Dim iterration As Boolean = False

    Private Sub SplashTimer_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick
        Spash.Close()
        Me.Show()
        SplashTimer.Enabled = False
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        COMMTimer.Enabled = True
        Dots()
    End Sub

    'serial port setup-----------------------------------------------
    Private Sub COMMComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMMComboBox.SelectedIndexChanged
        BasicQY.VerifyQ(countinue, SerialPort, COMMComboBox)
    End Sub

    Private Sub COMMTimer_Tick(sender As Object, e As EventArgs) Handles COMMTimer.Tick
        Dim comPorts As String() = SerialPort.GetPortNames()

        If comPorts.Length > 0 Then
            For Each port As String In comPorts
                COMMComboBox.Items.Add(port)
            Next
            COMMTimer.Enabled = False
            TxTimer.Enabled = True
        End If
    End Sub

    'data handling--------------------------------------------------
    Private Sub SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        BasicQY.RecieveData(SerialPort, incoming)
    End Sub

    Private Sub TxTimer_Tick(sender As Object, e As EventArgs) Handles TxTimer.Tick
        Dim working As Byte = &H0
        Dim _bytes(1) As Byte
        _bytes(0) = &H51
        _bytes(1) = &H52

        If countinue = False Then
            Try
                working = incoming.Dequeue
            Catch ex As Exception
                working = &H0
            End Try
            'verifies the connected device is the quiet boad
            countinue = BasicQY.QYCheck(working)
        Else
            ConnectedLabel.Text = "Quiet Board is Connected"
            SerialPort.Write(_bytes, 0, 2)
            ADC = BasicQY.GetAnalog(incoming)
            If ADC Is Nothing Then
            Else
                If iterration = False Then
                    DrawLine(ADC(0), ADC(1))
                    iterration = True
                    _store(0) = ADC(0)
                    _store(1) = ADC(1)
                Else
                    DrawLine(_store(0), _store(1))
                    _store(0) = ADC(0)
                    _store(1) = ADC(1)
                End If
            End If
        End If
    End Sub

    'graphics---------------------------------------------------------
    Sub Dots()
        Dim g As Graphics = BGPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black)
        Dim x As Integer = BGPictureBox.Width
        Dim y As Integer = BGPictureBox.Height
        g.DrawEllipse(pen, x, y, 100, 100)

        g.Dispose()
    End Sub

    Sub DrawLine(startX As Integer, startY As Integer)
        Dim g As Graphics = EtchPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black)
        Dim endx As Integer
        Dim endy As Integer
        Try
            endx = CInt(EtchPictureBox.Width / ADC(0))
            endy = CInt(EtchPictureBox.Height / ADC(1))
            g.DrawLine(pen, startX, startY, endx, endy)
        Catch ex As Exception

        End Try


        g.Dispose()

    End Sub

    'exit button------------------------------------------------------
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class