Public Class ScanItems
    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        Dim setPart As New SelectPartcode

        setPart.dateSelected = dtpicker1.Value.ToString("yyyy-MM-dd")
        setPart.shiftSelected = If(Guna2RadioButton1.Checked = True, "DS", "NS")
        setPart.ShowDialog()
        setPart.BringToFront()
    End Sub
End Class