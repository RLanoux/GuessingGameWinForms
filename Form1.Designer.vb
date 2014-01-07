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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSetHighValue = New System.Windows.Forms.Button()
        Me.cboHighValue = New System.Windows.Forms.ComboBox()
        Me.lblHighValue = New System.Windows.Forms.Label()
        Me.tslGuesses = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtGuess
        '
        Me.txtGuess.Location = New System.Drawing.Point(116, 57)
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(98, 20)
        Me.txtGuess.TabIndex = 2
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 87)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(98, 30)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslStatus, Me.tslGuesses})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 138)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(434, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslStatus
        '
        Me.tslStatus.Name = "tslStatus"
        Me.tslStatus.Size = New System.Drawing.Size(42, 17)
        Me.tslStatus.Text = "Ready!"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(220, 51)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(98, 30)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit &Guess"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(116, 87)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(98, 30)
        Me.btnRestart.TabIndex = 5
        Me.btnRestart.Text = "&Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(220, 87)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(98, 30)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "I &Quit!"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(324, 87)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 30)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(9, 60)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(89, 13)
        Me.lbl1.TabIndex = 7
        Me.lbl1.Text = "Enter your guess:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(324, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 69)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnSetHighValue
        '
        Me.btnSetHighValue.Location = New System.Drawing.Point(220, 12)
        Me.btnSetHighValue.Name = "btnSetHighValue"
        Me.btnSetHighValue.Size = New System.Drawing.Size(98, 30)
        Me.btnSetHighValue.TabIndex = 1
        Me.btnSetHighValue.Text = "Set High &Value"
        Me.btnSetHighValue.UseVisualStyleBackColor = True
        '
        'cboHighValue
        '
        Me.cboHighValue.FormattingEnabled = True
        Me.cboHighValue.Items.AddRange(New Object() {"1000", "10,000", "100,000", "1,000,000"})
        Me.cboHighValue.Location = New System.Drawing.Point(116, 18)
        Me.cboHighValue.Name = "cboHighValue"
        Me.cboHighValue.Size = New System.Drawing.Size(98, 21)
        Me.cboHighValue.TabIndex = 0
        Me.cboHighValue.Text = "(Select one.)"
        '
        'lblHighValue
        '
        Me.lblHighValue.AutoSize = True
        Me.lblHighValue.Location = New System.Drawing.Point(12, 21)
        Me.lblHighValue.Name = "lblHighValue"
        Me.lblHighValue.Size = New System.Drawing.Size(73, 13)
        Me.lblHighValue.TabIndex = 11
        Me.lblHighValue.Text = "Set the value:"
        '
        'tslGuesses
        '
        Me.tslGuesses.Name = "tslGuesses"
        Me.tslGuesses.Size = New System.Drawing.Size(0, 17)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 160)
        Me.Controls.Add(Me.lblHighValue)
        Me.Controls.Add(Me.cboHighValue)
        Me.Controls.Add(Me.btnSetHighValue)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtGuess)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Guessing Game"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGuess As System.Windows.Forms.TextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tslStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSetHighValue As System.Windows.Forms.Button
    Friend WithEvents cboHighValue As System.Windows.Forms.ComboBox
    Friend WithEvents lblHighValue As System.Windows.Forms.Label
    Friend WithEvents tslGuesses As System.Windows.Forms.ToolStripStatusLabel

End Class
