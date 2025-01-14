Imports MySql.Data.MySqlClient
Public Class edit_plan
    Dim idno As Integer
    Private Sub edit_plan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub loaddata(id As Integer)


        Dim query As String = "SELECT ap.id,ap.partcode, am.partname, `plan`, `line`,model, cycle FROM assy_lineplan ap
            JOIN assy_masterlist am ON am.partcode=ap.partcode 
            WHERE ap.id='" & id & "'"
        con.Close()
        con.Open()
        Dim selectpart As New MySqlCommand(query, con)
        dr = selectpart.ExecuteReader
        If dr.Read = True Then
            txt_plan.Text = dr.GetInt32("plan").ToString
            txt_cycle.Text = dr.GetInt32("cycle").ToString
            txt_partname.Text = dr.GetString("partname").ToString & " (" & dr.GetString("partcode").ToString & ")"
            txt_model.Text = dr.GetString("model").ToString

            cmb_line.Text = "SET Line (" & PCline & ") Plan"

            lbl_date.Text = date1 & " ( " & thisshift() & " )"
            idno = id
        End If
    End Sub


    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_plan.KeyPress, txt_cycle.KeyPress
        ' Allow only numbers and control keys
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Block the input
        End If
    End Sub
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim query As String = "UPDATE `assy_lineplan` SET `plan`='" & txt_plan.Text & "',`cycle`='" & txt_cycle.Text & "' WHERE id ='" & idno & "'"
        con.Close()
        con.Open()
        Dim updatedata As New MySqlCommand(query, con)
        updatedata.ExecuteNonQuery()
        planning.reloadgrid_plan()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        If Guna2TextBox1.Text = "redhorsE" Then
            btn_save.Enabled = True
        Else
            btn_save.Enabled = False

        End If
    End Sub
End Class