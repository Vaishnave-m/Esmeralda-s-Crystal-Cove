Public Class frmPuzzle
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim puzzlePictures() As PictureBox = {picPuzzle1, picPuzzle2, picPuzzle3, picPuzzle4, picPuzzle5, picPuzzle6, picPuzzle7, picPuzzle8, picPuzzle9}

        For i As Integer = 0 To puzzlePictures.Length - 1
            puzzlePictures(i).AllowDrop = True
        Next
    End Sub
    Private Sub picChakra1_MouseDown(sender As Object, e As MouseEventArgs) Handles picChakra1.MouseDown, picChakra2.MouseDown, picChakra3.MouseDown,
        picChakra4.MouseDown, picChakra5.MouseDown, picChakra6.MouseDown, picChakra7.MouseDown, picChakra8.MouseDown, picChakra9.MouseDown
        'When the mouse hold on this jigsaw pieces, it will drag a copy to my destination. 
        Dim picture As PictureBox

        picture = CType(sender, PictureBox)
        picture.DoDragDrop(picture, DragDropEffects.Copy)
    End Sub
    Private Sub picPuzzle1_DragEnter(sender As Object, e As DragEventArgs) Handles picPuzzle1.DragEnter, picPuzzle2.DragEnter, picPuzzle3.DragEnter,
        picPuzzle4.DragEnter, picPuzzle5.DragEnter, picPuzzle6.DragEnter, picPuzzle7.DragEnter, picPuzzle8.DragEnter, picPuzzle9.DragEnter
        'If my mouse is being clicks and enters any one of the blank puzzle spots, a copy will be made into the blank piece. The original piece
        'disappears.
        Dim picture As PictureBox
        Dim puzzle As PictureBox = sender

        picture = e.Data.GetData(GetType(PictureBox))
        If sender.image Is Nothing Then
            sender.Image = picture.Image
            picture.Visible = False
        End If
        Call CheckWin()
    End Sub
    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        'When restart is clicked, the game resets to original position.
        Dim puzzlePictures() As PictureBox = {picPuzzle1, picPuzzle2, picPuzzle3, picPuzzle4, picPuzzle5, picPuzzle6, picPuzzle7, picPuzzle8, picPuzzle9}
        Dim chakraPictures() As PictureBox = {picChakra1, picChakra2, picChakra3, picChakra4, picChakra5, picChakra6, picChakra7, picChakra8, picChakra9}

        picChakra1.Image = My.Resources.chakra1
        picChakra2.Image = My.Resources.chakra2
        picChakra3.Image = My.Resources.chakra31
        picChakra4.Image = My.Resources.chakra4
        picChakra5.Image = My.Resources.chakra5
        picChakra6.Image = My.Resources.chakra6
        picChakra7.Image = My.Resources.chakra7
        picChakra8.Image = My.Resources.chakra8
        picChakra9.Image = My.Resources.chakra9

        For i As Integer = 0 To puzzlePictures.Length - 1
            puzzlePictures(i).Image = Nothing
            chakraPictures(i).Visible = True
        Next
    End Sub
    'This procedure declares victory by verifying each puzzle picture's image is equal to a chakra's image. If won, controls will appear 
    'to notify the user has won. 
    Private Sub CheckWin()
        Dim puzzlePictures() As PictureBox = {picPuzzle1, picPuzzle2, picPuzzle3, picPuzzle4, picPuzzle5, picPuzzle6, picPuzzle7, picPuzzle8, picPuzzle9}
        Dim chakraPictures() As PictureBox = {picChakra1, picChakra2, picChakra3, picChakra4, picChakra5, picChakra6, picChakra7, picChakra8, picChakra9}

        For i As Integer = 0 To puzzlePictures.Length - 1
            If puzzlePictures(i).Image IsNot chakraPictures(i).Image Then
                Exit Sub
            End If
        Next

        For l As Integer = 0 To puzzlePictures.Length - 1
            puzzlePictures(l).Visible = False
        Next

        btnRestart.Visible = False
        lblWin.Visible = True
        Me.BackColor = Color.FromArgb(7, 0, 17)
        picPotion.Visible = True
        picChiliPepper.Visible = True
        tmrZoomChili.Start()
    End Sub
    Private Sub tmrZoomChili_Tick(sender As Object, e As EventArgs) Handles tmrZoomChili.Tick
        'When the player wins, the potion item will have an animation effect using this timer. 
        picChiliPepper.Width += 5
        picChiliPepper.Height += 5

        If picChiliPepper.Width > 300 Then
            btnMainMenu.Visible = True
            tmrZoomChili.Stop()
            lblWin.ForeColor = Color.Red
            lblWin.Text = "Congratulations! You've received Indian Ghost Peppers."
            pepper = True
            Me.Hide()
            frmRoomLocked.Show()
        End If
    End Sub
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Hide()
        frmRoomLocked.Show()
    End Sub
End Class
