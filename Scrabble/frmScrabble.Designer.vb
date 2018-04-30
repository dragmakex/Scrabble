<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScrabble
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
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.pic4 = New System.Windows.Forms.PictureBox()
        Me.pic5 = New System.Windows.Forms.PictureBox()
        Me.pic6 = New System.Windows.Forms.PictureBox()
        Me.pic7 = New System.Windows.Forms.PictureBox()
        Me.cmdCheck = New System.Windows.Forms.Button()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplaceTilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pic1
        '
        Me.pic1.Location = New System.Drawing.Point(28, 388)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(150, 150)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 0
        Me.pic1.TabStop = False
        '
        'pic2
        '
        Me.pic2.Location = New System.Drawing.Point(208, 388)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(150, 150)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 1
        Me.pic2.TabStop = False
        '
        'pic3
        '
        Me.pic3.Location = New System.Drawing.Point(397, 388)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(150, 150)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic3.TabIndex = 2
        Me.pic3.TabStop = False
        '
        'pic4
        '
        Me.pic4.Location = New System.Drawing.Point(587, 388)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(150, 150)
        Me.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic4.TabIndex = 3
        Me.pic4.TabStop = False
        '
        'pic5
        '
        Me.pic5.Location = New System.Drawing.Point(772, 388)
        Me.pic5.Name = "pic5"
        Me.pic5.Size = New System.Drawing.Size(150, 150)
        Me.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic5.TabIndex = 4
        Me.pic5.TabStop = False
        '
        'pic6
        '
        Me.pic6.Location = New System.Drawing.Point(957, 388)
        Me.pic6.Name = "pic6"
        Me.pic6.Size = New System.Drawing.Size(150, 150)
        Me.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic6.TabIndex = 5
        Me.pic6.TabStop = False
        '
        'pic7
        '
        Me.pic7.Location = New System.Drawing.Point(1145, 388)
        Me.pic7.Name = "pic7"
        Me.pic7.Size = New System.Drawing.Size(150, 150)
        Me.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic7.TabIndex = 6
        Me.pic7.TabStop = False
        '
        'cmdCheck
        '
        Me.cmdCheck.BackColor = System.Drawing.Color.DarkBlue
        Me.cmdCheck.ForeColor = System.Drawing.Color.White
        Me.cmdCheck.Location = New System.Drawing.Point(479, 254)
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.Size = New System.Drawing.Size(366, 60)
        Me.cmdCheck.TabIndex = 7
        Me.cmdCheck.Text = "Check the Word!"
        Me.cmdCheck.UseVisualStyleBackColor = False
        Me.cmdCheck.Visible = False
        '
        'lblWord
        '
        Me.lblWord.Font = New System.Drawing.Font("Modern No. 20", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWord.Location = New System.Drawing.Point(28, 55)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(1257, 62)
        Me.lblWord.TabIndex = 8
        Me.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1924, 28)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ReplaceTilesToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.GameToolStripMenuItem.Text = "Game"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ReplaceTilesToolStripMenuItem
        '
        Me.ReplaceTilesToolStripMenuItem.Name = "ReplaceTilesToolStripMenuItem"
        Me.ReplaceTilesToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.ReplaceTilesToolStripMenuItem.Text = "Replace Tiles"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 587)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 34)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Your Current Score"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Modern No. 20", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(135, 650)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(31, 34)
        Me.lblScore.TabIndex = 13
        Me.lblScore.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Modern No. 20", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(362, 587)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(245, 34)
        Me.lbl3.TabIndex = 15
        Me.lbl3.Text = "Time remaining"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(427, 650)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(41, 30)
        Me.lblTime.TabIndex = 16
        Me.lblTime.Text = "80"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(474, 649)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 30)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "s"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'frmScrabble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWord)
        Me.Controls.Add(Me.cmdCheck)
        Me.Controls.Add(Me.pic7)
        Me.Controls.Add(Me.pic6)
        Me.Controls.Add(Me.pic5)
        Me.Controls.Add(Me.pic4)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmScrabble"
        Me.Text = "frmScrabble"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic1 As PictureBox
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents pic3 As PictureBox
    Friend WithEvents pic4 As PictureBox
    Friend WithEvents pic5 As PictureBox
    Friend WithEvents pic6 As PictureBox
    Friend WithEvents pic7 As PictureBox
    Friend WithEvents cmdCheck As Button
    Friend WithEvents lblWord As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReplaceTilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl3 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer2 As Timer
End Class
