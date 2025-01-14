Imports MySql.Data.MySqlClient
Public Class Login
    Dim pass As String




    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            If getPCline() = "0" Then
                display_form(New Register_PC)
            Else

                dtpicker1.Value = Date.Now
                panelselect.Enabled = True
            End If
        Catch ex As Exception
            display_error("Oops! Something went wrong. Please close app and try again.", 0)
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        If radio_ds.Checked = False And radio_ns.Checked = False Then
            display_error("Please select shift first!", 0)
        Else
            date1 = dtpicker1.Value.ToString("MMMM dd, yyyy")
            datedb = dtpicker1.Value.ToString("yyyy-MM-dd")
            ' Assign the selected shift
            If radio_ds.Checked Then
                selected_shift = 0
                ' Proceed with further logic

            ElseIf radio_ns.Checked Then
                selected_shift = 1

            End If
            display_form(sub_mainframe)
            Me.Close()
        End If
    End Sub
    Private Sub txtbarcode_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtbarcode_KeyDown(sender As Object, e As KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then
        '    Try
        '        Dim idwithA As String = "A" & txtbarcode.Text & "A"
        '        Dim idwithoutA As String = txtbarcode.Text.TrimStart("A"c).TrimEnd("A"c)
        '        Dim idwithoutasmall As String = txtbarcode.Text.TrimStart("a"c).TrimEnd("a"c)

        '        con.Close()

        '        con.Open()

        '        Dim query As String = "SELECT * FROM trc_user WHERE IDno = @idwithoutA OR IDno = @idwithA OR IDno = @idwithoutasmall"
        '        Using cmd As New MySqlCommand(query, con)
        '            cmd.Parameters.AddWithValue("@idwithA", idwithA)
        '            cmd.Parameters.AddWithValue("@idwithoutA", idwithoutA)
        '            cmd.Parameters.AddWithValue("@idwithoutasmall", idwithoutasmall)

        '            Using dr As MySqlDataReader = cmd.ExecuteReader()
        '                If dr.Read() Then
        '                    fname = dr("firstname").ToString()
        '                    idno = dr("IDno").ToString()
        '                    user_level = dr.GetInt32("level")
        '                    pass = If(IsDBNull(dr("password")), String.Empty, dr("password").ToString())

        '                    Select Case user_level
        '                        Case 1
        '                            sub_mainframe.tool_manage.Visible = False


        '                            display_form(sub_mainframe)
        '                            sub_mainframe.userstrip.Text = "Hello, " & fname

        '                            txtbarcode.Clear()
        '                            Me.Close()
        '                        Case 0
        '                            panel_pass.Visible = True
        '                            txtbarcode.Enabled = False
        '                    End Select

        '                Else
        '                    display_error("Invalid Credentials", 0)
        '                End If
        '            End Using
        '        End Using


        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '    Finally
        '        con.Close()
        '    End Try
        'End If
    End Sub



    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then
        '    If txt_password.Text = pass Then
        '        sub_mainframe.tool_manage.Visible = True
        '        display_form(sub_mainframe)
        '        sub_mainframe.userstrip.Text = "Hello, " & fname

        '        txtbarcode.Clear()
        '        Me.Close()
        '    Else
        '        display_error("Invalid Credentials", 0)
        '    End If


        'End If


    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        display_form(New Login)
        Me.Close()
    End Sub

End Class