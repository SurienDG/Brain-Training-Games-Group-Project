Option Explicit On
Public Class frmIntro
    Public whichForm As Byte
    'When wants to play...bm'
    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        Me.Hide()
        frmLevelSelect.Show()
    End Sub

    'When user wants to exit...bm'
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    'When user clicks 'Instructions' in menu strip...bm'
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("This game removes a letter from a word.  You have to guess that letter.  Simple right?  Have fun!")
    End Sub

    Private Sub mnuMainMenu_Click(sender As Object, e As EventArgs) Handles mnuMainMenu.Click
        'show the main menu...sdg
        Me.Hide()
        frmOverallSplash.Show()
    End Sub
End Class
