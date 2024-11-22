<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class select_shift
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
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.radio_ds = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.radio_ns = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.btn_start = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dtpicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 15
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'radio_ds
        '
        Me.radio_ds.AutoSize = True
        Me.radio_ds.BackColor = System.Drawing.Color.Transparent
        Me.radio_ds.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radio_ds.CheckedState.BorderThickness = 0
        Me.radio_ds.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radio_ds.CheckedState.InnerColor = System.Drawing.Color.White
        Me.radio_ds.CheckedState.InnerOffset = -4
        Me.radio_ds.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_ds.Location = New System.Drawing.Point(146, 98)
        Me.radio_ds.Name = "radio_ds"
        Me.radio_ds.Size = New System.Drawing.Size(91, 25)
        Me.radio_ds.TabIndex = 2
        Me.radio_ds.Text = "Day Shift"
        Me.radio_ds.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.radio_ds.UncheckedState.BorderThickness = 2
        Me.radio_ds.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.radio_ds.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.radio_ds.UseVisualStyleBackColor = False
        '
        'radio_ns
        '
        Me.radio_ns.AutoSize = True
        Me.radio_ns.BackColor = System.Drawing.Color.Transparent
        Me.radio_ns.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radio_ns.CheckedState.BorderThickness = 0
        Me.radio_ns.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radio_ns.CheckedState.InnerColor = System.Drawing.Color.White
        Me.radio_ns.CheckedState.InnerOffset = -4
        Me.radio_ns.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_ns.Location = New System.Drawing.Point(146, 129)
        Me.radio_ns.Name = "radio_ns"
        Me.radio_ns.Size = New System.Drawing.Size(103, 25)
        Me.radio_ns.TabIndex = 3
        Me.radio_ns.Text = "Night Shift"
        Me.radio_ns.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.radio_ns.UncheckedState.BorderThickness = 2
        Me.radio_ns.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.radio_ns.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.radio_ns.UseVisualStyleBackColor = False
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
        Me.btn_start.Location = New System.Drawing.Point(132, 177)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(136, 60)
        Me.btn_start.TabIndex = 11
        Me.btn_start.Text = "Proceed"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.dtpicker1)
        Me.Guna2Panel1.Controls.Add(Me.btn_start)
        Me.Guna2Panel1.Controls.Add(Me.radio_ns)
        Me.Guna2Panel1.Controls.Add(Me.radio_ds)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(51, 89)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.Size = New System.Drawing.Size(400, 283)
        Me.Guna2Panel1.TabIndex = 14
        '
        'dtpicker1
        '
        Me.dtpicker1.Checked = True
        Me.dtpicker1.FillColor = System.Drawing.Color.MidnightBlue
        Me.dtpicker1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpicker1.ForeColor = System.Drawing.Color.White
        Me.dtpicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpicker1.Location = New System.Drawing.Point(72, 42)
        Me.dtpicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpicker1.Name = "dtpicker1"
        Me.dtpicker1.Size = New System.Drawing.Size(257, 36)
        Me.dtpicker1.TabIndex = 15
        Me.dtpicker1.Value = New Date(2024, 11, 22, 8, 48, 16, 832)
        '
        'select_shift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 454)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "select_shift"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "select_shift"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents radio_ns As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents radio_ds As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents btn_start As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dtpicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
