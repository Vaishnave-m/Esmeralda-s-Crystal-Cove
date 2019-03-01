<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnterRoom
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
        Me.lblUserDialogue = New System.Windows.Forms.Label()
        Me.tmrTextEffect = New System.Windows.Forms.Timer(Me.components)
        Me.picEsmeraldaSpeech = New System.Windows.Forms.PictureBox()
        Me.btnDoor = New System.Windows.Forms.Button()
        CType(Me.picEsmeraldaSpeech, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserDialogue
        '
        Me.lblUserDialogue.BackColor = System.Drawing.Color.Transparent
        Me.lblUserDialogue.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserDialogue.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblUserDialogue.Location = New System.Drawing.Point(119, 9)
        Me.lblUserDialogue.Name = "lblUserDialogue"
        Me.lblUserDialogue.Size = New System.Drawing.Size(618, 49)
        Me.lblUserDialogue.TabIndex = 0
        Me.lblUserDialogue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrTextEffect
        '
        '
        'picEsmeraldaSpeech
        '
        Me.picEsmeraldaSpeech.BackColor = System.Drawing.Color.Transparent
        Me.picEsmeraldaSpeech.Image = Global.AhmedN_FinalProject.My.Resources.Resources.speech_bubble_door2
        Me.picEsmeraldaSpeech.Location = New System.Drawing.Point(472, 124)
        Me.picEsmeraldaSpeech.Name = "picEsmeraldaSpeech"
        Me.picEsmeraldaSpeech.Size = New System.Drawing.Size(362, 228)
        Me.picEsmeraldaSpeech.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picEsmeraldaSpeech.TabIndex = 1
        Me.picEsmeraldaSpeech.TabStop = False
        Me.picEsmeraldaSpeech.Visible = False
        '
        'btnDoor
        '
        Me.btnDoor.BackColor = System.Drawing.Color.Transparent
        Me.btnDoor.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDoor.FlatAppearance.BorderSize = 0
        Me.btnDoor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDoor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDoor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDoor.Location = New System.Drawing.Point(300, 75)
        Me.btnDoor.Name = "btnDoor"
        Me.btnDoor.Size = New System.Drawing.Size(249, 471)
        Me.btnDoor.TabIndex = 2
        Me.btnDoor.UseVisualStyleBackColor = False
        Me.btnDoor.Visible = False
        '
        'frmEnterRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AhmedN_FinalProject.My.Resources.Resources.first_door
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(846, 635)
        Me.Controls.Add(Me.picEsmeraldaSpeech)
        Me.Controls.Add(Me.btnDoor)
        Me.Controls.Add(Me.lblUserDialogue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEnterRoom"
        Me.Text = "Esmeralda's Crystal Cove"
        CType(Me.picEsmeraldaSpeech, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblUserDialogue As Label
    Friend WithEvents tmrTextEffect As Timer
    Friend WithEvents picEsmeraldaSpeech As PictureBox
    Friend WithEvents btnDoor As Button
End Class
