Public Class frmLicenseAgreement
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If rdbYes.Checked = False And rdbNo.Checked = False Then
            MessageBox.Show("Please select an option first!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If rdbYes.Checked = True Then
            If MessageBox.Show("Are you sure you accept the terms and conditions?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Me.Hide()
                frmMainPage.Show()
            End If
        End If

        If rdbNo.Checked = True Then
            Application.Exit()
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class