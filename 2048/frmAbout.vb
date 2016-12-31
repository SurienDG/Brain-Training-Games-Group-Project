Option Explicit On
Public Class frmAbout
    'event for when the back button is pressed..sdg
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        'hides the current window (about form)..sdg
        Me.Hide()
        'shows whichever window it previously came from..sdg
        If frmOverallSplash.LastForm = frmOverallSplash.OverallSplash Then
            Me.Hide()
            frmOverallSplash.Show()
        ElseIf frmOverallSplash.LastForm = frmOverallSplash.StartScreen2048 Then
            Me.Hide()
            frmStartScreen2048.Show()
        ElseIf frmOverallSplash.LastForm = frmOverallSplash.Normal2048 Then
            Me.Hide()
            frmNormal2048.Show()
        ElseIf frmOverallSplash.LastForm = frmOverallSplash.ChallengeSelection2048 Then
            Me.Hide()
            frmChallengeSelection2048.Show()
        ElseIf frmOverallSplash.LastForm = frmOverallSplash.Challenge2048 Then
            Me.Hide()
            frmChallenge2048.Show()
        ElseIf frmOverallSplash.LastForm = frmOverallSplash.Instructions2048 Then
            Me.Hide()
            frmInstructions2048.Show()
        End If
    End Sub
    'event for when the exit buttoon is pressed..sdg
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        'declares a variable for user response to exit check...sdg
        Dim Response As Byte
        'hides the current window and opens the exit form...sdg
        Response = MsgBox("Are you sure you want to exit?", 20, "Exit")
        If Response = 6 Then End
    End Sub

End Class