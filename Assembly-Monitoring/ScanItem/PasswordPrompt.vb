Imports MySql.Data.MySqlClient

Public Class PasswordPrompt
    Public ErrorText As String
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If String.IsNullOrWhiteSpace(txtUser.Text) Then
            MessageBox.Show("Please enter ID number.")
            Return
        End If
        Try
            Dim query As String = "SELECT id FROM trc_users.prod_qc WHERE IDno = @idno AND password= @password"
            con.Close()
            con.Open()
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@idno", txtUser.Text.Trim)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.HasRows Then
                        insertlogs()
                        DialogResult = DialogResult.OK
                        Me.Close()
                    Else
                        MessageBox.Show("Invalid Credentials")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Sub insertlogs()
        Dim query As String = "INSERT INTO `prod_logs`(location,line,error_text, `IDno`) VALUES ('" & user_PClocation & "'," & user_PCline & ",'" & ErrorText & "','" & txtUser.Text.Trim & "')"
        con.Close()
        con.Open()
        Using cmd As New MySqlCommand(query, con)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2Button1.PerformClick()
        End If
    End Sub

    Private Sub PasswordPrompt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblErrorText.Text = "Error: " & ErrorText
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub txtUser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub
End Class