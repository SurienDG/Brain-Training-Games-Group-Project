Option Explicit On
Public Class frmNormal2048
    'declare variable for storing all the tiles...sdg
    Dim Tiles(11) As PictureBox
    'variable for storing the board...sdg
    Dim Board(4, 4) As PictureBox
    'constants to have easy access to what position a tile is in the array
    Const Tile2 = 0
    Const Tile4 = 1
    Const Tile8 = 2
    Const Tile16 = 3
    Const Tile32 = 4
    Const Tile64 = 5
    Const Tile128 = 6
    Const Tile256 = 7
    Const Tile512 = 8
    Const Tile1024 = 9
    Const Tile2048 = 10
    'if KeyDown event occurs check how the tiles move..sdg
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'variable to store whether any tiles have moved or not...sdg
        Dim Moved As Boolean = False
        'variable to store whether anytiles have been combined or not...sdg
        Dim Combined As Boolean = False
        'if the right key was pressed then initialize loops to move tiles to the right...sdg
        If e.KeyCode = Keys.Right Then
            'first loop to move tiles over multiple tiles over to the right ...sdg
            For counter As Byte = 0 To 2
                'two loops to find the tiles that need to be moved...sdg
                For Rows As Byte = 0 To 3
                    For Columns As Byte = 0 To 3
                        'if statement to check whether the tile is a number tile and if it needs to be ...sdg
                        'moved...sdg
                        If Board(Columns, Rows).Image IsNot ptcBlank.Image And Columns <> 3 Then
                            'loop for moving the tile over to the right...sdg
                            For Columns2 As Byte = Columns + 1 To 3
                                'checks to see if a tile is in the way...sdg
                                If Board(Columns2, Rows).Image IsNot ptcBlank.Image Then
                                    'if tile is in the way moves tile beside it...sdg
                                    Board(Columns2 - 1, Rows).Image = Board(Columns, Rows).Image
                                    'checks to see if tile has moved...sdg
                                    If Columns2 - 1 <> Columns Then
                                        'if it moved makes the old space where it used to a blank tile...sdg
                                        Board(Columns, Rows).Image = ptcBlank.Image
                                        'sets the variable for whether it moved or not to true...sdg
                                        Moved = True
                                    End If
                                    'exits the for loop...sdg
                                    Exit For
                                    'checks to see if it has been moved to the right border...sdg
                                ElseIf Board(Columns2, Rows).Image Is ptcBlank.Image And Columns2 = 3 Then
                                    'moves it to the edge square...sdg
                                    Board(Columns2, Rows).Image = Board(Columns, Rows).Image
                                    'makes it's original position a blank tile ...sdg
                                    Board(Columns, Rows).Image = ptcBlank.Image
                                    'checks to see if tile was moved and if it was moved then sets Moved boolean to true..sdg
                                    If Columns2 <> Columns Then
                                        Moved = True
                                    End If
                                    'exits the for loop...sdg
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                Next
            Next
            'loops check to see if tiles could be combined when moved to the right...sdg
            For Rows As Byte = 0 To 3
                'checks to see if the tiles right to each other to the right are the same...sdg
                If Tile(3, Rows) = Tile(2, Rows) And Tile(3, Rows) <> 11 And Tile(2, Rows) <> 11 Then
                    'increases the score...sdg
                    lblScoreValue.Text += TileNumberToValue(Tile(3, Rows) + 1)
                    'upgrades the tile one up from what it used to be...sdg
                    Board(3, Rows).Image = Tiles(Tile(3, Rows) + 1).Image
                    'moves corresponding tiles over to the right
                    Board(2, Rows).Image = Board(1, Rows).Image
                    Board(1, Rows).Image = Board(0, Rows).Image
                    Board(0, Rows).Image = ptcBlank.Image
                    'makes combined equal to true if moved is equal to false...sdg
                    If Moved = False Then
                        Combined = True
                    End If
                    'checks to see if the tiles right to each other to the right are the same...sdg
                ElseIf Tile(2, Rows) = Tile(1, Rows) And Tile(2, Rows) <> 11 And Tile(1, Rows) <> 11 Then
                    'increases the score...sdg
                    lblScoreValue.Text += TileNumberToValue(Tile(2, Rows) + 1)
                    'upgrades the tile one up from what it used to be...sdg
                    Board(2, Rows).Image = Tiles(Tile(2, Rows) + 1).Image
                    'moves corresponding tiles over to the right
                    Board(1, Rows).Image = Board(0, Rows).Image
                    Board(0, Rows).Image = ptcBlank.Image
                    'makes combined equal to true if moved is equal to false...sdg
                    If Moved = False Then
                        Combined = True
                    End If
                    'checks to see if the tiles right to each other  are the same...sdg
                ElseIf Tile(1, Rows) = Tile(0, Rows) And Tile(1, Rows) <> 11 And Tile(0, Rows) <> 11 Then
                    'increases the score...sdg
                    lblScoreValue.Text += TileNumberToValue(Tile(1, Rows) + 1)
                    'upgrades the tile one up from what it used to be...sdg
                    Board(1, Rows).Image = Tiles(Tile(1, Rows) + 1).Image
                    Board(0, Rows).Image = ptcBlank.Image
                    'makes combined equal to true if moved is equal to false...sdg
                    If Moved = False Then
                        Combined = True
                    End If
                End If
            Next
            'if the left key was pressed then initialize loops to move tiles to the left...sdg
        ElseIf e.KeyCode = Keys.Left Then
            'first loop to move tiles over multiple tiles over to the left ...sdg
            For counter As Byte = 0 To 2
                'two loops to find the tiles that need to be moved...sdg
                For Rows As Byte = 0 To 3
                    For Columns As Byte = 0 To 3
                        'if statement to check whether the tile is a number tile and if it needs to be ...sdg
                        'moved...sdg
                        If Board(Columns, Rows).Image IsNot ptcBlank.Image And Columns <> 0 Then
                            'loop for moving the tile over to the left...sdg
                            For Columns2 As SByte = Columns - 1 To 0 Step -1
                                'checks to see if a tile is in the way...sdg
                                If Board(Columns2, Rows).Image IsNot ptcBlank.Image Then
                                    'if tile is in the way moves tile beside it...sdg
                                    Board(Columns2 + 1, Rows).Image = Board(Columns, Rows).Image
                                    'checks to see if tile has moved...sdg
                                    If Columns2 + 1 <> Columns Then
                                        Board(Columns, Rows).Image = ptcBlank.Image
                                        Moved = True
                                    End If
                                    'exits the for loop...sdg
                                    Exit For
                                    'checks to see if it has been moved to the left border...sdg
                                ElseIf Board(Columns2, Rows).Image Is ptcBlank.Image And Columns2 = 0 Then
                                    'moves it to the edge square...sdg
                                    Board(Columns2, Rows).Image = Board(Columns, Rows).Image
                                    'makes it's original position a blank tile ...sdg
                                    Board(Columns, Rows).Image = ptcBlank.Image
                                    'checks to see if tile was moved and if it was moved then sets Moved boolean to true..sdg
                                    If Columns2 <> Columns Then
                                        Moved = True
                                    End If
                                    'exits for loop...sdg
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                Next
            Next

            'loops check to see if tiles could be combined when moved to the left...sdg
            For Rows As Byte = 0 To 3
                'checks to see if the tiles to the left are the same...sdg
                If Tile(0, Rows) = Tile(1, Rows) And Tile(0, Rows) <> 11 And Tile(1, Rows) <> 11 Then
                    'increases the score...sdg
                    lblScoreValue.Text += TileNumberToValue(Tile(0, Rows) + 1)
                    'upgrades the tile one up from what it used to be...sdg
                    Board(0, Rows).Image = Tiles(Tile(0, Rows) + 1).Image
                    'moves tiles to the left...sdg
                    Board(1, Rows).Image = Board(2, Rows).Image
                    Board(2, Rows).Image = Board(3, Rows).Image
                    Board(3, Rows).Image = ptcBlank.Image
                    'if moved equals false sets combined to true...sdg
                    If Moved = False Then
                        Combined = True
                    End If
                    'checks to see if the tiles to the left are the same...sdg
                ElseIf Tile(1, Rows) = Tile(2, Rows) And Tile(1, Rows) <> 11 And Tile(2, Rows) <> 11 Then
                    'increases the score...sdg
                    lblScoreValue.Text += TileNumberToValue(Tile(1, Rows) + 1)
                    'upgrades the tile one up from what it used to be...sdg
                    Board(1, Rows).Image = Tiles(Tile(1, Rows) + 1).Image
                    'moves tiles to the left...sdg
                    Board(2, Rows).Image = Board(3, Rows).Image
                    Board(3, Rows).Image = ptcBlank.Image
                    'if moved equals false sets combined to true...sdg
                    If Moved = False Then
                        Combined = True
                    End If
                    'checks to see if the tiles to the left are the same...sdg
                ElseIf Tile(2, Rows) = Tile(3, Rows) And Tile(2, Rows) <> 11 And Tile(3, Rows) <> 11 Then
                    'increases the score...sdg
                    lblScoreValue.Text += TileNumberToValue(Tile(2, Rows) + 1)
                    'upgrades the tile one up from what it used to be...sdg
                    Board(2, Rows).Image = Tiles(Tile(2, Rows) + 1).Image
                    'moves tiles to the left...sdg
                    Board(3, Rows).Image = ptcBlank.Image
                    'if moved equals false sets combined to true...sdg
                    If Moved = False Then
                        Combined = True
                    End If
                End If

            Next
            'if the up key was pressed then initialize loops to move tiles up...sdg
        ElseIf e.KeyCode = Keys.Up Then
            'first loop to move tiles over multiple tiles up ...sdg
            For counter As Byte = 0 To 2
                'two loops to find the tiles that need to be moved...sdg
                For Rows As Byte = 0 To 3
                    For Columns As SByte = 0 To 3
                        'if statement to check whether the tile is a number tile and if it needs to be ...sdg
                        'moved...sdg
                        If Board(Columns, Rows).Image IsNot ptcBlank.Image And Rows <> 0 Then
                            'loop for moving the tile up...sdg
                            For Rows2 As SByte = Rows - 1 To 0 Step -1
                                'checks to see if a tile is in the way...sdg
                                If Board(Columns, Rows2).Image IsNot ptcBlank.Image Then
                                    'if tile is in the way moves tile beside it...sdg
                                    Board(Columns, Rows2 + 1).Image = Board(Columns, Rows).Image
                                    'checks to see if tile has moved...sdg
                                    If Rows2 + 1 <> Rows Then
                                        Board(Columns, Rows).Image = ptcBlank.Image
                                        Moved = True
                                    End If
                                    'exits the for loop...sdg
                                    Exit For
                                    'checks to see if it has been moved to the top border...sdg
                                ElseIf Board(Columns, Rows2).Image Is ptcBlank.Image And Rows2 = 0 Then
                                    'moves tile...sdg
                                    Board(Columns, Rows2).Image = Board(Columns, Rows).Image
                                    Board(Columns, Rows).Image = ptcBlank.Image
                                    'checks to see if tile has moved...sdg
                                    If Rows2 <> Rows Then
                                        Moved = True
                                    End If
                                    'exits for loop...sdg
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                Next
            Next
            'loops check to see if tiles could be combined when moved up...sdg
            For Columns As Byte = 0 To 3
                'checks to see if the tiles to the top are the same...sdg
                If Tile(Columns, 0) = Tile(Columns, 1) And Tile(Columns, 0) <> 11 And Tile(Columns, 1) <> 11 Then
                    'increases the score...sdg
                    lblScoreValue.Text += TileNumberToValue(Tile(Columns, 0) + 1)
                    'upgrades the tile one up from what it used to be...sdg
                    Board(Columns, 0).Image = Tiles(Tile(Columns, 0) + 1).Image
                    'moves tiles to the top...sdg
                    Board(Columns, 1).Image = Board(Columns, 2).Image
                    Board(Columns, 2).Image = Board(Columns, 3).Image
                    Board(Columns, 3).Image = ptcBlank.Image
                    'if moved equals false then makes combined true...sdg
                    If Moved = False Then
                        Combined = True
                    End If
                    'checks to see if the tiles to the top are the same...sdg
                ElseIf Tile(Columns, 1) = Tile(Columns, 2) And Tile(Columns, 1) <> 11 And Tile(Columns, 2) <> 11 Then
                    'increases the score...sdg
                    lblScoreValue.Text += TileNumberToValue(Tile(Columns, 1) + 1)
                    'upgrades the tile one up from what it used to be...sdg
                    Board(Columns, 1).Image = Tiles(Tile(Columns, 1) + 1).Image
                    'moves tiles to the top...sdg
                    Board(Columns, 2).Image = Board(Columns, 3).Image
                    Board(Columns, 3).Image = ptcBlank.Image
                    'if moved equals false then makes combined true...sdg
                    If Moved = False Then
                        Combined = True
                    End If
                    'checks to see if the tiles to the top are the same...sdg
                ElseIf Tile(Columns, 2) = Tile(Columns, 3) And Tile(Columns, 2) <> 11 And Tile(Columns, 3) <> 11 Then
                    'increases the score...sdg
                    lblScoreValue.Text += TileNumberToValue(Tile(Columns, 2) + 1)
                    'upgrades the tile one up from what it used to be...sdg
                    Board(Columns, 2).Image = Tiles(Tile(Columns, 2) + 1).Image
                    'moves tiles to the top...sdg
                    Board(Columns, 3).Image = ptcBlank.Image
                    'if moved equals false then makes combined true...sdg
                    If Moved = False Then
                        Combined = True
                    End If
                End If

            Next
            'if the up key was pressed then initialize loops to move tiles down...sdg
        ElseIf e.KeyCode = Keys.Down Then
            'two loops to find the tiles that need to be moved...sdg
            For counter As Byte = 0 To 2
                For Rows As Byte = 0 To 3
                    For Columns As Byte = 0 To 3
                        'if statement to check whether the tile is a number tile and if it needs to be ...sdg
                        'moved...sdg
                        If Board(Columns, Rows).Image IsNot ptcBlank.Image And Rows <> 3 Then
                            'loop for moving the tile up...sdg
                            For Rows2 As Byte = Rows + 1 To 3
                                'checks to see if a tile is in the way...sdg
                                If Board(Columns, Rows2).Image IsNot ptcBlank.Image Then
                                    'if tile is in the way moves tile beside it...sdg
                                    Board(Columns, Rows2 - 1).Image = Board(Columns, Rows).Image
                                    'checks to see if tile has moved...sdg
                                    If Rows2 - 1 <> Rows Then
                                        Board(Columns, Rows).Image = ptcBlank.Image
                                        Moved = True
                                    End If
                                    'exits for loop...sdg
                                    Exit For
                                ElseIf Board(Columns, Rows2).Image Is ptcBlank.Image And Rows2 = 3 Then
                                    'moves tile...sdg
                                    Board(Columns, Rows2).Image = Board(Columns, Rows).Image
                                    Board(Columns, Rows).Image = ptcBlank.Image
                                    'checks to see if tile has moved...sdg
                                    If Rows2 <> Rows Then
                                        Moved = True
                                    End If
                                    'exits for loop...sdg
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                Next
            Next
            'loops check to see if tiles could be combined when moved down...sdg
            For Columns As Byte = 0 To 3
                'checks to see if the tiles to the bottem are the same...sdg
                If Tile(Columns, 3) = Tile(Columns, 2) And Tile(Columns, 3) <> 11 And Tile(Columns, 2) <> 11 Then
                    'increases the score...sdg
                    lblScoreValue.Text += TileNumberToValue(Tile(Columns, 3) + 1)
                    'upgrades the tile one up from what it used to be...sdg
                    Board(Columns, 3).Image = Tiles(Tile(Columns, 3) + 1).Image
                    'moves tiles to the bottem...sdg
                    Board(Columns, 2).Image = Board(Columns, 1).Image
                    Board(Columns, 1).Image = Board(Columns, 0).Image
                    Board(Columns, 0).Image = ptcBlank.Image
                    'if moved equals false then makes combined true...sdg
                    If Moved = False Then
                        Combined = True
                    End If
                ElseIf Tile(Columns, 2) = Tile(Columns, 1) And Tile(Columns, 2) <> 11 And Tile(Columns, 1) <> 11 Then
                    'increases the score...sdg
                    lblScoreValue.Text += TileNumberToValue(Tile(Columns, 2) + 1)
                    'upgrades the tile one up from what it used to be...sdg
                    Board(Columns, 2).Image = Tiles(Tile(Columns, 2) + 1).Image
                    'moves tiles to the bottem...sdg
                    Board(Columns, 1).Image = Board(Columns, 0).Image
                    Board(Columns, 0).Image = ptcBlank.Image
                    'if moved equals false then makes combined true...sdg
                    If Moved = False Then
                        Combined = True
                    End If
                ElseIf Tile(Columns, 1) = Tile(Columns, 0) And Tile(Columns, 1) <> 11 And Tile(Columns, 0) <> 11 Then
                    'increases the score...sdg
                    lblScoreValue.Text += TileNumberToValue(Tile(Columns, 1) + 1)
                    'upgrades the tile one up from what it used to be...sdg
                    Board(Columns, 1).Image = Tiles(Tile(Columns, 1) + 1).Image
                    'moves tiles to the bottem...sdg
                    Board(Columns, 0).Image = ptcBlank.Image
                    'if moved equals false then makes combined true...sdg
                    If Moved = False Then
                        Combined = True
                    End If
                End If
            Next
        End If
        'if moved or combined equals true ... randomly create knew tile...sdg
        If Moved = True Or Combined = True Then
            'creates variables to assign random values to the rows and columns...sdg
            Dim Row As Byte = Int(3 * Rnd()) + 0
            Dim Column As Byte = Int(3 * Rnd()) + 0
            'creates variable for counter in random loop...sdg
            Dim counter As Byte = 0
            'keeps generating random coordinates on the board for the knew tile ...sdg
            'till it finds a place where the tile can be placed or counter get over 255...sdg
            While Board(Column, Row).Image IsNot ptcBlank.Image And counter < 255
                Row = Int(3 * Rnd()) + 0
                Column = Int(3 * Rnd()) + 0
                counter += 1
            End While
            'if wasn't successful in finding a random position for the tile then...sdg
            'checks through all of the board till finds a blank square and sets the tile there...sdg
            If Board(Column, Row).Image IsNot ptcBlank.Image Then
                For Rows As Byte = 0 To 3
                    For Columns As Byte = 0 To 3
                        If Board(Columns, Rows).Image Is ptcBlank.Image Then
                            Column = Columns
                            Row = Rows
                            Exit For
                        End If
                    Next
                    If Board(Column, Row).Image Is ptcBlank.Image Then
                        Exit For
                    End If
                Next
            End If
            'places the new tile...sdg
            Board(Column, Row).Image = Tiles(Tile2).Image

        End If

        If WinCheck() = True Then
            'declares a variable for user response to exit check...sdg
            Dim Response As Byte
            'hides the current window and opens the exit form...sdg
            Response = MsgBox("You won. Do you want to play again?", 36, "Winner")
            If Response = 6 Then
                'creates a new instannce of the form and closes the old one...sdg
                Dim frmNormal2048 = New frmNormal2048
                frmNormal2048.Show()
                Me.Close()
            Else
                'creates a new instannce of the form and closes the old one and goes back to the main form...sdg
                Dim frmNormal2048 = New frmNormal2048
                frmOverallSplash.Show()
                Me.Close()
            End If

        ElseIf GameOverCheck() = True Then
            'declares a variable for user response to exit check...sdg
            Dim Response As Byte
            'hides the current window and opens the exit form...sdg
            Response = MsgBox("You lost. Do you want to play again?", 36, "Game Over")
            If Response = 6 Then
                'creates a new instannce of the form and closes the old one...sdg
                Dim frmNormal2048 = New frmNormal2048
                frmNormal2048.Show()
                Me.Close()
            Else
                'creates a new instannce of the form and closes the old one and goes back to the main form...sdg
                Dim frmNormal2048 = New frmNormal2048
                frmOverallSplash.Show()
                Me.Close()
            End If
        End If
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sets all the board squares to BlankSquares...sdg
        Board(0, 0) = ptcBlankSquare1
        Board(1, 0) = ptcBlankSquare2
        Board(2, 0) = ptcBlankSquare3
        Board(3, 0) = ptcBlankSquare4
        Board(0, 1) = ptcBlankSquare5
        Board(1, 1) = ptcBlankSquare6
        Board(2, 1) = ptcBlankSquare7
        Board(3, 1) = ptcBlankSquare8
        Board(0, 2) = ptcBlankSquare9
        Board(1, 2) = ptcBlankSquare10
        Board(2, 2) = ptcBlankSquare11
        Board(3, 2) = ptcBlankSquare12
        Board(0, 3) = ptcBlankSquare13
        Board(1, 3) = ptcBlankSquare14
        Board(2, 3) = ptcBlankSquare15
        Board(3, 3) = ptcBlankSquare16
        'assigns all tiles their corresponding tiles...sdg
        Tiles(Tile2) = ptc2
        Tiles(Tile4) = ptc4
        Tiles(Tile8) = ptc8
        Tiles(Tile16) = ptc16
        Tiles(Tile32) = ptc32
        Tiles(Tile64) = ptc64
        Tiles(Tile128) = ptc128
        Tiles(Tile256) = ptc256
        Tiles(Tile512) = ptc512
        Tiles(Tile1024) = ptc1024
        Tiles(Tile2048) = ptc2048
        'makes all the board images...black squares...sdg
        For Columns As Byte = 0 To 3
            For Rows As Byte = 0 To 3
                Board(Columns, Rows).Image = ptcBlank.Image
            Next
        Next
        'randomizes the random numbers created for the rnd function...sdg
        Randomize()
        'places two tiles with value of 2...sdg
        Board(3, 2).Image = Tiles(Tile2).Image
        Board(3, 3).Image = Tiles(Tile2).Image

    End Sub
    'function to get the value of a tile at given position...sdg
    Function Tile(Columns As Byte, Rows As Byte) As Byte
        'compares the tile to all the values in the tile array...sdg
        For types As Byte = 0 To 10
            If Tiles(types).Image Is Board(Columns, Rows).Image Then
                'returns the number in the tile array...sdg
                Return types
            End If
        Next
        'returns 11 if the tile is not found....sdg
        Return 11
    End Function
    'converts a tile number to it's corresponding value...sdg
    Function TileNumberToValue(Number As Byte) As Short
        'converts a tile number to it's corresponding value...sdg
        If Number = 0 Then
            Return 2
        ElseIf Number = 1 Then
            Return 4
        ElseIf Number = 2 Then
            Return 8
        ElseIf Number = 3 Then
            Return 16
        ElseIf Number = 4 Then
            Return 32
        ElseIf Number = 5 Then
            Return 64
        ElseIf Number = 6 Then
            Return 128
        ElseIf Number = 7 Then
            Return 256
        ElseIf Number = 8 Then
            Return 512
        ElseIf Number = 9 Then
            Return 1024
        ElseIf Number = 10 Then
            Return 2048
        End If
        Return 11
    End Function

    Function GameOverCheck() As Boolean


        'two loops to find the tiles that need to be moved...sdg
        For Rows As Byte = 0 To 3
            For Columns As Byte = 0 To 3
                'if statement to check whether the tile is a number tile and if it needs to be ...sdg
                'moved...sdg
                If Board(Columns, Rows).Image Is ptcBlank.Image Then
                    Return False

                End If
            Next
        Next

        'loops check to see if tiles could be combined when moved to the right...sdg
        For Rows As Byte = 0 To 3
            'checks to see if the tiles right to each other to the right are the same...sdg
            If Tile(3, Rows) = Tile(2, Rows) And Tile(3, Rows) <> 11 And Tile(2, Rows) <> 11 Then
                Return False
                'checks to see if the tiles right to each other to the right are the same...sdg
            ElseIf Tile(2, Rows) = Tile(1, Rows) And Tile(2, Rows) <> 11 And Tile(1, Rows) <> 11 Then
                Return False
                'checks to see if the tiles right to each other  are the same...sdg
            ElseIf Tile(1, Rows) = Tile(0, Rows) And Tile(1, Rows) <> 11 And Tile(0, Rows) <> 11 Then
                Return False

            End If
        Next

        'loops check to see if tiles could be combined when moved to the left...sdg
        For Rows As Byte = 0 To 3
            'checks to see if the tiles to the left are the same...sdg
            If Tile(0, Rows) = Tile(1, Rows) And Tile(0, Rows) <> 11 And Tile(1, Rows) <> 11 Then
                Return False

                'checks to see if the tiles to the left are the same...sdg
            ElseIf Tile(1, Rows) = Tile(2, Rows) And Tile(1, Rows) <> 11 And Tile(2, Rows) <> 11 Then
                Return False
                'checks to see if the tiles to the left are the same...sdg
            ElseIf Tile(2, Rows) = Tile(3, Rows) And Tile(2, Rows) <> 11 And Tile(3, Rows) <> 11 Then
                Return False

            End If

        Next
        'loops check to see if tiles could be combined when moved up...sdg
        For Columns As Byte = 0 To 3
            'checks to see if the tiles to the top are the same...sdg
            If Tile(Columns, 0) = Tile(Columns, 1) And Tile(Columns, 0) <> 11 And Tile(Columns, 1) <> 11 Then
                Return False
                'checks to see if the tiles to the top are the same...sdg
            ElseIf Tile(Columns, 1) = Tile(Columns, 2) And Tile(Columns, 1) <> 11 And Tile(Columns, 2) <> 11 Then
                Return False
                'checks to see if the tiles to the top are the same...sdg
            ElseIf Tile(Columns, 2) = Tile(Columns, 3) And Tile(Columns, 2) <> 11 And Tile(Columns, 3) <> 11 Then
                Return False
            End If

        Next
        'loops check to see if tiles could be combined when moved down...sdg
        For Columns As Byte = 0 To 3
            'checks to see if the tiles to the bottem are the same...sdg
            If Tile(Columns, 3) = Tile(Columns, 2) And Tile(Columns, 3) <> 11 And Tile(Columns, 2) <> 11 Then
                Return False
            ElseIf Tile(Columns, 2) = Tile(Columns, 1) And Tile(Columns, 2) <> 11 And Tile(Columns, 1) <> 11 Then
                Return False
            ElseIf Tile(Columns, 1) = Tile(Columns, 0) And Tile(Columns, 1) <> 11 And Tile(Columns, 0) <> 11 Then
                Return False
            End If
        Next
        'if tile couldn't be moved or combined returns true...sdg
        Return True


    End Function
    Function WinCheck() As Boolean

        'two loops to find the tiles that need to be moved...sdg
        For Rows As Byte = 0 To 3
            For Columns As Byte = 0 To 3
                'if statement to check whether a 2048 tile is on the board ...sdg
                If Board(Columns, Rows).Image Is Tiles(Tile2048).Image Then
                    Return True
                End If
            Next
        Next
        'if there was no 2048 file returns false...sdg
        Return False
    End Function

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'declares a variable for user response to exit check...sdg
        Dim Response As Byte
        'hides the current window and opens the exit form...sdg
        Response = MsgBox("Are you sure you want to exit?", 20, "Exit")
        If Response = 6 Then End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        'store information about which form accessed the about form...sdg
        'then shows about form...sdg
        frmOverallSplash.LastForm = frmOverallSplash.Normal2048
        Me.Hide()
        frmAbout.Show()
    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuInstructions.Click
        'shows the instructions for playing the game...sdg
        MsgBox("To play this game move tiles using the arrow keys to combine like tiles till you get desired amount of tiles. If the board fills up before you get there or you run out of moves you lose. Good luck!", 64, "Intructions")
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        'shows the main splash screen...sdg
        Me.Hide()
        frmOverallSplash.Show()
    End Sub

    Private Sub mnuSelector_Click(sender As Object, e As EventArgs) Handles mnuSelector.Click
        'input string...sdg
        Dim UserInput As String = ""
        'asks the user for their input...sdg
        UserInput = InputBox("Please enter a command for where you wish to go in the program (CN2048 = Normal 2048, EGame = English Game, MGame = Math Game CS2048 = Challenge Selector 2048)", "Selector")
        'creates and hides the current form...sdg
        'and goes whereever the user entered they wanted to go...sdg
        If (UserInput = "CN2048") Then
            MsgBox("Already on that form")
        ElseIf (UserInput = "EGame") Then
            'code for english game...sdg
            Me.Hide()
            frmIntro.Show()
        ElseIf (UserInput = "MGame") Then
            'code for math game...sdg
            'when Damjan is done uncomment this code...sdg
            'frmMainMenu.Show()
            ' Me.Hide()
        ElseIf (UserInput = "CS2048") Then
            frmChallengeSelection2048.Show()
            Me.Hide()
        Else
            MsgBox("Invalid Command")
        End If

    End Sub
End Class
