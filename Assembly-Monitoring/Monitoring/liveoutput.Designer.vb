<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class liveoutput
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
        Me.panel_output = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_target = New System.Windows.Forms.Label()
        Me.lbl_output = New System.Windows.Forms.Label()
        Me.lbl_actual = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_partcode = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lbl_model = New System.Windows.Forms.Label()
        Me.lbl_partcode = New System.Windows.Forms.Label()
        Me.lbl_plan = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_cycle = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_percent = New System.Windows.Forms.Label()
        Me.radial = New Guna.UI2.WinForms.Guna2RadialGauge()
        Me.panel_output.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_output
        '
        Me.panel_output.Controls.Add(Me.lbl_target)
        Me.panel_output.Controls.Add(Me.lbl_output)
        Me.panel_output.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_output.FillColor = System.Drawing.Color.White
        Me.panel_output.Location = New System.Drawing.Point(0, 680)
        Me.panel_output.Name = "panel_output"
        Me.panel_output.Size = New System.Drawing.Size(867, 436)
        Me.panel_output.TabIndex = 35
        '
        'lbl_target
        '
        Me.lbl_target.AutoSize = True
        Me.lbl_target.BackColor = System.Drawing.Color.Transparent
        Me.lbl_target.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_target.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_target.Location = New System.Drawing.Point(42, -9)
        Me.lbl_target.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_target.Name = "lbl_target"
        Me.lbl_target.Size = New System.Drawing.Size(255, 86)
        Me.lbl_target.TabIndex = 23
        Me.lbl_target.Text = "TARGET"
        '
        'lbl_output
        '
        Me.lbl_output.AutoSize = True
        Me.lbl_output.BackColor = System.Drawing.Color.Transparent
        Me.lbl_output.Font = New System.Drawing.Font("Impact", 300.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_output.ForeColor = System.Drawing.Color.Black
        Me.lbl_output.Location = New System.Drawing.Point(-79, -9)
        Me.lbl_output.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_output.Name = "lbl_output"
        Me.lbl_output.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.lbl_output.Size = New System.Drawing.Size(1065, 508)
        Me.lbl_output.TabIndex = 24
        Me.lbl_output.Text = "0000"
        '
        'lbl_actual
        '
        Me.lbl_actual.AutoSize = True
        Me.lbl_actual.BackColor = System.Drawing.Color.Transparent
        Me.lbl_actual.Font = New System.Drawing.Font("Impact", 300.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_actual.ForeColor = System.Drawing.Color.Black
        Me.lbl_actual.Location = New System.Drawing.Point(-79, 0)
        Me.lbl_actual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_actual.Name = "lbl_actual"
        Me.lbl_actual.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.lbl_actual.Size = New System.Drawing.Size(1065, 508)
        Me.lbl_actual.TabIndex = 17
        Me.lbl_actual.Text = "0000"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Gray
        Me.Guna2Panel3.BorderThickness = 2
        Me.Guna2Panel3.Controls.Add(Me.Label4)
        Me.Guna2Panel3.Controls.Add(Me.Label5)
        Me.Guna2Panel3.Controls.Add(Me.cmb_partcode)
        Me.Guna2Panel3.Controls.Add(Me.lbl_model)
        Me.Guna2Panel3.Controls.Add(Me.lbl_partcode)
        Me.Guna2Panel3.Controls.Add(Me.lbl_plan)
        Me.Guna2Panel3.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(867, 224)
        Me.Guna2Panel3.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(4, 10)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 32)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Partcode"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(468, -12)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 86)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Plan"
        '
        'cmb_partcode
        '
        Me.cmb_partcode.BackColor = System.Drawing.Color.Transparent
        Me.cmb_partcode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_partcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_partcode.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_partcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_partcode.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_partcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_partcode.ItemHeight = 30
        Me.cmb_partcode.Location = New System.Drawing.Point(128, 9)
        Me.cmb_partcode.Name = "cmb_partcode"
        Me.cmb_partcode.Size = New System.Drawing.Size(247, 36)
        Me.cmb_partcode.TabIndex = 25
        '
        'lbl_model
        '
        Me.lbl_model.AutoSize = True
        Me.lbl_model.BackColor = System.Drawing.Color.Transparent
        Me.lbl_model.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_model.ForeColor = System.Drawing.Color.Black
        Me.lbl_model.Location = New System.Drawing.Point(5, 120)
        Me.lbl_model.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_model.Name = "lbl_model"
        Me.lbl_model.Size = New System.Drawing.Size(121, 65)
        Me.lbl_model.TabIndex = 22
        Me.lbl_model.Text = "N/A"
        '
        'lbl_partcode
        '
        Me.lbl_partcode.AutoSize = True
        Me.lbl_partcode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_partcode.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_partcode.ForeColor = System.Drawing.Color.Black
        Me.lbl_partcode.Location = New System.Drawing.Point(4, 48)
        Me.lbl_partcode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_partcode.Name = "lbl_partcode"
        Me.lbl_partcode.Size = New System.Drawing.Size(121, 65)
        Me.lbl_partcode.TabIndex = 27
        Me.lbl_partcode.Text = "N/A"
        '
        'lbl_plan
        '
        Me.lbl_plan.AutoSize = True
        Me.lbl_plan.BackColor = System.Drawing.Color.Transparent
        Me.lbl_plan.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_plan.Font = New System.Drawing.Font("Segoe UI", 99.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_plan.ForeColor = System.Drawing.Color.Black
        Me.lbl_plan.Location = New System.Drawing.Point(321, 0)
        Me.lbl_plan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_plan.Name = "lbl_plan"
        Me.lbl_plan.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.lbl_plan.Size = New System.Drawing.Size(305, 205)
        Me.lbl_plan.TabIndex = 15
        Me.lbl_plan.Text = "000"
        Me.lbl_plan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Gray
        Me.Guna2Panel2.BorderRadius = 10
        Me.Guna2Panel2.BorderThickness = 7
        Me.Guna2Panel2.Controls.Add(Me.Label6)
        Me.Guna2Panel2.Controls.Add(Me.lbl_cycle)
        Me.Guna2Panel2.Controls.Add(Me.Label7)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(626, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(241, 224)
        Me.Guna2Panel2.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(19, 10)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(202, 47)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "CYCLE TIME"
        '
        'lbl_cycle
        '
        Me.lbl_cycle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_cycle.AutoSize = True
        Me.lbl_cycle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cycle.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cycle.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_cycle.Location = New System.Drawing.Point(4, 9)
        Me.lbl_cycle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cycle.Name = "lbl_cycle"
        Me.lbl_cycle.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.lbl_cycle.Size = New System.Drawing.Size(246, 158)
        Me.lbl_cycle.TabIndex = 28
        Me.lbl_cycle.Text = "00.0"
        Me.lbl_cycle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(37, 125)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.Label7.Size = New System.Drawing.Size(166, 80)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "sec/item"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.lbl_actual)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 224)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(867, 456)
        Me.Guna2Panel1.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(13, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(264, 86)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "ACTUAL"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.Gray
        Me.Guna2Panel4.BorderThickness = 2
        Me.Guna2Panel4.Controls.Add(Me.lbl_percent)
        Me.Guna2Panel4.Controls.Add(Me.radial)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel4.FillColor = System.Drawing.Color.White
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 1116)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(867, 435)
        Me.Guna2Panel4.TabIndex = 38
        '
        'lbl_percent
        '
        Me.lbl_percent.AutoSize = True
        Me.lbl_percent.BackColor = System.Drawing.Color.Transparent
        Me.lbl_percent.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_percent.Font = New System.Drawing.Font("Segoe UI", 99.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_percent.ForeColor = System.Drawing.Color.Black
        Me.lbl_percent.Location = New System.Drawing.Point(601, 0)
        Me.lbl_percent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_percent.Name = "lbl_percent"
        Me.lbl_percent.Size = New System.Drawing.Size(266, 175)
        Me.lbl_percent.TabIndex = 24
        Me.lbl_percent.Text = "0%"
        '
        'radial
        '
        Me.radial.ArrowColor = System.Drawing.SystemColors.ControlDarkDark
        Me.radial.ArrowThickness = 20
        Me.radial.BackColor = System.Drawing.Color.Transparent
        Me.radial.Dock = System.Windows.Forms.DockStyle.Left
        Me.radial.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.radial.Location = New System.Drawing.Point(0, 0)
        Me.radial.MinimumSize = New System.Drawing.Size(30, 30)
        Me.radial.Name = "radial"
        Me.radial.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.radial.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.radial.ProgressThickness = 50
        Me.radial.Size = New System.Drawing.Size(450, 450)
        Me.radial.TabIndex = 25
        Me.radial.UseTransparentBackground = True
        '
        'liveoutput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 50)
        Me.ClientSize = New System.Drawing.Size(884, 1061)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.panel_output)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Name = "liveoutput"
        Me.Text = "monitoring"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel_output.ResumeLayout(False)
        Me.panel_output.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_output As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbl_actual As Label
    Friend WithEvents lbl_target As Label
    Friend WithEvents lbl_output As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbl_partcode As Label
    Friend WithEvents cmb_partcode As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lbl_model As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_plan As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbl_percent As Label
    Friend WithEvents radial As Guna.UI2.WinForms.Guna2RadialGauge
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_cycle As Label
    Friend WithEvents Label7 As Label
End Class
