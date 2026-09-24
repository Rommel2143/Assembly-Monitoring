Imports MySql.Data.MySqlClient

Module userModules

    '========================================================
    ' USER INFORMATION
    '========================================================

    Public user_ID As Integer
    Public user_IDNumber As String = String.Empty
    Public user_UserName As String = String.Empty
    Public user_Password As String = String.Empty
    Public user_LastName As String = String.Empty

    Public user_PC As String = Environment.MachineName

    Public user_PCline As String = getPCline()
    Public user_PClocation As String = getPClocation()

    '========================================================
    ' DATABASE TABLES
    '========================================================

    Public userTable As String = "trc_users.prod_qc"

    Public prodTable As String = GetProdTable(user_PClocation)


    '========================================================
    ' GET PRODUCTION TABLE BASED ON PC LOCATION
    '========================================================

    Private Function GetProdTable(location As String) As String

        Select Case location.ToUpperInvariant()

            Case "ADF"
                Return "prod_adf"

            Case "SCANNER"
                Return "prod_scanner"

            Case Else
                MessageBox.Show(
                    "PC location not recognized. Please contact IT support.",
                    "System Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return String.Empty

        End Select

    End Function


    '========================================================
    ' LOGIN
    '========================================================

    Public Function isLogin(IDno As String, pass As String) As Boolean

        Try

            Const query As String =
                "SELECT `id`, `IDno`, `Firstname`, `Lastname`, `password` " &
                "FROM trc_users.prod_qc " &
                "WHERE `IDno` = @IDno AND `password` = @password " &
                "LIMIT 1"

            Using cmd As New MySqlCommand(query, con)

                cmd.Parameters.Add("@IDno", MySqlDbType.VarChar).Value =
                    IDno.Trim()

                cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value =
                    pass

                If con.State <> ConnectionState.Open Then
                    con.Open()
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then

                        user_ID =
                            If(IsDBNull(reader("id")),
                               0,
                               Convert.ToInt32(reader("id")))

                        user_IDNumber =
                            If(IsDBNull(reader("IDno")),
                               String.Empty,
                               reader("IDno").ToString())

                        user_UserName =
                            If(IsDBNull(reader("Firstname")),
                               String.Empty,
                               reader("Firstname").ToString())

                        user_LastName =
                            If(IsDBNull(reader("Lastname")),
                               String.Empty,
                               reader("Lastname").ToString())

                        user_Password =
                            If(IsDBNull(reader("password")),
                               String.Empty,
                               reader("password").ToString())

                        Return True

                    End If

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Unable to login. Please try again later." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Login Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

        Return False

    End Function


    '========================================================
    ' CHECK USER ACCESS
    '========================================================

    Public Function isAccess(column As String) As Boolean

        Try

            '------------------------------------------------
            ' Only allow known column names.
            ' Column names cannot be parameterized, so we
            ' validate the requested column before using it.
            '------------------------------------------------

            Dim allowedColumns As String() = {
                "admin",
                "create",
                "edit",
                "delete",
                "print",
                "view"
            }

            If Not allowedColumns.Contains(
                column,
                StringComparer.OrdinalIgnoreCase) Then

                Return False

            End If


            Dim query As String =
                $"SELECT `{column}`, `admin` " &
                "FROM trc_users.prod_qc " &
                "WHERE `IDno` = @IDno " &
                "LIMIT 1"

            Using cmd As New MySqlCommand(query, con)

                cmd.Parameters.Add("@IDno", MySqlDbType.VarChar).Value =
                    user_IDNumber

                If con.State <> ConnectionState.Open Then
                    con.Open()
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then

                        'Admin automatically has access
                        If Not IsDBNull(reader("admin")) AndAlso
                           Convert.ToBoolean(reader("admin")) Then

                            Return True

                        End If

                        'Check requested permission
                        If Not IsDBNull(reader(column)) Then
                            Return Convert.ToBoolean(reader(column))
                        End If

                    End If

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Something went wrong while checking user access." &
                Environment.NewLine &
                "Please try again later.",
                "Access Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

        Return False

    End Function


    '========================================================
    ' GET PC LINE
    '========================================================

    Public Function getPCline() As String

        Try

            Const query As String =
                "SELECT `line` " &
                "FROM `prod_pcline` " &
                "WHERE `pcname` = @pcname " &
                "LIMIT 1"

            Using cmd As New MySqlCommand(query, con)

                cmd.Parameters.Add("@pcname", MySqlDbType.VarChar).Value =
                    Environment.MachineName

                If con.State <> ConnectionState.Open Then
                    con.Open()
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() AndAlso
                       Not IsDBNull(reader("line")) Then

                        Return reader.GetInt32("line").ToString()

                    End If

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Unable to get PC details.",
                "System Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

        Return String.Empty

    End Function


    '========================================================
    ' GET PC LOCATION
    '========================================================

    Public Function getPClocation() As String

        Try

            Const query As String =
                "SELECT `location` " &
                "FROM `prod_pcline` " &
                "WHERE `pcname` = @pcname " &
                "LIMIT 1"

            Using cmd As New MySqlCommand(query, con)

                cmd.Parameters.Add("@pcname", MySqlDbType.VarChar).Value =
                    Environment.MachineName

                If con.State <> ConnectionState.Open Then
                    con.Open()
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() AndAlso
                       Not IsDBNull(reader("location")) Then

                        Return reader("location").ToString().ToUpperInvariant()

                    End If

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Unable to get PC location.",
                "System Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

        Return String.Empty

    End Function


    '========================================================
    ' LOGOUT
    '========================================================

    Public Sub LogoutUser()

        user_ID = 0
        user_IDNumber = String.Empty
        user_UserName = String.Empty
        user_Password = String.Empty
        user_LastName = String.Empty
        user_PC = Environment.MachineName

    End Sub

End Module