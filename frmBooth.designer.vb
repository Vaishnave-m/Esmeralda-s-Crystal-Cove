<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBooth
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
        Me.lblUserDialogue = New System.Windows.Forms.Label()
        Me.tmrTextEffect = New System.Windows.Forms.Timer(Me.components)
        Me.btnNext = New System.Windows.Forms.Button()
        Me.picEsmeraldaSpeech = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picEsmeraldaSpeech, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserDialogue
        '
        Me.lblUserDialogue.BackColor = System.Drawing.Color.Transparent
        Me.lblUserDialogue.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserDialogue.ForeColor = System.Drawing.Color.White
        Me.lblUserDialogue.Location = New System.Drawing.Point(12, 9)
        Me.lblUserDialogue.Name = "lblUserDialogue"
        Me.lblUserDialogue.Size = New System.Drawing.Size(895, 129)
        Me.lblUserDialogue.TabIndex = 0
        Me.lblUserDialogue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tmrTextEffect
        '
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Maroon
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNext.Location = New System.Drawing.Point(404, 106)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(91, 47)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'picEsmeraldaSpeech
        '
        Me.picEsmeraldaSpeech.BackColor = System.Drawing.Color.Transparent
        Me.picEsmeraldaSpeech.Image = Global.AhmedN_FinalProject.My.Resources.Resources.introSpeech
        Me.picEsmeraldaSpeech.Location = New System.Drawing.Point(100, 382)
        Me.picEsmeraldaSpeech.Name = "picEsmeraldaSpeech"
        Me.picEsmeraldaSpeech.Size = New System.Drawing.Size(395, 76)
        Me.picEsmeraldaSpeech.TabIndex = 2
        Me.picEsmeraldaSpeech.TabStop = False
        Me.picEsmeraldaSpeech.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmBooth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AhmedN_FinalProject.My.Resources.Resources.carnivalScene
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(904, 593)
        Me.Controls.Add(Me.picEsmeraldaSpeech)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblUserDialogue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBooth"
        Me.Text = "Esmeralda's Crystal Cove"
        CType(Me.picEsmeraldaSpeech, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblUserDialogue As Label
    Friend WithEvents tmrTextEffect As Timer
    Friend WithEvents btnNext As Button
    Friend WithEvents picEsmeraldaSpeech As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
