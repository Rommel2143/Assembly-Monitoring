Imports MySql.Data.MySqlClient
Public Class warning
    Public errorText As String
    Public Sub duplicate(text As String)
        lbl_error.Text = "Duplicate Barcode Detected!"
        Dim query As String = "SELECT datestamp FROM "& prodtable &" WHERE barcode = @barcode ORDER BY id DESC LIMIT 1"
        Using cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@barcode", text)
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    Dim datestamp As DateTime = dr.GetDateTime("datestamp")
                    lbl_barcode.Text = "Barcode : " & text & vbCrLf & "Last Scanned: " & datestamp.ToString("yyyy-MM-dd HH:mm:ss")
                End If
            End Using
        End Using


        errorText = text
    End Sub


    Public Sub invalid(text As String, mcode As String)
        lbl_error.Text = "Invalid Barcode Detected!"
        lbl_barcode.Text = "Barcode Scanned: " & text & vbCrLf & "Expected Model Code: " & mcode & vbCrLf & "Expected Barcode Lenght: 12"
        errorText = text
    End Sub


    Public Sub invalid(text As String)
        lbl_error.Text = "Invalid Barcode Detected!"
        lbl_barcode.Text = "Barcode Scanned: " & text & vbCrLf & "Expected Partcode: " & scan_IN.lbl_partcode.Text & vbCrLf & ""
        errorText = text
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
        Dim query As String = "INSERT INTO `prod_logs`(line,error_text, `details`, `IDno`) VALUES (" & user_PCline & ",'" & errorText & "','" & lbl_error.Text & "','" & txt_id.Text.Trim & "')"
        con.Close()
        con.Open()
        Using cmd As New MySqlCommand(query, con)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class