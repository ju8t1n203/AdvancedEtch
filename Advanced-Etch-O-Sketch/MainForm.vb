'Justin Bell
'RCET3371
'Spring 2025
'link

Option Explicit On
Option Strict On
Public Class MainForm
    Private Sub SplashTimer_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick
        Spash.Close()
        Me.Show()
        SplashTimer.Enabled = False
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
