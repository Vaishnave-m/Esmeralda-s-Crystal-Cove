Imports System.IO
Public Class frmPalmResults
    Private Sub frmPalmResults_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim userPalmResultsFile, userLineFile As StreamReader
        Dim strLineNumber(), strResult() As String
        Dim userPalmResult, userLines As String

        tmrPicChange.Start()

        userPalmResult = ("palmResults.txt")
        userLines = ("userPalm.txt")

        If File.Exists(userLines) Then
            userLineFile = File.OpenText("userPalm.txt")

            Do Until userLineFile.Peek = -1
                strLineNumber = Split(userLineFile.ReadLine(), ",")
            Loop
            userLineFile.Close()
        Else
            Me.Hide()
            frmRegularTopics.Show()
        End If

        If File.Exists(userPalmResult) Then
            userPalmResultsFile = File.OpenText("palmResults.txt")

            Do Until userPalmResultsFile.Peek = -1
                strResult = Split(userPalmResultsFile.ReadLine(), "@")
                For i As Integer = 0 To strResult.Length - 1
                    If strResult(i).Contains(strLineNumber(1)) Then
                        lblResults.Text &= strResult(2)
                    End If
                Next
            Loop
            userPalmResultsFile.Close()
        Else
            Me.Hide()
            frmRegularTopics.Show()
        End If
    End Sub
    Private Sub tmrPicChange_Tick(sender As Object, e As EventArgs) Handles tmrPicChange.Tick
        Static x As Integer

        x += 1

        If x Mod 3 = 0 Then
            picPsychic.Image = My.Resources.purpleSymbolHand
        ElseIf x Mod 3 = 1 Then
            picPsychic.Image = My.Resources.worldSpinning
        ElseIf x Mod 3 = 2 Then
            picPsychic.Image = My.Resources.neonPalmSign
        End If
    End Sub
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        If storyMode = True Then
            tmrPicChange.Stop()
            Me.Hide()
            frmMushroom.Show()
        Else
            tmrPicChange.Stop()
            Me.Hide()
            Application.Restart()
        End If
    End Sub
End Class