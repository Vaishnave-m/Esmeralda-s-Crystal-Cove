<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExplainCard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnBackToResults = New System.Windows.Forms.Button()
        Me.picCard = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        CType(Me.picCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Centaur", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblDescription.Location = New System.Drawing.Point(330, 92)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(660, 589)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHeading.Font = New System.Drawing.Font("Copperplate Gothic Bold", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Maroon
        Me.lblHeading.Location = New System.Drawing.Point(383, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(268, 72)
        Me.lblHeading.TabIndex = 2
        Me.lblHeading.Text = "P A S T"
        '
        'btnBackToResults
        '
        Me.btnBackToResults.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBackToResults.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBackToResults.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackToResults.ForeColor = System.Drawing.Color.PaleGreen
        Me.btnBackToResults.Location = New System.Drawing.Point(12, 542)
        Me.btnBackToResults.Name = "btnBackToResults"
        Me.btnBackToResults.Size = New System.Drawing.Size(369, 64)
        Me.btnBackToResults.TabIndex = 3
        Me.btnBackToResults.Text = "Back to the Results"
        Me.btnBackToResults.UseVisualStyleBackColor = False
        '
        'picCard
        '
        Me.picCard.Image = Global.AhmedN_FinalProject.My.Resources.Resources.emperor
        Me.picCard.Location = New System.Drawing.Point(52, 83)
        Me.picCard.Name = "picCard"
        Me.picCard.Size = New System.Drawing.Size(241, 433)
        Me.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCard.TabIndex = 0
        Me.picCard.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(0, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(39, 33)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "X"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMainMenu.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.ForeColor = System.Drawing.Color.PaleGreen
        Me.btnMainMenu.Location = New System.Drawing.Point(52, 628)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(290, 53)
        Me.btnMainMenu.TabIndex = 32
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'frmExplainCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1042, 705)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnBackToResults)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.picCard)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmExplainCard"
        Me.Text = "Esmeralda's Crystal Cove"
        CType(Me.picCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picCard As PictureBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents btnBackToResults As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnMainMenu As Button
End Class
