﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sub_mainframe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sub_mainframe))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MasterlistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScanBarcodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.userstrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MonitoringToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiveOutputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TraceItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Location = New System.Drawing.Point(0, 41)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.MinimumSize = New System.Drawing.Size(40, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1044, 747)
        Me.Panel1.TabIndex = 12
        '
        'MasterlistToolStripMenuItem
        '
        Me.MasterlistToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlanningToolStripMenuItem, Me.ScanBarcodeToolStripMenuItem})
        Me.MasterlistToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterlistToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MasterlistToolStripMenuItem.Image = CType(resources.GetObject("MasterlistToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MasterlistToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MasterlistToolStripMenuItem.Name = "MasterlistToolStripMenuItem"
        Me.MasterlistToolStripMenuItem.Size = New System.Drawing.Size(108, 37)
        Me.MasterlistToolStripMenuItem.Text = "Assembly"
        '
        'PlanningToolStripMenuItem
        '
        Me.PlanningToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PlanningToolStripMenuItem.Image = CType(resources.GetObject("PlanningToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PlanningToolStripMenuItem.Name = "PlanningToolStripMenuItem"
        Me.PlanningToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.PlanningToolStripMenuItem.Text = "Planning"
        '
        'ScanBarcodeToolStripMenuItem
        '
        Me.ScanBarcodeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ScanBarcodeToolStripMenuItem.Image = CType(resources.GetObject("ScanBarcodeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ScanBarcodeToolStripMenuItem.Name = "ScanBarcodeToolStripMenuItem"
        Me.ScanBarcodeToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.ScanBarcodeToolStripMenuItem.Text = "Scan Barcode"
        '
        'userstrip
        '
        Me.userstrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.userstrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.UpdateSystemToolStripMenuItem, Me.ManageToolStripMenuItem, Me.ToolStripMenuItem3})
        Me.userstrip.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.userstrip.Image = CType(resources.GetObject("userstrip.Image"), System.Drawing.Image)
        Me.userstrip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.userstrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.userstrip.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.userstrip.Name = "userstrip"
        Me.userstrip.Size = New System.Drawing.Size(121, 37)
        Me.userstrip.Text = "Assembly"
        Me.userstrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.userstrip.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem4.Enabled = False
        Me.ToolStripMenuItem4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(232, 38)
        Me.ToolStripMenuItem4.Text = "Suggest to improve"
        '
        'UpdateSystemToolStripMenuItem
        '
        Me.UpdateSystemToolStripMenuItem.Enabled = False
        Me.UpdateSystemToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UpdateSystemToolStripMenuItem.Image = CType(resources.GetObject("UpdateSystemToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UpdateSystemToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UpdateSystemToolStripMenuItem.Name = "UpdateSystemToolStripMenuItem"
        Me.UpdateSystemToolStripMenuItem.Size = New System.Drawing.Size(232, 38)
        Me.UpdateSystemToolStripMenuItem.Text = "Update System"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemToolStripMenuItem1, Me.ChangeLineToolStripMenuItem})
        Me.ManageToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ManageToolStripMenuItem.Image = CType(resources.GetObject("ManageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ManageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(232, 38)
        Me.ManageToolStripMenuItem.Text = "Manage"
        '
        'AddItemToolStripMenuItem1
        '
        Me.AddItemToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.AddItemToolStripMenuItem1.Name = "AddItemToolStripMenuItem1"
        Me.AddItemToolStripMenuItem1.Size = New System.Drawing.Size(166, 26)
        Me.AddItemToolStripMenuItem1.Text = "Add Item"
        '
        'ChangeLineToolStripMenuItem
        '
        Me.ChangeLineToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ChangeLineToolStripMenuItem.Name = "ChangeLineToolStripMenuItem"
        Me.ChangeLineToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.ChangeLineToolStripMenuItem.Text = "Change Line"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(232, 38)
        Me.ToolStripMenuItem3.Text = "Exit"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterlistToolStripMenuItem, Me.userstrip, Me.MonitoringToolStripMenuItem1})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1044, 41)
        Me.MenuStrip1.TabIndex = 13
        '
        'MonitoringToolStripMenuItem1
        '
        Me.MonitoringToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OverviewToolStripMenuItem, Me.LiveOutputToolStripMenuItem, Me.TraceItemToolStripMenuItem})
        Me.MonitoringToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MonitoringToolStripMenuItem1.Image = CType(resources.GetObject("MonitoringToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.MonitoringToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MonitoringToolStripMenuItem1.Name = "MonitoringToolStripMenuItem1"
        Me.MonitoringToolStripMenuItem1.Size = New System.Drawing.Size(124, 37)
        Me.MonitoringToolStripMenuItem1.Text = "Monitoring"
        '
        'OverviewToolStripMenuItem
        '
        Me.OverviewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.OverviewToolStripMenuItem.Image = CType(resources.GetObject("OverviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OverviewToolStripMenuItem.Name = "OverviewToolStripMenuItem"
        Me.OverviewToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.OverviewToolStripMenuItem.Text = "Overview"
        '
        'LiveOutputToolStripMenuItem
        '
        Me.LiveOutputToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LiveOutputToolStripMenuItem.Image = CType(resources.GetObject("LiveOutputToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LiveOutputToolStripMenuItem.Name = "LiveOutputToolStripMenuItem"
        Me.LiveOutputToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.LiveOutputToolStripMenuItem.Text = "Live Output"
        '
        'TraceItemToolStripMenuItem
        '
        Me.TraceItemToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
        Me.TraceItemToolStripMenuItem.Image = CType(resources.GetObject("TraceItemToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TraceItemToolStripMenuItem.Name = "TraceItemToolStripMenuItem"
        Me.TraceItemToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.TraceItemToolStripMenuItem.Text = "Trace Item"
        '
        'sub_mainframe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 788)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "sub_mainframe"
        Me.Text = "sub_mainframe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MasterlistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents userstrip As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents UpdateSystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PlanningToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScanBarcodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonitoringToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OverviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LiveOutputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddItemToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ChangeLineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TraceItemToolStripMenuItem As ToolStripMenuItem
End Class
