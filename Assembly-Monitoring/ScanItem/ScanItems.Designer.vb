<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScanItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScanItems))
        Me.panel_select = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Guna2RadioButton2 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RadioButton1 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.dtpicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btn_select = New Guna.UI2.WinForms.Guna2Button()
        Me.panel_select.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_select
        '
        Me.panel_select.BackColor = System.Drawing.Color.Transparent
        Me.panel_select.BorderColor = System.Drawing.Color.Gray
        Me.panel_select.BorderRadius = 8
        Me.panel_select.Controls.Add(Me.Guna2Panel4)
        Me.panel_select.Controls.Add(Me.dtpicker1)
        Me.panel_select.Controls.Add(Me.btn_select)
        Me.panel_select.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.panel_select.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel_select.ForeColor = System.Drawing.Color.White
        Me.panel_select.Location = New System.Drawing.Point(41, 25)
        Me.panel_select.Name = "panel_select"
        Me.panel_select.ShadowDecoration.BorderRadius = 10
        Me.panel_select.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.panel_select.ShadowDecoration.Enabled = True
        Me.panel_select.Size = New System.Drawing.Size(1005, 114)
        Me.panel_select.TabIndex = 36
        Me.panel_select.Text = "DATE & SHIFT"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel4.BorderRadius = 8
        Me.Guna2Panel4.BorderThickness = 1
        Me.Guna2Panel4.Controls.Add(Me.Guna2VSeparator1)
        Me.Guna2Panel4.Controls.Add(Me.Guna2RadioButton2)
        Me.Guna2Panel4.Controls.Add(Me.Guna2RadioButton1)
        Me.Guna2Panel4.Location = New System.Drawing.Point(479, 50)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(239, 51)
        Me.Guna2Panel4.TabIndex = 33
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(114, 5)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(10, 41)
        Me.Guna2VSeparator1.TabIndex = 29
        '
        'Guna2RadioButton2
        '
        Me.Guna2RadioButton2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2RadioButton2.AutoSize = True
        Me.Guna2RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton2.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton2.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton2.CheckedState.InnerOffset = -4
        Me.Guna2RadioButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.Guna2RadioButton2.Location = New System.Drawing.Point(144, 3)
        Me.Guna2RadioButton2.Name = "Guna2RadioButton2"
        Me.Guna2RadioButton2.Size = New System.Drawing.Size(71, 41)
        Me.Guna2RadioButton2.TabIndex = 28
        Me.Guna2RadioButton2.Text = "NS"
        Me.Guna2RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton2.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton2.UseVisualStyleBackColor = False
        '
        'Guna2RadioButton1
        '
        Me.Guna2RadioButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2RadioButton1.AutoSize = True
        Me.Guna2RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton1.Checked = True
        Me.Guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton1.CheckedState.BorderThickness = 3
        Me.Guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton1.CheckedState.InnerOffset = -4
        Me.Guna2RadioButton1.Font = New System.Drawing.Font("Segoe UI", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.Guna2RadioButton1.Location = New System.Drawing.Point(21, 1)
        Me.Guna2RadioButton1.Name = "Guna2RadioButton1"
        Me.Guna2RadioButton1.Size = New System.Drawing.Size(81, 49)
        Me.Guna2RadioButton1.TabIndex = 27
        Me.Guna2RadioButton1.TabStop = True
        Me.Guna2RadioButton1.Text = "DS"
        Me.Guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton1.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton1.UseVisualStyleBackColor = False
        '
        'dtpicker1
        '
        Me.dtpicker1.BackColor = System.Drawing.Color.Transparent
        Me.dtpicker1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtpicker1.BorderRadius = 8
        Me.dtpicker1.BorderThickness = 1
        Me.dtpicker1.Checked = True
        Me.dtpicker1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.dtpicker1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpicker1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.dtpicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpicker1.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.dtpicker1.Location = New System.Drawing.Point(23, 50)
        Me.dtpicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpicker1.Name = "dtpicker1"
        Me.dtpicker1.Size = New System.Drawing.Size(428, 51)
        Me.dtpicker1.TabIndex = 32
        Me.dtpicker1.Value = New Date(2025, 8, 13, 9, 22, 27, 105)
        '
        'btn_select
        '
        Me.btn_select.AutoRoundedCorners = True
        Me.btn_select.BackColor = System.Drawing.Color.Transparent
        Me.btn_select.BorderRadius = 24
        Me.btn_select.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_select.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_select.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_select.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_select.FillColor = System.Drawing.Color.ForestGreen
        Me.btn_select.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.btn_select.ForeColor = System.Drawing.Color.White
        Me.btn_select.Image = CType(resources.GetObject("btn_select.Image"), System.Drawing.Image)
        Me.btn_select.ImageOffset = New System.Drawing.Point(-2, 0)
        Me.btn_select.ImageSize = New System.Drawing.Size(38, 38)
        Me.btn_select.Location = New System.Drawing.Point(824, 50)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_select.Size = New System.Drawing.Size(146, 51)
        Me.btn_select.TabIndex = 32
        Me.btn_select.Text = "Select FG"
        '
        'ScanItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 662)
        Me.Controls.Add(Me.panel_select)
        Me.Name = "ScanItems"
        Me.Text = "ScanItems"
        Me.panel_select.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_select As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents Guna2RadioButton2 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RadioButton1 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents dtpicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btn_select As Guna.UI2.WinForms.Guna2Button
End Class
