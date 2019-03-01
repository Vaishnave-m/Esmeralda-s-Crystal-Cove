Public Class frmRegularTopics
    Private Sub btn8Ball_Click(sender As Object, e As EventArgs) Handles btn8Ball.Click
        Me.Hide()
        frm8BallLoading.Show()
    End Sub
    Private Sub btnHoroscope_Click(sender As Object, e As EventArgs) Handles btnHoroscope.Click
        Me.Hide()
        frmHoroscopeLoading.Show()
    End Sub
    Private Sub btnLoveCompatibility_Click(sender As Object, e As EventArgs) Handles btnLoveCompatibility.Click
        frmUserIntroductory.Show()
        Me.Hide()
    End Sub
    Private Sub btnPalmReading_Click(sender As Object, e As EventArgs) Handles btnPalmReading.Click
        frmPalmRoom.Show()
        Me.Hide()
    End Sub
    Private Sub btnTarotCard_Click(sender As Object, e As EventArgs) Handles btnTarotCard.Click
        frmLoading.Show()
        Me.Hide()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Hide()
        frmMainPage.Show()
    End Sub
End Class