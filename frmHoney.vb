Public Class frmHoney
    Private Sub frmHoney_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrHoney.Start()
    End Sub
    Private Sub tmrHoney_Tick(sender As Object, e As EventArgs) Handles tmrHoney.Tick
        Static x As Integer

        x += 1

        If x = 15 Then
            tmrHoney.Interval = 70
            picHoney.Visible = True

            picHoney.Width += 5
            picHoney.Height += 5

            If picHoney.Width > 380 Then
                tmrHoney.Stop()
                lblWin.ForeColor = Color.Gold
                honey = True
                lblWin.Text = "You've received Italian Manuka Honey."
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