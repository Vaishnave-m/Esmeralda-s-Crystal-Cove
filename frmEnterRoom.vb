Public Class frmEnterRoom
    Private i As Integer
    Private strMessage As String
    Private Sub frmProblemRoom_Load(sender As Object, e As EventArgs) Handles Me.Load
        tmrTextEffect.Enabled = True
    End Sub
    Private Sub tmrTextEffect_Tick(sender As Object, e As EventArgs) Handles tmrTextEffect.Tick
        'This timer ensures each message is displayed on the form for a specific amount of timer so the 
        'user has enough time to read the message. 
        Static y As Integer

        y += 1

        If y = 5 Then
            lblUserDialogue.Text = "Hello? Is anyone here?? I'm here to help."
        ElseIf y = 35 Then
            lblUserDialogue.ResetText()
            picEsmeraldaSpeech.Visible = True
        ElseIf y = 75 Then
            picEsmeraldaSpeech.Visible = False
            lblUserDialogue.Text = "Click on the door to enter."
            btnDoor.Visible = True
        End If
    End Sub
    Private Sub btnDoor_MouseEnter(sender As Object, e As EventArgs) Handles btnDoor.MouseEnter
        'Used to create a button effect. 
        btnDoor.FlatAppearance.BorderSize = 3
    End Sub
    Private Sub btnDoor_MouseLeave(sender As Object, e As EventArgs) Handles btnDoor.MouseLeave
        btnDoor.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub btnDoor_Click(sender As Object, e As EventArgs) Handles btnDoor.Click
        Me.Hide()
        frmRoomLocked.Show()
    End Sub
End Class