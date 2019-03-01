<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHoroscopeStory
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
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.pctBook = New System.Windows.Forms.PictureBox()
        Me.pnlTitle.SuspendLayout()
        CType(Me.pctBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTitle
        '
        Me.pnlTitle.BackgroundImage = My.Resources.wood_with_warm_lights_1048_3935
        Me.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Controls.Add(Me.btnOpen)
        Me.pnlTitle.Controls.Add(Me.pctBook)
        Me.pnlTitle.Location = New System.Drawing.Point(1, 1)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(946, 601)
        Me.pnlTitle.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Blackadder ITC", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Thistle
        Me.lblTitle.Location = New System.Drawing.Point(107, 60)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(721, 82)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Click to Reveal your Destiny!"
        '
        'btnOpen
        '
        Me.btnOpen.BackgroundImage = My.Resources.sparkly_background_purple_by_sourl3m0n_d48d75s
        Me.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOpen.Font = New System.Drawing.Font("Matura MT Script Capitals", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpen.ForeColor = System.Drawing.Color.Indigo
        Me.btnOpen.Location = New System.Drawing.Point(357, 161)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(250, 83)
        Me.btnOpen.TabIndex = 1
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'pctBook
        '
        Me.pctBook.BackColor = System.Drawing.Color.Transparent
        Me.pctBook.Image = My.Resources.png_magic_book_by_moonglowlilly_d5z1pgm
        Me.pctBook.Location = New System.Drawing.Point(167, 173)
        Me.pctBook.Name = "pctBook"
        Me.pctBook.Size = New System.Drawing.Size(613, 385)
        Me.pctBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBook.TabIndex = 0
        Me.pctBook.TabStop = False
        '
        'frmHoroscopeStory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 548)
        Me.Controls.Add(Me.pnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHoroscopeStory"
        Me.Text = "n "
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        CType(Me.pctBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTitle As Panel
    Friend WithEvents pctBook As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnOpen As Button
End Class
