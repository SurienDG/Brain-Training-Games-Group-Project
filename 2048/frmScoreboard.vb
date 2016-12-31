Option Explicit On
Public Class frmScoreboard


    'When form is loaded, the label displays the final score...bm'
    Private Sub frmScoreboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Easy level...bm'
        If (frmIntro.whichForm = 0) Then
            lblEndScore.Text = frmEasyLevel.finalScore
            'Hard level...bm'
        ElseIf (frmIntro.whichForm = 1) Then
            lblEndScore.Text = frmHardLevel.finalScore
        End If
    End Sub

    'When user presses the 'Main Menu' button in the menu strip...bm'
    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        Me.Close()
        frmEasyLevel.Close()
        frmHardLevel.Close()
        frmOverallSplash.Show()
    End Sub
End Class