Imports MySql.Data.MySqlClient
Public Class planning

    Private Sub planning_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        reloadgrid()
        lbl_date.Text = date1 & " ( " & thisshift() & " )"
    End Sub



    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_plan.KeyPress, txt_cycle.KeyPress
        ' Allow only numbers and control keys
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Block the input
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        Dim query As String = "INSERT INTO `assy_lineplan`(`partcode`, `plan`, `datein`, `shift`, `line`,cycle,target_output) VALUES ('" & cmb_partcode.Text.Trim & "','" & txt_plan.Text & "','" & datedb & "','" & selected_shift & "','" & cmb_line.Text & "','" & txt_cycle.Text & "','0')"
        con.Close()
        con.Open()

        Dim insert As New MySqlCommand(query, con)
        insert.ExecuteNonQuery()
        reloadgrid()
    End Sub


    Private Sub reloadgrid()
        reload("SELECT ap.partcode,am.partname, `plan`, `line`,cycle FROM assy_lineplan ap
                    JOIN assy_masterlist am ON am.partcode=ap.partcode 
                WHERE datein ='" & datedb & "'", datagrid1)
    End Sub

    Private Sub txt_plan_TextChanged(sender As Object, e As EventArgs) Handles txt_plan.TextChanged

    End Sub

    Private Sub cmb_partcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_partcode.SelectedIndexChanged
        Dim query As String = "Select * FROM assy_masterlist WHERE partcode='" & cmb_partcode.Text & "'"
        con.Close()
        con.Open()
        Dim selectpart As New MySqlCommand(query, con)
        dr = selectpart.ExecuteReader
        If dr.Read = True Then
            txt_plan.Text = dr.GetInt32("planset").ToString
            txt_cycle.Text = dr.GetInt32("cycleset").ToString
        End If
    End Sub

    Private Sub cmb_partcode_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_partcode.MouseClick
        cmb_display("SELECT distinct(partcode) as ITEM FROM `assy_masterlist`", "ITEM", cmb_partcode)
    End Sub
End Class