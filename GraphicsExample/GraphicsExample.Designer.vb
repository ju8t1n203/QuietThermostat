<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuietThermostat
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
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMMComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.Connection = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMMTimer = New System.Windows.Forms.Timer(Me.components)
        Me.VerificationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.UpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CurrentTempLabel = New System.Windows.Forms.Label()
        Me.SetTempLabel = New System.Windows.Forms.Label()
        Me.TargetTempMeter = New System.Windows.Forms.TrackBar()
        Me.DILabel = New System.Windows.Forms.Label()
        Me.FanLabel = New System.Windows.Forms.Label()
        Me.TimeDateStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.TimenDateStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TopMenuStrip.SuspendLayout()
        CType(Me.TargetTempMeter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TimeDateStatusStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SerialPort
        '
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(800, 24)
        Me.TopMenuStrip.TabIndex = 0
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'ConnectToolStripMenuItem
        '
        Me.ConnectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COMMComboBox, Me.Connection})
        Me.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem"
        Me.ConnectToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ConnectToolStripMenuItem.Text = "Connect"
        '
        'COMMComboBox
        '
        Me.COMMComboBox.Name = "COMMComboBox"
        Me.COMMComboBox.Size = New System.Drawing.Size(121, 23)
        '
        'Connection
        '
        Me.Connection.Name = "Connection"
        Me.Connection.Size = New System.Drawing.Size(201, 22)
        Me.Connection.Text = "Connect To a Q@ Board"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'COMMTimer
        '
        '
        'VerificationTimer
        '
        '
        'UpdateTimer
        '
        '
        'CurrentTempLabel
        '
        Me.CurrentTempLabel.AutoSize = True
        Me.CurrentTempLabel.Location = New System.Drawing.Point(235, 63)
        Me.CurrentTempLabel.Name = "CurrentTempLabel"
        Me.CurrentTempLabel.Size = New System.Drawing.Size(107, 13)
        Me.CurrentTempLabel.TabIndex = 1
        Me.CurrentTempLabel.Text = "Current Temperature:"
        '
        'SetTempLabel
        '
        Me.SetTempLabel.AutoSize = True
        Me.SetTempLabel.Location = New System.Drawing.Point(56, 63)
        Me.SetTempLabel.Name = "SetTempLabel"
        Me.SetTempLabel.Size = New System.Drawing.Size(89, 13)
        Me.SetTempLabel.TabIndex = 2
        Me.SetTempLabel.Text = "Set Temperature:"
        '
        'TargetTempMeter
        '
        Me.TargetTempMeter.Location = New System.Drawing.Point(70, 94)
        Me.TargetTempMeter.Maximum = 82
        Me.TargetTempMeter.Minimum = 48
        Me.TargetTempMeter.Name = "TargetTempMeter"
        Me.TargetTempMeter.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TargetTempMeter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TargetTempMeter.Size = New System.Drawing.Size(45, 171)
        Me.TargetTempMeter.TabIndex = 3
        Me.TargetTempMeter.TabStop = False
        Me.TargetTempMeter.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TargetTempMeter.Value = 48
        '
        'DILabel
        '
        Me.DILabel.AutoSize = True
        Me.DILabel.Location = New System.Drawing.Point(235, 94)
        Me.DILabel.Name = "DILabel"
        Me.DILabel.Size = New System.Drawing.Size(51, 13)
        Me.DILabel.TabIndex = 5
        Me.DILabel.Text = "Digital In:"
        '
        'FanLabel
        '
        Me.FanLabel.AutoSize = True
        Me.FanLabel.Location = New System.Drawing.Point(618, 223)
        Me.FanLabel.Name = "FanLabel"
        Me.FanLabel.Size = New System.Drawing.Size(58, 13)
        Me.FanLabel.TabIndex = 7
        Me.FanLabel.Text = "Fan is OFF"
        '
        'TimeDateStatusStrip
        '
        Me.TimeDateStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimenDateStatusLabel})
        Me.TimeDateStatusStrip.Location = New System.Drawing.Point(0, 428)
        Me.TimeDateStatusStrip.Name = "TimeDateStatusStrip"
        Me.TimeDateStatusStrip.Size = New System.Drawing.Size(800, 22)
        Me.TimeDateStatusStrip.TabIndex = 8
        Me.TimeDateStatusStrip.Text = "StatusStrip1"
        '
        'TimenDateStatusLabel
        '
        Me.TimenDateStatusLabel.Name = "TimenDateStatusLabel"
        Me.TimenDateStatusLabel.Size = New System.Drawing.Size(64, 17)
        Me.TimenDateStatusLabel.Text = "SomeTime"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(520, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 193)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'QuietThermostat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TimeDateStatusStrip)
        Me.Controls.Add(Me.FanLabel)
        Me.Controls.Add(Me.DILabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TargetTempMeter)
        Me.Controls.Add(Me.SetTempLabel)
        Me.Controls.Add(Me.CurrentTempLabel)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "QuietThermostat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Justin's Air Pressure Solutions"
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        CType(Me.TargetTempMeter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TimeDateStatusStrip.ResumeLayout(False)
        Me.TimeDateStatusStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents ConnectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COMMTimer As Timer
    Friend WithEvents COMMComboBox As ToolStripComboBox
    Friend WithEvents VerificationTimer As Timer
    Friend WithEvents Connection As ToolStripMenuItem
    Friend WithEvents UpdateTimer As Timer
    Friend WithEvents CurrentTempLabel As Label
    Friend WithEvents SetTempLabel As Label
    Friend WithEvents TargetTempMeter As TrackBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DILabel As Label
    Friend WithEvents FanLabel As Label
    Friend WithEvents TimeDateStatusStrip As StatusStrip
    Friend WithEvents TimenDateStatusLabel As ToolStripStatusLabel
End Class
