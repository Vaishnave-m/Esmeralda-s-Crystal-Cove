Public Class frmMathGame
    Private answer As Double
    Private timeLeft As Integer = 31
    Private correctAnswers As Integer
    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If frog = True Then
            btnMainMenu.Visible = True
        End If
        tmrCountDown.Start()
        Call GenerateQuestion()
    End Sub
    Private Sub PlaySystemSound()
        My.Computer.Audio.Play(My.Resources.creepyMusic, AudioPlayMode.Background)
    End Sub
    Private Sub tmrCountDown_Tick(sender As Object, e As EventArgs) Handles tmrCountDown.Tick
        'If timeLeft is greater than 0, the value will be displayed in the label. If it is equal to 0, the timer will 
        'stop and check if the user has answered more than 25 questions correctly. If user wins, a potion ingredient
        'will be displayed. If they lose, a messagebox will ask the user to play again. 

        If timeLeft > 0 Then
            timeLeft -= 1
            lblCountDown.Text = "00:" & timeLeft
        Else
            lblCountDown.Text = "0:00"
            If correctAnswers > 10 Then
                tmrCountDown.Stop()
                Me.BackColor = Color.FromArgb(7, 0, 17)
                lblCountDown.Visible = False
                lblWin.Visible = True
                tmrCountDown.Start()
                tmrCountDown.Interval = 70
                picPotion.Visible = True
                picFrog.Visible = True
                picFrog.Width += 5
                picFrog.Height += 5
                picFrog.Top -= 3

                If picFrog.Width > 275 Then
                    btnMainMenu.Visible = True
                    tmrCountDown.Stop()
                    picPotion.Visible = True
                    lblWin.Text = "Congratulations! You've received a frog from the Congo."
                    lblWin.ForeColor = Color.ForestGreen
                    frog = True
                End If
            Else
                tmrCountDown.Stop()
                Call Reset()
                tmrCountDown.Start()
                correctAnswers = 0
                Call GenerateQuestion()
            End If
        End If
    End Sub
    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Call CheckAnswer()
        Call GenerateQuestion()
    End Sub
    Private Sub GenerateQuestion()
        'The operation signs are randomized in an array. According to the sign, a first digit, a second digit 
        'and answer is generated to form a math question. All the info is then displayed in the respective labels. 

        Dim operationSigns() As String = {"+", "-", "*", "/"}
        Dim displayedOperator As String
        Dim numberOne, numberTwo As Integer
        Dim rand As New Random

        displayedOperator = operationSigns(CInt(Rnd() * 3))
        numberOne = rand.Next(1, 11)
        numberTwo = rand.Next(1, 11)

        Select Case displayedOperator
            Case "+"
                answer = numberOne + numberTwo
            Case "-"
                answer = numberOne - numberTwo
            Case "*"
                answer = numberOne * numberTwo
            Case "/"
                answer = Math.Round(numberOne / numberTwo, 1)
        End Select

        lblMathProblem.Text = numberOne & " " & displayedOperator & " " & numberTwo & " = "
        txtUserAnswer.Text = ""
        txtUserAnswer.Focus()
    End Sub
    'This procedure checks the answer the user has entered every time enter is clicked. The results is displayed.
    Private Sub CheckAnswer()
        If answer = Val(txtUserAnswer.Text) Then
            lblRightOrWrong.Text = "You are correct!"
            correctAnswers += 1
        Else
            lblRightOrWrong.Text = "Oh NO! Incorrect answer!"
            txtUserAnswer.Text = Nothing
            txtUserAnswer.Focus()
        End If
    End Sub
    'This procedure prompts the user to play again. If chosen yes, the form, timer and labels are reset so the user
    'can play the game again. 
    Private Sub Reset()
        Dim answer As DialogResult

        answer = MessageBox.Show("Oh No! You lost. Play again or else you will be vaporized.", "Esmeralda's Crystal Cove",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information)
        If answer = DialogResult.OK Then
            timeLeft = 31
            lblMathProblem.ResetText()
            lblRightOrWrong.ResetText()
        End If
    End Sub
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Hide()
        frmRoomLocked.Show()
    End Sub
End Class