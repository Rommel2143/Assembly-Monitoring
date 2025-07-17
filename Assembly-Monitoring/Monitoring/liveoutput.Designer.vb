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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(liveoutput))
        Me.panel_output = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_cycle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_actual = New System.Windows.Forms.Label()
        Me.lbl_target = New System.Windows.Forms.Label()
        Me.lbl_output = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_partcode = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lbl_model = New System.Windows.Forms.Label()
        Me.lbl_plan = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panel_CTtarget = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_CTtarget = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.radial = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_percent = New System.Windows.Forms.Label()
        Me.panel_output.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.panel_CTtarget.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_output
        '
        Me.panel_output.BorderColor = System.Drawing.Color.Gray
        Me.panel_output.BorderThickness = 2
        Me.panel_output.Controls.Add(Me.Guna2Panel2)
        Me.panel_output.Controls.Add(Me.Label2)
        Me.panel_output.Controls.Add(Me.lbl_actual)
        Me.panel_output.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_output.FillColor = System.Drawing.Color.White
        Me.panel_output.Location = New System.Drawing.Point(0, 650)
        Me.panel_output.Name = "panel_output"
        Me.panel_output.Size = New System.Drawing.Size(867, 490)
        Me.panel_output.TabIndex = 35
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Guna2PictureBox3)
        Me.Guna2Panel2.Controls.Add(Me.lbl_cycle)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.MistyRose
        Me.Guna2Panel2.Location = New System.Drawing.Point(545, 6)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(310, 100)
        Me.Guna2Panel2.TabIndex = 32
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(100, 100)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox3.TabIndex = 30
        Me.Guna2PictureBox3.TabStop = False
        '
        'lbl_cycle
        '
        Me.lbl_cycle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_cycle.AutoSize = True
        Me.lbl_cycle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cycle.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cycle.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_cycle.Location = New System.Drawing.Point(77, -12)
        Me.lbl_cycle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cycle.Name = "lbl_cycle"
        Me.lbl_cycle.Size = New System.Drawing.Size(220, 128)
        Me.lbl_cycle.TabIndex = 28
        Me.lbl_cycle.Text = "000"
        Me.lbl_cycle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(4, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(445, 86)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "ACTUAL SCAN"
        '
        'lbl_actual
        '
        Me.lbl_actual.AutoSize = True
        Me.lbl_actual.BackColor = System.Drawing.Color.Transparent
        Me.lbl_actual.Font = New System.Drawing.Font("Impact", 249.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_actual.ForeColor = System.Drawing.Color.Black
        Me.lbl_actual.Location = New System.Drawing.Point(-58, 57)
        Me.lbl_actual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_actual.Name = "lbl_actual"
        Me.lbl_actual.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.lbl_actual.Size = New System.Drawing.Size(890, 426)
        Me.lbl_actual.TabIndex = 17
        Me.lbl_actual.Text = "0000"
        '
        'lbl_target
        '
        Me.lbl_target.AutoSize = True
        Me.lbl_target.BackColor = System.Drawing.Color.Transparent
        Me.lbl_target.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_target.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_target.Location = New System.Drawing.Point(4, -9)
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
        Me.lbl_output.Font = New System.Drawing.Font("Impact", 249.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_output.ForeColor = System.Drawing.Color.Black
        Me.lbl_output.Location = New System.Drawing.Point(-69, 87)
        Me.lbl_output.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_output.Name = "lbl_output"
        Me.lbl_output.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.lbl_output.Size = New System.Drawing.Size(890, 426)
        Me.lbl_output.TabIndex = 24
        Me.lbl_output.Text = "0000"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Gray
        Me.Guna2Panel3.BorderThickness = 2
        Me.Guna2Panel3.Controls.Add(Me.Guna2VSeparator1)
        Me.Guna2Panel3.Controls.Add(Me.Label4)
        Me.Guna2Panel3.Controls.Add(Me.Label5)
        Me.Guna2Panel3.Controls.Add(Me.cmb_partcode)
        Me.Guna2Panel3.Controls.Add(Me.lbl_model)
        Me.Guna2Panel3.Controls.Add(Me.lbl_plan)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(867, 194)
        Me.Guna2Panel3.TabIndex = 33
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(576, 9)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(10, 166)
        Me.Guna2VSeparator1.TabIndex = 26
        Me.Guna2VSeparator1.UseTransparentBackground = True
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
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(580, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 50)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Line Plan"
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
        Me.lbl_model.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_model.ForeColor = System.Drawing.Color.Black
        Me.lbl_model.Location = New System.Drawing.Point(13, 42)
        Me.lbl_model.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_model.MaximumSize = New System.Drawing.Size(557, 0)
        Me.lbl_model.Name = "lbl_model"
        Me.lbl_model.Size = New System.Drawing.Size(161, 86)
        Me.lbl_model.TabIndex = 22
        Me.lbl_model.Text = "N/A"
        '
        'lbl_plan
        '
        Me.lbl_plan.AutoSize = True
        Me.lbl_plan.BackColor = System.Drawing.Color.Transparent
        Me.lbl_plan.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_plan.ForeColor = System.Drawing.Color.Black
        Me.lbl_plan.Location = New System.Drawing.Point(567, 9)
        Me.lbl_plan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_plan.Name = "lbl_plan"
        Me.lbl_plan.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.lbl_plan.Size = New System.Drawing.Size(220, 158)
        Me.lbl_plan.TabIndex = 15
        Me.lbl_plan.Text = "000"
        Me.lbl_plan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Gray
        Me.Guna2Panel1.BorderThickness = 2
        Me.Guna2Panel1.Controls.Add(Me.panel_CTtarget)
        Me.Guna2Panel1.Controls.Add(Me.lbl_target)
        Me.Guna2Panel1.Controls.Add(Me.lbl_output)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 194)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(867, 456)
        Me.Guna2Panel1.TabIndex = 37
        '
        'panel_CTtarget
        '
        Me.panel_CTtarget.Controls.Add(Me.Guna2PictureBox1)
        Me.panel_CTtarget.Controls.Add(Me.lbl_CTtarget)
        Me.panel_CTtarget.FillColor = System.Drawing.Color.MistyRose
        Me.panel_CTtarget.Location = New System.Drawing.Point(545, 6)
        Me.panel_CTtarget.Name = "panel_CTtarget"
        Me.panel_CTtarget.Size = New System.Drawing.Size(310, 100)
        Me.panel_CTtarget.TabIndex = 31
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 30
        Me.Guna2PictureBox1.TabStop = False
        '
        'lbl_CTtarget
        '
        Me.lbl_CTtarget.AutoSize = True
        Me.lbl_CTtarget.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CTtarget.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CTtarget.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_CTtarget.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl_CTtarget.Location = New System.Drawing.Point(90, -12)
        Me.lbl_CTtarget.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_CTtarget.Name = "lbl_CTtarget"
        Me.lbl_CTtarget.Size = New System.Drawing.Size(220, 128)
        Me.lbl_CTtarget.TabIndex = 29
        Me.lbl_CTtarget.Text = "000"
        Me.lbl_CTtarget.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.Gray
        Me.Guna2Panel4.BorderThickness = 2
        Me.Guna2Panel4.Controls.Add(Me.radial)
        Me.Guna2Panel4.Controls.Add(Me.Label1)
        Me.Guna2Panel4.Controls.Add(Me.lbl_percent)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel4.FillColor = System.Drawing.Color.White
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 1140)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(867, 435)
        Me.Guna2Panel4.TabIndex = 38
        '
        'radial
        '
        Me.radial.Dock = System.Windows.Forms.DockStyle.Top
        Me.radial.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radial.Location = New System.Drawing.Point(0, 0)
        Me.radial.Name = "radial"
        Me.radial.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.SolidTransition
        Me.radial.ProgressColor = System.Drawing.Color.Crimson
        Me.radial.ProgressColor2 = System.Drawing.Color.GreenYellow
        Me.radial.ShowText = True
        Me.radial.Size = New System.Drawing.Size(867, 102)
        Me.radial.TabIndex = 27
        Me.radial.Text = "Guna2ProgressBar1"
        Me.radial.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value
        Me.radial.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.radial.Value = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(15, 105)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 50)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "LINE PROGRESS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_percent
        '
        Me.lbl_percent.AutoSize = True
        Me.lbl_percent.BackColor = System.Drawing.Color.Transparent
        Me.lbl_percent.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_percent.ForeColor = System.Drawing.Color.Black
        Me.lbl_percent.Location = New System.Drawing.Point(13, 128)
        Me.lbl_percent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_percent.Name = "lbl_percent"
        Me.lbl_percent.Size = New System.Drawing.Size(193, 128)
        Me.lbl_percent.TabIndex = 24
        Me.lbl_percent.Text = "0%"
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
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.panel_CTtarget.ResumeLayout(False)
        Me.panel_CTtarget.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_output As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbl_actual As Label
    Friend WithEvents lbl_target As Label
    Friend WithEvents lbl_output As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
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
    Friend WithEvents lbl_cycle As Label
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents panel_CTtarget As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lbl_CTtarget As Label
    Friend WithEvents radial As Guna.UI2.WinForms.Guna2ProgressBar
End Class
