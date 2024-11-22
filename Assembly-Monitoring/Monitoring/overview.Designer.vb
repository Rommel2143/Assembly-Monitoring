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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txt_search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'flow_item
        '
        Me.flow_item.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flow_item.Location = New System.Drawing.Point(0, 112)
        Me.flow_item.Name = "flow_item"
        Me.flow_item.Size = New System.Drawing.Size(1088, 610)
        Me.flow_item.TabIndex = 7
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.txt_search)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1088, 112)
        Me.Guna2Panel1.TabIndex = 6
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'txt_search
        '
        Me.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_search.DefaultText = ""
        Me.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search.Location = New System.Drawing.Point(42, 28)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_search.PlaceholderText = "Search Line..."
        Me.txt_search.SelectedText = ""
        Me.txt_search.Size = New System.Drawing.Size(314, 36)
        Me.txt_search.TabIndex = 0
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flow_item As FlowLayoutPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txt_search As Guna.UI2.WinForms.Guna2TextBox
End Class
