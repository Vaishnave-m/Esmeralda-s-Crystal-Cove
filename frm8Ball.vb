Public Class frm8Ball
    Private count As Integer = 0
    Private rand As New Random
    Private num As Integer

    Private Sub frm8Ball_Load(sender As Object, e As EventArgs) Handles Me.Load
        If storyMode = True Then
            btnMainMenu.Text = "Main Room"
        End If

        txtQuestion.Focus()
        My.Computer.Audio.Play(My.Resources._8BallBackground1, AudioPlayMode.Background)
    End Sub
    'Checks if text has been entered in the text
    'box and starts generating a random answer.
    Private Sub btnShake_Click(sender As Object, e As EventArgs) Handles btnShake.Click
        If txtQuestion.Text = String.Empty Then
            MessageBox.Show("You must enter a question first for it to be answered!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            lblAsk.Visible = False
            lblGenerate.Visible = True
            pct8Ball.Image = My.Resources.tumblr_na4jrdL4xa1sp2uy4o1_400
            tmrShake.Start()
        End If
    End Sub
    '8Ball that generates a random answer based 
    'on what the user inputted.
    Private Sub tmrShake_Tick(sender As Object, e As EventArgs) Handles tmrShake.Tick
        count += 1

        num = rand.Next(1, 13)

        lblDisplay.Visible = True

        If count = 10 Then
            Select Case num
                Case 1
                    pct8Ball.Image = My.Resources.AbsolutelyNot
                    lblDisplay.Text = "Absolutely Not!"
                Case 2
                    pct8Ball.Image = My.Resources.AllSignsPointToYes
                    lblDisplay.Text = "All Signs Point To Yes!"
                Case 3
                    pct8Ball.Image = My.Resources.AskAgainLater
                    lblDisplay.Text = "Ask Again Later..."
                Case 4
                    pct8Ball.Image = My.Resources.MostDefinitely
                    lblDisplay.Text = "Most Definitely!"
                Case 5
                    pct8Ball.Image = My.Resources.MostLikely
                    lblDisplay.Text = "Most Likely"
                Case 6
                    pct8Ball.Image = My.Resources.MySourcesSayNo
                    lblDisplay.Text = "My Sources Say No"
                Case 7
                    pct8Ball.Image = My.Resources.ItIsCertain
                    lblDisplay.Text = "It Is Certain!"
                Case 8
                    pct8Ball.Image = My.Resources.YouMayRelyOnIt
                    lblDisplay.Text = "You May Rely On It"
                Case 9
                    pct8Ball.Image = My.Resources.WithoutADoubt
                    lblDisplay.Text = "Without A Doubt!"
                Case 10
                    pct8Ball.Image = My.Resources.VeryDoubtful
                    lblDisplay.Text = "Very Doubtful"
                Case 11
                    pct8Ball.Image = My.Resources.SignsPointToYes
                    lblDisplay.Text = "Signs Point To Yes!"
                Case 12
                    pct8Ball.Image = My.Resources.Don_tCountOnIt
                    lblDisplay.Text = "Don't Count On It"
            End Select

            txtQuestion.Text = String.Empty
            txtQuestion.Focus()
            lblGenerate.Visible = False
            tmrShake.Stop()
            count = 0
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        If storymode = True Then
            Me.Hide()
            frmHoney.Show()
        Else
            Me.Hide()
            Application.Restart()
        End If
    End Sub
End Class