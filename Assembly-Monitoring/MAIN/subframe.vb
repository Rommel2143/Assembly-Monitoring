Public Class subframe


    Private Sub SetLineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetLineToolStripMenuItem.Click
        change_line.Show()
        change_line.BringToFront()
    End Sub

    Private Sub btn_profile_Click(sender As Object, e As EventArgs) Handles btn_profile.Click

        If btn_profile.ContextMenuStrip IsNot Nothing Then
            btn_profile.ContextMenuStrip.Show(btn_profile, 0, btn_profile.Height)
        End If
    End Sub

    Private Sub subframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_inSub(New ScanItems)
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        selectLive.ShowDialog()
        selectLive.BringToFront()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        search_barcode.ShowDialog()
        search_barcode.BringToFront()
    End Sub


End Class