Option Explicit On
Public Class frmEasyLevel
    'Declare variable...bm'
    Dim fileReader As String
    Dim word(30) As String
    Dim x As Integer
    Dim dictionary As String
    Dim AnswerWord As String
    Dim wordsDictionary(354935) As String
    Dim MissingLetter As Byte
    Dim timer As Byte = 10
    Dim score As Byte = 0
    Dim scoreSum As Byte = 0
    Dim scoreTimer As Byte = 10
    Public finalScore As Integer = 0
    Dim questionCounter As Byte = 1

    'Main game form
    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialize timer...bm'
        timer = 10
        'Enable next button...bm'
        cmdNext.Enabled = False
        'Enable timer...bm'
        Timer1.Enabled = True
        'Read text files...bm'
        Dim objReader As New System.IO.StreamReader(Application.StartupPath & "\WordsForGame.txt")
        fileReader = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\WordsForGame1.txt")

        'Start counter...bm'
        Dim counter1 As Integer = 0
        'Count amount of words...bm'
        Dim WordNumber As Integer = 0
        'Loop for reading each character and checking what they are and add words to list box...bm'
        For Each character As Char In fileReader
            If AscW(character) = 32 Then
                For counter3 As Byte = counter1 + 1 To Len(fileReader) - 1
                    If AscW(fileReader(counter3)) <> 32 Then
                        word(WordNumber) += fileReader(counter3)
                    Else
                        lstWordBank.Items.Add(word(WordNumber))
                        WordNumber += 1
                        Exit For
                    End If
                Next
            End If
            counter1 += 1
        Next
        'Reset amount of words...bm'
        WordNumber = 0
        'Loop to read dictionary to check if words are correct...bm'
        Do While objReader.Peek() <> -1
            wordsDictionary(WordNumber) = ""
            wordsDictionary(WordNumber) = wordsDictionary(WordNumber) & objReader.ReadLine() & vbNewLine
            Dim Length = Len(wordsDictionary(WordNumber))
            Dim TempWord = wordsDictionary(WordNumber)
            wordsDictionary(WordNumber) = ""
            For counter As SByte = 0 To Length - 3
                wordsDictionary(WordNumber) += TempWord(counter)
            Next
            WordNumber += 1
        Loop

        'Randomly generate word and randomly remove one letter of one word...bm'
        Randomize()
        x = Int(30 * Rnd()) + 0
        lblDisplayedWord.Text = ""
        MissingLetter = Int(Len(word(x)) * Rnd()) + 0
        For counter4 As Byte = 0 To Len(word(x)) - 1
            If counter4 = MissingLetter Then
                lblDisplayedWord.Text += "_"
            Else
                lblDisplayedWord.Text += word(x)(counter4)
            End If
        Next
        AnswerWord = ""
    End Sub

    'Once next button is pressed, the form resets to the initial state allowing the user to go to the next question and adds the score...bm;
    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        cmdSkip.Enabled = True
        txtAnswerBox.Text = ""
        txtAnswerBox.Enabled = True
        cmdEnterAnswer.Enabled = True
        scoreSum = score + scoreTimer
        finalScore += scoreSum
        score = 0
        scoreTimer = 10
        lblScore.Text = finalScore
        timer = 10
        cmdNext.Enabled = False
        lblTimer.Text = "10"
        questionCounter = questionCounter + 1
        lblActualQuestionNumber.Text = questionCounter
        'If the user reaches the last question it ends the game and displays the scoreboard...bm'
        If questionCounter = 11 Then
            Timer1.Stop()
            Me.Hide()
            frmScoreboard.Show()
            Return
        End If
        'Start timer...bm'
        Timer1.Start()

        'Randomly generate word and randomly remove one letter of one word...bm'
        Randomize()
        x = Int(30 * Rnd()) + 0
        lblDisplayedWord.Text = ""
        MissingLetter = Int(Len(word(x)) * Rnd()) + 0
        For counter4 As Byte = 0 To Len(word(x)) - 1
            If counter4 = MissingLetter Then
                lblDisplayedWord.Text += "_"
            Else
                lblDisplayedWord.Text += word(x)(counter4)

            End If
        Next
        AnswerWord = ""
    End Sub

    'Once check button is pushed, it checks if the inputted character is correct...bm'
    Private Sub cmdEnterAnswer_Click(sender As Object, e As EventArgs) Handles cmdEnterAnswer.Click
        'If nothing is entered...bm'
        If txtAnswerBox.Text = vbNullString Or txtAnswerBox.Text = " " Then

            'If more than one character is entered...bm'
        ElseIf Len(txtAnswerBox.Text) > 1 Then
            Timer1.Stop()
            MsgBox("Please enter only one character")
            Timer1.Start()
            'Gives a variable the value of the missing letter to use to check if it is correct...bm'
        ElseIf Len(txtAnswerBox.Text) = 1 Then
            AnswerWord = ""
            For counter4 As Byte = 0 To Len(word(x)) - 1
                If counter4 = MissingLetter Then
                    AnswerWord += UCase(txtAnswerBox.Text)
                Else
                    AnswerWord += word(x)(counter4)
                End If
            Next
            'Loop to check if what was entered is correct...bm'
            For counter4 As Integer = 0 To 354933
                If UCase(wordsDictionary(counter4)) = UCase(AnswerWord) Then
                    Timer1.Stop()
                    MsgBox("That is correct")
                    cmdSkip.Enabled = False
                    cmdNext.Enabled = True
                    txtAnswerBox.Enabled = False
                    cmdEnterAnswer.Enabled = False
                    scoreTimer = timer * 10
                    timer = 10
                    score += 100
                    cmdNext.Enabled = True
                    Return
                End If
            Next
            'If what was entered is incorrect...bm'
            Timer1.Stop()
            MsgBox("That is incorrect")
            txtAnswerBox.Enabled = False
            cmdEnterAnswer.Enabled = False
            cmdNext.Enabled = False
            cmdSkip.Enabled = True
        End If
    End Sub

    'Timer for game...bm'
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timer = timer - 1
        lblTimer.Text = timer
        If timer = 0 Then
            score = 10 * timer
            cmdNext.Enabled = True
            Timer1.Stop()
            MsgBox("You ran out of time!")
            cmdSkip.Enabled = True
            cmdNext.Enabled = False
            cmdEnterAnswer.Enabled = False
            txtAnswerBox.Enabled = False
        End If
    End Sub

    'If the user presses the skip button, it resets the form and gives a new question...bm'
    Private Sub cmdSkip_Click(sender As Object, e As EventArgs) Handles cmdSkip.Click
        questionCounter = questionCounter + 1
        lblActualQuestionNumber.Text = questionCounter
        If questionCounter = 11 Then
            Timer1.Stop()
            Me.Hide()
            frmIntro.whichForm = 0
            frmScoreboard.Show()
            Return
        End If
        txtAnswerBox.Text = ""
        txtAnswerBox.Enabled = True
        cmdEnterAnswer.Enabled = True
        lblScore.Text = finalScore
        timer = 10
        cmdNext.Enabled = False
        lblTimer.Text = "10"
        Timer1.Start()

        'Randomly generate word and randomly remove one letter of one word...bm'
        Randomize()
        x = Int(30 * Rnd()) + 0
        lblDisplayedWord.Text = ""
        MissingLetter = Int(Len(word(x)) * Rnd()) + 0
        For counter4 As Byte = 0 To Len(word(x)) - 1
            If counter4 = MissingLetter Then
                lblDisplayedWord.Text += "_"
            Else
                lblDisplayedWord.Text += word(x)(counter4)
            End If
        Next
        AnswerWord = ""
    End Sub

    'When user clicks 'Main Menu' in menu strip...bm'
    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuMenu.Click
        Timer1.Stop()
        Me.Close()
        frmOverallSplash.Show()
    End Sub

End Class