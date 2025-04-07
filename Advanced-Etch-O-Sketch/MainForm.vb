'Justin Bell
'RCET3371
'Spring 2025
'link

Option Explicit On
Option Strict On
Imports System.IO.Ports
Imports System.Xml
Imports System.Threading
Imports Microsoft.VisualBasic.Devices

Public Class MainForm
    Dim incoming As New Queue(Of Byte)
    Dim countinue As Boolean = False
    Dim vQ As Integer

    Private Sub SplashTimer_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick
        Spash.Close()
        Me.Show()
        SplashTimer.Enabled = False
    End Sub

    Sub Dots()
        Dim g As Graphics = BGPictureBox.CreateGraphics
        Dim pen As New Pen(Color.White)
        g.DrawEllipse(pen, 100, 100, 100, 100)

        g.Dispose()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        COMMTimer.Enabled = True
    End Sub

    Private Sub COMMTimer_Tick(sender As Object, e As EventArgs) Handles COMMTimer.Tick
        EstablishComm()
    End Sub

    Sub EstablishComm()
        Dim comPorts As String() = SerialPort.GetPortNames()

        If comPorts.Length > 0 Then
            For Each port As String In comPorts
                COMMComboBox.Items.Add(port)
            Next
            COMMTimer.Enabled = False
            UpdateTimer.Enabled = True
        End If
    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        BasicQY.RecieveData(SerialPort, incoming)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub COMMComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMMComboBox.SelectedIndexChanged
        BasicQY.VerifyQ(countinue, SerialPort, COMMComboBox)
    End Sub

    Private Sub UpdateTimer_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        Dim working As Byte = &H0

        Try
            working = incoming.Dequeue
        Catch ex As Exception
            working = &H0
        End Try

        'verifies the connected device is the quiet boad
        countinue = BasicQY.QYCheck(working, vQ)

        If countinue = True Then
            ConnectedLabel.Text = "Quiet Board is Connected"
            'do thing
        End If

    End Sub

End Class
