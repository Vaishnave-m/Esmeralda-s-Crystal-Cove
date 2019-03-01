Public Class frmBooth
    Private i As Integer
    Private strMessage As String
    Private Sub frmBooth_Load(sender As Object, e As EventArgs) Handles Me.Load
        My.Computer.Audio.Play(My.Resources.creepyMusic, AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'strMessage is given a value, and the appripriate controls reset to invisible/nothing. 
        i = 0
        lblUserDialogue.ResetText()
        strMessage = MessageOrder()
        tmrTextEffect.Enabled = True
    End Sub
    Private Sub tmrTextEffect_Tick(sender As Object, e As EventArgs) Handles tmrTextEffect.Tick
        'A type writer effect is created using this timer by  using a string function and displaying one letter at a time in the tick event. 
        i += 1
        lblUserDialogue.Text += strMessage.Substring(i - 1, 1)

        If i = strMessage.Length Then
            tmrTextEffect.Enabled = False
            btnNext.Visible = True
        End If
    End Sub
    Private Function MessageOrder()
        'Depending on the nubmber of mouse clicks , the appropriate message is returned from this function. This function has the user internal 
        'dialogue displayed on the form.
        Static click As Integer
        click += 1

        Select Case click
            Case 1
                strMessage = "This has been the best day ever! Oh no!...it's almost 10:30. I better leave before my curfew reaches!"
            Case 2
                strMessage = "Wait I haven't been to this booth yet...Why is it so far off from the carnival? It looks abandonned!"
                Me.BackgroundImage = My.Resources.introTentScene
            Case 3
                strMessage = "What does the sign say? Fortune Tellers??? Aren't they those weird people who see into your future?"
            Case 4
                strMessage = "Psychics aren't even real and are frauds... they just cheat people by making up lies."
            Case 5
                strMessage = "Wait... what's that light? Is someone in there??"
                btnNext.Top -= 40
            Case 6
                picEsmeraldaSpeech.Visible = True
                strMessage = "                                                     "
            Case 7
                picEsmeraldaSpeech.Visible = False
                strMessage = "Oh my god! Poor lady...I need to go in and help her. "
            Case 8
                Me.Hide()
                frmEnterRoom.Show()
        End Select

        Return strMessage
    End Function
End Class
