Imports System.IO
Public Class frmExplainCard
    Private Sub frmExplainCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Activated
        Call DisplayCard(cardNumber)

        Select Case cardNumber
            Case 1
                lblHeading.Text = "P A S T"
                Call CardDescription(cardPast)
            Case 2
                lblHeading.Text = "P R E S E N T"
                Call CardDescription(cardPresent)
            Case 3
                lblHeading.Text = "F U T U R E"
                Call CardDescription(cardFuture)
        End Select
    End Sub
    Private Sub DisplayCard(num)
        If cardNumber = 1 Then
            num = rand1
        ElseIf cardNumber = 2 Then
            num = rand2
        ElseIf cardNumber = 3 Then
            num = rand3
        End If

        Select Case num
            Case 1
                picCard.Image = My.Resources.magician
            Case 2
                picCard.Image = My.Resources.popess
            Case 3
                picCard.Image = My.Resources.empress
            Case 4
                picCard.Image = My.Resources.emperor
            Case 5
                picCard.Image = My.Resources.pope
            Case 6
                picCard.Image = My.Resources.lovers
            Case 7
                picCard.Image = My.Resources.chariot
            Case 8
                picCard.Image = My.Resources.justice
            Case 9
                picCard.Image = My.Resources.hermit
            Case 10
                picCard.Image = My.Resources.wheeloffortune
            Case 11
                picCard.Image = My.Resources.strength
            Case 12
                picCard.Image = My.Resources.the_hanged_man
            Case 13
                picCard.Image = My.Resources.death
            Case 14
                picCard.Image = My.Resources.temperance
            Case 15
                picCard.Image = My.Resources.the_devil
        End Select
    End Sub
    Private Sub CardDescription(cardName)
        Dim pastFile, presentFile, futureFile As StreamReader
        Dim past, present, future As String
        Dim str() As String

        past = "Past.txt"
        present = "Present.txt"
        future = "Future.txt"

        Select Case cardNumber
            Case 1
                pastFile = File.OpenText(past)
                Do Until pastFile.Peek = -1
                    str = Split(pastFile.ReadLine(), "@")
                    If str(0) = cardName Then
                        lblDescription.Text = str(1)
                    End If
                Loop
            Case 2
                presentFile = File.OpenText(present)
                Do Until presentFile.Peek = -1
                    str = Split(presentFile.ReadLine(), "@")
                    If str(0) = cardName Then
                        lblDescription.Text = str(1)
                    End If
                Loop
            Case 3
                futureFile = File.OpenText(future)
                Do Until futureFile.Peek = -1
                    str = Split(futureFile.ReadLine(), "@")
                    If str(0) = cardName Then
                        lblDescription.Text = str(1)
                    End If
                Loop
        End Select
    End Sub
    Private Sub btnBackToResults_Click(sender As Object, e As EventArgs) Handles btnBackToResults.Click
        picCard.Image = Nothing
        lblDescription.Text = Nothing
        Me.Hide()
        frmTarotResults.Show()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        If storymode = True Then
            Me.Hide()
            frmRoomLocked.Show()
        Else
            Me.Hide()
            frmMainPage.Show()
        End If
    End Sub
End Class