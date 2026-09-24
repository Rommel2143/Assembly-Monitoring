<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class selectLive
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
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.radNS = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.radDS = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.btn_select = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2DateTimePicker1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2DateTimePicker1.BorderRadius = 8
        Me.Guna2DateTimePicker1.BorderThickness = 1
        Me.Guna2DateTimePicker1.Checked = True
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DateTimePicker1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(28, 53)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(273, 50)
        Me.Guna2DateTimePicker1.TabIndex = 30
        Me.Guna2DateTimePicker1.Value = New Date(2025, 8, 13, 9, 22, 27, 105)
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel4.BorderRadius = 8
        Me.Guna2Panel4.BorderThickness = 1
        Me.Guna2Panel4.Controls.Add(Me.Guna2VSeparator1)
        Me.Guna2Panel4.Controls.Add(Me.radNS)
        Me.Guna2Panel4.Controls.Add(Me.radDS)
        Me.Guna2Panel4.Location = New System.Drawing.Point(328, 53)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(239, 51)
        Me.Guna2Panel4.TabIndex = 34
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(114, 5)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(10, 41)
        Me.Guna2VSeparator1.TabIndex = 29
        '
        'radNS
        '
        Me.radNS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radNS.AutoSize = True
        Me.radNS.BackColor = System.Drawing.Color.Transparent
        Me.radNS.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radNS.CheckedState.BorderThickness = 0
        Me.radNS.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radNS.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radNS.CheckedState.InnerOffset = -4
        Me.radNS.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNS.ForeColor = System.Drawing.Color.Black
        Me.radNS.Location = New System.Drawing.Point(144, 3)
        Me.radNS.Name = "radNS"
        Me.radNS.Size = New System.Drawing.Size(71, 41)
        Me.radNS.TabIndex = 28
        Me.radNS.Text = "NS"
        Me.radNS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.radNS.UncheckedState.BorderThickness = 2
        Me.radNS.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.radNS.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.radNS.UseVisualStyleBackColor = False
        '
        'radDS
        '
        Me.radDS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radDS.AutoSize = True
        Me.radDS.BackColor = System.Drawing.Color.Transparent
        Me.radDS.Checked = True
        Me.radDS.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radDS.CheckedState.BorderThickness = 3
        Me.radDS.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radDS.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radDS.CheckedState.InnerOffset = -4
        Me.radDS.Font = New System.Drawing.Font("Segoe UI", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDS.ForeColor = System.Drawing.Color.Black
        Me.radDS.Location = New System.Drawing.Point(21, 1)
        Me.radDS.Name = "radDS"
        Me.radDS.Size = New System.Drawing.Size(81, 49)
        Me.radDS.TabIndex = 27
        Me.radDS.TabStop = True
        Me.radDS.Text = "DS"
        Me.radDS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.radDS.UncheckedState.BorderThickness = 2
        Me.radDS.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.radDS.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.radDS.UseVisualStyleBackColor = False
        '
        'btn_select
        '
        Me.btn_select.BackColor = System.Drawing.Color.Transparent
        Me.btn_select.BorderRadius = 5
        Me.btn_select.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_select.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_select.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_select.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_select.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_select.FillColor = System.Drawing.Color.Crimson
        Me.btn_select.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_select.ForeColor = System.Drawing.Color.White
        Me.btn_select.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_select.ImageSize = New System.Drawing.Size(38, 38)
        Me.btn_select.Location = New System.Drawing.Point(0, 624)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_select.Size = New System.Drawing.Size(609, 51)
        Me.btn_select.TabIndex = 35
        Me.btn_select.Text = "Select Live"
        '
        'selectLive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 675)
        Me.Controls.Add(Me.btn_select)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Name = "selectLive"
        Me.Text = "selectLive"
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents radNS As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents radDS As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents btn_select As Guna.UI2.WinForms.Guna2Button
End Class
