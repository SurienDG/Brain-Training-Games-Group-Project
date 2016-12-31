<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEasyLevel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEasyLevel))
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.lblDisplayedWord = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lstWordBank = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAnswerBox = New System.Windows.Forms.TextBox()
        Me.cmdEnterAnswer = New System.Windows.Forms.Button()
        Me.cmdSkip = New System.Windows.Forms.Button()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblDisplayScore = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblQuestionNumber = New System.Windows.Forms.Label()
        Me.lblActualQuestionNumber = New System.Windows.Forms.Label()
        Me.ptcIntro = New System.Windows.Forms.PictureBox()
        Me.MenuStrip.SuspendLayout()
        CType(Me.ptcIntro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdNext
        '
        Me.cmdNext.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.Location = New System.Drawing.Point(631, 489)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(75, 23)
        Me.cmdNext.TabIndex = 3
        Me.cmdNext.Text = "Next"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'lblDisplayedWord
        '
        Me.lblDisplayedWord.AutoSize = True
        Me.lblDisplayedWord.BackColor = System.Drawing.Color.White
        Me.lblDisplayedWord.Font = New System.Drawing.Font("Elephant", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayedWord.Location = New System.Drawing.Point(342, 287)
        Me.lblDisplayedWord.Name = "lblDisplayedWord"
        Me.lblDisplayedWord.Size = New System.Drawing.Size(15, 35)
        Me.lblDisplayedWord.TabIndex = 5
        Me.lblDisplayedWord.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.White
        Me.lblHeader.Font = New System.Drawing.Font("Elephant", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(161, 55)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(470, 47)
        Me.lblHeader.TabIndex = 6
        Me.lblHeader.Text = "What Letter is Missing?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lstWordBank
        '
        Me.lstWordBank.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstWordBank.FormattingEnabled = True
        Me.lstWordBank.ItemHeight = 21
        Me.lstWordBank.Location = New System.Drawing.Point(108, 218)
        Me.lstWordBank.Name = "lstWordBank"
        Me.lstWordBank.Size = New System.Drawing.Size(190, 172)
        Me.lstWordBank.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 27)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Word Bank"
        '
        'txtAnswerBox
        '
        Me.txtAnswerBox.Location = New System.Drawing.Point(335, 353)
        Me.txtAnswerBox.Name = "txtAnswerBox"
        Me.txtAnswerBox.Size = New System.Drawing.Size(207, 20)
        Me.txtAnswerBox.TabIndex = 9
        '
        'cmdEnterAnswer
        '
        Me.cmdEnterAnswer.Location = New System.Drawing.Point(399, 379)
        Me.cmdEnterAnswer.Name = "cmdEnterAnswer"
        Me.cmdEnterAnswer.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnterAnswer.TabIndex = 10
        Me.cmdEnterAnswer.Text = "Check"
        Me.cmdEnterAnswer.UseVisualStyleBackColor = True
        '
        'cmdSkip
        '
        Me.cmdSkip.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSkip.Location = New System.Drawing.Point(631, 460)
        Me.cmdSkip.Name = "cmdSkip"
        Me.cmdSkip.Size = New System.Drawing.Size(75, 23)
        Me.cmdSkip.TabIndex = 11
        Me.cmdSkip.Text = "Skip"
        Me.cmdSkip.UseVisualStyleBackColor = True
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.Color.White
        Me.lblTimer.Font = New System.Drawing.Font("Elephant", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(55, 489)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(49, 35)
        Me.lblTimer.TabIndex = 12
        Me.lblTimer.Text = "10"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.White
        Me.lblScore.Font = New System.Drawing.Font("Elephant", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(641, 218)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(22, 35)
        Me.lblScore.TabIndex = 13
        Me.lblScore.Text = " "
        '
        'lblDisplayScore
        '
        Me.lblDisplayScore.AutoSize = True
        Me.lblDisplayScore.BackColor = System.Drawing.Color.White
        Me.lblDisplayScore.Font = New System.Drawing.Font("Elephant", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayScore.Location = New System.Drawing.Point(621, 179)
        Me.lblDisplayScore.Name = "lblDisplayScore"
        Me.lblDisplayScore.Size = New System.Drawing.Size(100, 38)
        Me.lblDisplayScore.TabIndex = 14
        Me.lblDisplayScore.Text = "Score"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.White
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(768, 24)
        Me.MenuStrip.TabIndex = 15
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMenu})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuMenu
        '
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(152, 22)
        Me.mnuMenu.Text = " &Main Menu"
        '
        'lblQuestionNumber
        '
        Me.lblQuestionNumber.AutoSize = True
        Me.lblQuestionNumber.BackColor = System.Drawing.Color.White
        Me.lblQuestionNumber.Font = New System.Drawing.Font("Elephant", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionNumber.Location = New System.Drawing.Point(13, 28)
        Me.lblQuestionNumber.Name = "lblQuestionNumber"
        Me.lblQuestionNumber.Size = New System.Drawing.Size(87, 20)
        Me.lblQuestionNumber.TabIndex = 16
        Me.lblQuestionNumber.Text = "Question: "
        '
        'lblActualQuestionNumber
        '
        Me.lblActualQuestionNumber.AutoSize = True
        Me.lblActualQuestionNumber.BackColor = System.Drawing.Color.White
        Me.lblActualQuestionNumber.Font = New System.Drawing.Font("Elephant", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualQuestionNumber.Location = New System.Drawing.Point(93, 29)
        Me.lblActualQuestionNumber.Name = "lblActualQuestionNumber"
        Me.lblActualQuestionNumber.Size = New System.Drawing.Size(17, 20)
        Me.lblActualQuestionNumber.TabIndex = 17
        Me.lblActualQuestionNumber.Text = "1"
        '
        'ptcIntro
        '
        Me.ptcIntro.ErrorImage = CType(resources.GetObject("ptcIntro.ErrorImage"), System.Drawing.Image)
        Me.ptcIntro.Image = Global._2048.My.Resources.Resources.white_background
        Me.ptcIntro.InitialImage = CType(resources.GetObject("ptcIntro.InitialImage"), System.Drawing.Image)
        Me.ptcIntro.Location = New System.Drawing.Point(-2, 0)
        Me.ptcIntro.Name = "ptcIntro"
        Me.ptcIntro.Size = New System.Drawing.Size(772, 564)
        Me.ptcIntro.TabIndex = 4
        Me.ptcIntro.TabStop = False
        '
        'frmEasyLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblActualQuestionNumber)
        Me.Controls.Add(Me.lblQuestionNumber)
        Me.Controls.Add(Me.lblDisplayScore)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.cmdSkip)
        Me.Controls.Add(Me.cmdEnterAnswer)
        Me.Controls.Add(Me.txtAnswerBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstWordBank)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblDisplayedWord)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.ptcIntro)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmEasyLevel"
        Me.Text = "Easy Level"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.ptcIntro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents ptcIntro As System.Windows.Forms.PictureBox
    Friend WithEvents lblDisplayedWord As System.Windows.Forms.Label
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lstWordBank As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAnswerBox As System.Windows.Forms.TextBox
    Friend WithEvents cmdEnterAnswer As System.Windows.Forms.Button
    Friend WithEvents cmdSkip As System.Windows.Forms.Button
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblDisplayScore As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblQuestionNumber As System.Windows.Forms.Label
    Friend WithEvents lblActualQuestionNumber As System.Windows.Forms.Label
End Class
