<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.fbtn = New System.Windows.Forms.Button()
        Me.bbtn = New System.Windows.Forms.Button()
        Me.abtn = New System.Windows.Forms.Button()
        Me.gbtn = New System.Windows.Forms.Button()
        Me.ebtn = New System.Windows.Forms.Button()
        Me.cbtn = New System.Windows.Forms.Button()
        Me.dbtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.startButton = New System.Windows.Forms.Button()
        Me.stopButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fbtn
        '
        Me.fbtn.Location = New System.Drawing.Point(36, 53)
        Me.fbtn.Name = "fbtn"
        Me.fbtn.Size = New System.Drawing.Size(32, 125)
        Me.fbtn.TabIndex = 0
        Me.fbtn.UseVisualStyleBackColor = True
        '
        'bbtn
        '
        Me.bbtn.Location = New System.Drawing.Point(191, 53)
        Me.bbtn.Name = "bbtn"
        Me.bbtn.Size = New System.Drawing.Size(32, 125)
        Me.bbtn.TabIndex = 0
        Me.bbtn.UseVisualStyleBackColor = True
        '
        'abtn
        '
        Me.abtn.Location = New System.Drawing.Point(67, 25)
        Me.abtn.Name = "abtn"
        Me.abtn.Size = New System.Drawing.Size(125, 32)
        Me.abtn.TabIndex = 1
        Me.abtn.UseVisualStyleBackColor = True
        '
        'gbtn
        '
        Me.gbtn.Location = New System.Drawing.Point(67, 174)
        Me.gbtn.Name = "gbtn"
        Me.gbtn.Size = New System.Drawing.Size(125, 32)
        Me.gbtn.TabIndex = 1
        Me.gbtn.UseVisualStyleBackColor = True
        '
        'ebtn
        '
        Me.ebtn.Location = New System.Drawing.Point(36, 203)
        Me.ebtn.Name = "ebtn"
        Me.ebtn.Size = New System.Drawing.Size(32, 125)
        Me.ebtn.TabIndex = 0
        Me.ebtn.UseVisualStyleBackColor = True
        '
        'cbtn
        '
        Me.cbtn.Location = New System.Drawing.Point(191, 203)
        Me.cbtn.Name = "cbtn"
        Me.cbtn.Size = New System.Drawing.Size(32, 125)
        Me.cbtn.TabIndex = 0
        Me.cbtn.UseVisualStyleBackColor = True
        '
        'dbtn
        '
        Me.dbtn.Location = New System.Drawing.Point(67, 324)
        Me.dbtn.Name = "dbtn"
        Me.dbtn.Size = New System.Drawing.Size(125, 32)
        Me.dbtn.TabIndex = 1
        Me.dbtn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'startButton
        '
        Me.startButton.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.startButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.startButton.Location = New System.Drawing.Point(311, 113)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(95, 46)
        Me.startButton.TabIndex = 2
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = False
        '
        'stopButton
        '
        Me.stopButton.BackColor = System.Drawing.Color.Red
        Me.stopButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.stopButton.Location = New System.Drawing.Point(311, 183)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(95, 46)
        Me.stopButton.TabIndex = 3
        Me.stopButton.Text = "Stop"
        Me.stopButton.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Controls.Add(Me.stopButton)
        Me.GroupBox1.Controls.Add(Me.startButton)
        Me.GroupBox1.Controls.Add(Me.dbtn)
        Me.GroupBox1.Controls.Add(Me.gbtn)
        Me.GroupBox1.Controls.Add(Me.abtn)
        Me.GroupBox1.Controls.Add(Me.cbtn)
        Me.GroupBox1.Controls.Add(Me.ebtn)
        Me.GroupBox1.Controls.Add(Me.bbtn)
        Me.GroupBox1.Controls.Add(Me.fbtn)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 390)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 406)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fbtn As Button
    Friend WithEvents bbtn As Button
    Friend WithEvents abtn As Button
    Friend WithEvents gbtn As Button
    Friend WithEvents ebtn As Button
    Friend WithEvents cbtn As Button
    Friend WithEvents dbtn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents startButton As Button
    Friend WithEvents stopButton As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
