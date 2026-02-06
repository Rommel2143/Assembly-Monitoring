Imports MySql.Data.MySqlClient
Public Class Partcode

    Public Property partID As Integer
    Public Property partcode As String
    Public Property partname As String
    Public Property model As String
    Public Property modelcode As String
    Public Property planset As Integer
    Public Property cycleset As Integer
    Public Property qty As Integer
    Public Property location As String

    Public Sub getPartData(partcode As String)

        Dim query As String = "SELECT `id`, `partcode`, `partname`, `model`, `modelcode`, `planset`, `cycleset`, `qty`, `location` 
                           FROM `assy_masterlist` 
                           WHERE partcode = @partcode"

        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@partcode", partcode)

                conn.Open()

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        partID = reader("id")
                        Me.partcode = reader("partcode").ToString()
                        partname = reader("partname").ToString()
                        model = reader("model").ToString()
                        modelcode = reader("modelcode").ToString()
                        planset = reader("planset")
                        cycleset = reader("cycleset")
                        qty = reader("qty")
                        location = reader("location").ToString()
                    End If
                End Using

            End Using
        End Using

    End Sub




End Class
