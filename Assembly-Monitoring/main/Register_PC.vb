Imports MySql.Data.MySqlClient
Public Class Register_PC
    Private Sub Register_PC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpcname.Text = PCname

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try


            If txtuser.Text = "PTRCI" And txtpassword.Text = "redhorsE" Then
                con.Close()
                con.Open()
                Dim cmdselect As New MySqlCommand("INSERT INTO `assy_devices`(`PCname`,`line`) VALUES ('" & PCname & "','" & txt_line.Text & "')", con)
                cmdselect.ExecuteNonQuery()
                Dim result As DialogResult = MessageBox.Show("Machine Verified!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                display_form(New Login)
            Else
                MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            display_error(ex.Message, 0)
        End Try
    End Sub
End Class