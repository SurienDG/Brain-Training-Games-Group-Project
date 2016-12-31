Option Explicit On
Public Class frmOverallSplash
    'varibles store values for forms that can be used for going baclk to a form from the about page...sdg
    Public LastForm As Byte = 0
    Public Const OverallSplash = 0
    Public Const StartScreen2048 = 1
    Public Const Normal2048 = 2
    Public Const ChallengeSelection2048 = 3
    Public Const Challenge2048 = 4
    Public Const Instructions2048 = 5


    Private Sub Overall_Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sets the focus on the skip button...sdg
        Me.Show()
        cmdSkip.Focus()
        'enables the timer...sdg
        Timer1.Enabled = True
        'starts the splashscreen animation from the file in the given folder...sdg
        AxShockwaveFlash1.Movie = Application.StartupPath & "\BrainBusters.swf"
    End Sub
    'timer to have constant check occuring througout the program...sdg
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'checks to see if the current frame has reached the point hwere the buttons need to be shown if so repeats the set of frames...sdg
        'also if conditions are met also hides the skip button...sdg
        If AxShockwaveFlash1.CurrentFrame = AxShockwaveFlash1.TotalFrames - 20 Then
            AxShockwaveFlash1.FrameNum = AxShockwaveFlash1.TotalFrames - 100
            AxShockwaveFlash1.Play()
        ElseIf AxShockwaveFlash1.FrameNum = AxShockwaveFlash1.TotalFrames - 150 Then
            cmdEnglish.Show()
            cmdMath.Show()
            cmdProblemSolving.Show()
            cmdSkip.Hide()
        End If
    End Sub


    'if button is pressed hides the current form and shows problem solving form...sdg
    Private Sub cmdProblemSolving_Click(sender As Object, e As EventArgs) Handles cmdProblemSolving.Click
        Me.Hide()
        frmStartScreen2048.Show()
    End Sub
    'if clicked skips to the part where user can make decision about what genre of game they want to play...sdg
    Private Sub cmdSkip_Click(sender As Object, e As EventArgs) Handles cmdSkip.Click
        AxShockwaveFlash1.FrameNum = AxShockwaveFlash1.TotalFrames - 155
        AxShockwaveFlash1.Play()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'declares a variable for user response to exit check...sdg
        Dim Response As Byte
        'hides the current window and opens the exit form...sdg
        Response = MsgBox("Are you sure you want to exit?", 20, "Exit")
        If Response = 6 Then End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        'stores information about which form the about form was accessed from and then displays the about form...sdg
        LastForm = OverallSplash
        Me.Hide()
        frmAbout.Show()
    End Sub

    Private Sub cmdEnglish_Click(sender As Object, e As EventArgs) Handles cmdEnglish.Click
        'code to show english game...sdg
        Me.Hide()
        frmIntro.Show()
    End Sub

    Private Sub cmdMath_Click(sender As Object, e As EventArgs) Handles cmdMath.Click
        'code to show math game...sdg
        'uncomment when Damjan form is added
        'Me.Hide()
        'frmMainMenu.show()

    End Sub
End Class