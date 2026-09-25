<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LiveView
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
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.progress1 = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTargetOutput = New System.Windows.Forms.Label()
        Me.lblTargetCycle = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblActualScanned = New System.Windows.Forms.Label()
        Me.lblActualCycle = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.lbl_plan = New System.Windows.Forms.Label()
        Me.lblCountdown = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Panel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.progress1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(3, 346)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(779, 92)
        Me.Guna2Panel2.TabIndex = 19
        '
        'progress1
        '
        Me.progress1.Dock = System.Windows.Forms.DockStyle.Top
        Me.progress1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.progress1.Location = New System.Drawing.Point(0, 0)
        Me.progress1.Name = "progress1"
        Me.progress1.ProgressColor = System.Drawing.Color.Crimson
        Me.progress1.ProgressColor2 = System.Drawing.Color.RoyalBlue
        Me.progress1.ShowText = True
        Me.progress1.Size = New System.Drawing.Size(779, 60)
        Me.progress1.TabIndex = 0
        Me.progress1.Text = "Guna2ProgressBar1"
        Me.progress1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblTargetOutput, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lblTargetCycle, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 444)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(779, 212)
        Me.TableLayoutPanel3.TabIndex = 17
        '
        'lblTargetOutput
        '
        Me.lblTargetOutput.AutoSize = True
        Me.lblTargetOutput.BackColor = System.Drawing.Color.Transparent
        Me.lblTargetOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTargetOutput.Font = New System.Drawing.Font("Arial Rounded MT Bold", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetOutput.ForeColor = System.Drawing.Color.Black
        Me.lblTargetOutput.Location = New System.Drawing.Point(4, 46)
        Me.lblTargetOutput.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTargetOutput.Name = "lblTargetOutput"
        Me.lblTargetOutput.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.lblTargetOutput.Size = New System.Drawing.Size(771, 166)
        Me.lblTargetOutput.TabIndex = 16
        Me.lblTargetOutput.Text = "000"
        Me.lblTargetOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTargetCycle
        '
        Me.lblTargetCycle.AutoSize = True
        Me.lblTargetCycle.BackColor = System.Drawing.Color.Transparent
        Me.lblTargetCycle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTargetCycle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTargetCycle.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetCycle.ForeColor = System.Drawing.Color.Black
        Me.lblTargetCycle.Location = New System.Drawing.Point(4, 0)
        Me.lblTargetCycle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTargetCycle.Name = "lblTargetCycle"
        Me.lblTargetCycle.Size = New System.Drawing.Size(771, 46)
        Me.lblTargetCycle.TabIndex = 15
        Me.lblTargetCycle.Text = "TARGET OUTPUT"
        Me.lblTargetCycle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblActualScanned, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lblActualCycle, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 662)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(779, 213)
        Me.TableLayoutPanel4.TabIndex = 18
        '
        'lblActualScanned
        '
        Me.lblActualScanned.AutoSize = True
        Me.lblActualScanned.BackColor = System.Drawing.Color.Transparent
        Me.lblActualScanned.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblActualScanned.Font = New System.Drawing.Font("Arial Rounded MT Bold", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualScanned.ForeColor = System.Drawing.Color.Black
        Me.lblActualScanned.Location = New System.Drawing.Point(4, 46)
        Me.lblActualScanned.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblActualScanned.Name = "lblActualScanned"
        Me.lblActualScanned.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.lblActualScanned.Size = New System.Drawing.Size(771, 167)
        Me.lblActualScanned.TabIndex = 16
        Me.lblActualScanned.Text = "000"
        Me.lblActualScanned.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblActualCycle
        '
        Me.lblActualCycle.AutoSize = True
        Me.lblActualCycle.BackColor = System.Drawing.Color.Transparent
        Me.lblActualCycle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblActualCycle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblActualCycle.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualCycle.ForeColor = System.Drawing.Color.Black
        Me.lblActualCycle.Location = New System.Drawing.Point(4, 0)
        Me.lblActualCycle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblActualCycle.Name = "lblActualCycle"
        Me.lblActualCycle.Size = New System.Drawing.Size(771, 46)
        Me.lblActualCycle.TabIndex = 15
        Me.lblActualCycle.Text = "ACTUAL SCANNED"
        Me.lblActualCycle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblLine, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_plan, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCountdown, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(779, 337)
        Me.TableLayoutPanel2.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(4, 117)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(771, 53)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "TOTAL PLAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblLine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLine.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine.ForeColor = System.Drawing.Color.White
        Me.lblLine.Location = New System.Drawing.Point(4, 0)
        Me.lblLine.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(771, 90)
        Me.lblLine.TabIndex = 15
        Me.lblLine.Text = "LINE PLAN"
        Me.lblLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_plan
        '
        Me.lbl_plan.AutoSize = True
        Me.lbl_plan.BackColor = System.Drawing.Color.Transparent
        Me.lbl_plan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_plan.Font = New System.Drawing.Font("Arial Rounded MT Bold", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_plan.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbl_plan.Location = New System.Drawing.Point(4, 170)
        Me.lbl_plan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_plan.Name = "lbl_plan"
        Me.lbl_plan.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.lbl_plan.Size = New System.Drawing.Size(771, 167)
        Me.lbl_plan.TabIndex = 16
        Me.lbl_plan.Text = "000"
        Me.lbl_plan.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCountdown
        '
        Me.lblCountdown.AutoSize = True
        Me.lblCountdown.BackColor = System.Drawing.Color.White
        Me.lblCountdown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCountdown.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountdown.ForeColor = System.Drawing.Color.DimGray
        Me.lblCountdown.Location = New System.Drawing.Point(4, 90)
        Me.lblCountdown.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCountdown.Name = "lblCountdown"
        Me.lblCountdown.Size = New System.Drawing.Size(771, 27)
        Me.lblCountdown.TabIndex = 18
        Me.lblCountdown.Text = "TOTAL PLAN"
        Me.lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 343.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(785, 878)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(779, 337)
        Me.Panel1.TabIndex = 38
        '
        'LiveView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 878)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "LiveView"
        Me.Text = "LiveView"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents progress1 As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lblTargetOutput As Label
    Friend WithEvents lblTargetCycle As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lblActualScanned As Label
    Friend WithEvents lblActualCycle As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLine As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCountdown As Label
    Friend WithEvents lbl_plan As Label
End Class
