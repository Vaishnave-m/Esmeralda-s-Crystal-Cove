Public Class frmHoroscopeStory
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        frmHoroscopes.Show()
        Me.Hide()
    End Sub
End Class