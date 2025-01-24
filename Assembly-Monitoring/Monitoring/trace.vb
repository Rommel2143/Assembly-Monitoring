Public Class trace
    Private Sub txt_barcode_TextChanged(sender As Object, e As EventArgs) Handles txt_barcode.TextChanged

    End Sub

    Private Sub txt_barcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_barcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            reload("
            SELECT `id`, `barcode`, `partcode`, `datein`,
                   CASE 
                       WHEN shift IN (0) THEN 'Dayshift'
                       ELSE 'Nightshift'
                   END AS `Shift`, `timein`, `clock`, `line` 
            FROM `assy_barcodes` 
            WHERE barcode = '" & txt_barcode.Text & "'", datagrid1)
            txt_barcode.Clear()
            txt_barcode.Focus()
        End If
    End Sub

    Private Sub export_excel_Click(sender As Object, e As EventArgs) Handles export_excel.Click
        exportexcel(datagrid1)
    End Sub
End Class