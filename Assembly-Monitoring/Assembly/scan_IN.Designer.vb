<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scan_IN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scan_IN))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_barcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_line = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_plan = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_actual = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_clock = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.datagrid1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.lbl_model = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_cycle = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_partname = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmb_partcode = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_output = New System.Windows.Forms.Label()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_modelcode = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_targettime = New System.Windows.Forms.Label()
        Me.panel_scan = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.panel_scan.SuspendLayout()
        Me.Guna2Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_barcode
        '
        Me.txt_barcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_barcode.DefaultText = ""
        Me.txt_barcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_barcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_barcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_barcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_barcode.Enabled = False
        Me.txt_barcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_barcode.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_barcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_barcode.IconLeft = CType(resources.GetObject("txt_barcode.IconLeft"), System.Drawing.Image)
        Me.txt_barcode.Location = New System.Drawing.Point(26, 25)
        Me.txt_barcode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_barcode.PlaceholderText = "Scan Here..."
        Me.txt_barcode.SelectedText = ""
        Me.txt_barcode.Size = New System.Drawing.Size(264, 50)
        Me.txt_barcode.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(22, 25)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Line"
        '
        'cmb_line
        '
        Me.cmb_line.BackColor = System.Drawing.Color.Transparent
        Me.cmb_line.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_line.DropDownHeight = 300
        Me.cmb_line.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_line.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_line.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_line.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_line.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_line.IntegralHeight = False
        Me.cmb_line.ItemHeight = 30
        Me.cmb_line.Location = New System.Drawing.Point(31, 45)
        Me.cmb_line.Name = "cmb_line"
        Me.cmb_line.Size = New System.Drawing.Size(202, 36)
        Me.cmb_line.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(22, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Partcode"
        '
        'lbl_plan
        '
        Me.lbl_plan.AutoSize = True
        Me.lbl_plan.BackColor = System.Drawing.Color.Transparent
        Me.lbl_plan.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_plan.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_plan.Location = New System.Drawing.Point(17, 37)
        Me.lbl_plan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_plan.Name = "lbl_plan"
        Me.lbl_plan.Size = New System.Drawing.Size(56, 45)
        Me.lbl_plan.TabIndex = 15
        Me.lbl_plan.Text = "00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(22, 22)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Plan"
        '
        'lbl_actual
        '
        Me.lbl_actual.AutoSize = True
        Me.lbl_actual.BackColor = System.Drawing.Color.Transparent
        Me.lbl_actual.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_actual.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_actual.Location = New System.Drawing.Point(200, 160)
        Me.lbl_actual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_actual.Name = "lbl_actual"
        Me.lbl_actual.Size = New System.Drawing.Size(56, 45)
        Me.lbl_actual.TabIndex = 17
        Me.lbl_actual.Text = "00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(184, 143)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Actual Output"
        '
        'lbl_clock
        '
        Me.lbl_clock.AutoSize = True
        Me.lbl_clock.BackColor = System.Drawing.Color.Transparent
        Me.lbl_clock.Font = New System.Drawing.Font("Orbitron", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clock.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbl_clock.Location = New System.Drawing.Point(10, 41)
        Me.lbl_clock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_clock.Name = "lbl_clock"
        Me.lbl_clock.Size = New System.Drawing.Size(82, 46)
        Me.lbl_clock.TabIndex = 19
        Me.lbl_clock.Text = "00"
        Me.lbl_clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(21, 9)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 25)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Timer"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'datagrid1
        '
        Me.datagrid1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagrid1.ColumnHeadersHeight = 28
        Me.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid1.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.Location = New System.Drawing.Point(26, 83)
        Me.datagrid1.Name = "datagrid1"
        Me.datagrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datagrid1.RowHeadersVisible = False
        Me.datagrid1.Size = New System.Drawing.Size(264, 356)
        Me.datagrid1.TabIndex = 20
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
        'lbl_model
        '
        Me.lbl_model.AutoSize = True
        Me.lbl_model.BackColor = System.Drawing.Color.Transparent
        Me.lbl_model.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_model.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_model.Location = New System.Drawing.Point(31, 153)
        Me.lbl_model.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_model.Name = "lbl_model"
        Me.lbl_model.Size = New System.Drawing.Size(48, 25)
        Me.lbl_model.TabIndex = 22
        Me.lbl_model.Text = "N/A"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(22, 136)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Model"
        '
        'lbl_cycle
        '
        Me.lbl_cycle.AutoSize = True
        Me.lbl_cycle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cycle.Font = New System.Drawing.Font("Orbitron", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cycle.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_cycle.Location = New System.Drawing.Point(22, 45)
        Me.lbl_cycle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cycle.Name = "lbl_cycle"
        Me.lbl_cycle.Size = New System.Drawing.Size(58, 30)
        Me.lbl_cycle.TabIndex = 24
        Me.lbl_cycle.Text = "0.0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(10, 11)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 21)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Cycle time"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Crimson
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(70, 70)
        Me.Guna2Button1.Location = New System.Drawing.Point(239, 490)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(188, 97)
        Me.Guna2Button1.TabIndex = 25
        Me.Guna2Button1.Text = "Stop"
        '
        'lbl_partname
        '
        Me.lbl_partname.AutoSize = True
        Me.lbl_partname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_partname.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_partname.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_partname.Location = New System.Drawing.Point(29, 103)
        Me.lbl_partname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_partname.Name = "lbl_partname"
        Me.lbl_partname.Size = New System.Drawing.Size(48, 25)
        Me.lbl_partname.TabIndex = 27
        Me.lbl_partname.Text = "N/A"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(22, 86)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 17)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Partname"
        '
        'cmb_partcode
        '
        Me.cmb_partcode.BackColor = System.Drawing.Color.Transparent
        Me.cmb_partcode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_partcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_partcode.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_partcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_partcode.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_partcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_partcode.ItemHeight = 30
        Me.cmb_partcode.Location = New System.Drawing.Point(31, 38)
        Me.cmb_partcode.Name = "cmb_partcode"
        Me.cmb_partcode.Size = New System.Drawing.Size(202, 36)
        Me.cmb_partcode.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(184, 22)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 17)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Target Output"
        '
        'lbl_output
        '
        Me.lbl_output.AutoSize = True
        Me.lbl_output.BackColor = System.Drawing.Color.Transparent
        Me.lbl_output.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_output.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_output.Location = New System.Drawing.Point(200, 39)
        Me.lbl_output.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_output.Name = "lbl_output"
        Me.lbl_output.Size = New System.Drawing.Size(56, 45)
        Me.lbl_output.TabIndex = 24
        Me.lbl_output.Text = "00"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.MidnightBlue
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), System.Drawing.Image)
        Me.Guna2Button2.ImageSize = New System.Drawing.Size(70, 70)
        Me.Guna2Button2.Location = New System.Drawing.Point(35, 490)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(185, 97)
        Me.Guna2Button2.TabIndex = 29
        Me.Guna2Button2.Text = "Start"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.DimGray
        Me.Guna2Panel2.BorderRadius = 5
        Me.Guna2Panel2.BorderThickness = 5
        Me.Guna2Panel2.Controls.Add(Me.Label6)
        Me.Guna2Panel2.Controls.Add(Me.lbl_cycle)
        Me.Guna2Panel2.Controls.Add(Me.Label8)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(328, 265)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(103, 137)
        Me.Guna2Panel2.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(8, 104)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "seconds/item"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.DimGray
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.BorderThickness = 5
        Me.Guna2Panel1.Controls.Add(Me.Label9)
        Me.Guna2Panel1.Controls.Add(Me.lbl_clock)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.Black
        Me.Guna2Panel1.Location = New System.Drawing.Point(328, 120)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(103, 129)
        Me.Guna2Panel1.TabIndex = 26
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.Label11)
        Me.Guna2Panel3.Controls.Add(Me.lbl_modelcode)
        Me.Guna2Panel3.Controls.Add(Me.lbl_partname)
        Me.Guna2Panel3.Controls.Add(Me.Label13)
        Me.Guna2Panel3.Controls.Add(Me.cmb_partcode)
        Me.Guna2Panel3.Controls.Add(Me.Label3)
        Me.Guna2Panel3.Controls.Add(Me.Label1)
        Me.Guna2Panel3.Controls.Add(Me.lbl_model)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(21, 161)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(311, 195)
        Me.Guna2Panel3.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(171, 136)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 17)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Model Code"
        '
        'lbl_modelcode
        '
        Me.lbl_modelcode.AutoSize = True
        Me.lbl_modelcode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_modelcode.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_modelcode.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_modelcode.Location = New System.Drawing.Point(180, 153)
        Me.lbl_modelcode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_modelcode.Name = "lbl_modelcode"
        Me.lbl_modelcode.Size = New System.Drawing.Size(48, 25)
        Me.lbl_modelcode.TabIndex = 29
        Me.lbl_modelcode.Text = "N/A"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Controls.Add(Me.Label4)
        Me.Guna2Panel4.Controls.Add(Me.cmb_line)
        Me.Guna2Panel4.FillColor = System.Drawing.Color.White
        Me.Guna2Panel4.Location = New System.Drawing.Point(21, 21)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(311, 129)
        Me.Guna2Panel4.TabIndex = 31
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Controls.Add(Me.lbl_actual)
        Me.Guna2Panel5.Controls.Add(Me.Label10)
        Me.Guna2Panel5.Controls.Add(Me.Label7)
        Me.Guna2Panel5.Controls.Add(Me.Label2)
        Me.Guna2Panel5.Controls.Add(Me.lbl_output)
        Me.Guna2Panel5.Controls.Add(Me.lbl_targettime)
        Me.Guna2Panel5.Controls.Add(Me.Label5)
        Me.Guna2Panel5.Controls.Add(Me.lbl_plan)
        Me.Guna2Panel5.FillColor = System.Drawing.Color.White
        Me.Guna2Panel5.Location = New System.Drawing.Point(21, 368)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(311, 276)
        Me.Guna2Panel5.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(22, 143)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Timing"
        '
        'lbl_targettime
        '
        Me.lbl_targettime.AutoSize = True
        Me.lbl_targettime.BackColor = System.Drawing.Color.Transparent
        Me.lbl_targettime.Font = New System.Drawing.Font("Orbitron", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_targettime.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_targettime.Location = New System.Drawing.Point(18, 160)
        Me.lbl_targettime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_targettime.Name = "lbl_targettime"
        Me.lbl_targettime.Size = New System.Drawing.Size(71, 40)
        Me.lbl_targettime.TabIndex = 26
        Me.lbl_targettime.Text = "00"
        '
        'panel_scan
        '
        Me.panel_scan.Controls.Add(Me.Guna2Button2)
        Me.panel_scan.Controls.Add(Me.Guna2Panel2)
        Me.panel_scan.Controls.Add(Me.Guna2Panel1)
        Me.panel_scan.Controls.Add(Me.txt_barcode)
        Me.panel_scan.Controls.Add(Me.Guna2Button1)
        Me.panel_scan.Controls.Add(Me.datagrid1)
        Me.panel_scan.Enabled = False
        Me.panel_scan.FillColor = System.Drawing.Color.White
        Me.panel_scan.Location = New System.Drawing.Point(342, 21)
        Me.panel_scan.Name = "panel_scan"
        Me.panel_scan.Size = New System.Drawing.Size(463, 622)
        Me.panel_scan.TabIndex = 33
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel6.Controls.Add(Me.panel_scan)
        Me.Guna2Panel6.Controls.Add(Me.Guna2Panel5)
        Me.Guna2Panel6.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel6.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel6.Location = New System.Drawing.Point(50, 46)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(834, 659)
        Me.Guna2Panel6.TabIndex = 34
        '
        'scan_IN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 750)
        Me.Controls.Add(Me.Guna2Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "scan_IN"
        Me.Text = "scan_IN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.panel_scan.ResumeLayout(False)
        Me.Guna2Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_barcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_line As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_plan As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_actual As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_clock As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents datagrid1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lbl_model As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_cycle As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_output As Label
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmb_partcode As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lbl_partname As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_targettime As Label
    Friend WithEvents panel_scan As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_modelcode As Label
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
End Class
