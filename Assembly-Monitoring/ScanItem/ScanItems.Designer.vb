<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScanItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScanItems))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panel_select = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Guna2RadioButton2 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RadioButton1 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.dtpicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btn_select = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnPlay = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox4 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_qctimer = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_cycle = New System.Windows.Forms.Label()
        Me.lbl_actual = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_targettime = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblExpectedCT = New System.Windows.Forms.Label()
        Me.lblExpectedOutput = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.lblPlan = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblSPQ = New System.Windows.Forms.Label()
        Me.lblPartname = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblPartcode = New System.Windows.Forms.Label()
        Me.panelItems = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.txtItemBarcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.flowScanned = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblBoxContent = New System.Windows.Forms.Label()
        Me.txtLotQR = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panelScan = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.datagrid1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.panel_select.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox4.SuspendLayout()
        Me.Guna2GroupBox3.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelItems.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelScan.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panel_select.Location = New System.Drawing.Point(12, 12)
        Me.panel_select.Name = "panel_select"
        Me.panel_select.ShadowDecoration.BorderRadius = 10
        Me.panel_select.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.panel_select.ShadowDecoration.Enabled = True
        Me.panel_select.Size = New System.Drawing.Size(972, 114)
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
        Me.btn_select.BackColor = System.Drawing.Color.Transparent
        Me.btn_select.BorderRadius = 5
        Me.btn_select.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_select.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_select.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_select.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_select.FillColor = System.Drawing.Color.ForestGreen
        Me.btn_select.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_select.ForeColor = System.Drawing.Color.White
        Me.btn_select.Image = CType(resources.GetObject("btn_select.Image"), System.Drawing.Image)
        Me.btn_select.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_select.ImageSize = New System.Drawing.Size(38, 38)
        Me.btn_select.Location = New System.Drawing.Point(724, 50)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_select.Size = New System.Drawing.Size(220, 51)
        Me.btn_select.TabIndex = 32
        Me.btn_select.Text = "Select Plan"
        Me.btn_select.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Gray
        Me.Guna2GroupBox1.BorderRadius = 8
        Me.Guna2GroupBox1.Controls.Add(Me.btnPlay)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2GroupBox4)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2GroupBox3)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Separator1)
        Me.Guna2GroupBox1.Controls.Add(Me.lblPlan)
        Me.Guna2GroupBox1.Controls.Add(Me.lblModel)
        Me.Guna2GroupBox1.Controls.Add(Me.lblSPQ)
        Me.Guna2GroupBox1.Controls.Add(Me.lblPartname)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2GroupBox1.Controls.Add(Me.lblPartcode)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 138)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.BorderRadius = 10
        Me.Guna2GroupBox1.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.Guna2GroupBox1.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(398, 582)
        Me.Guna2GroupBox1.TabIndex = 37
        Me.Guna2GroupBox1.Text = "Plan Details"
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.Transparent
        Me.btnPlay.BorderRadius = 15
        Me.btnPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPlay.FillColor = System.Drawing.Color.ForestGreen
        Me.btnPlay.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.Color.White
        Me.btnPlay.Image = Global.Assembly_Monitoring.My.Resources.Resources.play
        Me.btnPlay.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnPlay.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnPlay.ImageSize = New System.Drawing.Size(55, 55)
        Me.btnPlay.Location = New System.Drawing.Point(32, 495)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPlay.Size = New System.Drawing.Size(345, 74)
        Me.btnPlay.TabIndex = 41
        Me.btnPlay.Text = "Start"
        '
        'Guna2GroupBox4
        '
        Me.Guna2GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox4.BorderColor = System.Drawing.Color.Gray
        Me.Guna2GroupBox4.BorderRadius = 8
        Me.Guna2GroupBox4.Controls.Add(Me.Label1)
        Me.Guna2GroupBox4.Controls.Add(Me.lbl_qctimer)
        Me.Guna2GroupBox4.Controls.Add(Me.Label13)
        Me.Guna2GroupBox4.Controls.Add(Me.lbl_cycle)
        Me.Guna2GroupBox4.Controls.Add(Me.lbl_actual)
        Me.Guna2GroupBox4.Controls.Add(Me.Label15)
        Me.Guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2GroupBox4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox4.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox4.Location = New System.Drawing.Point(208, 213)
        Me.Guna2GroupBox4.Name = "Guna2GroupBox4"
        Me.Guna2GroupBox4.ShadowDecoration.BorderRadius = 10
        Me.Guna2GroupBox4.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.Guna2GroupBox4.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox4.Size = New System.Drawing.Size(169, 276)
        Me.Guna2GroupBox4.TabIndex = 40
        Me.Guna2GroupBox4.Text = "ACTUAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(46, 202)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 21)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "QC Timer"
        '
        'lbl_qctimer
        '
        Me.lbl_qctimer.AutoSize = True
        Me.lbl_qctimer.BackColor = System.Drawing.Color.Transparent
        Me.lbl_qctimer.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qctimer.ForeColor = System.Drawing.Color.Black
        Me.lbl_qctimer.Location = New System.Drawing.Point(65, 227)
        Me.lbl_qctimer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_qctimer.Name = "lbl_qctimer"
        Me.lbl_qctimer.Size = New System.Drawing.Size(23, 25)
        Me.lbl_qctimer.TabIndex = 26
        Me.lbl_qctimer.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(18, 120)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 21)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Actual Cycle Time"
        '
        'lbl_cycle
        '
        Me.lbl_cycle.AutoSize = True
        Me.lbl_cycle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cycle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cycle.ForeColor = System.Drawing.Color.Black
        Me.lbl_cycle.Location = New System.Drawing.Point(65, 145)
        Me.lbl_cycle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cycle.Name = "lbl_cycle"
        Me.lbl_cycle.Size = New System.Drawing.Size(39, 25)
        Me.lbl_cycle.TabIndex = 24
        Me.lbl_cycle.Text = "0.0"
        '
        'lbl_actual
        '
        Me.lbl_actual.AutoSize = True
        Me.lbl_actual.BackColor = System.Drawing.Color.Transparent
        Me.lbl_actual.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_actual.ForeColor = System.Drawing.Color.Black
        Me.lbl_actual.Location = New System.Drawing.Point(67, 79)
        Me.lbl_actual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_actual.Name = "lbl_actual"
        Me.lbl_actual.Size = New System.Drawing.Size(34, 25)
        Me.lbl_actual.TabIndex = 17
        Me.lbl_actual.Text = "00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(31, 54)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 21)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Actual Output"
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox3.BorderColor = System.Drawing.Color.Gray
        Me.Guna2GroupBox3.BorderRadius = 8
        Me.Guna2GroupBox3.Controls.Add(Me.Label3)
        Me.Guna2GroupBox3.Controls.Add(Me.lbl_targettime)
        Me.Guna2GroupBox3.Controls.Add(Me.Label4)
        Me.Guna2GroupBox3.Controls.Add(Me.Label10)
        Me.Guna2GroupBox3.Controls.Add(Me.lblExpectedCT)
        Me.Guna2GroupBox3.Controls.Add(Me.lblExpectedOutput)
        Me.Guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(32, 213)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.ShadowDecoration.BorderRadius = 10
        Me.Guna2GroupBox3.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.Guna2GroupBox3.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(169, 276)
        Me.Guna2GroupBox3.TabIndex = 38
        Me.Guna2GroupBox3.Text = "TARGET"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(36, 202)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 21)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Target Timer"
        '
        'lbl_targettime
        '
        Me.lbl_targettime.AutoSize = True
        Me.lbl_targettime.BackColor = System.Drawing.Color.Transparent
        Me.lbl_targettime.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_targettime.ForeColor = System.Drawing.Color.Black
        Me.lbl_targettime.Location = New System.Drawing.Point(72, 230)
        Me.lbl_targettime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_targettime.Name = "lbl_targettime"
        Me.lbl_targettime.Size = New System.Drawing.Size(25, 30)
        Me.lbl_targettime.TabIndex = 26
        Me.lbl_targettime.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(9, 113)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 21)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Expected Cycle Time"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(22, 54)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 21)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Expected Output"
        '
        'lblExpectedCT
        '
        Me.lblExpectedCT.AutoSize = True
        Me.lblExpectedCT.BackColor = System.Drawing.Color.Transparent
        Me.lblExpectedCT.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpectedCT.ForeColor = System.Drawing.Color.Black
        Me.lblExpectedCT.Location = New System.Drawing.Point(72, 141)
        Me.lblExpectedCT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExpectedCT.Name = "lblExpectedCT"
        Me.lblExpectedCT.Size = New System.Drawing.Size(25, 30)
        Me.lblExpectedCT.TabIndex = 24
        Me.lblExpectedCT.Text = "0"
        '
        'lblExpectedOutput
        '
        Me.lblExpectedOutput.AutoSize = True
        Me.lblExpectedOutput.BackColor = System.Drawing.Color.Transparent
        Me.lblExpectedOutput.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpectedOutput.ForeColor = System.Drawing.Color.Black
        Me.lblExpectedOutput.Location = New System.Drawing.Point(72, 79)
        Me.lblExpectedOutput.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExpectedOutput.Name = "lblExpectedOutput"
        Me.lblExpectedOutput.Size = New System.Drawing.Size(25, 30)
        Me.lblExpectedOutput.TabIndex = 24
        Me.lblExpectedOutput.Text = "0"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(32, 182)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(335, 14)
        Me.Guna2Separator1.TabIndex = 15
        '
        'lblPlan
        '
        Me.lblPlan.AutoSize = True
        Me.lblPlan.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlan.ForeColor = System.Drawing.Color.Black
        Me.lblPlan.Location = New System.Drawing.Point(19, 133)
        Me.lblPlan.Name = "lblPlan"
        Me.lblPlan.Size = New System.Drawing.Size(133, 21)
        Me.lblPlan.TabIndex = 13
        Me.lblPlan.Text = "Production Plan :"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.ForeColor = System.Drawing.Color.Black
        Me.lblModel.Location = New System.Drawing.Point(19, 112)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(66, 21)
        Me.lblModel.TabIndex = 12
        Me.lblModel.Text = "Model :"
        '
        'lblSPQ
        '
        Me.lblSPQ.AutoSize = True
        Me.lblSPQ.BackColor = System.Drawing.Color.Transparent
        Me.lblSPQ.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSPQ.ForeColor = System.Drawing.Color.Black
        Me.lblSPQ.Location = New System.Drawing.Point(19, 154)
        Me.lblSPQ.Name = "lblSPQ"
        Me.lblSPQ.Size = New System.Drawing.Size(104, 21)
        Me.lblSPQ.TabIndex = 11
        Me.lblSPQ.Text = "Package Qty:"
        '
        'lblPartname
        '
        Me.lblPartname.AutoSize = True
        Me.lblPartname.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartname.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblPartname.Location = New System.Drawing.Point(64, 54)
        Me.lblPartname.Name = "lblPartname"
        Me.lblPartname.Size = New System.Drawing.Size(99, 25)
        Me.lblPartname.TabIndex = 10
        Me.lblPartname.Text = "Partname"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(13, 54)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(44, 42)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 9
        Me.Guna2PictureBox1.TabStop = False
        '
        'lblPartcode
        '
        Me.lblPartcode.AutoSize = True
        Me.lblPartcode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartcode.ForeColor = System.Drawing.Color.Black
        Me.lblPartcode.Location = New System.Drawing.Point(64, 75)
        Me.lblPartcode.Name = "lblPartcode"
        Me.lblPartcode.Size = New System.Drawing.Size(78, 21)
        Me.lblPartcode.TabIndex = 8
        Me.lblPartcode.Text = "Partcode"
        '
        'panelItems
        '
        Me.panelItems.BackColor = System.Drawing.Color.Transparent
        Me.panelItems.BorderColor = System.Drawing.Color.Gray
        Me.panelItems.BorderRadius = 8
        Me.panelItems.Controls.Add(Me.Guna2Button1)
        Me.panelItems.Controls.Add(Me.txtItemBarcode)
        Me.panelItems.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.panelItems.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelItems.ForeColor = System.Drawing.Color.White
        Me.panelItems.Location = New System.Drawing.Point(3, 6)
        Me.panelItems.Name = "panelItems"
        Me.panelItems.ShadowDecoration.BorderRadius = 10
        Me.panelItems.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.panelItems.ShadowDecoration.Enabled = True
        Me.panelItems.Size = New System.Drawing.Size(565, 133)
        Me.panelItems.TabIndex = 38
        Me.panelItems.Text = "Scan Items"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.ForestGreen
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.ImageOffset = New System.Drawing.Point(-10, 0)
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(38, 38)
        Me.Guna2Button1.Location = New System.Drawing.Point(435, 54)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Guna2Button1.Size = New System.Drawing.Size(109, 50)
        Me.Guna2Button1.TabIndex = 33
        Me.Guna2Button1.Text = "Reset"
        '
        'txtItemBarcode
        '
        Me.txtItemBarcode.BackColor = System.Drawing.Color.White
        Me.txtItemBarcode.BorderColor = System.Drawing.Color.ForestGreen
        Me.txtItemBarcode.BorderRadius = 10
        Me.txtItemBarcode.BorderThickness = 3
        Me.txtItemBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemBarcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemBarcode.DefaultText = ""
        Me.txtItemBarcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItemBarcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItemBarcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemBarcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemBarcode.Enabled = False
        Me.txtItemBarcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemBarcode.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtItemBarcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemBarcode.IconLeft = CType(resources.GetObject("txtItemBarcode.IconLeft"), System.Drawing.Image)
        Me.txtItemBarcode.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtItemBarcode.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.txtItemBarcode.Location = New System.Drawing.Point(24, 54)
        Me.txtItemBarcode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtItemBarcode.Name = "txtItemBarcode"
        Me.txtItemBarcode.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtItemBarcode.PlaceholderText = "Scan Item Barcode..."
        Me.txtItemBarcode.SelectedText = ""
        Me.txtItemBarcode.Size = New System.Drawing.Size(405, 50)
        Me.txtItemBarcode.TabIndex = 18
        '
        'flowScanned
        '
        Me.flowScanned.AutoScroll = True
        Me.flowScanned.BackColor = System.Drawing.Color.Transparent
        Me.flowScanned.Location = New System.Drawing.Point(20, 68)
        Me.flowScanned.Margin = New System.Windows.Forms.Padding(0)
        Me.flowScanned.Name = "flowScanned"
        Me.flowScanned.Size = New System.Drawing.Size(524, 291)
        Me.flowScanned.TabIndex = 19
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.DimGray
        Me.Guna2Panel1.BorderRadius = 3
        Me.Guna2Panel1.BorderThickness = 3
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel1.Controls.Add(Me.lblBoxContent)
        Me.Guna2Panel1.Controls.Add(Me.flowScanned)
        Me.Guna2Panel1.Controls.Add(Me.txtLotQR)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(3, 145)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(565, 437)
        Me.Guna2Panel1.TabIndex = 39
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(20, 21)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 41
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'lblBoxContent
        '
        Me.lblBoxContent.AutoSize = True
        Me.lblBoxContent.BackColor = System.Drawing.Color.White
        Me.lblBoxContent.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBoxContent.ForeColor = System.Drawing.Color.Black
        Me.lblBoxContent.Location = New System.Drawing.Point(56, 21)
        Me.lblBoxContent.Name = "lblBoxContent"
        Me.lblBoxContent.Size = New System.Drawing.Size(162, 30)
        Me.lblBoxContent.TabIndex = 20
        Me.lblBoxContent.Text = "Box Content : 0"
        '
        'txtLotQR
        '
        Me.txtLotQR.BackColor = System.Drawing.Color.Transparent
        Me.txtLotQR.BorderColor = System.Drawing.Color.ForestGreen
        Me.txtLotQR.BorderRadius = 10
        Me.txtLotQR.BorderThickness = 3
        Me.txtLotQR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLotQR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLotQR.DefaultText = ""
        Me.txtLotQR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLotQR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLotQR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLotQR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLotQR.Enabled = False
        Me.txtLotQR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLotQR.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtLotQR.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLotQR.IconLeft = CType(resources.GetObject("txtLotQR.IconLeft"), System.Drawing.Image)
        Me.txtLotQR.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtLotQR.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.txtLotQR.Location = New System.Drawing.Point(20, 363)
        Me.txtLotQR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLotQR.Name = "txtLotQR"
        Me.txtLotQR.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtLotQR.PlaceholderText = "Scan Lot Box QR..."
        Me.txtLotQR.SelectedText = ""
        Me.txtLotQR.Size = New System.Drawing.Size(524, 50)
        Me.txtLotQR.TabIndex = 10
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'panelScan
        '
        Me.panelScan.Controls.Add(Me.panelItems)
        Me.panelScan.Controls.Add(Me.Guna2Panel1)
        Me.panelScan.Location = New System.Drawing.Point(416, 132)
        Me.panelScan.Name = "panelScan"
        Me.panelScan.Size = New System.Drawing.Size(577, 593)
        Me.panelScan.TabIndex = 40
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.Gray
        Me.Guna2GroupBox2.BorderRadius = 8
        Me.Guna2GroupBox2.Controls.Add(Me.datagrid1)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(999, 12)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.BorderRadius = 10
        Me.Guna2GroupBox2.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.Guna2GroupBox2.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(346, 702)
        Me.Guna2GroupBox2.TabIndex = 41
        Me.Guna2GroupBox2.Text = "Scanned Barcodes"
        '
        'datagrid1
        '
        Me.datagrid1.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.datagrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.datagrid1.ColumnHeadersHeight = 28
        Me.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid1.DefaultCellStyle = DataGridViewCellStyle7
        Me.datagrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.Location = New System.Drawing.Point(17, 50)
        Me.datagrid1.Name = "datagrid1"
        Me.datagrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.datagrid1.RowHeadersVisible = False
        Me.datagrid1.Size = New System.Drawing.Size(311, 628)
        Me.datagrid1.TabIndex = 21
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.datagrid1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagrid1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid1.ThemeStyle.HeaderStyle.Height = 28
        Me.datagrid1.ThemeStyle.ReadOnly = False
        Me.datagrid1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagrid1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid1.ThemeStyle.RowsStyle.Height = 22
        Me.datagrid1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ScanItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1427, 761)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.panelScan)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.panel_select)
        Me.Name = "ScanItems"
        Me.Text = "Scan Items"
        Me.panel_select.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2GroupBox4.ResumeLayout(False)
        Me.Guna2GroupBox4.PerformLayout()
        Me.Guna2GroupBox3.ResumeLayout(False)
        Me.Guna2GroupBox3.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelItems.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelScan.ResumeLayout(False)
        Me.Guna2GroupBox2.ResumeLayout(False)
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_select As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents Guna2RadioButton2 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RadioButton1 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents dtpicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btn_select As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents lblPlan As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblSPQ As Label
    Friend WithEvents lblPartname As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblPartcode As Label
    Friend WithEvents panelItems As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtLotQR As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtItemBarcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox4 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_cycle As Label
    Friend WithEvents lbl_actual As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblExpectedCT As Label
    Friend WithEvents lblExpectedOutput As Label
    Friend WithEvents flowScanned As FlowLayoutPanel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblBoxContent As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnPlay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_qctimer As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_targettime As Label
    Friend WithEvents panelScan As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents datagrid1 As Guna.UI2.WinForms.Guna2DataGridView
End Class
