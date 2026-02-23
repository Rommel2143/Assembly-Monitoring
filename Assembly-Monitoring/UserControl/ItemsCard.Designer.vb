<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemsCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ItemsCard))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblBarcode = New System.Windows.Forms.Label()
        Me.lblTimeStamp = New System.Windows.Forms.Label()
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.DimGray
        Me.Guna2Panel1.BorderRadius = 10
        Me.Guna2Panel1.BorderThickness = 2
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel1.Controls.Add(Me.lblBarcode)
        Me.Guna2Panel1.Controls.Add(Me.lblTimeStamp)
        Me.Guna2Panel1.Controls.Add(Me.lblInterval)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(10, 14)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.MaximumSize = New System.Drawing.Size(217, 110)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.BorderRadius = 12
        Me.Guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.Size = New System.Drawing.Size(209, 79)
        Me.Guna2Panel1.TabIndex = 5
        '
        'lblBarcode
        '
        Me.lblBarcode.AutoSize = True
        Me.lblBarcode.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarcode.ForeColor = System.Drawing.Color.Black
        Me.lblBarcode.Location = New System.Drawing.Point(46, 11)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(81, 25)
        Me.lblBarcode.TabIndex = 7
        Me.lblBarcode.Text = "Barcode"
        '
        'lblTimeStamp
        '
        Me.lblTimeStamp.AutoSize = True
        Me.lblTimeStamp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeStamp.ForeColor = System.Drawing.Color.Black
        Me.lblTimeStamp.Location = New System.Drawing.Point(16, 56)
        Me.lblTimeStamp.Name = "lblTimeStamp"
        Me.lblTimeStamp.Size = New System.Drawing.Size(73, 17)
        Me.lblTimeStamp.TabIndex = 6
        Me.lblTimeStamp.Text = "TimeStamp"
        '
        'lblInterval
        '
        Me.lblInterval.AutoSize = True
        Me.lblInterval.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterval.ForeColor = System.Drawing.Color.Black
        Me.lblInterval.Location = New System.Drawing.Point(16, 39)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(82, 17)
        Me.lblInterval.TabIndex = 5
        Me.lblInterval.Text = "Time Interval"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(193, 66)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(37, 38)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 8
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(19, 12)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(25, 24)
        Me.Guna2PictureBox2.TabIndex = 8
        Me.Guna2PictureBox2.TabStop = False
        '
        'ItemsCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.MaximumSize = New System.Drawing.Size(230, 150)
        Me.Name = "ItemsCard"
        Me.Size = New System.Drawing.Size(230, 107)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblInterval As Label
    Friend WithEvents lblBarcode As Label
    Friend WithEvents lblTimeStamp As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
End Class
