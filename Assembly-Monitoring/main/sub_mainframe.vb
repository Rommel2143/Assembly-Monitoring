﻿Imports System
Public Class sub_mainframe

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        con.Close()
        Application.Exit()
    End Sub

    Private Sub PlanningToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanningToolStripMenuItem.Click
        display_formsub(planning)
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub sub_mainframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        select_shift.ShowDialog()
    End Sub

    Private Sub ScanBarcodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScanBarcodeToolStripMenuItem.Click
        display_formsub(scan_IN)
    End Sub

    Private Sub MonitoringToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MasterlistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterlistToolStripMenuItem.Click

    End Sub

    Private Sub AddItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemToolStripMenuItem.Click
        display_formsub(New manage_item)
    End Sub

    Private Sub LiveOutputToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiveOutputToolStripMenuItem.Click
        liveoutput.Show()
        liveoutput.BringToFront()
    End Sub

    Private Sub OverviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OverviewToolStripMenuItem.Click
        display_formsub(New overview)
    End Sub
End Class