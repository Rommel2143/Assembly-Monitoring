Imports MySql.Data.MySqlClient


Public Class assembly_reports
    Private Sub assembly_reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt_from.Value = Date.Now
        dt_to.Value = Date.Now


        Dim query As String = "Select SUBSTRING_INDEX(`line`, '-', 1) FROM assy_barcodes GROUP BY SUBSTRING_INDEX(`line`, '-', 1)"
        con.Close()
        con.Open()
        Dim selectpart As New MySqlCommand(query, con)
        dr = selectpart.ExecuteReader
        cmb_line.Items.Clear()

        If dr.Read = True Then
            cmb_line.Items.Add(dr.GetString(0))
        End If
    End Sub

    Private Sub cmb_line_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_line.SelectedIndexChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            If String.IsNullOrWhiteSpace(cmb_line.Text) Then
                MessageBox.Show("Please select a valid line.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                Return

            End If
            reload("SELECT ab.partcode,am. partname, am.model, COUNT(ab.id) AS Actual_OUTPUT FROM assy_barcodes ab
                    LEFT JOIN assy_masterlist am ON ab.partcode = am.partcode
            
                WHERE SUBSTRING_INDEX(`line`, '-', 1)='" & cmb_line.Text & "' and datein BETWEEN '" & dt_from.Value.ToString("yyyy-MM-dd") & "' and '" & dt_to.Value.ToString("yyyy-MM-dd") & "'
                GROUP BY partcode", datagrid1)
        Catch ex As Exception

        End Try

    End Sub
End Class