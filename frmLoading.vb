Public Class frmLoading
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnReadMyFortune.Click
        lblInstructionTarot.Visible = False
        btnReadMyFortune.Visible = False
        picDeck.Visible = False

        Me.BackgroundImage = Nothing

        For fadein = 0.3 To 1 Step 0.05
            Me.Opacity = fadein
            Me.Refresh()
            Threading.Thread.Sleep(100)
        Next

        picDeck.Visible = True
        btnShuffle.Visible = True
        picDeck.Left -= 50
        tmrZoom.Enabled = True
    End Sub
    Private Sub btnShuffle_Click(sender As Object, e As EventArgs) Handles btnShuffle.Click
        Me.Hide()
        frmTarotResults.Show()
    End Sub
    Private Sub tmrZoom_Tick(sender As Object, e As EventArgs) Handles tmrZoom.Tick
        picDeck.Height += 10
        picDeck.Width += 10

        If picDeck.Height > 350 Then
            tmrZoom.Enabled = False
        End If
    End Sub
    Private Sub btnStop_Click(sender As Object, e As EventArgs)
        frmTarotResults.Show()
        Call Reset()
        Me.Hide()
    End Sub
    Private Sub Reset()
        lblInstructionTarot.Visible = True
        btnReadMyFortune.Visible = True
        picDeck.Visible = True
        Me.BackgroundImage = My.Resources.bluetable
        picDeck.Visible = False
        btnShuffle.Visible = False
        picDeck.Left += 50
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub
End Class
