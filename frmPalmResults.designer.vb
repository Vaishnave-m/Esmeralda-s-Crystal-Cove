<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPalmResults
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.lblPurple = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblYelloe = New System.Windows.Forms.Label()
        Me.tmrPicChange = New System.Windows.Forms.Timer(Me.components)
        Me.picStar2 = New System.Windows.Forms.PictureBox()
        Me.picStar1 = New System.Windows.Forms.PictureBox()
        Me.picPsychic = New System.Windows.Forms.PictureBox()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        CType(Me.picStar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPsychic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblResults
        '
        Me.lblResults.BackColor = System.Drawing.Color.Black
        Me.lblResults.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblResults.Location = New System.Drawing.Point(470, 32)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(499, 588)
        Me.lblResults.TabIndex = 16
        Me.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPurple
        '
        Me.lblPurple.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblPurple.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurple.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPurple.Location = New System.Drawing.Point(461, 26)
        Me.lblPurple.Name = "lblPurple"
        Me.lblPurple.Size = New System.Drawing.Size(515, 601)
        Me.lblPurple.TabIndex = 20
        '
        'lblHeading
        '
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblHeading.Location = New System.Drawing.Point(99, -5)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(244, 137)
        Me.lblHeading.TabIndex = 15
        Me.lblHeading.Text = "Esmeralda Says:"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYelloe
        '
        Me.lblYelloe.BackColor = System.Drawing.Color.Gold
        Me.lblYelloe.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYelloe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblYelloe.Location = New System.Drawing.Point(454, 19)
        Me.lblYelloe.Name = "lblYelloe"
        Me.lblYelloe.Size = New System.Drawing.Size(529, 616)
        Me.lblYelloe.TabIndex = 21
        '
        'tmrPicChange
        '
        Me.tmrPicChange.Interval = 1000
        '
        'picStar2
        '
        Me.picStar2.BackgroundImage = Global.AhmedN_FinalProject.My.Resources.Resources.blackSky
        Me.picStar2.Image = Global.AhmedN_FinalProject.My.Resources.Resources.starsYellow
        Me.picStar2.Location = New System.Drawing.Point(262, -34)
        Me.picStar2.Name = "picStar2"
        Me.picStar2.Size = New System.Drawing.Size(151, 210)
        Me.picStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStar2.TabIndex = 19
        Me.picStar2.TabStop = False
        '
        'picStar1
        '
        Me.picStar1.BackgroundImage = Global.AhmedN_FinalProject.My.Resources.Resources.blackSky
        Me.picStar1.Image = Global.AhmedN_FinalProject.My.Resources.Resources.starsYellow
        Me.picStar1.Location = New System.Drawing.Point(10, 4)
        Me.picStar1.Name = "picStar1"
        Me.picStar1.Size = New System.Drawing.Size(157, 184)
        Me.picStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStar1.TabIndex = 18
        Me.picStar1.TabStop = False
        '
        'picPsychic
        '
        Me.picPsychic.BackColor = System.Drawing.Color.Transparent
        Me.picPsychic.Location = New System.Drawing.Point(12, 205)
        Me.picPsychic.Name = "picPsychic"
        Me.picPsychic.Size = New System.Drawing.Size(412, 373)
        Me.picPsychic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPsychic.TabIndex = 17
        Me.picPsychic.TabStop = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMainMenu.Font = New System.Drawing.Font("Blackadder ITC", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.ForeColor = System.Drawing.Color.Gold
        Me.btnMainMenu.Location = New System.Drawing.Point(134, 599)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(177, 44)
        Me.btnMainMenu.TabIndex = 22
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'frmPalmResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.AhmedN_FinalProject.My.Resources.Resources.blackSky
        Me.ClientSize = New System.Drawing.Size(1004, 665)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.lblPurple)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picStar2)
        Me.Controls.Add(Me.picStar1)
        Me.Controls.Add(Me.picPsychic)
        Me.Controls.Add(Me.lblYelloe)
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPalmResults"
        Me.Text = "Esmeralda's Crystal Cove"
        CType(Me.picStar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPsychic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblResults As Label
    Friend WithEvents lblPurple As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents picStar2 As PictureBox
    Friend WithEvents picStar1 As PictureBox
    Friend WithEvents picPsychic As PictureBox
    Friend WithEvents lblYelloe As Label
    Friend WithEvents tmrPicChange As Timer
    Friend WithEvents btnMainMenu As Button
End Class
