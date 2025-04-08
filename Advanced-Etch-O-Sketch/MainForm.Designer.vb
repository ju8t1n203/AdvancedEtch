<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PenSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.BGPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EtchPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InputGroupBox.SuspendLayout()
        Me.ContextMenuStrip.SuspendLayout()
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
        Me.EtchPictureBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.EtchPictureBox.Location = New System.Drawing.Point(29, 26)
        Me.EtchPictureBox.Name = "EtchPictureBox"
        Me.EtchPictureBox.Size = New System.Drawing.Size(742, 334)
        Me.EtchPictureBox.TabIndex = 2
        Me.EtchPictureBox.TabStop = False
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InputGroupBox.Controls.Add(Me.ConnectedLabel)
        Me.InputGroupBox.Controls.Add(Me.FromLabel)
        Me.InputGroupBox.Controls.Add(Me.COMMComboBox)
        Me.InputGroupBox.Location = New System.Drawing.Point(12, 464)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(286, 79)
        Me.InputGroupBox.TabIndex = 0
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "Input"
        '
        'ConnectedLabel
        '
        Me.ConnectedLabel.AutoSize = True
        Me.ConnectedLabel.Location = New System.Drawing.Point(123, 33)
        Me.ConnectedLabel.Name = "ConnectedLabel"
        Me.ConnectedLabel.Size = New System.Drawing.Size(127, 13)
        Me.ConnectedLabel.TabIndex = 2
        Me.ConnectedLabel.Text = "Connect to a Quiet Board"
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
        Me.TxTimer.Interval = 50
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearButton.Location = New System.Drawing.Point(532, 464)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(125, 79)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoSize = True
        Me.LocationLabel.Location = New System.Drawing.Point(304, 475)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(51, 13)
        Me.LocationLabel.TabIndex = 3
        Me.LocationLabel.Text = "Location:"
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenSizeToolStripMenuItem, Me.PenColorToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(181, 114)
        '
        'PenSizeToolStripMenuItem
        '
        Me.PenSizeToolStripMenuItem.Name = "PenSizeToolStripMenuItem"
        Me.PenSizeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PenSizeToolStripMenuItem.Text = "Pen Size"
        '
        'PenColorToolStripMenuItem
        '
        Me.PenColorToolStripMenuItem.Name = "PenColorToolStripMenuItem"
        Me.PenColorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PenColorToolStripMenuItem.Text = "Pen Color"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 555)
        Me.Controls.Add(Me.LocationLabel)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Controls.Add(Me.EtchPictureBox)
        Me.Controls.Add(Me.BGPictureBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Etch-O-Sketch"
        CType(Me.BGPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EtchPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents ClearButton As Button
    Friend WithEvents LocationLabel As Label
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents PenSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
