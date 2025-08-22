Public Class selectLive
    Private Sub selectLive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2DateTimePicker1.Value = Date.Now
        Dim columnExists As Boolean = False
        For Each column As DataGridViewColumn In datagrid1.Columns
            If column.Name = "ActionImage" Then
                columnExists = True
                Exit For
            End If
        Next
        If Not columnExists Then
            Dim imgColumn As New DataGridViewImageColumn()
            imgColumn.Name = "ActionImage"
            imgColumn.HeaderText = "Action"
            imgColumn.Image = My.Resources.play_button ' Replace with your actual resource

            datagrid1.Columns.Insert(0, imgColumn) ' Insert at the first column
            datagrid1.Columns(0).Width = 50
        End If
    End Sub
    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick
        ' Make sure click is inside a valid row and the ActionImage column
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = datagrid1.Columns("ActionImage").Index Then
            ' Get the id of the selected row
            Dim selectedID As String = datagrid1.Rows(e.RowIndex).Cells("id").Value.ToString()
            liveoutput.liveID = selectedID
            liveoutput.loadLIVE()
            liveoutput.Show()
            liveoutput.BringToFront()

            ' Example: Call another sub or form
            ' playPlan(selectedID)
        End If
    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2DateTimePicker1.ValueChanged, Guna2RadioButton1.CheckedChanged, Guna2RadioButton2.CheckedChanged
        reloadplan()
    End Sub

    Public Sub reloadplan()
        reload("SELECT pp.id,pp.partcode,model,plan,duration AS 'Duration(Hrs)',cycletime FROM prod_plan pp
JOIN assy_masterlist am ON am.partcode=pp.partcode
WHERE datein='" & Guna2DateTimePicker1.Value.ToString("yyy-MM-dd") & "' AND shift='" & If(Guna2RadioButton1.Checked = True, 1, 0) & "' AND pp.location ='" & user_PClocation & "' AND line ='" & user_PCline & "'", datagrid1)
    End Sub
End Class