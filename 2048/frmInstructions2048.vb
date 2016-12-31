Option Explicit On
Public Class frmInstructions2048


    Private Sub frmInstructions2048_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'starts the splashscreen animation from the file in the given folder...sdg
        AxShockwaveFlash1.Movie = Application.StartupPath & "\Instructions.swf"
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuMainMenu.Click
        'shows the main menu ...sdg
        Me.Hide()
        frmOverallSplash.Show()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'declares a variable for user response to exit check...sdg
        Dim Response As Byte
        'hides the current window and opens the exit form...sdg
        Response = MsgBox("Are you sure you want to exit?", 20, "Exit")
        If Response = 6 Then End
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        'stores information about which form the about form was accessed from and then displays the about form...sdg
        frmOverallSplash.LastForm = frmOverallSplash.Instructions2048
        frmAbout.Show()
        Me.Hide()
    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        'goes back to 2048 menu form...sdg
        Me.Hide()
        frmStartScreen2048.Show()
    End Sub
End Class