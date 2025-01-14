Imports MySql.Data.MySqlClient
Public Class change_line
    Dim countdown As Integer = 3
    Private Sub change_line_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_line.Text = PCline
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try


            Dim query As String = "UPDATE assy_devices SET line='" & txt_line.Text.Trim & "' WHERE pcname='" & PCname & "'"
            con.Close()
            con.Open()

            Dim insert As New MySqlCommand(query, con)
            insert.ExecuteNonQuery()
            Timer1.Start()


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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Display the error message with the current countdown value
        display_error("Device Line has Changed! Application will exit in (" & countdown & ")", 0)

        ' Decrement the countdown
        countdown -= 1

        ' Check if countdown has reached 0
        If countdown < 0 Then
            ' Stop the timer to avoid further ticks
            Timer1.Stop()

            ' Exit the application
            Application.Exit()
        End If
    End Sub
End Class