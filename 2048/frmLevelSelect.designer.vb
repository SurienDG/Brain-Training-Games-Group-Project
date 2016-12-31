<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevelSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLevelSelect))
        Me.ptcIntro = New System.Windows.Forms.PictureBox()
        Me.lblChooseLevel = New System.Windows.Forms.Label()
        Me.lblEasy = New System.Windows.Forms.Label()
        Me.lblHard = New System.Windows.Forms.Label()
        Me.cmdEasy = New System.Windows.Forms.Button()
        Me.cmdHard = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ptcIntro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ptcIntro
        '
        Me.ptcIntro.ErrorImage = CType(resources.GetObject("ptcIntro.ErrorImage"), System.Drawing.Image)
        Me.ptcIntro.Image = Global._2048.My.Resources.Resources.white_background
        Me.ptcIntro.InitialImage = CType(resources.GetObject("ptcIntro.InitialImage"), System.Drawing.Image)
        Me.ptcIntro.Location = New System.Drawing.Point(-2, -1)
        Me.ptcIntro.Name = "ptcIntro"
        Me.ptcIntro.Size = New System.Drawing.Size(772, 564)
        Me.ptcIntro.TabIndex = 5
        Me.ptcIntro.TabStop = False
        '
        'lblChooseLevel
        '
        Me.lblChooseLevel.AutoSize = True
        Me.lblChooseLevel.BackColor = System.Drawing.Color.White
        Me.lblChooseLevel.Font = New System.Drawing.Font("Elephant", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseLevel.Location = New System.Drawing.Point(87, 122)
        Me.lblChooseLevel.Name = "lblChooseLevel"
        Me.lblChooseLevel.Size = New System.Drawing.Size(601, 90)
        Me.lblChooseLevel.TabIndex = 6
        Me.lblChooseLevel.Text = "Please Choose the Difficulty You " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wish to Play" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblChooseLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEasy
        '
        Me.lblEasy.AutoSize = True
        Me.lblEasy.BackColor = System.Drawing.Color.White
        Me.lblEasy.Font = New System.Drawing.Font("Elephant", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEasy.Location = New System.Drawing.Point(202, 278)
        Me.lblEasy.Name = "lblEasy"
        Me.lblEasy.Size = New System.Drawing.Size(105, 45)
        Me.lblEasy.TabIndex = 7
        Me.lblEasy.Text = "Easy"
        Me.lblEasy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHard
        '
        Me.lblHard.AutoSize = True
        Me.lblHard.BackColor = System.Drawing.Color.White
        Me.lblHard.Font = New System.Drawing.Font("Elephant", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHard.Location = New System.Drawing.Point(451, 278)
        Me.lblHard.Name = "lblHard"
        Me.lblHard.Size = New System.Drawing.Size(115, 45)
        Me.lblHard.TabIndex = 8
        Me.lblHard.Text = "Hard" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblHard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdEasy
        '
        Me.cmdEasy.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEasy.Location = New System.Drawing.Point(215, 336)
        Me.cmdEasy.Name = "cmdEasy"
        Me.cmdEasy.Size = New System.Drawing.Size(75, 23)
        Me.cmdEasy.TabIndex = 9
        Me.cmdEasy.Text = "Click Me!"
        Me.cmdEasy.UseVisualStyleBackColor = True
        '
        'cmdHard
        '
        Me.cmdHard.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHard.Location = New System.Drawing.Point(471, 336)
        Me.cmdHard.Name = "cmdHard"
        Me.cmdHard.Size = New System.Drawing.Size(75, 23)
        Me.cmdHard.TabIndex = 10
        Me.cmdHard.Text = "Click Me!"
        Me.cmdHard.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(768, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmLevelSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cmdHard)
        Me.Controls.Add(Me.cmdEasy)
        Me.Controls.Add(Me.lblHard)
        Me.Controls.Add(Me.lblEasy)
        Me.Controls.Add(Me.lblChooseLevel)
        Me.Controls.Add(Me.ptcIntro)
        Me.Name = "frmLevelSelect"
        Me.Text = "Select Level"
        CType(Me.ptcIntro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ptcIntro As System.Windows.Forms.PictureBox
    Friend WithEvents lblChooseLevel As System.Windows.Forms.Label
    Friend WithEvents lblEasy As System.Windows.Forms.Label
    Friend WithEvents lblHard As System.Windows.Forms.Label
    Friend WithEvents cmdEasy As System.Windows.Forms.Button
    Friend WithEvents cmdHard As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
