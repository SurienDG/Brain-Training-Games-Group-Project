<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOverallSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOverallSplash))
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuContent = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEnglish = New System.Windows.Forms.Button()
        Me.cmdMath = New System.Windows.Forms.Button()
        Me.cmdSkip = New System.Windows.Forms.Button()
        Me.cmdProblemSolving = New System.Windows.Forms.Button()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(0, 0)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(790, 568)
        Me.AxShockwaveFlash1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuContent})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(784, 24)
        Me.mnuStrip.TabIndex = 4
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
        Me.mnuContent.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuContent.Name = "mnuContent"
        Me.mnuContent.Size = New System.Drawing.Size(62, 20)
        Me.mnuContent.Text = "&Content"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuAbout.Text = "About"
        '
        'cmdEnglish
        '
        Me.cmdEnglish.Image = Global._2048.My.Resources.Resources.English
        Me.cmdEnglish.Location = New System.Drawing.Point(553, 370)
        Me.cmdEnglish.Name = "cmdEnglish"
        Me.cmdEnglish.Size = New System.Drawing.Size(198, 73)
        Me.cmdEnglish.TabIndex = 4
        Me.cmdEnglish.UseVisualStyleBackColor = True
        Me.cmdEnglish.Visible = False
        '
        'cmdMath
        '
        Me.cmdMath.Image = Global._2048.My.Resources.Resources.Math
        Me.cmdMath.Location = New System.Drawing.Point(554, 281)
        Me.cmdMath.Name = "cmdMath"
        Me.cmdMath.Size = New System.Drawing.Size(198, 75)
        Me.cmdMath.TabIndex = 3
        Me.cmdMath.UseVisualStyleBackColor = True
        Me.cmdMath.Visible = False
        '
        'cmdSkip
        '
        Me.cmdSkip.Image = Global._2048.My.Resources.Resources.Skip
        Me.cmdSkip.Location = New System.Drawing.Point(574, 474)
        Me.cmdSkip.Name = "cmdSkip"
        Me.cmdSkip.Size = New System.Drawing.Size(198, 75)
        Me.cmdSkip.TabIndex = 1
        Me.cmdSkip.UseVisualStyleBackColor = True
        '
        'cmdProblemSolving
        '
        Me.cmdProblemSolving.Image = Global._2048.My.Resources.Resources.ProblemSolving
        Me.cmdProblemSolving.Location = New System.Drawing.Point(53, 321)
        Me.cmdProblemSolving.Name = "cmdProblemSolving"
        Me.cmdProblemSolving.Size = New System.Drawing.Size(198, 75)
        Me.cmdProblemSolving.TabIndex = 2
        Me.cmdProblemSolving.UseVisualStyleBackColor = True
        Me.cmdProblemSolving.Visible = False
        '
        'frmOverallSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.mnuStrip)
        Me.Controls.Add(Me.cmdEnglish)
        Me.Controls.Add(Me.cmdMath)
        Me.Controls.Add(Me.cmdSkip)
        Me.Controls.Add(Me.cmdProblemSolving)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.MainMenuStrip = Me.mnuStrip
        Me.Name = "frmOverallSplash"
        Me.Text = "Brain Benders"
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DirectoryEntry1 As System.DirectoryServices.DirectoryEntry
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmdProblemSolving As System.Windows.Forms.Button
    Friend WithEvents cmdMath As System.Windows.Forms.Button
    Friend WithEvents cmdEnglish As System.Windows.Forms.Button
    Friend WithEvents cmdSkip As System.Windows.Forms.Button
    Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuContent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
End Class
