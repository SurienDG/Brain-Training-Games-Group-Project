<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNormal2048
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
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblScoreValue = New System.Windows.Forms.Label()
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuContent = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInstructions = New System.Windows.Forms.ToolStripMenuItem()
        Me.ptcBlankSquare4 = New System.Windows.Forms.PictureBox()
        Me.ptcBlankSquare3 = New System.Windows.Forms.PictureBox()
        Me.ptcBlankSquare2 = New System.Windows.Forms.PictureBox()
        Me.ptcBlankSquare8 = New System.Windows.Forms.PictureBox()
        Me.ptcBlankSquare7 = New System.Windows.Forms.PictureBox()
        Me.ptcBlankSquare12 = New System.Windows.Forms.PictureBox()
        Me.ptcBlankSquare11 = New System.Windows.Forms.PictureBox()
        Me.ptcBlankSquare10 = New System.Windows.Forms.PictureBox()
        Me.ptcBlankSquare16 = New System.Windows.Forms.PictureBox()
        Me.ptcBlankSquare15 = New System.Windows.Forms.PictureBox()
        Me.ptcBlankSquare14 = New System.Windows.Forms.PictureBox()
        Me.ptcBlankSquare13 = New System.Windows.Forms.PictureBox()
        Me.ptcBlankSquare9 = New System.Windows.Forms.PictureBox()
        Me.ptcBlankSquare6 = New System.Windows.Forms.PictureBox()
        Me.ptcBlankSquare5 = New System.Windows.Forms.PictureBox()
        Me.ptcBlank = New System.Windows.Forms.PictureBox()
        Me.ptcBlankSquare1 = New System.Windows.Forms.PictureBox()
        Me.ptc2 = New System.Windows.Forms.PictureBox()
        Me.ptc4 = New System.Windows.Forms.PictureBox()
        Me.ptc8 = New System.Windows.Forms.PictureBox()
        Me.ptc16 = New System.Windows.Forms.PictureBox()
        Me.ptc32 = New System.Windows.Forms.PictureBox()
        Me.ptc64 = New System.Windows.Forms.PictureBox()
        Me.ptc128 = New System.Windows.Forms.PictureBox()
        Me.ptc256 = New System.Windows.Forms.PictureBox()
        Me.ptc512 = New System.Windows.Forms.PictureBox()
        Me.ptc1024 = New System.Windows.Forms.PictureBox()
        Me.ptc2048 = New System.Windows.Forms.PictureBox()
        Me.ptcBackground = New System.Windows.Forms.PictureBox()
        Me.mnuSelector = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStrip.SuspendLayout()
        CType(Me.ptcBlankSquare4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcBlankSquare3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcBlankSquare2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcBlankSquare8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcBlankSquare7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcBlankSquare12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcBlankSquare11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcBlankSquare10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcBlankSquare16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcBlankSquare15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcBlankSquare14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcBlankSquare13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcBlankSquare9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcBlankSquare6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcBlankSquare5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcBlank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcBlankSquare1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptc2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptc4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptc8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptc16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptc32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptc64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptc128, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptc256, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptc512, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptc1024, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptc2048, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lblScore.Location = New System.Drawing.Point(788, 29)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(90, 31)
        Me.lblScore.TabIndex = 3
        Me.lblScore.Text = "Score:"
        '
        'lblScoreValue
        '
        Me.lblScoreValue.AutoSize = True
        Me.lblScoreValue.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreValue.Location = New System.Drawing.Point(869, 30)
        Me.lblScoreValue.Name = "lblScoreValue"
        Me.lblScoreValue.Size = New System.Drawing.Size(32, 31)
        Me.lblScoreValue.TabIndex = 3
        Me.lblScoreValue.Text = "0"
        '
        'mnuStrip
        '
        Me.mnuStrip.AutoSize = False
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuContent})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(984, 24)
        Me.mnuStrip.TabIndex = 5
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit, Me.MainMenuToolStripMenuItem, Me.mnuSelector})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(135, 22)
        Me.mnuExit.Text = "Exit"
        '
        'MainMenuToolStripMenuItem
        '
        Me.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.MainMenuToolStripMenuItem.Text = "Main Menu"
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
        Me.mnuAbout.Size = New System.Drawing.Size(136, 22)
        Me.mnuAbout.Text = "About"
        '
        'mnuInstructions
        '
        Me.mnuInstructions.Name = "mnuInstructions"
        Me.mnuInstructions.Size = New System.Drawing.Size(136, 22)
        Me.mnuInstructions.Text = "Instructions"
        '
        'ptcBlankSquare4
        '
        Me.ptcBlankSquare4.Image = Global._2048.My.Resources.Resources.Blank_Square
        Me.ptcBlankSquare4.Location = New System.Drawing.Point(592, 27)
        Me.ptcBlankSquare4.Name = "ptcBlankSquare4"
        Me.ptcBlankSquare4.Size = New System.Drawing.Size(167, 114)
        Me.ptcBlankSquare4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBlankSquare4.TabIndex = 2
        Me.ptcBlankSquare4.TabStop = False
        '
        'ptcBlankSquare3
        '
        Me.ptcBlankSquare3.Image = Global._2048.My.Resources.Resources.Blank_Square
        Me.ptcBlankSquare3.Location = New System.Drawing.Point(403, 27)
        Me.ptcBlankSquare3.Name = "ptcBlankSquare3"
        Me.ptcBlankSquare3.Size = New System.Drawing.Size(167, 114)
        Me.ptcBlankSquare3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBlankSquare3.TabIndex = 2
        Me.ptcBlankSquare3.TabStop = False
        '
        'ptcBlankSquare2
        '
        Me.ptcBlankSquare2.Image = Global._2048.My.Resources.Resources.Blank_Square
        Me.ptcBlankSquare2.Location = New System.Drawing.Point(214, 27)
        Me.ptcBlankSquare2.Name = "ptcBlankSquare2"
        Me.ptcBlankSquare2.Size = New System.Drawing.Size(167, 114)
        Me.ptcBlankSquare2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBlankSquare2.TabIndex = 2
        Me.ptcBlankSquare2.TabStop = False
        '
        'ptcBlankSquare8
        '
        Me.ptcBlankSquare8.Image = Global._2048.My.Resources.Resources.Blank_Square
        Me.ptcBlankSquare8.Location = New System.Drawing.Point(592, 158)
        Me.ptcBlankSquare8.Name = "ptcBlankSquare8"
        Me.ptcBlankSquare8.Size = New System.Drawing.Size(167, 114)
        Me.ptcBlankSquare8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBlankSquare8.TabIndex = 2
        Me.ptcBlankSquare8.TabStop = False
        '
        'ptcBlankSquare7
        '
        Me.ptcBlankSquare7.Image = Global._2048.My.Resources.Resources.Blank_Square
        Me.ptcBlankSquare7.Location = New System.Drawing.Point(403, 158)
        Me.ptcBlankSquare7.Name = "ptcBlankSquare7"
        Me.ptcBlankSquare7.Size = New System.Drawing.Size(167, 114)
        Me.ptcBlankSquare7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBlankSquare7.TabIndex = 2
        Me.ptcBlankSquare7.TabStop = False
        '
        'ptcBlankSquare12
        '
        Me.ptcBlankSquare12.Image = Global._2048.My.Resources.Resources.Blank_Square
        Me.ptcBlankSquare12.Location = New System.Drawing.Point(592, 289)
        Me.ptcBlankSquare12.Name = "ptcBlankSquare12"
        Me.ptcBlankSquare12.Size = New System.Drawing.Size(167, 114)
        Me.ptcBlankSquare12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBlankSquare12.TabIndex = 2
        Me.ptcBlankSquare12.TabStop = False
        '
        'ptcBlankSquare11
        '
        Me.ptcBlankSquare11.Image = Global._2048.My.Resources.Resources.Blank_Square
        Me.ptcBlankSquare11.Location = New System.Drawing.Point(403, 289)
        Me.ptcBlankSquare11.Name = "ptcBlankSquare11"
        Me.ptcBlankSquare11.Size = New System.Drawing.Size(167, 114)
        Me.ptcBlankSquare11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBlankSquare11.TabIndex = 2
        Me.ptcBlankSquare11.TabStop = False
        '
        'ptcBlankSquare10
        '
        Me.ptcBlankSquare10.Image = Global._2048.My.Resources.Resources.Blank_Square
        Me.ptcBlankSquare10.Location = New System.Drawing.Point(214, 289)
        Me.ptcBlankSquare10.Name = "ptcBlankSquare10"
        Me.ptcBlankSquare10.Size = New System.Drawing.Size(167, 114)
        Me.ptcBlankSquare10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBlankSquare10.TabIndex = 2
        Me.ptcBlankSquare10.TabStop = False
        '
        'ptcBlankSquare16
        '
        Me.ptcBlankSquare16.Image = Global._2048.My.Resources.Resources.Blank_Square
        Me.ptcBlankSquare16.Location = New System.Drawing.Point(592, 419)
        Me.ptcBlankSquare16.Name = "ptcBlankSquare16"
        Me.ptcBlankSquare16.Size = New System.Drawing.Size(167, 114)
        Me.ptcBlankSquare16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBlankSquare16.TabIndex = 2
        Me.ptcBlankSquare16.TabStop = False
        '
        'ptcBlankSquare15
        '
        Me.ptcBlankSquare15.Image = Global._2048.My.Resources.Resources.Blank_Square
        Me.ptcBlankSquare15.Location = New System.Drawing.Point(403, 419)
        Me.ptcBlankSquare15.Name = "ptcBlankSquare15"
        Me.ptcBlankSquare15.Size = New System.Drawing.Size(167, 114)
        Me.ptcBlankSquare15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBlankSquare15.TabIndex = 2
        Me.ptcBlankSquare15.TabStop = False
        '
        'ptcBlankSquare14
        '
        Me.ptcBlankSquare14.Image = Global._2048.My.Resources.Resources.Blank_Square
        Me.ptcBlankSquare14.Location = New System.Drawing.Point(214, 419)
        Me.ptcBlankSquare14.Name = "ptcBlankSquare14"
        Me.ptcBlankSquare14.Size = New System.Drawing.Size(167, 114)
        Me.ptcBlankSquare14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBlankSquare14.TabIndex = 2
        Me.ptcBlankSquare14.TabStop = False
        '
        'ptcBlankSquare13
        '
        Me.ptcBlankSquare13.Image = Global._2048.My.Resources.Resources.Blank_Square
        Me.ptcBlankSquare13.Location = New System.Drawing.Point(26, 419)
        Me.ptcBlankSquare13.Name = "ptcBlankSquare13"
        Me.ptcBlankSquare13.Size = New System.Drawing.Size(167, 114)
        Me.ptcBlankSquare13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBlankSquare13.TabIndex = 2
        Me.ptcBlankSquare13.TabStop = False
        '
        'ptcBlankSquare9
        '
        Me.ptcBlankSquare9.Image = Global._2048.My.Resources.Resources.Blank_Square
        Me.ptcBlankSquare9.Location = New System.Drawing.Point(26, 289)
        Me.ptcBlankSquare9.Name = "ptcBlankSquare9"
        Me.ptcBlankSquare9.Size = New System.Drawing.Size(167, 114)
        Me.ptcBlankSquare9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBlankSquare9.TabIndex = 2
        Me.ptcBlankSquare9.TabStop = False
        '
        'ptcBlankSquare6
        '
        Me.ptcBlankSquare6.Image = Global._2048.My.Resources.Resources.Blank_Square
        Me.ptcBlankSquare6.Location = New System.Drawing.Point(214, 159)
        Me.ptcBlankSquare6.Name = "ptcBlankSquare6"
        Me.ptcBlankSquare6.Size = New System.Drawing.Size(167, 114)
        Me.ptcBlankSquare6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBlankSquare6.TabIndex = 2
        Me.ptcBlankSquare6.TabStop = False
        '
        'ptcBlankSquare5
        '
        Me.ptcBlankSquare5.Image = Global._2048.My.Resources.Resources.Blank_Square
        Me.ptcBlankSquare5.Location = New System.Drawing.Point(26, 159)
        Me.ptcBlankSquare5.Name = "ptcBlankSquare5"
        Me.ptcBlankSquare5.Size = New System.Drawing.Size(167, 114)
        Me.ptcBlankSquare5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBlankSquare5.TabIndex = 2
        Me.ptcBlankSquare5.TabStop = False
        '
        'ptcBlank
        '
        Me.ptcBlank.Image = Global._2048.My.Resources.Resources.Blank_Square
        Me.ptcBlank.Location = New System.Drawing.Point(805, 435)
        Me.ptcBlank.Name = "ptcBlank"
        Me.ptcBlank.Size = New System.Drawing.Size(167, 114)
        Me.ptcBlank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBlank.TabIndex = 2
        Me.ptcBlank.TabStop = False
        Me.ptcBlank.Visible = False
        '
        'ptcBlankSquare1
        '
        Me.ptcBlankSquare1.Image = Global._2048.My.Resources.Resources.Blank_Square
        Me.ptcBlankSquare1.Location = New System.Drawing.Point(26, 27)
        Me.ptcBlankSquare1.Name = "ptcBlankSquare1"
        Me.ptcBlankSquare1.Size = New System.Drawing.Size(167, 114)
        Me.ptcBlankSquare1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBlankSquare1.TabIndex = 2
        Me.ptcBlankSquare1.TabStop = False
        '
        'ptc2
        '
        Me.ptc2.Image = Global._2048.My.Resources.Resources._2
        Me.ptc2.Location = New System.Drawing.Point(403, 288)
        Me.ptc2.Name = "ptc2"
        Me.ptc2.Size = New System.Drawing.Size(167, 114)
        Me.ptc2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptc2.TabIndex = 1
        Me.ptc2.TabStop = False
        '
        'ptc4
        '
        Me.ptc4.Image = Global._2048.My.Resources.Resources._4
        Me.ptc4.Location = New System.Drawing.Point(214, 288)
        Me.ptc4.Name = "ptc4"
        Me.ptc4.Size = New System.Drawing.Size(167, 114)
        Me.ptc4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptc4.TabIndex = 1
        Me.ptc4.TabStop = False
        '
        'ptc8
        '
        Me.ptc8.Image = Global._2048.My.Resources.Resources._8
        Me.ptc8.Location = New System.Drawing.Point(26, 289)
        Me.ptc8.Name = "ptc8"
        Me.ptc8.Size = New System.Drawing.Size(167, 114)
        Me.ptc8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptc8.TabIndex = 1
        Me.ptc8.TabStop = False
        '
        'ptc16
        '
        Me.ptc16.Image = Global._2048.My.Resources.Resources._16
        Me.ptc16.Location = New System.Drawing.Point(592, 158)
        Me.ptc16.Name = "ptc16"
        Me.ptc16.Size = New System.Drawing.Size(167, 114)
        Me.ptc16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptc16.TabIndex = 1
        Me.ptc16.TabStop = False
        '
        'ptc32
        '
        Me.ptc32.Image = Global._2048.My.Resources.Resources._321
        Me.ptc32.Location = New System.Drawing.Point(403, 158)
        Me.ptc32.Name = "ptc32"
        Me.ptc32.Size = New System.Drawing.Size(167, 114)
        Me.ptc32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptc32.TabIndex = 1
        Me.ptc32.TabStop = False
        '
        'ptc64
        '
        Me.ptc64.Image = Global._2048.My.Resources.Resources._641
        Me.ptc64.Location = New System.Drawing.Point(214, 159)
        Me.ptc64.Name = "ptc64"
        Me.ptc64.Size = New System.Drawing.Size(167, 114)
        Me.ptc64.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptc64.TabIndex = 1
        Me.ptc64.TabStop = False
        '
        'ptc128
        '
        Me.ptc128.Image = Global._2048.My.Resources.Resources._1281
        Me.ptc128.Location = New System.Drawing.Point(26, 159)
        Me.ptc128.Name = "ptc128"
        Me.ptc128.Size = New System.Drawing.Size(167, 114)
        Me.ptc128.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptc128.TabIndex = 1
        Me.ptc128.TabStop = False
        '
        'ptc256
        '
        Me.ptc256.Image = Global._2048.My.Resources.Resources._2561
        Me.ptc256.Location = New System.Drawing.Point(592, 27)
        Me.ptc256.Name = "ptc256"
        Me.ptc256.Size = New System.Drawing.Size(167, 114)
        Me.ptc256.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptc256.TabIndex = 1
        Me.ptc256.TabStop = False
        '
        'ptc512
        '
        Me.ptc512.Image = Global._2048.My.Resources.Resources._5121
        Me.ptc512.Location = New System.Drawing.Point(403, 27)
        Me.ptc512.Name = "ptc512"
        Me.ptc512.Size = New System.Drawing.Size(167, 114)
        Me.ptc512.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptc512.TabIndex = 1
        Me.ptc512.TabStop = False
        '
        'ptc1024
        '
        Me.ptc1024.Image = Global._2048.My.Resources.Resources._10241
        Me.ptc1024.Location = New System.Drawing.Point(214, 27)
        Me.ptc1024.Name = "ptc1024"
        Me.ptc1024.Size = New System.Drawing.Size(167, 114)
        Me.ptc1024.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptc1024.TabIndex = 1
        Me.ptc1024.TabStop = False
        '
        'ptc2048
        '
        Me.ptc2048.Image = Global._2048.My.Resources.Resources._20481
        Me.ptc2048.Location = New System.Drawing.Point(26, 27)
        Me.ptc2048.Name = "ptc2048"
        Me.ptc2048.Size = New System.Drawing.Size(167, 114)
        Me.ptc2048.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptc2048.TabIndex = 1
        Me.ptc2048.TabStop = False
        '
        'ptcBackground
        '
        Me.ptcBackground.Image = Global._2048.My.Resources.Resources.board
        Me.ptcBackground.Location = New System.Drawing.Point(-6, 0)
        Me.ptcBackground.Name = "ptcBackground"
        Me.ptcBackground.Size = New System.Drawing.Size(794, 566)
        Me.ptcBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBackground.TabIndex = 0
        Me.ptcBackground.TabStop = False
        '
        'mnuSelector
        '
        Me.mnuSelector.Name = "mnuSelector"
        Me.mnuSelector.Size = New System.Drawing.Size(152, 22)
        Me.mnuSelector.Text = "Selector"
        '
        'frmNormal2048
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.mnuStrip)
        Me.Controls.Add(Me.lblScoreValue)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.ptcBlankSquare4)
        Me.Controls.Add(Me.ptcBlankSquare3)
        Me.Controls.Add(Me.ptcBlankSquare2)
        Me.Controls.Add(Me.ptcBlankSquare8)
        Me.Controls.Add(Me.ptcBlankSquare7)
        Me.Controls.Add(Me.ptcBlankSquare12)
        Me.Controls.Add(Me.ptcBlankSquare11)
        Me.Controls.Add(Me.ptcBlankSquare10)
        Me.Controls.Add(Me.ptcBlankSquare16)
        Me.Controls.Add(Me.ptcBlankSquare15)
        Me.Controls.Add(Me.ptcBlankSquare14)
        Me.Controls.Add(Me.ptcBlankSquare13)
        Me.Controls.Add(Me.ptcBlankSquare9)
        Me.Controls.Add(Me.ptcBlankSquare6)
        Me.Controls.Add(Me.ptcBlankSquare5)
        Me.Controls.Add(Me.ptcBlank)
        Me.Controls.Add(Me.ptcBlankSquare1)
        Me.Controls.Add(Me.ptc2)
        Me.Controls.Add(Me.ptc4)
        Me.Controls.Add(Me.ptc8)
        Me.Controls.Add(Me.ptc16)
        Me.Controls.Add(Me.ptc32)
        Me.Controls.Add(Me.ptc64)
        Me.Controls.Add(Me.ptc128)
        Me.Controls.Add(Me.ptc256)
        Me.Controls.Add(Me.ptc512)
        Me.Controls.Add(Me.ptc1024)
        Me.Controls.Add(Me.ptc2048)
        Me.Controls.Add(Me.ptcBackground)
        Me.KeyPreview = True
        Me.Name = "frmNormal2048"
        Me.Text = "Normal 2048"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        CType(Me.ptcBlankSquare4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcBlankSquare3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcBlankSquare2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcBlankSquare8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcBlankSquare7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcBlankSquare12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcBlankSquare11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcBlankSquare10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcBlankSquare16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcBlankSquare15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcBlankSquare14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcBlankSquare13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcBlankSquare9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcBlankSquare6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcBlankSquare5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcBlank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcBlankSquare1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptc2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptc4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptc8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptc16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptc32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptc64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptc128, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptc256, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptc512, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptc1024, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptc2048, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ptcBackground As System.Windows.Forms.PictureBox
    Friend WithEvents ptc2048 As System.Windows.Forms.PictureBox
    Friend WithEvents ptc1024 As System.Windows.Forms.PictureBox
    Friend WithEvents ptc512 As System.Windows.Forms.PictureBox
    Friend WithEvents ptc256 As System.Windows.Forms.PictureBox
    Friend WithEvents ptc128 As System.Windows.Forms.PictureBox
    Friend WithEvents ptc64 As System.Windows.Forms.PictureBox
    Friend WithEvents ptc32 As System.Windows.Forms.PictureBox
    Friend WithEvents ptc16 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ptc8 As System.Windows.Forms.PictureBox
    Friend WithEvents ptc4 As System.Windows.Forms.PictureBox
    Friend WithEvents ptc2 As System.Windows.Forms.PictureBox
    Friend WithEvents ptcBlankSquare1 As System.Windows.Forms.PictureBox
    Friend WithEvents ptcBlankSquare2 As System.Windows.Forms.PictureBox
    Friend WithEvents ptcBlankSquare3 As System.Windows.Forms.PictureBox
    Friend WithEvents ptcBlankSquare4 As System.Windows.Forms.PictureBox
    Friend WithEvents ptcBlankSquare5 As System.Windows.Forms.PictureBox
    Friend WithEvents ptcBlankSquare6 As System.Windows.Forms.PictureBox
    Friend WithEvents ptcBlankSquare7 As System.Windows.Forms.PictureBox
    Friend WithEvents ptcBlankSquare8 As System.Windows.Forms.PictureBox
    Friend WithEvents ptcBlankSquare9 As System.Windows.Forms.PictureBox
    Friend WithEvents ptcBlankSquare10 As System.Windows.Forms.PictureBox
    Friend WithEvents ptcBlankSquare11 As System.Windows.Forms.PictureBox
    Friend WithEvents ptcBlankSquare12 As System.Windows.Forms.PictureBox
    Friend WithEvents ptcBlankSquare13 As System.Windows.Forms.PictureBox
    Friend WithEvents ptcBlankSquare14 As System.Windows.Forms.PictureBox
    Friend WithEvents ptcBlankSquare15 As System.Windows.Forms.PictureBox
    Friend WithEvents ptcBlankSquare16 As System.Windows.Forms.PictureBox
    Friend WithEvents ptcBlank As System.Windows.Forms.PictureBox
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblScoreValue As System.Windows.Forms.Label
    Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuContent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInstructions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSelector As System.Windows.Forms.ToolStripMenuItem

End Class
