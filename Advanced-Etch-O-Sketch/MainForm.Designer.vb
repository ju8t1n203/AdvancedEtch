<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SplashTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.BGPictureBox = New System.Windows.Forms.PictureBox()
        Me.EtchPictureBox = New System.Windows.Forms.PictureBox()
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.ConnectedLabel = New System.Windows.Forms.Label()
        Me.FromLabel = New System.Windows.Forms.Label()
        Me.COMMComboBox = New System.Windows.Forms.ComboBox()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.COMMTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TxTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ADC1ValueLabel = New System.Windows.Forms.Label()
        Me.ADC1MSBLabel = New System.Windows.Forms.Label()
        Me.ADC1LSBLabel = New System.Windows.Forms.Label()
        Me.ADC2LSBLabel = New System.Windows.Forms.Label()
        Me.ADC2MSBLabel = New System.Windows.Forms.Label()
        Me.ADC2Label = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.BGPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EtchPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplashTimer
        '
        Me.SplashTimer.Interval = 1000
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.Location = New System.Drawing.Point(663, 464)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(125, 79)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'BGPictureBox
        '
        Me.BGPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BGPictureBox.BackColor = System.Drawing.Color.Red
        Me.BGPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.BGPictureBox.Name = "BGPictureBox"
        Me.BGPictureBox.Size = New System.Drawing.Size(776, 446)
        Me.BGPictureBox.TabIndex = 1
        Me.BGPictureBox.TabStop = False
        '
        'EtchPictureBox
        '
        Me.EtchPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EtchPictureBox.BackColor = System.Drawing.Color.White
        Me.EtchPictureBox.Location = New System.Drawing.Point(29, 26)
        Me.EtchPictureBox.Name = "EtchPictureBox"
        Me.EtchPictureBox.Size = New System.Drawing.Size(742, 334)
        Me.EtchPictureBox.TabIndex = 2
        Me.EtchPictureBox.TabStop = False
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.ADC2LSBLabel)
        Me.InputGroupBox.Controls.Add(Me.ADC2MSBLabel)
        Me.InputGroupBox.Controls.Add(Me.ADC2Label)
        Me.InputGroupBox.Controls.Add(Me.ADC1LSBLabel)
        Me.InputGroupBox.Controls.Add(Me.ADC1MSBLabel)
        Me.InputGroupBox.Controls.Add(Me.ADC1ValueLabel)
        Me.InputGroupBox.Controls.Add(Me.ConnectedLabel)
        Me.InputGroupBox.Controls.Add(Me.FromLabel)
        Me.InputGroupBox.Controls.Add(Me.COMMComboBox)
        Me.InputGroupBox.Location = New System.Drawing.Point(12, 464)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(645, 79)
        Me.InputGroupBox.TabIndex = 0
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "Input"
        '
        'ConnectedLabel
        '
        Me.ConnectedLabel.AutoSize = True
        Me.ConnectedLabel.Location = New System.Drawing.Point(361, 30)
        Me.ConnectedLabel.Name = "ConnectedLabel"
        Me.ConnectedLabel.Size = New System.Drawing.Size(0, 13)
        Me.ConnectedLabel.TabIndex = 2
        '
        'FromLabel
        '
        Me.FromLabel.AutoSize = True
        Me.FromLabel.Location = New System.Drawing.Point(6, 33)
        Me.FromLabel.Name = "FromLabel"
        Me.FromLabel.Size = New System.Drawing.Size(33, 13)
        Me.FromLabel.TabIndex = 0
        Me.FromLabel.Text = "From:"
        '
        'COMMComboBox
        '
        Me.COMMComboBox.FormattingEnabled = True
        Me.COMMComboBox.Location = New System.Drawing.Point(45, 30)
        Me.COMMComboBox.Name = "COMMComboBox"
        Me.COMMComboBox.Size = New System.Drawing.Size(72, 21)
        Me.COMMComboBox.TabIndex = 1
        '
        'SerialPort
        '
        '
        'COMMTimer
        '
        '
        'TxTimer
        '
        '
        'ADC1ValueLabel
        '
        Me.ADC1ValueLabel.AutoSize = True
        Me.ADC1ValueLabel.Location = New System.Drawing.Point(168, 16)
        Me.ADC1ValueLabel.Name = "ADC1ValueLabel"
        Me.ADC1ValueLabel.Size = New System.Drawing.Size(38, 13)
        Me.ADC1ValueLabel.TabIndex = 3
        Me.ADC1ValueLabel.Text = "ADC1:"
        '
        'ADC1MSBLabel
        '
        Me.ADC1MSBLabel.AutoSize = True
        Me.ADC1MSBLabel.Location = New System.Drawing.Point(168, 30)
        Me.ADC1MSBLabel.Name = "ADC1MSBLabel"
        Me.ADC1MSBLabel.Size = New System.Drawing.Size(33, 13)
        Me.ADC1MSBLabel.TabIndex = 4
        Me.ADC1MSBLabel.Text = "MSB:"
        '
        'ADC1LSBLabel
        '
        Me.ADC1LSBLabel.AutoSize = True
        Me.ADC1LSBLabel.Location = New System.Drawing.Point(168, 43)
        Me.ADC1LSBLabel.Name = "ADC1LSBLabel"
        Me.ADC1LSBLabel.Size = New System.Drawing.Size(30, 13)
        Me.ADC1LSBLabel.TabIndex = 5
        Me.ADC1LSBLabel.Text = "LSB:"
        '
        'ADC2LSBLabel
        '
        Me.ADC2LSBLabel.AutoSize = True
        Me.ADC2LSBLabel.Location = New System.Drawing.Point(263, 43)
        Me.ADC2LSBLabel.Name = "ADC2LSBLabel"
        Me.ADC2LSBLabel.Size = New System.Drawing.Size(30, 13)
        Me.ADC2LSBLabel.TabIndex = 8
        Me.ADC2LSBLabel.Text = "LSB:"
        '
        'ADC2MSBLabel
        '
        Me.ADC2MSBLabel.AutoSize = True
        Me.ADC2MSBLabel.Location = New System.Drawing.Point(263, 30)
        Me.ADC2MSBLabel.Name = "ADC2MSBLabel"
        Me.ADC2MSBLabel.Size = New System.Drawing.Size(33, 13)
        Me.ADC2MSBLabel.TabIndex = 7
        Me.ADC2MSBLabel.Text = "MSB:"
        '
        'ADC2Label
        '
        Me.ADC2Label.AutoSize = True
        Me.ADC2Label.Location = New System.Drawing.Point(263, 16)
        Me.ADC2Label.Name = "ADC2Label"
        Me.ADC2Label.Size = New System.Drawing.Size(38, 13)
        Me.ADC2Label.TabIndex = 6
        Me.ADC2Label.Text = "ADC2:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(503, 98)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(237, 212)
        Me.ListBox1.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 555)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Controls.Add(Me.EtchPictureBox)
        Me.Controls.Add(Me.BGPictureBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Etch-O-Sketch"
        CType(Me.BGPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EtchPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplashTimer As Timer
    Friend WithEvents ExitButton As Button
    Friend WithEvents BGPictureBox As PictureBox
    Friend WithEvents EtchPictureBox As PictureBox
    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents FromLabel As Label
    Friend WithEvents COMMComboBox As ComboBox
    Friend WithEvents ConnectedLabel As Label
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents COMMTimer As Timer
    Friend WithEvents TxTimer As Timer
    Friend WithEvents ADC1ValueLabel As Label
    Friend WithEvents ADC1LSBLabel As Label
    Friend WithEvents ADC1MSBLabel As Label
    Friend WithEvents ADC2LSBLabel As Label
    Friend WithEvents ADC2MSBLabel As Label
    Friend WithEvents ADC2Label As Label
    Friend WithEvents ListBox1 As ListBox
End Class
