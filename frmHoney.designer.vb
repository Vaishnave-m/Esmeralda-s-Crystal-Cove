<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoney
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
        Me.tmrHoney = New System.Windows.Forms.Timer(Me.components)
        Me.picHoney = New System.Windows.Forms.PictureBox()
        Me.picPotion = New System.Windows.Forms.PictureBox()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        CType(Me.picHoney, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPotion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWin
        '
        Me.lblWin.BackColor = System.Drawing.Color.Transparent
        Me.lblWin.Font = New System.Drawing.Font("Colonna MT", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWin.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblWin.Location = New System.Drawing.Point(-15, 9)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(1017, 148)
        Me.lblWin.TabIndex = 20
        Me.lblWin.Text = "You've received a potion item!"
        Me.lblWin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tmrHoney
        '
        '
        'picHoney
        '
        Me.picHoney.BackColor = System.Drawing.Color.Transparent
        Me.picHoney.Image = Global.AhmedN_FinalProject.My.Resources.Resources.honey
        Me.picHoney.Location = New System.Drawing.Point(32, 269)
        Me.picHoney.Name = "picHoney"
        Me.picHoney.Size = New System.Drawing.Size(29, 26)
        Me.picHoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHoney.TabIndex = 23
        Me.picHoney.TabStop = False
        Me.picHoney.Visible = False
        '
        'picPotion
        '
        Me.picPotion.Image = Global.AhmedN_FinalProject.My.Resources.Resources.potion
        Me.picPotion.Location = New System.Drawing.Point(386, 126)
        Me.picPotion.Name = "picPotion"
        Me.picPotion.Size = New System.Drawing.Size(838, 696)
        Me.picPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPotion.TabIndex = 22
        Me.picPotion.TabStop = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMainMenu.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.ForeColor = System.Drawing.Color.Black
        Me.btnMainMenu.Location = New System.Drawing.Point(374, 629)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(127, 38)
        Me.btnMainMenu.TabIndex = 24
        Me.btnMainMenu.Text = "Main Room"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'frmHoney
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 739)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.lblWin)
        Me.Controls.Add(Me.picHoney)
        Me.Controls.Add(Me.picPotion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHoney"
        Me.Text = "Esmeralda's Crystal Cove"
        CType(Me.picHoney, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPotion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblWin As Label
    Friend WithEvents picPotion As PictureBox
    Friend WithEvents picHoney As PictureBox
    Friend WithEvents tmrHoney As Timer
    Friend WithEvents btnMainMenu As Button
End Class
