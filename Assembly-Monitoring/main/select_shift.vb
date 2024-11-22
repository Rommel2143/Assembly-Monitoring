Public Class select_shift
    Private Sub select_shift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpicker1.Value = Date.Now
    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        If radio_ds.Checked = False And radio_ns.Checked = False Then
            display_error("Please select shift first!", 0)
        Else
            date1 = dtpicker1.Value.ToString("MMMM dd, yyyy")
            datedb = dtpicker1.Value.ToString("yyyy-MM-dd")
            ' Assign the selected shift
            If radio_ds.Checked Then
                selected_shift = 0
                ' Proceed with further logic
                display_error("Shift selected: Day Shift ", 0)
            ElseIf radio_ns.Checked Then
                selected_shift = 1
                display_error("Shift selected: Night Shift ", 0)
            End If
            Me.Close()
        End If
    End Sub

End Class