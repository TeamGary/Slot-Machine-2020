<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Imglistbilleder = New System.Windows.Forms.ImageList(Me.components)
        Me.ImglistRuller = New System.Windows.Forms.ImageList(Me.components)
        Me.TimerR1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimerArm = New System.Windows.Forms.Timer(Me.components)
        Me.PboxR1 = New System.Windows.Forms.PictureBox()
        Me.PboxR2 = New System.Windows.Forms.PictureBox()
        Me.PboxR3 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_Text = New System.Windows.Forms.Label()
        Me.Lbl_Saldo = New System.Windows.Forms.Label()
        CType(Me.PboxR1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PboxR2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PboxR3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Imglistbilleder
        '
        Me.Imglistbilleder.ImageStream = CType(resources.GetObject("Imglistbilleder.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Imglistbilleder.TransparentColor = System.Drawing.Color.Transparent
        Me.Imglistbilleder.Images.SetKeyName(0, "kirsebær120x59.jpg")
        Me.Imglistbilleder.Images.SetKeyName(1, "appelsin120x59.jpg")
        Me.Imglistbilleder.Images.SetKeyName(2, "blomme120x59.jpg")
        Me.Imglistbilleder.Images.SetKeyName(3, "jordbær120x59.jpg")
        Me.Imglistbilleder.Images.SetKeyName(4, "klokke120x59.jpg")
        Me.Imglistbilleder.Images.SetKeyName(5, "jackpot120x59.jpg")
        '
        'ImglistRuller
        '
        Me.ImglistRuller.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImglistRuller.ImageSize = New System.Drawing.Size(120, 59)
        Me.ImglistRuller.TransparentColor = System.Drawing.Color.Transparent
        '
        'TimerR1
        '
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Image = Global.tyveknægt_23g.My.Resources.Resources.frame_3_delay_s
        Me.Label1.Location = New System.Drawing.Point(620, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 408)
        Me.Label1.TabIndex = 4
        '
        'PboxR1
        '
        Me.PboxR1.Location = New System.Drawing.Point(63, 50)
        Me.PboxR1.Name = "PboxR1"
        Me.PboxR1.Size = New System.Drawing.Size(120, 59)
        Me.PboxR1.TabIndex = 0
        Me.PboxR1.TabStop = False
        '
        'PboxR2
        '
        Me.PboxR2.Location = New System.Drawing.Point(209, 50)
        Me.PboxR2.Name = "PboxR2"
        Me.PboxR2.Size = New System.Drawing.Size(120, 59)
        Me.PboxR2.TabIndex = 2
        Me.PboxR2.TabStop = False
        '
        'PboxR3
        '
        Me.PboxR3.Location = New System.Drawing.Point(358, 50)
        Me.PboxR3.Name = "PboxR3"
        Me.PboxR3.Size = New System.Drawing.Size(120, 59)
        Me.PboxR3.TabIndex = 3
        Me.PboxR3.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PboxR1)
        Me.Panel1.Controls.Add(Me.PboxR2)
        Me.Panel1.Controls.Add(Me.PboxR3)
        Me.Panel1.Location = New System.Drawing.Point(89, 139)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(534, 167)
        Me.Panel1.TabIndex = 5
        '
        'Lbl_Text
        '
        Me.Lbl_Text.AutoSize = True
        Me.Lbl_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Text.Location = New System.Drawing.Point(91, 309)
        Me.Lbl_Text.Name = "Lbl_Text"
        Me.Lbl_Text.Size = New System.Drawing.Size(144, 39)
        Me.Lbl_Text.TabIndex = 6
        Me.Lbl_Text.Text = "SALDO:"
        '
        'Lbl_Saldo
        '
        Me.Lbl_Saldo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_Saldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Saldo.Location = New System.Drawing.Point(231, 309)
        Me.Lbl_Saldo.Name = "Lbl_Saldo"
        Me.Lbl_Saldo.Size = New System.Drawing.Size(144, 39)
        Me.Lbl_Saldo.TabIndex = 7
        Me.Lbl_Saldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(849, 456)
        Me.Controls.Add(Me.Lbl_Saldo)
        Me.Controls.Add(Me.Lbl_Text)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PboxR1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PboxR2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PboxR3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Imglistbilleder As ImageList
    Friend WithEvents ImglistRuller As ImageList
    Friend WithEvents TimerR1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents TimerArm As Timer
    Friend WithEvents PboxR1 As PictureBox
    Friend WithEvents PboxR2 As PictureBox
    Friend WithEvents PboxR3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lbl_Text As Label
    Friend WithEvents Lbl_Saldo As Label
End Class
