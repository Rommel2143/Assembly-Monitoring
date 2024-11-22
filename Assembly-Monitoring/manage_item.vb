Imports MySql.Data.MySqlClient
Public Class manage_item
    Private Sub manage_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txt_plan.TextChanged


    End Sub

    Private Sub txt_plan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_plan.KeyPress, txt_boxitem.KeyPress, txt_cycletime.KeyPress
        ' Allow only numbers and control keys
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Block the input
        End If

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try


            Dim query As String = "INSERT INTO `assy_masterlist`(`partcode`, `partname`, `model`, `modelcode`, `planset`, `cycleset`, `qty`) VALUES ('" & txt_partcode.Text & "','" & txt_partname.Text & "','" & txt_model.Text & "','" & txt_modelcode.Text & "','" & txt_plan.Text & "','" & txt_cycletime.Text & "','" & txt_boxitem.Text & "')"
            con.Close()
            con.Open()

            Dim insert As New MySqlCommand(query, con)
            insert.ExecuteNonQuery()
            Me.Close()
            display_error("Partcode Saved!", 0)
        Catch ex As Exception
            display_error(ex.Message, 0)
        End Try
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        If Guna2TextBox1.Text = "redhorsE" Then
            Guna2Panel1.Enabled = True
        Else
            Guna2Panel1.Enabled = False

        End If
    End Sub
End Class