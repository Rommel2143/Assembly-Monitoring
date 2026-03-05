<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordPrompt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasswordPrompt))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_error = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblErrorText = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 20
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 123)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lbl_error
        '
        Me.lbl_error.AutoSize = True
        Me.lbl_error.BackColor = System.Drawing.Color.Transparent
        Me.lbl_error.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error.ForeColor = System.Drawing.Color.Red
        Me.lbl_error.Location = New System.Drawing.Point(170, 22)
        Me.lbl_error.Name = "lbl_error"
        Me.lbl_error.Size = New System.Drawing.Size(362, 45)
        Me.lbl_error.TabIndex = 2
        Me.lbl_error.Text = "Authorization Needed !"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderRadius = 10
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Panel2.Location = New System.Drawing.Point(178, 70)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(445, 90)
        Me.Guna2Panel2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 13)
        Me.Label1.MaximumSize = New System.Drawing.Size(410, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 65)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NOTE:  For further investigation, the QA Leader must input their credentials to c" &
    "lose the case." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Any attempt to bypass this step or forcibly close the system " &
    "will result in a memo being issued."
        '
        'txtUser
        '
        Me.txtUser.BorderRadius = 10
        Me.txtUser.BorderThickness = 2
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser.DefaultText = ""
        Me.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUser.IconLeft = CType(resources.GetObject("txtUser.IconLeft"), System.Drawing.Image)
        Me.txtUser.Location = New System.Drawing.Point(147, 293)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PlaceholderText = "ID number..."
        Me.txtUser.SelectedText = ""
        Me.txtUser.Size = New System.Drawing.Size(341, 42)
        Me.txtUser.TabIndex = 10
        '
        'txtPassword
        '
        Me.txtPassword.BorderRadius = 10
        Me.txtPassword.BorderThickness = 2
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.IconLeft = CType(resources.GetObject("txtPassword.IconLeft"), System.Drawing.Image)
        Me.txtPassword.Location = New System.Drawing.Point(147, 341)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderText = "Password..."
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(341, 42)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(147, 389)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(341, 42)
        Me.Guna2Button1.TabIndex = 12
        Me.Guna2Button1.Text = "Close "
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(39, 243)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(567, 11)
        Me.Guna2Separator1.TabIndex = 13
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 10
        Me.Guna2Panel1.Controls.Add(Me.lblErrorText)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.Tomato
        Me.Guna2Panel1.Location = New System.Drawing.Point(32, 166)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(591, 50)
        Me.Guna2Panel1.TabIndex = 14
        '
        'lblErrorText
        '
        Me.lblErrorText.AutoSize = True
        Me.lblErrorText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorText.ForeColor = System.Drawing.Color.White
        Me.lblErrorText.Location = New System.Drawing.Point(18, 15)
        Me.lblErrorText.Name = "lblErrorText"
        Me.lblErrorText.Size = New System.Drawing.Size(46, 17)
        Me.lblErrorText.TabIndex = 0
        Me.lblErrorText.Text = "Label2"
        '
        'PasswordPrompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 533)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.lbl_error)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PasswordPrompt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PasswordPrompt"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_error As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblErrorText As Label
End Class
