Imports MySql.Data.MySqlClient
Public Class warning

    Public Sub display(text As String)
        lbl_error.Text = text
    End Sub
    Private Sub warning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_id.Focus()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged

    End Sub

    Private Sub txt_id_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_id.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrWhiteSpace(txt_id.Text) Then
                MessageBox.Show("Please enter an ID number.")
                Return
            End If
            Try
                Dim query As String = "SELECT id FROM trc_users.prod_qc WHERE IDno = @idno"
                con.Close()
                con.Open()
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@idno", txt_id.Text.Trim)

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.HasRows Then
                            insertlogs()

                            Me.Close()
                        Else
                            MessageBox.Show("ID number not registered.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                txt_id.Clear()
                txt_id.Focus()
            End Try
        End If
    End Sub

    Sub insertlogs()
        Dim query As String = "INSERT INTO `prod_logs`(line, `details`, `IDno`) VALUES (" & user_PCline & ",'" & lbl_error.Text & "','" & txt_id.Text.Trim & "')"
        con.Close()
        con.Open()
        Using cmd As New MySqlCommand(query, con)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class