Public Class frmMushroom
    Private Sub frmMushroom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrMushroom.Start()
    End Sub
    Private Sub PlaySystemSound()
        My.Computer.Audio.Play(My.Resources.creepyMusic, AudioPlayMode.Background)
    End Sub
    Private Sub tmrMushroom_Tick(sender As Object, e As EventArgs) Handles tmrMushroom.Tick
        Static x As Integer

        x += 1

        If x = 15 Then
            tmrMushroom.Interval = 70
            picMushroom.Visible = True

            picMushroom.Width += 5
            picMushroom.Height += 5

            If picMushroom.Width > 380 Then
                tmrMushroom.Stop()
                lblWin.ForeColor = Color.FromArgb(203, 160, 86)
                mushroom = True
                lblWin.Text = "Congratulations! You've received Amazonian Amanita Muscaria Mushrooms."
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