<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class overview
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
        Me.flow_item = New System.Windows.Forms.FlowLayoutPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dtpicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.rad_ds = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rad_ns = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'flow_item
        '
        Me.flow_item.AutoScroll = True
        Me.flow_item.AutoScrollMargin = New System.Drawing.Size(0, 50)
        Me.flow_item.BackColor = System.Drawing.SystemColors.ControlLight
        Me.flow_item.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flow_item.Location = New System.Drawing.Point(0, 80)
        Me.flow_item.Name = "flow_item"
        Me.flow_item.Size = New System.Drawing.Size(1088, 642)
        Me.flow_item.TabIndex = 7
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.dtpicker1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1088, 80)
        Me.Guna2Panel1.TabIndex = 8
        '
        'dtpicker1
        '
        Me.dtpicker1.BorderRadius = 3
        Me.dtpicker1.BorderThickness = 1
        Me.dtpicker1.Checked = True
        Me.dtpicker1.FillColor = System.Drawing.Color.White
        Me.dtpicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpicker1.Location = New System.Drawing.Point(27, 24)
        Me.dtpicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpicker1.Name = "dtpicker1"
        Me.dtpicker1.Size = New System.Drawing.Size(260, 37)
        Me.dtpicker1.TabIndex = 0
        Me.dtpicker1.Value = New Date(2025, 7, 17, 15, 0, 32, 722)
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.BorderRadius = 3
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.rad_ns)
        Me.Guna2Panel2.Controls.Add(Me.rad_ds)
        Me.Guna2Panel2.Location = New System.Drawing.Point(297, 25)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(243, 35)
        Me.Guna2Panel2.TabIndex = 1
        '
        'rad_ds
        '
        Me.rad_ds.AutoSize = True
        Me.rad_ds.Checked = True
        Me.rad_ds.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rad_ds.CheckedState.BorderThickness = 0
        Me.rad_ds.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rad_ds.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rad_ds.CheckedState.InnerOffset = -4
        Me.rad_ds.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rad_ds.Location = New System.Drawing.Point(20, 9)
        Me.rad_ds.Name = "rad_ds"
        Me.rad_ds.Size = New System.Drawing.Size(81, 17)
        Me.rad_ds.TabIndex = 0
        Me.rad_ds.TabStop = True
        Me.rad_ds.Text = "DAY SHIFT"
        Me.rad_ds.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rad_ds.UncheckedState.BorderThickness = 2
        Me.rad_ds.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rad_ds.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rad_ns
        '
        Me.rad_ns.AutoSize = True
        Me.rad_ns.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rad_ns.CheckedState.BorderThickness = 0
        Me.rad_ns.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rad_ns.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rad_ns.CheckedState.InnerOffset = -4
        Me.rad_ns.Location = New System.Drawing.Point(135, 9)
        Me.rad_ns.Name = "rad_ns"
        Me.rad_ns.Size = New System.Drawing.Size(93, 17)
        Me.rad_ns.TabIndex = 1
        Me.rad_ns.Text = "NIGHT SHIFT"
        Me.rad_ns.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rad_ns.UncheckedState.BorderThickness = 2
        Me.rad_ns.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rad_ns.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 722)
        Me.Controls.Add(Me.flow_item)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "overview"
        Me.Text = "overview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flow_item As FlowLayoutPanel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dtpicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents rad_ns As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rad_ds As Guna.UI2.WinForms.Guna2RadioButton
End Class
