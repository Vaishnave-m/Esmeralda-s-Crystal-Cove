Public Class frmHumanHeart
    Private Sub frmHumanHeart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrHeart.Start()
    End Sub
    Private Sub PlaySystemSound()
        My.Computer.Audio.Play(My.Resources.creepyMusic, AudioPlayMode.Background)
    End Sub
    Private Sub tmrHeart_Tick(sender As Object, e As EventArgs) Handles tmrHeart.Tick
        Static x As Integer

        x += 1

        If x = 15 Then
            tmrHeart.Interval = 70
            picHoney.Visible = True

            picHoney.Width += 5
            picHoney.Height += 5

            If picHoney.Width > 380 Then
                tmrHeart.Stop()
                lblWin.ForeColor = Color.LightPink
                heart = True
                lblWin.Text = "You've received a Pegasus's heart."
                Exit Sub
            End If
            x = 14
        End If
    End Sub
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Hide()
        frmRoomLocked.Show()
    End Sub
End Class