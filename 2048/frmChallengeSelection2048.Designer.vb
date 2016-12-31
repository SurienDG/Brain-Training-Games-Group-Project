<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChallengeSelection2048
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChallengeSelection2048))
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSelector = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuContent = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdGet2And16 = New System.Windows.Forms.Button()
        Me.cmdGet1And16 = New System.Windows.Forms.Button()
        Me.cmdGet3And8 = New System.Windows.Forms.Button()
        Me.cmdGet2And8 = New System.Windows.Forms.Button()
        Me.cmdGet1And8 = New System.Windows.Forms.Button()
        Me.ptcBackground = New System.Windows.Forms.PictureBox()
        Me.mnuMainMenu = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuStrip.TabIndex = 7
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit, Me.mnuMainMenu, Me.mnuSelector})
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
        'mnuSelector
        '
        Me.mnuSelector.Name = "mnuSelector"
        Me.mnuSelector.Size = New System.Drawing.Size(152, 22)
        Me.mnuSelector.Text = "Selector"
        '
        'mnuContent
        '
        Me.mnuContent.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
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
        'cmdGet2And16
        '
        Me.cmdGet2And16.Image = CType(resources.GetObject("cmdGet2And16.Image"), System.Drawing.Image)
        Me.cmdGet2And16.Location = New System.Drawing.Point(451, 333)
        Me.cmdGet2And16.Name = "cmdGet2And16"
        Me.cmdGet2And16.Size = New System.Drawing.Size(89, 128)
        Me.cmdGet2And16.TabIndex = 5
        Me.cmdGet2And16.UseVisualStyleBackColor = True
        '
        'cmdGet1And16
        '
        Me.cmdGet1And16.Image = CType(resources.GetObject("cmdGet1And16.Image"), System.Drawing.Image)
        Me.cmdGet1And16.Location = New System.Drawing.Point(276, 333)
        Me.cmdGet1And16.Name = "cmdGet1And16"
        Me.cmdGet1And16.Size = New System.Drawing.Size(89, 128)
        Me.cmdGet1And16.TabIndex = 4
        Me.cmdGet1And16.UseVisualStyleBackColor = True
        '
        'cmdGet3And8
        '
        Me.cmdGet3And8.Image = CType(resources.GetObject("cmdGet3And8.Image"), System.Drawing.Image)
        Me.cmdGet3And8.Location = New System.Drawing.Point(362, 213)
        Me.cmdGet3And8.Name = "cmdGet3And8"
        Me.cmdGet3And8.Size = New System.Drawing.Size(89, 124)
        Me.cmdGet3And8.TabIndex = 3
        Me.cmdGet3And8.UseVisualStyleBackColor = True
        '
        'cmdGet2And8
        '
        Me.cmdGet2And8.Image = CType(resources.GetObject("cmdGet2And8.Image"), System.Drawing.Image)
        Me.cmdGet2And8.Location = New System.Drawing.Point(450, 101)
        Me.cmdGet2And8.Name = "cmdGet2And8"
        Me.cmdGet2And8.Size = New System.Drawing.Size(89, 119)
        Me.cmdGet2And8.TabIndex = 2
        Me.cmdGet2And8.UseVisualStyleBackColor = True
        '
        'cmdGet1And8
        '
        Me.cmdGet1And8.Image = CType(resources.GetObject("cmdGet1And8.Image"), System.Drawing.Image)
        Me.cmdGet1And8.Location = New System.Drawing.Point(276, 101)
        Me.cmdGet1And8.Name = "cmdGet1And8"
        Me.cmdGet1And8.Size = New System.Drawing.Size(89, 119)
        Me.cmdGet1And8.TabIndex = 1
        Me.cmdGet1And8.UseVisualStyleBackColor = True
        '
        'ptcBackground
        '
        Me.ptcBackground.BackColor = System.Drawing.Color.Transparent
        Me.ptcBackground.Image = Global._2048.My.Resources.Resources.BackGroundForChallengeMode2
        Me.ptcBackground.Location = New System.Drawing.Point(-14, 0)
        Me.ptcBackground.Name = "ptcBackground"
        Me.ptcBackground.Size = New System.Drawing.Size(798, 568)
        Me.ptcBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBackground.TabIndex = 6
        Me.ptcBackground.TabStop = False
        '
        'mnuMainMenu
        '
        Me.mnuMainMenu.Name = "mnuMainMenu"
        Me.mnuMainMenu.Size = New System.Drawing.Size(152, 22)
        Me.mnuMainMenu.Text = "Main Menu"
        '
        'frmChallengeSelection2048
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdGet2And16)
        Me.Controls.Add(Me.cmdGet1And16)
        Me.Controls.Add(Me.cmdGet3And8)
        Me.Controls.Add(Me.cmdGet2And8)
        Me.Controls.Add(Me.cmdGet1And8)
        Me.Controls.Add(Me.mnuStrip)
        Me.Controls.Add(Me.ptcBackground)
        Me.Name = "frmChallengeSelection2048"
        Me.Text = "Challenge Selector"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        CType(Me.ptcBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuContent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ptcBackground As System.Windows.Forms.PictureBox
    Friend WithEvents cmdGet1And8 As System.Windows.Forms.Button
    Friend WithEvents cmdGet2And8 As System.Windows.Forms.Button
    Friend WithEvents cmdGet3And8 As System.Windows.Forms.Button
    Friend WithEvents cmdGet1And16 As System.Windows.Forms.Button
    Friend WithEvents cmdGet2And16 As System.Windows.Forms.Button
    Friend WithEvents mnuSelector As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMainMenu As System.Windows.Forms.ToolStripMenuItem
End Class
