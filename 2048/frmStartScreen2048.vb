Option Explicit On
Public Class frmStartScreen2048
    'if button is pressed takes the user to the normal 2048 game...sdg
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdNormalMode.Click
        Me.Hide()
        frmNormal2048.Show()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'declares a variable for user response to exit check...sdg
        Dim Response As Byte
        'hides the current window and opens the exit form...sdg
        Response = MsgBox("Are you sure you want to exit?", 20, "Exit")
        If Response = 6 Then End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        'stores what the last form was so it can take the user back to the correct form after they are done on the about page...sdg
        frmOverallSplash.LastForm = frmOverallSplash.StartScreen2048
        'hides the currect form...sdg
        Me.Hide()
        'shows the about form...sdg
        frmAbout.Show()
    End Sub

  
    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        'goes back to main menu ...sdg 
        Me.Hide()
        frmOverallSplash.Show()
    End Sub

    Private Sub cmdChallengeMode_Click(sender As Object, e As EventArgs) Handles cmdChallengeMode.Click
        'shows the 2048 challenge screen selection menu...sdg
        Me.Hide()
        frmChallengeSelection2048.Show()
    End Sub

    Private Sub mnuInstructions_Click(sender As Object, e As EventArgs) Handles mnuInstructions.Click
        'shows the 2048 instructions screen selection menu...sdg
        Me.Hide()
        frmInstructions2048.Show()
    End Sub

End Class