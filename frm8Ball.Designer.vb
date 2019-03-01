<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm8Ball
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
        Me.components = New System.ComponentModel.Container()
        Me.pct8Ball = New System.Windows.Forms.PictureBox()
        Me.btnShake = New System.Windows.Forms.Button()
        Me.pctTitle = New System.Windows.Forms.PictureBox()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblAsk = New System.Windows.Forms.Label()
        Me.tmrShake = New System.Windows.Forms.Timer(Me.components)
        Me.lblGenerate = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        CType(Me.pct8Ball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pct8Ball
        '
        Me.pct8Ball.BackColor = System.Drawing.Color.Transparent
        Me.pct8Ball.Image = Global.AhmedN_FinalProject.My.Resources.Resources.Constant8Ball
        Me.pct8Ball.Location = New System.Drawing.Point(260, 168)
        Me.pct8Ball.Name = "pct8Ball"
        Me.pct8Ball.Size = New System.Drawing.Size(505, 407)
        Me.pct8Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pct8Ball.TabIndex = 0
        Me.pct8Ball.TabStop = False
        '
        'btnShake
        '
        Me.btnShake.BackgroundImage = Global.AhmedN_FinalProject.My.Resources.Resources.original
        Me.btnShake.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShake.Font = New System.Drawing.Font("Script MT Bold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShake.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.btnShake.Location = New System.Drawing.Point(710, 495)
        Me.btnShake.Name = "btnShake"
        Me.btnShake.Size = New System.Drawing.Size(213, 68)
        Me.btnShake.TabIndex = 1
        Me.btnShake.Text = "Shake"
        Me.btnShake.UseVisualStyleBackColor = True
        '
        'pctTitle
        '
        Me.pctTitle.BackColor = System.Drawing.Color.Transparent
        Me.pctTitle.Image = Global.AhmedN_FinalProject.My.Resources.Resources.monthly_11_2012_13c3a4aa37c8b1e1216afe8a9a8a8e09_x
        Me.pctTitle.Location = New System.Drawing.Point(178, -102)
        Me.pctTitle.Name = "pctTitle"
        Me.pctTitle.Size = New System.Drawing.Size(651, 381)
        Me.pctTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctTitle.TabIndex = 2
        Me.pctTitle.TabStop = False
        '
        'txtQuestion
        '
        Me.txtQuestion.Font = New System.Drawing.Font("Poor Richard", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion.Location = New System.Drawing.Point(48, 657)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(896, 52)
        Me.txtQuestion.TabIndex = 3
        Me.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(0, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(39, 33)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "X"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblAsk
        '
        Me.lblAsk.BackColor = System.Drawing.Color.Transparent
        Me.lblAsk.Font = New System.Drawing.Font("Blackadder ITC", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsk.ForeColor = System.Drawing.Color.PowderBlue
        Me.lblAsk.Location = New System.Drawing.Point(184, 585)
        Me.lblAsk.Name = "lblAsk"
        Me.lblAsk.Size = New System.Drawing.Size(645, 63)
        Me.lblAsk.TabIndex = 21
        Me.lblAsk.Text = "Ask the 8 Ball a Question..."
        Me.lblAsk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrShake
        '
        '
        'lblGenerate
        '
        Me.lblGenerate.BackColor = System.Drawing.Color.Transparent
        Me.lblGenerate.Font = New System.Drawing.Font("Blackadder ITC", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenerate.ForeColor = System.Drawing.Color.PowderBlue
        Me.lblGenerate.Location = New System.Drawing.Point(133, 578)
        Me.lblGenerate.Name = "lblGenerate"
        Me.lblGenerate.Size = New System.Drawing.Size(719, 70)
        Me.lblGenerate.TabIndex = 22
        Me.lblGenerate.Text = "The 8 Ball is generating an answer..."
        Me.lblGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblGenerate.Visible = False
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplay.Font = New System.Drawing.Font("Blackadder ITC", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.ForeColor = System.Drawing.Color.PowderBlue
        Me.lblDisplay.Location = New System.Drawing.Point(88, 578)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(835, 69)
        Me.lblDisplay.TabIndex = 28
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDisplay.Visible = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMainMenu.Font = New System.Drawing.Font("Script MT Bold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMainMenu.Location = New System.Drawing.Point(730, 445)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(177, 44)
        Me.btnMainMenu.TabIndex = 29
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'frm8Ball
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AhmedN_FinalProject.My.Resources.Resources.videoblocks_misty_blue_fog_smoke_clouds_abstract_background_animation_alpha_channel_included_it_van_be_placed_over_other_backgrounds_hqelvxwghe_thumbnail_full12
        Me.ClientSize = New System.Drawing.Size(987, 735)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.lblGenerate)
        Me.Controls.Add(Me.lblAsk)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnShake)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.pct8Ball)
        Me.Controls.Add(Me.pctTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm8Ball"
        Me.Text = "8 Ball"
        CType(Me.pct8Ball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pct8Ball As PictureBox
    Friend WithEvents btnShake As Button
    Friend WithEvents pctTitle As PictureBox
    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblAsk As Label
    Friend WithEvents tmrShake As Timer
    Friend WithEvents lblGenerate As Label
    Friend WithEvents lblDisplay As Label
    Friend WithEvents btnMainMenu As Button
End Class
