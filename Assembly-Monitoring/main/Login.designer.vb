<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelselect = New Guna.UI2.WinForms.Guna2Panel()
        Me.dtpicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btn_start = New Guna.UI2.WinForms.Guna2Button()
        Me.radio_ds = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radio_ns = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2Panel2.SuspendLayout()
        Me.panelselect.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel2.Controls.Add(Me.panelselect)
        Me.Guna2Panel2.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Location = New System.Drawing.Point(223, 100)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(700, 527)
        Me.Guna2Panel2.TabIndex = 209
        '
        'panelselect
        '
        Me.panelselect.Controls.Add(Me.radio_ns)
        Me.panelselect.Controls.Add(Me.dtpicker1)
        Me.panelselect.Controls.Add(Me.btn_start)
        Me.panelselect.Controls.Add(Me.radio_ds)
        Me.panelselect.Enabled = False
        Me.panelselect.FillColor = System.Drawing.Color.White
        Me.panelselect.Location = New System.Drawing.Point(131, 116)
        Me.panelselect.Name = "panelselect"
        Me.panelselect.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.panelselect.ShadowDecoration.Enabled = True
        Me.panelselect.Size = New System.Drawing.Size(462, 345)
        Me.panelselect.TabIndex = 25
        '
        'dtpicker1
        '
        Me.dtpicker1.Checked = True
        Me.dtpicker1.FillColor = System.Drawing.Color.MidnightBlue
        Me.dtpicker1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpicker1.ForeColor = System.Drawing.Color.White
        Me.dtpicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpicker1.Location = New System.Drawing.Point(84, 78)
        Me.dtpicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpicker1.Name = "dtpicker1"
        Me.dtpicker1.Size = New System.Drawing.Size(295, 36)
        Me.dtpicker1.TabIndex = 15
        Me.dtpicker1.Value = New Date(2024, 11, 22, 8, 48, 16, 832)
        '
        'btn_start
        '
        Me.btn_start.BorderRadius = 5
        Me.btn_start.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_start.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_start.FillColor = System.Drawing.Color.MidnightBlue
        Me.btn_start.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start.ForeColor = System.Drawing.Color.White
        Me.btn_start.Location = New System.Drawing.Point(163, 235)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(136, 60)
        Me.btn_start.TabIndex = 11
        Me.btn_start.Text = "Proceed"
        '
        'radio_ds
        '
        Me.radio_ds.AutoSize = True
        Me.radio_ds.BackColor = System.Drawing.Color.Transparent
        Me.radio_ds.CheckedState.BorderColor = System.Drawing.Color.MidnightBlue
        Me.radio_ds.CheckedState.BorderThickness = 1
        Me.radio_ds.CheckedState.FillColor = System.Drawing.Color.MidnightBlue
        Me.radio_ds.CheckedState.InnerColor = System.Drawing.Color.MidnightBlue
        Me.radio_ds.CheckedState.InnerOffset = -4
        Me.radio_ds.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.radio_ds.Location = New System.Drawing.Point(179, 140)
        Me.radio_ds.Name = "radio_ds"
        Me.radio_ds.Size = New System.Drawing.Size(105, 29)
        Me.radio_ds.TabIndex = 2
        Me.radio_ds.Text = "Day Shift"
        Me.radio_ds.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.radio_ds.UncheckedState.BorderThickness = 1
        Me.radio_ds.UncheckedState.FillColor = System.Drawing.Color.White
        Me.radio_ds.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.radio_ds.UncheckedState.InnerOffset = 1
        Me.radio_ds.UseVisualStyleBackColor = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(177, 13)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(104, 65)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 23
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(287, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Philippines TRC Inc."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(287, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Assembly Monitoring"
        '
        'radio_ns
        '
        Me.radio_ns.AutoSize = True
        Me.radio_ns.BackColor = System.Drawing.Color.Transparent
        Me.radio_ns.CheckedState.BorderColor = System.Drawing.Color.MidnightBlue
        Me.radio_ns.CheckedState.BorderThickness = 1
        Me.radio_ns.CheckedState.FillColor = System.Drawing.Color.MidnightBlue
        Me.radio_ns.CheckedState.InnerColor = System.Drawing.Color.MidnightBlue
        Me.radio_ns.CheckedState.InnerOffset = -4
        Me.radio_ns.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.radio_ns.Location = New System.Drawing.Point(171, 175)
        Me.radio_ns.Name = "radio_ns"
        Me.radio_ns.Size = New System.Drawing.Size(120, 29)
        Me.radio_ns.TabIndex = 16
        Me.radio_ns.Text = "Night Shift"
        Me.radio_ns.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.radio_ns.UncheckedState.BorderThickness = 1
        Me.radio_ns.UncheckedState.FillColor = System.Drawing.Color.White
        Me.radio_ns.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.radio_ns.UncheckedState.InnerOffset = 1
        Me.radio_ns.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 673)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.panelselect.ResumeLayout(False)
        Me.panelselect.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelselect As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dtpicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btn_start As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents radio_ds As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents radio_ns As Guna.UI2.WinForms.Guna2RadioButton
End Class
