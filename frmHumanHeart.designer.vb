<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHumanHeart
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
        Me.lblWin = New System.Windows.Forms.Label()
        Me.tmrHeart = New System.Windows.Forms.Timer(Me.components)
        Me.picPotion = New System.Windows.Forms.PictureBox()
        Me.picHoney = New System.Windows.Forms.PictureBox()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        CType(Me.picPotion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWin
        '
        Me.lblWin.BackColor = System.Drawing.Color.Transparent
        Me.lblWin.Font = New System.Drawing.Font("Colonna MT", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWin.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblWin.Location = New System.Drawing.Point(12, 9)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(1038, 156)
        Me.lblWin.TabIndex = 24
        Me.lblWin.Text = "You've received a potion item!"
        Me.lblWin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tmrHeart
        '
        '
        'picPotion
        '
        Me.picPotion.Image = Global.AhmedN_FinalProject.My.Resources.Resources.potion
        Me.picPotion.Location = New System.Drawing.Point(468, 136)
        Me.picPotion.Name = "picPotion"
        Me.picPotion.Size = New System.Drawing.Size(704, 626)
        Me.picPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPotion.TabIndex = 25
        Me.picPotion.TabStop = False
        '
        'picHoney
        '
        Me.picHoney.BackColor = System.Drawing.Color.Transparent
        Me.picHoney.Image = Global.AhmedN_FinalProject.My.Resources.Resources.humanHeart
        Me.picHoney.Location = New System.Drawing.Point(58, 201)
        Me.picHoney.Name = "picHoney"
        Me.picHoney.Size = New System.Drawing.Size(22, 16)
        Me.picHoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHoney.TabIndex = 26
        Me.picHoney.TabStop = False
        Me.picHoney.Visible = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMainMenu.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.ForeColor = System.Drawing.Color.Black
        Me.btnMainMenu.Location = New System.Drawing.Point(416, 595)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(133, 36)
        Me.btnMainMenu.TabIndex = 27
        Me.btnMainMenu.Text = "Main Room"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'frmHumanHeart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1062, 698)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.lblWin)
        Me.Controls.Add(Me.picPotion)
        Me.Controls.Add(Me.picHoney)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHumanHeart"
        Me.Text = "Esmeralda's Crystal Cove"
        CType(Me.picPotion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHoney, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblWin As Label
    Friend WithEvents picPotion As PictureBox
    Friend WithEvents tmrHeart As Timer
    Friend WithEvents picHoney As PictureBox
    Friend WithEvents btnMainMenu As Button
End Class
