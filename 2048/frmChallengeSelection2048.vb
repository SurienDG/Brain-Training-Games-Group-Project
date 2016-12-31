Option Explicit On
Public Class frmChallengeSelection2048

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        'store information about which form accessed the about form...sdg
        'then shows about form...sdg
        frmOverallSplash.LastForm = frmOverallSplash.ChallengeSelection2048
        Me.Hide()
        frmAbout.Show()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'declares a variable for user response to exit check...sdg
        Dim Response As Byte
        'hides the current window and opens the exit form...sdg
        Response = MsgBox("Are you sure you want to exit?", 20, "Exit")
        If Response = 6 Then End
    End Sub


    Private Sub cmdGet1And8_Click(sender As Object, e As EventArgs) Handles cmdGet1And8.Click
        'sets the parameters needed for the game in the next form...sdg
        frmChallenge2048.lbl8TilesNeededValue.Text = 1
        frmChallenge2048.lblMovesLeftValue.Text = 5
        Me.Hide()
        frmChallenge2048.Show()
    End Sub


    Private Sub mnuSelector_Click(sender As Object, e As EventArgs) Handles mnuSelector.Click
        'input string...sdg
        Dim UserInput As String = ""
        'asks the user for their input...sdg
        UserInput = InputBox("Please enter a command for where you wish to go in the program (CN2048 = Normal 2048, EGame = English Game, MGame = Math Game CS2048=Challenge Selector 2048)", "Selector")
        'creates and hides the current form...sdg
        'and goes whereever the user entered they wanted to go...sdg
        If (UserInput = "CN2048") Then
            frmNormal2048.Show()
            Me.Hide()
        ElseIf (UserInput = "EGame") Then
            'code for english game
            frmIntro.Show()
            Me.Hide()
        ElseIf (UserInput = "MGame") Then
            'code for math game
            'when Damjan is done uncomment this code...sdg
            'frmMainMenu.Show()
            'Me.Hide()
        ElseIf (UserInput = "CS2048") Then
            MsgBox("Already on that form")
        Else
            MsgBox("Invalid Command")
        End If
    End Sub

    Private Sub cmdGet2And8_Click(sender As Object, e As EventArgs) Handles cmdGet2And8.Click
        'sets the parameters needed for the game in the next form...sdg
        frmChallenge2048.lbl8TilesNeededValue.Text = 2
        frmChallenge2048.lblMovesLeftValue.Text = 10
        Me.Hide()
        frmChallenge2048.Show()
    End Sub

    Private Sub cmdGet3And8_Click(sender As Object, e As EventArgs) Handles cmdGet3And8.Click
        'sets the parameters needed for the game in the next form...sdg
        frmChallenge2048.lbl8TilesNeededValue.Text = 3
        frmChallenge2048.lblMovesLeftValue.Text = 15
        Me.Hide()
        frmChallenge2048.Show()
    End Sub

    Private Sub cmdGet1And16_Click(sender As Object, e As EventArgs) Handles cmdGet1And16.Click
        'sets the parameters needed for the game in the next form...sdg
        frmChallenge2048.lbl16TilesNeededValue.Text = 1
        frmChallenge2048.lblMovesLeftValue.Text = 12
        Me.Hide()
        frmChallenge2048.Show()
    End Sub

    Private Sub cmdGet1And8And16_Click(sender As Object, e As EventArgs) Handles cmdGet2And16.Click
        'sets the parameters needed for the game in the next form...sdg
        frmChallenge2048.lbl16TilesNeededValue.Text = 2
        frmChallenge2048.lblMovesLeftValue.Text = 21
        Me.Hide()
        frmChallenge2048.Show()
    End Sub

    Private Sub mnuMainMenu_Click(sender As Object, e As EventArgs) Handles mnuMainMenu.Click
        'shows the main menu ...sdg
        Me.Hide()
        frmOverallSplash.Show()
    End Sub
End Class