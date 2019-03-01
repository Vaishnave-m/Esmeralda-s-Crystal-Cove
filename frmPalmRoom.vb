Imports System.IO
Public Class frmPalmRoom
    Private pictureNumberClick As Integer
    Private nextLineClick As Integer
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        tmrPalm.Enabled = True
        picPalm.Visible = True
        btnNext.Visible = False
    End Sub
    Private Sub tmrPalm_Tick(sender As Object, e As EventArgs) Handles tmrPalm.Tick
        'The timer enables the picture of the basepalm to move up each timer tick to create an animation.
        Static x As Integer

        picPalm.Top -= 10
        x += 20

        If x > 770 Then
            tmrPalm.Enabled = False
            lblDescription.Visible = True
            lblLineSelection.Visible = True
            btnNextLine.Visible = True
            tmrPalm.Enabled = False
            Call LineDescription()
        End If
    End Sub
    'This procedure used the number of clicks to determine which description of the line to display. The description
    'provides insight on what the line represents. 
    Private Sub LineDescription()
        Dim lineDetails As String
        Dim lineType As String

        Select Case nextLineClick
            Case 0
                lineDetails = "The head line reflects your beliefs, philosopy, attitude and approach to life. 
It represents your mind-set and intelligence."
                lineType = "Head Line"
            Case 1
                lineDetails = "The life line It reflects physical health, general well-being, and major life 
changes (cataclysmic events, physical injuries, and recolation).Your basic physical vitality and life energy are reflected in this line."
                lineType = "Life Line"
            Case 2
                lineDetails = "The heart line indicates emotional stability, romantic perspectives, depression, and cardiac health.
If your love and marriage life go smoothly and whether you could have a good personal relationship can all be reflected from the line.  "
                lineType = "Heart Line"
            Case 3
                lineDetails = "The destiny line reflects the fortune of one's career or job. From the line, you can find out the 
changes of your career during your life as well as your ability in work."
                lineType = "Destiny Line"
        End Select

        lblInstruction.ForeColor = Color.Gold
        lblInstruction.Font = New Font("Blackadder ITC", 42)
        lblInstruction.Text = "Esmeralda will now look at your " & lineType & " ."
        lblLineSelection.Text = "Select the line that best ressembles your " & lineType & " ."
        lblDescription.Text = lineDetails

    End Sub
    Private Sub btnNextLine_Click(sender As Object, e As EventArgs) Handles btnNextLine.Click
        'When the next button is clicked, depending on the mouse clicks which represents the picture number,
        'the program call a procedure and pass down  the clicks. 

        pictureNumberClick += 1
        btnYes.Visible = True

        If nextLineClick = 1 Then
            Call LifeLine(pictureNumberClick)
        ElseIf nextLineClick = 2 Then
            Call HeartLine(pictureNumberClick)
        ElseIf nextLineClick = 3 Then
            Call DestinyLine(pictureNumberClick)
        Else
            Call HeadLine(pictureNumberClick)
        End If

        If pictureNumberClick = 5 Then
            pictureNumberClick = 1
        End If
    End Sub
    'This procedure uses clicks to determine which image of the head line to display. 
    Private Sub HeadLine(clicks)

        Select Case clicks
            Case 1
                picPalm.Image = My.Resources.head_line_1
                picPalm.Tag = 1
            Case 2
                picPalm.Image = My.Resources.head_line_2
                picPalm.Tag = 2
            Case 3
                picPalm.Image = My.Resources.head_line_3
                picPalm.Tag = 3
            Case 4
                picPalm.Image = My.Resources.head_line_4
                picPalm.Tag = 4
            Case 5
                picPalm.Image = My.Resources.head_line_5
                picPalm.Tag = 5
        End Select
    End Sub
    'This procedure uses clicks to determine which image of the life line to display. 
    Private Sub LifeLine(clicks)
        Select Case clicks
            Case 1
                picPalm.Image = My.Resources.life_line_1
                picPalm.Tag = 1
            Case 2
                picPalm.Image = My.Resources.life_line_2
                picPalm.Tag = 2
            Case 3
                picPalm.Image = My.Resources.life_line_3
                picPalm.Tag = 3
            Case 4
                picPalm.Image = My.Resources.life_line_4
                picPalm.Tag = 4
            Case 5
                picPalm.Image = My.Resources.life_line_5
                picPalm.Tag = 5
        End Select
    End Sub
    'This procedure uses clicks to determine which image of the heart line to display.
    Private Sub HeartLine(clicks)
        Select Case clicks
            Case 1
                picPalm.Image = My.Resources.heart_line_1
                picPalm.Tag = 1
            Case 2
                picPalm.Image = My.Resources.heart_line_2
                picPalm.Tag = 2
            Case 3
                picPalm.Image = My.Resources.heart_line_3
                picPalm.Tag = 3
            Case 4
                picPalm.Image = My.Resources.heart_line_4
                picPalm.Tag = 4
            Case 5
                picPalm.Image = My.Resources.heart_line_5
                picPalm.Tag = 5
        End Select
    End Sub
    'This procedure uses clicks to determine which image of the destiny line to display.
    Private Sub DestinyLine(clicks)
        Select Case clicks
            Case 1
                picPalm.Image = My.Resources.destiny_line_1
                picPalm.Tag = 1
            Case 2
                picPalm.Image = My.Resources.destiny_line_2
                picPalm.Tag = 2
            Case 3
                picPalm.Image = My.Resources.destiny_line_3
                picPalm.Tag = 3
            Case 4
                picPalm.Image = My.Resources.destiny_line_4
                picPalm.Tag = 4
            Case 5
                picPalm.Image = My.Resources.destiny_line_5
                picPalm.Tag = 5
        End Select
    End Sub
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        'When the yes button is clicked, depending on the mouse clicks on the button, the program calculates 
        'which line to display next.
        Dim line As String

        nextLineClick += 1
        btnYes.Visible = False
        Select Case nextLineClick
            Case 1
                line = "Head Line"
                picPalm.Image = My.Resources.life_line_1
            Case 2
                line = "Life Line"
                picPalm.Image = My.Resources.heart_line_1
            Case 3
                line = "Heart Line"
                picPalm.Image = My.Resources.destiny_line_1
            Case 4
                line = "Destiny Line"
                Call PalmReadingResults()

        End Select

        pictureNumberClick = 0

        Call LineDescription()
        Call AddPalmInfo(line)
    End Sub
    'This procedure write into a text file and stores which lines the user picked. This text file will
    'be accessed later to determine what results/description to display. 
    Private Sub AddPalmInfo(lineType)
        Dim userPalmFile As StreamWriter

        If lineType = "Head Line" Then
            userPalmFile = File.CreateText("userPalm.txt")
            userPalmFile.Close()
        End If

        userPalmFile = File.AppendText("userPalm.txt")
        Select Case picPalm.Tag
            Case 0 Or 1
                userPalmFile.Write(lineType & ",1")
            Case 2
                userPalmFile.Write(lineType & ",2")
            Case 3
                userPalmFile.Write(lineType & ",3")
            Case 4
                userPalmFile.Write(lineType & ",4")
            Case 5
                userPalmFile.Write(lineType & ",5")
        End Select

        userPalmFile.WriteLine()
        userPalmFile.Close()
    End Sub
    Private Sub PalmReadingResults()
        Reset()
        Me.BackColor = Color.Beige
        frmEsmeraldaLoading.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub frmPalmRoom_Load(sender As Object, e As EventArgs) Handles Me.Load
        If storyMode = True Then
            lblInstruction.Text = "This looks like Esmeralda's palm reading room. May as well read my destiny."
        End If
    End Sub
End Class
