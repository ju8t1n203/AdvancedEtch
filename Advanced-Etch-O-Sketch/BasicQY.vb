'Justin Bell
'RCET3371
'Spring 2025
Imports System.IO.Ports
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

    Public Shared Sub VerifyQ(countinue As Boolean, serialport As SerialPort, pullfrom As ComboBox)
        countinue = False
        serialport.PortName = pullfrom.SelectedItem.ToString
        serialport.Open()

        Dim _bytes(0) As Byte
        _bytes(0) = &B11110000

        serialport.Write(_bytes, 0, 1)
    End Sub

    Public Shared Function QYCheck(_byte As Byte, vq As Integer) As Boolean
        'verifies the connected device is the quiet boad
        'the value of vQ will need to be updated if/when QY@3.0 is implemented
        Dim _continue As Boolean = False
        If vq < 873 Then
            vq = CInt(_byte) + vq
        ElseIf vq = 873 Then
            _continue = True
        Else
            vq = 0
        End If
        Return _continue
    End Function

End Class
