<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStartScreen2048
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
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuContent = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInstructions = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.cmdNormalMode = New System.Windows.Forms.Button()
        Me.cmdChallengeMode = New System.Windows.Forms.Button()
        Me.ptcBackground = New System.Windows.Forms.PictureBox()
        Me.mnuStrip.SuspendLayout()
        CType(Me.ptcBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuContent})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(784, 24)
        Me.mnuStrip.TabIndex = 5
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuContent
        '
        Me.mnuContent.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout, Me.mnuInstructions})
        Me.mnuContent.Name = "mnuContent"
        Me.mnuContent.Size = New System.Drawing.Size(62, 20)
        Me.mnuContent.Text = "&Content"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(152, 22)
        Me.mnuAbout.Text = "About"
        '
        'mnuInstructions
        '
        Me.mnuInstructions.Name = "mnuInstructions"
        Me.mnuInstructions.Size = New System.Drawing.Size(152, 22)
        Me.mnuInstructions.Text = "Instructions"
        '
        'cmdBack
        '
        Me.cmdBack.Font = New System.Drawing.Font("Elephant", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdBack.Location = New System.Drawing.Point(613, 506)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(159, 43)
        Me.cmdBack.TabIndex = 3
        Me.cmdBack.Text = "Main "
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'cmdNormalMode
        '
        Me.cmdNormalMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNormalMode.Image = Global._2048.My.Resources.Resources.NormalModeButton1
        Me.cmdNormalMode.Location = New System.Drawing.Point(480, 347)
        Me.cmdNormalMode.Name = "cmdNormalMode"
        Me.cmdNormalMode.Size = New System.Drawing.Size(250, 138)
        Me.cmdNormalMode.TabIndex = 2
        Me.cmdNormalMode.UseVisualStyleBackColor = True
        '
        'cmdChallengeMode
        '
        Me.cmdChallengeMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdChallengeMode.Image = Global._2048.My.Resources.Resources.ChallengeModeButton4
        Me.cmdChallengeMode.Location = New System.Drawing.Point(57, 347)
        Me.cmdChallengeMode.Name = "cmdChallengeMode"
        Me.cmdChallengeMode.Size = New System.Drawing.Size(251, 138)
        Me.cmdChallengeMode.TabIndex = 1
        Me.cmdChallengeMode.Text = "Button1"
        Me.cmdChallengeMode.UseVisualStyleBackColor = True
        '
        'ptcBackground
        '
        Me.ptcBackground.BackColor = System.Drawing.Color.Transparent
        Me.ptcBackground.Image = Global._2048.My.Resources.Resources.StartScreen5
        Me.ptcBackground.Location = New System.Drawing.Point(-7, 1)
        Me.ptcBackground.Name = "ptcBackground"
        Me.ptcBackground.Size = New System.Drawing.Size(798, 568)
        Me.ptcBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBackground.TabIndex = 0
        Me.ptcBackground.TabStop = False
        '
        'frmStartScreen2048
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.mnuStrip)
        Me.Controls.Add(Me.cmdNormalMode)
        Me.Controls.Add(Me.cmdChallengeMode)
        Me.Controls.Add(Me.ptcBackground)
        Me.Name = "frmStartScreen2048"
        Me.Text = "2048 Game"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        CType(Me.ptcBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ptcBackground As System.Windows.Forms.PictureBox
    Friend WithEvents cmdChallengeMode As System.Windows.Forms.Button
    Friend WithEvents cmdNormalMode As System.Windows.Forms.Button
    Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuContent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents mnuInstructions As System.Windows.Forms.ToolStripMenuItem
End Class
