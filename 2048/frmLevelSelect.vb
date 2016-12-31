Option Explicit On
Public Class frmLevelSelect

    'When user wants the hard level...bm'
    Private Sub cmdHard_Click(sender As Object, e As EventArgs) Handles cmdHard.Click
        Me.Hide()
        frmHardLevel.Show()
    End Sub
    'When user wants the easy level...bm'
    Private Sub cmdEasy_Click(sender As Object, e As EventArgs) Handles cmdEasy.Click
        Me.Hide()
        frmEasyLevel.Show()
    End Sub

    'When user wants to exit...bm'
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

End Class