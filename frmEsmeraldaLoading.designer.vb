<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEsmeraldaLoading
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
        Me.picSmoke2 = New System.Windows.Forms.PictureBox()
        Me.picSmoke1 = New System.Windows.Forms.PictureBox()
        Me.picCandle = New System.Windows.Forms.PictureBox()
        Me.picSmoke3 = New System.Windows.Forms.PictureBox()
        Me.lblWait = New System.Windows.Forms.Label()
        Me.tmrWait = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picSmoke2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSmoke1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCandle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSmoke3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSmoke2
        '
        Me.picSmoke2.Image = Global.AhmedN_FinalProject.My.Resources.Resources.smoke
        Me.picSmoke2.Location = New System.Drawing.Point(576, 395)
        Me.picSmoke2.Name = "picSmoke2"
        Me.picSmoke2.Size = New System.Drawing.Size(515, 520)
        Me.picSmoke2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSmoke2.TabIndex = 2
        Me.picSmoke2.TabStop = False
        '
        'picSmoke1
        '
        Me.picSmoke1.Image = Global.AhmedN_FinalProject.My.Resources.Resources.smoke
        Me.picSmoke1.Location = New System.Drawing.Point(-61, 395)
        Me.picSmoke1.Name = "picSmoke1"
        Me.picSmoke1.Size = New System.Drawing.Size(399, 325)
        Me.picSmoke1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSmoke1.TabIndex = 1
        Me.picSmoke1.TabStop = False
        '
        'picCandle
        '
        Me.picCandle.Image = Global.AhmedN_FinalProject.My.Resources.Resources.candle1
        Me.picCandle.Location = New System.Drawing.Point(91, 9)
        Me.picCandle.Name = "picCandle"
        Me.picCandle.Size = New System.Drawing.Size(715, 522)
        Me.picCandle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCandle.TabIndex = 0
        Me.picCandle.TabStop = False
        '
        'picSmoke3
        '
        Me.picSmoke3.Image = Global.AhmedN_FinalProject.My.Resources.Resources.smoke
        Me.picSmoke3.Location = New System.Drawing.Point(314, 425)
        Me.picSmoke3.Name = "picSmoke3"
        Me.picSmoke3.Size = New System.Drawing.Size(285, 336)
        Me.picSmoke3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSmoke3.TabIndex = 3
        Me.picSmoke3.TabStop = False
        '
        'lblWait
        '
        Me.lblWait.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWait.ForeColor = System.Drawing.Color.Gold
        Me.lblWait.Location = New System.Drawing.Point(23, 9)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(839, 93)
        Me.lblWait.TabIndex = 4
        Me.lblWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrWait
        '
        '
        'frmEsmeraldaLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(897, 629)
        Me.Controls.Add(Me.lblWait)
        Me.Controls.Add(Me.picSmoke3)
        Me.Controls.Add(Me.picSmoke2)
        Me.Controls.Add(Me.picSmoke1)
        Me.Controls.Add(Me.picCandle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEsmeraldaLoading"
        Me.Text = "Esmeralda's Crystal Cove"
        CType(Me.picSmoke2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSmoke1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCandle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSmoke3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picCandle As PictureBox
    Friend WithEvents picSmoke1 As PictureBox
    Friend WithEvents picSmoke2 As PictureBox
    Friend WithEvents picSmoke3 As PictureBox
    Friend WithEvents lblWait As Label
    Friend WithEvents tmrWait As Timer
End Class
