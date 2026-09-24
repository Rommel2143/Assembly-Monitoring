Imports MySql.Data.MySqlClient

Public Class change_line

    Private countdown As Integer = 3


    '========================================================
    ' FORM LOAD
    '========================================================

    Private Sub change_line_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Try

            '------------------------------------------------
            ' Set current PC location
            '------------------------------------------------

            cmb_location.Text = user_PClocation


            '------------------------------------------------
            ' Set current production line
            '------------------------------------------------

            Dim lineNumber As Integer

            If Integer.TryParse(user_PCline, lineNumber) Then

                'Make sure value is within NumericUpDown range
                If lineNumber < num_line.Minimum Then
                    lineNumber = CInt(num_line.Minimum)
                ElseIf lineNumber > num_line.Maximum Then
                    lineNumber = CInt(num_line.Maximum)
                End If

                num_line.Value = lineNumber

            Else

                num_line.Value = num_line.Minimum

            End If


        Catch ex As Exception

            Show_Error(
                "Unable to load PC line information." &
                Environment.NewLine &
                ex.Message,
                0
            )

        End Try

    End Sub


    '========================================================
    ' SAVE
    '========================================================

    Private Sub Guna2Button1_Click(
        sender As Object,
        e As EventArgs
    ) Handles btn_save.Click

        Try

            '------------------------------------------------
            ' Validate location
            '------------------------------------------------

            If String.IsNullOrWhiteSpace(cmb_location.Text) Then

                MessageBox.Show(
                    "Please select a location.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                cmb_location.Focus()
                Return

            End If


            '------------------------------------------------
            ' Validate line
            '------------------------------------------------

            If num_line.Value <= 0 Then

                MessageBox.Show(
                    "Please select a valid production line.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                num_line.Focus()
                Return

            End If


            '------------------------------------------------
            ' Save PC configuration
            '------------------------------------------------

            Const query As String =
                "INSERT INTO `prod_pcline` " &
                "(`pcname`, `location`, `line`) " &
                "VALUES " &
                "(@pcname, @location, @line) " &
                "ON DUPLICATE KEY UPDATE " &
                "`location` = @location, " &
                "`line` = @line"


            Using cmd As New MySqlCommand(query, con)

                cmd.Parameters.Add(
                    "@pcname",
                    MySqlDbType.VarChar
                ).Value = user_PC


                cmd.Parameters.Add(
                    "@location",
                    MySqlDbType.VarChar
                ).Value = cmb_location.Text.Trim()


                cmd.Parameters.Add(
                    "@line",
                    MySqlDbType.Int32
                ).Value = Convert.ToInt32(num_line.Value)


                If con.State <> ConnectionState.Open Then
                    con.Open()
                End If


                cmd.ExecuteNonQuery()

            End Using


            '------------------------------------------------
            ' Update application variables
            '------------------------------------------------

            user_PClocation =
                cmb_location.Text.Trim().ToUpperInvariant()

            user_PCline =
                Convert.ToInt32(num_line.Value).ToString()


            '------------------------------------------------
            ' Start shutdown countdown
            '------------------------------------------------

            countdown = 3

            Timer1.Interval = 1000

            Timer1.Start()


        Catch ex As MySqlException

            Show_Error(
                "Unable to save PC line configuration." &
                Environment.NewLine &
                ex.Message,
                0
            )


        Catch ex As Exception

            Show_Error(
                "Unable to save PC line configuration." &
                Environment.NewLine &
                ex.Message,
                0
            )


        Finally

            If con.State <> ConnectionState.Closed Then
                con.Close()
            End If

        End Try

    End Sub


    '========================================================
    ' COUNTDOWN
    '========================================================

    Private Sub Timer1_Tick(
        sender As Object,
        e As EventArgs
    ) Handles Timer1.Tick

        Show_Error(
            "Device Line has Changed!" &
            Environment.NewLine &
            Environment.NewLine &
            "Application will exit in (" &
            countdown.ToString() &
            ")",
            0
        )


        countdown -= 1


        If countdown < 0 Then

            Timer1.Stop()

            Application.Exit()

        End If

    End Sub

End Class