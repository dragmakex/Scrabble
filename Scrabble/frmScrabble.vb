Public Class frmScrabble
    Dim b As Bag
    Dim item As String
    Dim arrpic(7) As PictureBox
    Dim arrwords(58113) As String
    Dim dictnumitems As Integer
    Dim word As String
    Dim score As Integer
    Dim tempscore As Integer

    Structure Tile
        Dim letter As String
        Dim v As Integer

        Function getTstr() As String

            getTstr = letter + "-" + Str(v)

        End Function
    End Structure

    Structure Bag
        Dim arrbag() As Tile
        Sub Fill()
            Dim path As String

            ReDim arrbag(100)
            Dim line As String
            Dim letter As String
            Dim value As String
            Dim num As Integer
            Dim spacepos1 As Integer
            Dim spacepos2 As Integer
            Dim i As Integer
            Dim c As Integer = 0
            path = "F:\Locker\Files\Projects\CP II\VB.NET\Scrabble\Scrabble Resources\scrabblevalues.txt"
            FileOpen(1, path, OpenMode.Input)
            Do While Not EOF(1)
                line = Trim(LineInput(1))

                For i = 1 To line.Length
                    If Mid(line, i, 1) = " " And spacepos1 = Nothing Then
                        spacepos1 = i
                    ElseIf Mid(line, i, 1) = " " Then
                        spacepos2 = i
                    End If
                Next

                letter = Mid(line, 1, 1)
                value = Mid(line, 3, spacepos2 - 3)
                num = Mid(line, spacepos2 + 1, line.Length - spacepos2)

                For i = 1 To num
                    arrbag(c).letter = letter
                    arrbag(c).v = value
                    c += 1
                Next

            Loop

            FileClose(1)


        End Sub



        Sub Shuffle()
            Dim rnum As Integer
            Dim temp1 As Tile

            Randomize()

            For I = 1 To 100
                rnum = Int(Rnd() * 100) + 1
                temp1 = arrbag(I)
                arrbag(I) = arrbag(rnum)
                arrbag(rnum) = temp1
            Next I



            'For i = 1 To 100
            'frmScrabble.lstTiles.Items.Add(arrbag(i).letter & " " & arrbag(i).v)
            'Next


        End Sub

        Sub Deal()
            Dim phand(7) As Tile
            Dim path As String
            path = "F:\Locker\Files\Projects\CP II\VB.NET\Scrabble\Tiles\"
            For i = 1 To 7
                frmScrabble.arrpic(i).ImageLocation = path + arrbag(i).letter + ".jpg"
            Next
        End Sub
    End Structure


    Private Sub frmScrabble_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setcontrollarray()

    End Sub

    Private Sub lstTiles_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdFill_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub cmdShuff_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub FillToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Sub setcontrollarray()
        arrpic(1) = pic1
        arrpic(2) = pic2
        arrpic(3) = pic3
        arrpic(4) = pic4
        arrpic(5) = pic5
        arrpic(6) = pic6
        arrpic(7) = pic7

    End Sub

    Sub checkword()

        Dim low As Integer
        Dim high As Integer
        Dim mid As Integer
        Dim pos As Integer

        pos = 0
        high = 58112
        low = 1


        Do While low <= high
            mid = Int((low + high) / 2)
            If Trim(LCase(word)) < Trim(LCase(arrwords(mid))) Then
                high = mid - 1
            ElseIf Trim(LCase(word)) > Trim(LCase(arrwords(mid))) Then
                low = mid + 1
            ElseIf Trim(LCase(word)) = Trim(LCase(arrwords(mid))) Then
                pos = mid
                MsgBox("Great job for finding:" & " " & word & "!" & " " & "Five seconds added.")
                score = tempscore
                lblScore.Text = score
                word = ""
                lblWord.Text = ""
                lblTime.Text = lblTime.Text + 5
                Exit Do

            End If
        Loop

        If pos = 0 Then
            MsgBox("Doesn't exist! Ten seconds deducted.", vbCritical)
            lblWord.Text = ""
            word = ""
            tempscore = 0
            lblTime.Text = lblTime.Text - 10
        Else
            low = 1
            high = 58112
            pos = 0
        End If
        'binary search


    End Sub

    Sub Filldict() 'fill the array of words
        Dim path As String
        Dim i As Integer

        dictnumitems = 1
        path = "F:\Locker\Files\Projects\CP II\VB.NET\Scrabble\Scrabble Resources\dictionary.txt"

        FileOpen(1, path, OpenMode.Input)

        For i = 1 To 58112
            arrwords(i) = LineInput(1)

            dictnumitems = dictnumitems + 1
        Next i
        'lstDict.Items.Add(arrwords(1))
        FileClose(1)
        'Label2.Text = dictnumitems
    End Sub

    Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartToolStripMenuItem.Click

        'lstDict.Items.Clear()
        'lstTiles.Items.Clear()
        Timer1.Enabled = True
        For i = 1 To 7
            arrpic(i).Visible = True
        Next
        b.Fill()
        b.Shuffle()
        Filldict()
        b.Deal()
        cmdCheck.Visible = True

    End Sub

    Private Sub pic1_Click(sender As Object, e As EventArgs) Handles pic1.Click, pic2.Click, pic3.Click, pic4.Click, pic5.Click, pic6.Click, pic7.Click
        sender.hide() 'clicking on a letter
        Dim answer As String

        If Mid(sender.imagelocation, 54, 1) = "+" Then
            answer = Trim(UCase(InputBox("What letter do wish for?")))
            word = word + answer
            lblWord.Text = word
        Else
            word = word + Mid(sender.imagelocation, 54, 1)
            lblWord.Text = word
        End If

        If Mid(sender.imagelocation, 54, 1) = "A" Then
            tempscore = tempscore + 1
        ElseIf Mid(sender.imagelocation, 54, 1) = "B" Then
            tempscore = tempscore + 3
        ElseIf Mid(sender.imagelocation, 54, 1) = "C" Then
            tempscore = tempscore + 3
        ElseIf Mid(sender.imagelocation, 54, 1) = "D" Then
            tempscore = tempscore + 2
        ElseIf Mid(sender.imagelocation, 54, 1) = "E" Then
            tempscore = tempscore + 1
        ElseIf Mid(sender.imagelocation, 54, 1) = "F" Then
            tempscore = tempscore + 4
        ElseIf Mid(sender.imagelocation, 54, 1) = "G" Then
            tempscore = tempscore + 2
        ElseIf Mid(sender.imagelocation, 54, 1) = "H" Then
            tempscore = tempscore + 4
        ElseIf Mid(sender.imagelocation, 54, 1) = "I" Then
            tempscore = tempscore + 1
        ElseIf Mid(sender.imagelocation, 54, 1) = "J" Then
            tempscore = tempscore + 8
        ElseIf Mid(sender.imagelocation, 54, 1) = "K" Then
            tempscore = tempscore + 5
        ElseIf Mid(sender.imagelocation, 54, 1) = "L" Then
            tempscore = tempscore + 1
        ElseIf Mid(sender.imagelocation, 54, 1) = "M" Then
            tempscore = tempscore + 3
        ElseIf Mid(sender.imagelocation, 54, 1) = "N" Then
            tempscore = tempscore + 1
        ElseIf Mid(sender.imagelocation, 54, 1) = "O" Then
            tempscore = tempscore + 1
        ElseIf Mid(sender.imagelocation, 54, 1) = "P" Then
            tempscore = tempscore + 3
        ElseIf Mid(sender.imagelocation, 54, 1) = "Q" Then
            tempscore = tempscore + 10
        ElseIf Mid(sender.imagelocation, 54, 1) = "R" Then
            tempscore = tempscore + 1
        ElseIf Mid(sender.imagelocation, 54, 1) = "S" Then
            tempscore = tempscore + 1
        ElseIf Mid(sender.imagelocation, 54, 1) = "T" Then
            tempscore = tempscore + 1
        ElseIf Mid(sender.imagelocation, 54, 1) = "U" Then
            tempscore = tempscore + 1
        ElseIf Mid(sender.imagelocation, 54, 1) = "V" Then
            tempscore = tempscore + 4
        ElseIf Mid(sender.imagelocation, 54, 1) = "W" Then
            tempscore = tempscore + 4
        ElseIf Mid(sender.imagelocation, 54, 1) = "X" Then
            tempscore = tempscore + 8
        ElseIf Mid(sender.imagelocation, 54, 1) = "Y" Then
            tempscore = tempscore + 4
        ElseIf Mid(sender.imagelocation, 54, 1) = "Z" Then
            tempscore = tempscore + 10
        End If

        If answer = "A" Or answer = "E" Or answer = "I" Or answer = "L" Or answer = "N" Or answer = "O" Or answer = "R" Or answer = "S" Or answer = "T" Or answer = "U" Then
            tempscore = tempscore + 1
        End If

        If answer = "D" Or answer = "G" Then
            tempscore = tempscore + 2
        End If

        If answer = "B" Or answer = "C" Or answer = "M" Or answer = "P" Then
            tempscore = tempscore + 3
        End If

        If answer = "Z" Or answer = "Q" Then
            tempscore = tempscore + 10
        End If

        If answer = "F" Or answer = "H" Or answer = "V" Or answer = "W" Or answer = "Y" Then
            tempscore = tempscore + 4
        End If

        If answer = "J" Or answer = "X" Then
            tempscore = tempscore + 8
        End If
        lblScore.Text = score
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'lstDict.Items.Clear()
        'lstTiles.Items.Clear()
        For i = 1 To 7
            arrpic(i).Visible = False
        Next
        lblWord.Text = ""
        'Label2.Text = ""
        word = ""
        Timer1.Enabled = False
        lblTime.Text = "80"
        lblScore.Text = "0"
        score = 0
        tempscore = 0
    End Sub

    Private Sub cmdCheck_Click(sender As Object, e As EventArgs) Handles cmdCheck.Click
        checkword()
    End Sub

    Private Sub ReplaceTilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplaceTilesToolStripMenuItem.Click

        Dim path As String
        path = "F:\Locker\Files\Projects\CP II\VB.NET\Scrabble\Tiles\"
        For i = 1 To 7
            If arrpic(i).Visible = False Then
                arrpic(i).ImageLocation = path + b.arrbag(i + 7).letter + ".jpg"
                arrpic(i).Visible = True
            End If
        Next
    End Sub
    Sub sortwords()
        'declare pointer into the array
        Dim j As Integer
        'declare the shrink factor as a constant
        Const shrink = 1.3
        'declare gap
        Dim gap As Single
        'declare space for swapping
        Dim temp As String
        Dim swapped As Integer
        'the indefinite looop stops when list is sorted
        gap = dictnumitems

        Do
            gap = Int(gap / shrink)
            'the gap must not be less than 1
            If gap < 1 Then gap = 1
            swapped = False
            For j = 1 To dictnumitems - gap
                'compare elements, gap apart
                If arrwords(j) > arrwords(j + gap) Then
                    'swap
                    temp = arrwords(j)
                    arrwords(j) = arrwords(j + gap)
                    arrwords(j + gap) = temp
                    'swap did occur
                    swapped = True
                End If
            Next j
        Loop Until Not swapped And gap = 1

        'put sorted values into list

    End Sub

    Sub getscore()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = lblTime.Text - 1
        If lblTime.Text = "0" Then
            Timer1.Enabled = False
            Timer2.Enabled = True
            MsgBox("TIME IS UP!")
            MsgBox("Your score is:" & " " & score)

            For i = 1 To 7
                arrpic(i).Enabled = False
            Next
            cmdCheck.Enabled = False

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If lblTime.Visible = True Then
                lblTime.Visible = False
            End If

            If lblTime.Visible = False Then
                lblTime.Visible = True
            End If

    End Sub
End Class