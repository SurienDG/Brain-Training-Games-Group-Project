<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScoreboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScoreboard))
        Me.lblEndScore = New System.Windows.Forms.Label()
        Me.lblScoreboard = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ptcIntro = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcIntro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEndScore
        '
        Me.lblEndScore.AutoSize = True
        Me.lblEndScore.BackColor = System.Drawing.Color.White
        Me.lblEndScore.Font = New System.Drawing.Font("Elephant", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndScore.Location = New System.Drawing.Point(268, 229)
        Me.lblEndScore.Name = "lblEndScore"
        Me.lblEndScore.Size = New System.Drawing.Size(253, 83)
        Me.lblEndScore.TabIndex = 6
        Me.lblEndScore.Text = "Label1"
        Me.lblEndScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScoreboard
        '
        Me.lblScoreboard.AutoSize = True
        Me.lblScoreboard.BackColor = System.Drawing.Color.White
        Me.lblScoreboard.Font = New System.Drawing.Font("Elephant", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreboard.Location = New System.Drawing.Point(35, 133)
        Me.lblScoreboard.Name = "lblScoreboard"
        Me.lblScoreboard.Size = New System.Drawing.Size(713, 82)
        Me.lblScoreboard.TabIndex = 7
        Me.lblScoreboard.Text = "Congratulations, you have finished the test!  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Here is your score!"
        Me.lblScoreboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(768, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'MainMenuToolStripMenuItem
        '
        Me.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.MainMenuToolStripMenuItem.Text = " Main Menu"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global._2048.My.Resources.Resources.congrats
        Me.PictureBox1.Location = New System.Drawing.Point(-57, 324)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(852, 292)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'ptcIntro
        '
        Me.ptcIntro.ErrorImage = CType(resources.GetObject("ptcIntro.ErrorImage"), System.Drawing.Image)
        Me.ptcIntro.Image = Global._2048.My.Resources.Resources.white_background
        Me.ptcIntro.InitialImage = CType(resources.GetObject("ptcIntro.InitialImage"), System.Drawing.Image)
        Me.ptcIntro.Location = New System.Drawing.Point(-2, -1)
        Me.ptcIntro.Name = "ptcIntro"
        Me.ptcIntro.Size = New System.Drawing.Size(772, 565)
        Me.ptcIntro.TabIndex = 5
        Me.ptcIntro.TabStop = False
        '
        'frmScoreboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblScoreboard)
        Me.Controls.Add(Me.lblEndScore)
        Me.Controls.Add(Me.ptcIntro)
        Me.Name = "frmScoreboard"
        Me.Text = "Scoreboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcIntro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ptcIntro As System.Windows.Forms.PictureBox
    Friend WithEvents lblEndScore As System.Windows.Forms.Label
    Friend WithEvents lblScoreboard As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
