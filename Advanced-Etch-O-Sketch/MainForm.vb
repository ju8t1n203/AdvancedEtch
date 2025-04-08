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

    Private Sub MainForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Spash.Show()
        Me.Hide()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        COMMTimer.Enabled = True
        Dots()
        penColor(Color.Black)
        penWidth(1)
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
            If ADC(0) < 5 Then
            Else
                If iterration = False Then
                    DrawLine(ADC(0), ADC(1))
                    iterration = True
                Else
                    DrawLine(_store(0), _store(1))
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
        Dim pen As New Pen(penColor(), penWidth())
        Dim endx As Integer
        Dim endy As Integer

        Try
            endx = ADC(0)
            endy = ADC(1)
            g.DrawLine(pen, startX, startY, endx, endy)
            _store(0) = endx
            _store(1) = endy
        Catch ex As Exception

        End Try

        LocationLabel.Text = $"Location: {ADC(0)}, {ADC(1)}"

        g.Dispose()

    End Sub

    Function penColor(Optional newColor As Color = Nothing) As Color
        'holds and updates the drawing tool color
        Static _color As Color

        If newColor <> Nothing Then
            _color = newColor
        End If

        Return _color
    End Function

    Function penWidth(Optional newWidth As Integer = Nothing) As Integer
        'holds and updates the drawing tool color
        Static _width As Integer

        If newWidth <> Nothing Then
            _width = newWidth
        End If

        Return _width
    End Function

    'buttons----------------------------------------------------------
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        EtchPictureBox.Image = Nothing
    End Sub

    'context menu strip---------------------------------------------
    Private Sub PenSizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenSizeToolStripMenuItem.Click

    End Sub

    Private Sub PenColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenColorToolStripMenuItem.Click
        'opens a dialog for the user to change the tool color
        Dim ColorDialog As New ColorDialog
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            penColor(ColorDialog.Color)
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ClearButton.PerformClick()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class